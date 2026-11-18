DELIMITER %%
DROP PROCEDURE `banco_filmes`.`consultaLogin`%%
CREATE DEFINER=`root`@`localhost` PROCEDURE `banco_filmes`.`consultaLogin`(IN usuario VARCHAR(100))
BEGIN
    SELECT senha
    FROM usuarios
    WHERE nome = usuario;
END%%
DELIMITER ;