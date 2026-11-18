DELIMITER %%
DROP PROCEDURE `banco_filmes`.`sp_insereFilme`%%
CREATE DEFINER=`root`@`localhost` PROCEDURE `banco_filmes`.`sp_insereFilme`(
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

END%%
DELIMITER ;