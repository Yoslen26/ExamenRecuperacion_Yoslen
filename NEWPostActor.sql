USE [BASEB]
GO

CREATE PROCEDURE [dbo].[INSERTACTOR]
    @Id_actor int,
    @Nombre VARCHAR(100),
    @Apellido VARCHAR(100),
    @Fecha_nacimiento DATE,
    @Nacionalidad VARCHAR(100),
    @Genero VARCHAR(100),
    @Biografia VARCHAR(100),
    @Premios VARCHAR(100),
    @Numero_peliculas INTEGER,
    @Fecha_creacion DATE
AS
BEGIN
    INSERT INTO ACTOR (id_actor, nombre, apellido, fecha_nacimiento, nacionalidad, genero, biografia, premios, numero_peliculas, fecha_creacion)
    VALUES (@Id_actor, @Nombre, @Apellido, @Fecha_Nacimiento, @Nacionalidad, @Genero, @Biografia, @Premios, @Numero_Peliculas, @Fecha_creacion);
END;