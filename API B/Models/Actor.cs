namespace API_B.Models
{
    public class Actor
    {
        public int Id_Actor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Genero { get; set; }
        public string Biografia { get; set; }
        public string Premios { get; set; }
        public int Numero_Peliculas { get; set; }
        public DateTime Fecha_Creacion { get; set; }
    }
}
