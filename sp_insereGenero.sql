DELIMITER %%
DROP PROCEDURE `banco_filmes`.`sp_insereGenero`%%
CREATE DEFINER=`root`@`localhost` PROCEDURE `banco_filmes`.`sp_insereGenero`(
    IN nomeGenero VARCHAR(45)
)
BEGIN

    INSERT INTO generos
    (genero)
    VALUES
    (nomeGenero);

END%%
DELIMITER ;