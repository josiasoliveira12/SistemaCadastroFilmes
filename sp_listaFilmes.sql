DROP PROCEDURE IF EXISTS sp_listaFilmes;

DELIMITER //

CREATE PROCEDURE sp_listaFilmes()
BEGIN

    SELECT
        idfilme,
        titulo,
        ano,
        duracao,
        generos.genero

    FROM filmes

    INNER JOIN generos
        ON filmes.fk_genero = generos.idgenero;

END //

DELIMITER ;