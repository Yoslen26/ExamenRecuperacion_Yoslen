using System;
using System.Collections.Generic;
using API_A.Context;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;

namespace API_A.Models;

public partial class Actor
{
    public int IdActor { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public string? Nacionalidad { get; set; }

    public string? Genero { get; set; }

    public string? Biografia { get; set; }

    public string? Premios { get; set; }

    public int? NumeroPeliculas { get; set; }

    public DateOnly? FechaCreacion { get; set; }
}
