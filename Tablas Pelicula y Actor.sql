CREATE TABLE PELICULA(
    id_pelicula INTEGER,
    titulo VARCHAR(100),
    genero VARCHAR(100),
    director VARCHAR(100),
    anio_estreno INTEGER,
    duracion INTEGER,
    clasificacion VARCHAR(50),
    pais_origen VARCHAR(100),
    idioma VARCHAR(100),
    sinopsis VARCHAR(100),
    fecha_creacion DATE
);

CREATE TABLE ACTOR(
    id_actor INTEGER,
    nombre VARCHAR(100),
    apellido VARCHAR(100),
    fecha_nacimiento DATE,
    nacionalidad VARCHAR(100),
    genero VARCHAR(100),
    biografia VARCHAR(100),
    premios VARCHAR(100),
    numero_peliculas INTEGER,
    fecha_creacion DATE
);