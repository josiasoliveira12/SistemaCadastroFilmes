USE banco_filmes;

DROP PROCEDURE IF EXISTS sp_alteraFilme;

DELIMITER //

CREATE PROCEDURE sp_alteraFilme(
    IN p_idFilme INT,
    IN p_titulo VARCHAR(100),
    IN p_ano INT,
    IN p_duracao INT,
    IN p_genero INT
)
BEGIN
    UPDATE filmes
    SET
        titulo = p_titulo,
        ano = p_ano,
        duracao = p_duracao,
        fk_genero = p_genero
    WHERE filmes.idfilme = p_idFilme;

END //

DELIMITER ;