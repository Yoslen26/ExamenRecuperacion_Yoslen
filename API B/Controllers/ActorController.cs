using API_B.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_B.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActoresController : ControllerBase
    {
        private readonly string _connectionString = "Server=PC5_LAB1\\SQLEXPRESS;Database=BASEB;Trusted_Connection=True;";

        [HttpPost]
        public async Task<ActionResult> PostActor(Actor actor)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERTACTOR", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_actor", actor.Id_Actor);
                cmd.Parameters.AddWithValue("@Nombre", actor.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", actor.Apellido);
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", actor.Fecha_Nacimiento);
                cmd.Parameters.AddWithValue("@Nacionalidad", actor.Nacionalidad);
                cmd.Parameters.AddWithValue("@Genero", actor.Genero);
                cmd.Parameters.AddWithValue("@Biografia", actor.Biografia);
                cmd.Parameters.AddWithValue("@Premios", actor.Premios);
                cmd.Parameters.AddWithValue("@Numero_Peliculas", actor.Numero_Peliculas);
                cmd.Parameters.AddWithValue("@Fecha_creacion", actor.Fecha_Creacion);

                conn.Open();
                await cmd.ExecuteNonQueryAsync();
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000/api/Actores");
                var response = await client.PostAsJsonAsync("", actor);

                if (!response.IsSuccessStatusCode)
                {
                    return StatusCode((int)response.StatusCode, "Error al sincronizar con API A");
                }
            }

            return Ok();
        }
    }
}
