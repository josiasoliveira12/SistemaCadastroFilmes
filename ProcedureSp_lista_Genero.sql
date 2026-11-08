USE banco_filmes;

DROP PROCEDURE IF EXISTS sp_listaGeneros;

DELIMITER //

CREATE PROCEDURE sp_listaGeneros()
BEGIN
    SELECT idgenero, genero
    FROM generos
    ORDER BY genero;
END //

DELIMITER ;