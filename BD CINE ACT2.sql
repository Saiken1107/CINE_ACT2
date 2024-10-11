CREATE DATABASE CINE_DB_ACT2;
GO
USE CINE_DB_ACT2;
GO
CREATE TABLE Peliculas (
    PeliculaId INT PRIMARY KEY IDENTITY(1,1),
    Titulo NVARCHAR(100),
    Director NVARCHAR(100),
    Año INT
);

INSERT INTO Peliculas (Titulo, Director, Año)
VALUES
('Inception', 'Christopher Nolan', 2010),
('The Godfather', 'Francis Ford Coppola', 1972),
('Pulp Fiction', 'Quentin Tarantino', 1994),
('The Dark Knight', 'Christopher Nolan', 2008),
('Forrest Gump', 'Robert Zemeckis', 1994);

SELECT * from Peliculas;