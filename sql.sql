-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.4.20-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Copiando estrutura para tabela aquaminas.especie
CREATE TABLE IF NOT EXISTS `especie` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(250) NOT NULL,
  `preco` decimal(20,2) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Copiando dados para a tabela aquaminas.especie: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `especie` DISABLE KEYS */;
/*!40000 ALTER TABLE `especie` ENABLE KEYS */;

-- Copiando estrutura para procedure aquaminas.sp_alteraEspecie
DELIMITER //
CREATE PROCEDURE `sp_alteraEspecie`(
	IN `idEspecie` INT,
	IN `nomeEspecie` VARCHAR(250),
	IN `precoEspecie` DECIMAL(20,2)
)
BEGIN
UPDATE especie SET nome = nomeEspecie, preco = precoEspecie WHERE id = idEspecie;
END//
DELIMITER ;

-- Copiando estrutura para procedure aquaminas.sp_alteraVenda
DELIMITER //
CREATE PROCEDURE `sp_alteraVenda`(
	IN `idVenda` INT,
	IN `quantidadeVenda` INT,
	IN `peixeVenda` INT,
	IN `precoTotal` DECIMAL(20,2)
)
BEGIN
UPDATE venda SET quantidade = quantidadeVenda, peixe = peixeVenda, preco_total = precoTotal WHERE id = idVenda;
END//
DELIMITER ;

-- Copiando estrutura para procedure aquaminas.sp_consultaLogin
DELIMITER //
CREATE PROCEDURE `sp_consultaLogin`(
	IN `usuario` VARCHAR(250),
	IN `senha` VARCHAR(250)
)
BEGIN
SELECT * FROM usuarios WHERE usuarios.usuarios = usuario AND usuarios.senha = senha;
END//
DELIMITER ;

-- Copiando estrutura para procedure aquaminas.sp_insereEspecie
DELIMITER //
CREATE PROCEDURE `sp_insereEspecie`(
	IN `nome` VARCHAR(250),
	IN `preco` DECIMAL(20,2)
)
BEGIN
INSERT INTO especie(nome, preco) VALUES (nome, preco);
END//
DELIMITER ;

-- Copiando estrutura para procedure aquaminas.sp_insereVenda
DELIMITER //
CREATE PROCEDURE `sp_insereVenda`(
	IN `quantidade` INT,
	IN `precoTotal` DECIMAL(20,2),
	IN `peixe` INT
)
BEGIN
INSERT INTO venda (quantidade, preco_total, peixe) VALUES (quantidade, precoTotal, peixe);
END//
DELIMITER ;

-- Copiando estrutura para procedure aquaminas.sp_listaEspecie
DELIMITER //
CREATE PROCEDURE `sp_listaEspecie`()
BEGIN
SELECT * FROM especie;
END//
DELIMITER ;

-- Copiando estrutura para procedure aquaminas.sp_listaVenda
DELIMITER //
CREATE PROCEDURE `sp_listaVenda`()
BEGIN
SELECT * FROM venda;
END//
DELIMITER ;

-- Copiando estrutura para procedure aquaminas.sp_removeEspecie
DELIMITER //
CREATE PROCEDURE `sp_removeEspecie`(
	IN `idEspecie` INT
)
BEGIN
DELETE FROM especie WHERE id = idEspecie;
END//
DELIMITER ;

-- Copiando estrutura para procedure aquaminas.sp_removeVenda
DELIMITER //
CREATE PROCEDURE `sp_removeVenda`(
	IN `idVenda` INT
)
BEGIN
DELETE FROM venda WHERE id = idVenda;
END//
DELIMITER ;

-- Copiando estrutura para tabela aquaminas.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `idUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `usuarios` varchar(250) NOT NULL,
  `senha` varchar(250) NOT NULL,
  PRIMARY KEY (`idUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

-- Copiando dados para a tabela aquaminas.usuarios: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` (`idUsuario`, `usuarios`, `senha`) VALUES
	(1, 'adm', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;

-- Copiando estrutura para tabela aquaminas.venda
CREATE TABLE IF NOT EXISTS `venda` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `peixe` int(11) DEFAULT NULL,
  `quantidade` int(11) DEFAULT NULL,
  `preco_total` decimal(20,2) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `peixe` (`peixe`),
  CONSTRAINT `FK_venda_especie` FOREIGN KEY (`peixe`) REFERENCES `especie` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Copiando dados para a tabela aquaminas.venda: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `venda` DISABLE KEYS */;
/*!40000 ALTER TABLE `venda` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
