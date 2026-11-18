DELIMITER %%
DROP PROCEDURE `banco_filmes`.`sp_removeFilme`%%
CREATE DEFINER=`root`@`localhost` PROCEDURE `banco_filmes`.`sp_removeFilme`(IN p_idFilme INT)
BEGIN
    DELETE FROM filmes
    WHERE filmes.idfilme = p_idFilme;
END%%
DELIMITER ;