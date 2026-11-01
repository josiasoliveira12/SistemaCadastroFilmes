DELIMITER $$

DROP PROCEDURE IF EXISTS sp_insereFilme $$

CREATE PROCEDURE sp_insereFilme(
    IN titulo VARCHAR(100),
    IN ano INT,
    IN duracao INT,
    IN genero INT
)
BEGIN

    INSERT INTO filmes
    (titulo, ano, duracao, fk_genero)
    VALUES
    (titulo, ano, duracao, genero);

END $$

DELIMITER ;