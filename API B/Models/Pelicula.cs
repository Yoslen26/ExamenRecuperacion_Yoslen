namespace API_B.Models
{
    public class Pelicula
    {
        public int Id_Pelicula { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Director { get; set; }
        public int Anio_Estreno { get; set; }
        public int Duracion { get; set; }
        public string Clasificacion { get; set; }
        public string Pais_Origen { get; set; }
        public string Idioma { get; set; }
        public string Sinopsis { get; set; }
        public DateTime Fecha_Creacion { get; set; }
    }
}
