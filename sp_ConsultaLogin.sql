
DELIMITER $$

DROP PROCEDURE IF EXISTS consultaLogin$$

CREATE PROCEDURE consultaLogin(
    IN p_usuario VARCHAR(100),
    IN p_senha VARCHAR(100)
)
BEGIN
    SELECT nome
    FROM usuarios
    WHERE nome = p_usuario
      AND senha = p_senha;
END$$

DELIMITER ;
