USE banco_filmes;

DROP PROCEDURE IF EXISTS sp_removeFilme;

DELIMITER //

CREATE PROCEDURE sp_removeFilme(IN idFilme INT)
BEGIN
    DELETE FROM filmes
    WHERE idfilme = idFilme;
END //

DELIMITER ;