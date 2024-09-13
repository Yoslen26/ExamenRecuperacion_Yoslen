using API_B.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_B.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculasController : ControllerBase
    {
        private readonly string _connectionString = "Server=PC5_LAB1\\SQLEXPRESS;Database=BASEB;Trusted_Connection=True;";

        [HttpPost]
        public async Task<ActionResult> PostPelicula(Pelicula pelicula)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERTPELICULA", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_pelicula", pelicula.Id_Pelicula);
                cmd.Parameters.AddWithValue("@Titulo", pelicula.Titulo);
                cmd.Parameters.AddWithValue("@Genero", pelicula.Genero);
                cmd.Parameters.AddWithValue("@Director", pelicula.Director);
                cmd.Parameters.AddWithValue("@Anio_Estreno", pelicula.Anio_Estreno);
                cmd.Parameters.AddWithValue("@Duracion", pelicula.Duracion);
                cmd.Parameters.AddWithValue("@Clasificacion", pelicula.Clasificacion);
                cmd.Parameters.AddWithValue("@Pais_Origen", pelicula.Pais_Origen);
                cmd.Parameters.AddWithValue("@Idioma", pelicula.Idioma);
                cmd.Parameters.AddWithValue("@Sinopsis", pelicula.Sinopsis);
                cmd.Parameters.AddWithValue("@Fecha_creacion", pelicula.Fecha_Creacion);

                conn.Open();
                await cmd.ExecuteNonQueryAsync();
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000/api/Peliculas");
                await client.PostAsJsonAsync("", pelicula);
            }

            return Ok();
        }
    }
}
