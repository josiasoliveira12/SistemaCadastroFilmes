DELIMITER %%
DROP PROCEDURE `banco_filmes`.`sp_listaFilmes`%%
CREATE DEFINER=`root`@`localhost` PROCEDURE `banco_filmes`.`sp_listaFilmes`()
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

END%%
DELIMITER ;