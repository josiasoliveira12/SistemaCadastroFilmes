CREATE DATABASE banco_filmes;
USE banco_filmes;

CREATE TABLE generos (
    idgenero INT NOT NULL AUTO_INCREMENT,
    genero VARCHAR(45) DEFAULT NULL,
    PRIMARY KEY (idgenero)
);


INSERT INTO generos (genero) VALUES
('Ação'),
('Aventura'),
('Ficção Científica'),
('Drama'),
('Comédia');

CREATE TABLE filmes (
    idfilme INT NOT NULL AUTO_INCREMENT,
    titulo VARCHAR(100) DEFAULT NULL,
    ano INT DEFAULT NULL,
    duracao INT DEFAULT NULL,
    fk_genero INT DEFAULT NULL,

    PRIMARY KEY (idfilme),

    FOREIGN KEY (fk_genero)
    REFERENCES generos (idgenero)
);


INSERT INTO filmes (titulo, ano, duracao, fk_genero)
VALUES
('Interestelar', 2014, 169, 3),
('Titanic', 1997, 194, 4),
('Vingadores: Ultimato', 2019, 181, 1);


