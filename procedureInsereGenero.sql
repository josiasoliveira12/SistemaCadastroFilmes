DELIMITER %%
DROP PROCEDURE IF EXISTS `banco_filmes`.`sp_insereGenero`%%
/* Add or remove procedure IN/OUT/INOUT parameters as needed. */
CREATE PROCEDURE `banco_filmes`.`sp_insereGenero`(IN arg1 INTEGER, OUT arg2 INTEGER)
SQL SECURITY DEFINER
NOT DETERMINISTIC
BEGIN
    /* Insert the procedure code here. */
    SET arg2 = arg1 * 2;
END%%
DELIMITER ;

CALL `banco_filmes`.`sp_insereGenero`(1, @arg2);
SELECT @arg2;