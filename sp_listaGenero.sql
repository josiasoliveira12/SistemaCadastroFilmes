DELIMITER %%
DROP PROCEDURE `banco_filmes`.`sp_listaGeneros`%%
CREATE DEFINER=`root`@`localhost` PROCEDURE `banco_filmes`.`sp_listaGeneros`()
BEGIN
    SELECT idgenero, genero
    FROM generos
    ORDER BY genero;
END%%
DELIMITER ;