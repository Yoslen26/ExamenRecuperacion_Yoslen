using System;
using System.Collections.Generic;

namespace API_A.Models;

public partial class Pelicula
{
    public int IdPelicula { get; set; }

    public string? Titulo { get; set; }

    public string? Genero { get; set; }

    public string? Director { get; set; }

    public int? AnioEstreno { get; set; }

    public int? Duracion { get; set; }

    public string? Clasificacion { get; set; }

    public string? PaisOrigen { get; set; }

    public string? Idioma { get; set; }

    public string? Sinopsis { get; set; }

    public DateOnly? FechaCreacion { get; set; }
}
