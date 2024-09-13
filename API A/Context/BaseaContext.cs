using System;
using System.Collections.Generic;
using API_A.Models;
using Microsoft.EntityFrameworkCore;

namespace API_A.Context;

public partial class BaseaContext : DbContext
{
    public BaseaContext()
    {
    }

    public BaseaContext(DbContextOptions<BaseaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actor> Actors { get; set; }

    public virtual DbSet<Pelicula> Peliculas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-HB58NUH\\SQLEXPRESS; Initial Catalog=BASEA; Integrated Security=True; Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>(entity =>
        {
            entity.HasKey(e => e.IdActor).HasName("PK__ACTOR__F86BE7170AA0D17D");

            entity.ToTable("ACTOR");

            entity.Property(e => e.IdActor)
                .ValueGeneratedNever()
                .HasColumnName("id_actor");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Biografia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("biografia");
            entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");
            entity.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");
            entity.Property(e => e.Genero)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("genero");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nacionalidad");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NumeroPeliculas).HasColumnName("numero_peliculas");
            entity.Property(e => e.Premios)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("premios");
        });

        modelBuilder.Entity<Pelicula>(entity =>
        {
            entity.HasKey(e => e.IdPelicula).HasName("PK__PELICULA__B5017F4D41C67AA5");

            entity.ToTable("PELICULA");

            entity.Property(e => e.IdPelicula)
                .ValueGeneratedNever()
                .HasColumnName("id_pelicula");
            entity.Property(e => e.AnioEstreno).HasColumnName("anio_estreno");
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clasificacion");
            entity.Property(e => e.Director)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("director");
            entity.Property(e => e.Duracion).HasColumnName("duracion");
            entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");
            entity.Property(e => e.Genero)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("genero");
            entity.Property(e => e.Idioma)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("idioma");
            entity.Property(e => e.PaisOrigen)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("pais_origen");
            entity.Property(e => e.Sinopsis)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sinopsis");
            entity.Property(e => e.Titulo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("titulo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
