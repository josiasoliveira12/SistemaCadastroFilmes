USE banco_filmes;

DELIMITER //

CREATE PROCEDURE consultaLogin(IN usuario VARCHAR(100))
BEGIN
    SELECT senha
    FROM usuarios
    WHERE nome = usuario;
END //

DELIMITER ;