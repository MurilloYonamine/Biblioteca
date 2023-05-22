-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: bd_biblioteca
-- ------------------------------------------------------
-- Server version	8.0.33

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tb_administrador`
--

DROP TABLE IF EXISTS `tb_administrador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_administrador` (
  `usuario_cpf` varchar(11) NOT NULL,
  PRIMARY KEY (`usuario_cpf`),
  CONSTRAINT `tb_administrador_ibfk_1` FOREIGN KEY (`usuario_cpf`) REFERENCES `tb_usuario` (`cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_administrador`
--

LOCK TABLES `tb_administrador` WRITE;
/*!40000 ALTER TABLE `tb_administrador` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_administrador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_autor`
--

DROP TABLE IF EXISTS `tb_autor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_autor` (
  `autor_nome` varchar(50) NOT NULL,
  `autor_nacionalidade` varchar(100) DEFAULT 'BRASIL',
  `autor_nascimento` datetime NOT NULL,
  `autor_id` smallint NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`autor_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_autor`
--

LOCK TABLES `tb_autor` WRITE;
/*!40000 ALTER TABLE `tb_autor` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_autor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_bibliotecario`
--

DROP TABLE IF EXISTS `tb_bibliotecario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_bibliotecario` (
  `usuario_cpf` varchar(11) NOT NULL,
  PRIMARY KEY (`usuario_cpf`),
  CONSTRAINT `tb_bibliotecario_ibfk_1` FOREIGN KEY (`usuario_cpf`) REFERENCES `tb_usuario` (`cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_bibliotecario`
--

LOCK TABLES `tb_bibliotecario` WRITE;
/*!40000 ALTER TABLE `tb_bibliotecario` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_bibliotecario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_categoria`
--

DROP TABLE IF EXISTS `tb_categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_categoria` (
  `categoria_id` smallint NOT NULL AUTO_INCREMENT,
  `categoria_nome` varchar(35) NOT NULL,
  PRIMARY KEY (`categoria_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_categoria`
--

LOCK TABLES `tb_categoria` WRITE;
/*!40000 ALTER TABLE `tb_categoria` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_cliente`
--

DROP TABLE IF EXISTS `tb_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_cliente` (
  `cliente_cpf` varchar(11) NOT NULL,
  PRIMARY KEY (`cliente_cpf`),
  CONSTRAINT `tb_cliente_ibfk_1` FOREIGN KEY (`cliente_cpf`) REFERENCES `tb_usuario` (`cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_cliente`
--

LOCK TABLES `tb_cliente` WRITE;
/*!40000 ALTER TABLE `tb_cliente` DISABLE KEYS */;
INSERT INTO `tb_cliente` VALUES ('28004343848');
/*!40000 ALTER TABLE `tb_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_emprestimo`
--

DROP TABLE IF EXISTS `tb_emprestimo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_emprestimo` (
  `emprestimo_id` smallint NOT NULL AUTO_INCREMENT,
  `cliente_cpf` varchar(11) DEFAULT NULL,
  `livro_isbn` varchar(13) DEFAULT NULL,
  `emprestimo_data` date DEFAULT NULL,
  `emprestimo_devolucao` date DEFAULT NULL,
  PRIMARY KEY (`emprestimo_id`),
  KEY `cliente_cpf` (`cliente_cpf`),
  KEY `livro_isbn` (`livro_isbn`),
  CONSTRAINT `tb_emprestimo_ibfk_1` FOREIGN KEY (`cliente_cpf`) REFERENCES `tb_cliente` (`cliente_cpf`),
  CONSTRAINT `tb_emprestimo_ibfk_2` FOREIGN KEY (`livro_isbn`) REFERENCES `tb_livro` (`livro_isbn`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_emprestimo`
--

LOCK TABLES `tb_emprestimo` WRITE;
/*!40000 ALTER TABLE `tb_emprestimo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_emprestimo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_livro`
--

DROP TABLE IF EXISTS `tb_livro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_livro` (
  `livro_titulo` varchar(63) NOT NULL,
  `livro_autor_id` smallint DEFAULT NULL,
  `livro_editora` varchar(25) NOT NULL,
  `livro_isbn` varchar(13) NOT NULL,
  `livro_publicacao` datetime NOT NULL,
  `livro_idioma` varchar(25) NOT NULL,
  `livro_pagina` varchar(12056) NOT NULL,
  `livro_sinopse` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`livro_isbn`),
  KEY `livro_autor_id` (`livro_autor_id`),
  CONSTRAINT `tb_livro_ibfk_1` FOREIGN KEY (`livro_autor_id`) REFERENCES `tb_autor` (`autor_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_livro`
--

LOCK TABLES `tb_livro` WRITE;
/*!40000 ALTER TABLE `tb_livro` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_livro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_livro_categoria`
--

DROP TABLE IF EXISTS `tb_livro_categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_livro_categoria` (
  `livro_isbn` varchar(13) DEFAULT NULL,
  `categoria_id` smallint DEFAULT NULL,
  KEY `livro_isbn` (`livro_isbn`),
  KEY `categoria_id` (`categoria_id`),
  CONSTRAINT `tb_livro_categoria_ibfk_1` FOREIGN KEY (`livro_isbn`) REFERENCES `tb_livro` (`livro_isbn`),
  CONSTRAINT `tb_livro_categoria_ibfk_2` FOREIGN KEY (`categoria_id`) REFERENCES `tb_categoria` (`categoria_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_livro_categoria`
--

LOCK TABLES `tb_livro_categoria` WRITE;
/*!40000 ALTER TABLE `tb_livro_categoria` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_livro_categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_usuario`
--

DROP TABLE IF EXISTS `tb_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_usuario` (
  `cpf` varchar(13) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `senha` varchar(50) NOT NULL,
  `nascimento` date NOT NULL,
  `idade` smallint NOT NULL,
  `nome_social` varchar(50) DEFAULT NULL,
  `genero` varchar(20) DEFAULT NULL,
  `tipo` varchar(15) NOT NULL,
  PRIMARY KEY (`cpf`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_usuario`
--

LOCK TABLES `tb_usuario` WRITE;
/*!40000 ALTER TABLE `tb_usuario` DISABLE KEYS */;
INSERT INTO `tb_usuario` VALUES ('28004343848','Planta de Arroz','Picodaplantadearroz@gmail.com','123456789','2004-06-09',18,'Planta de Feijão','Gênero fluído','Cliente'),('43297698837','Murillo Gomes Yonamine','murillo346@hotmail.com','22060412','2004-06-08',18,'','Masculino','cliente');
/*!40000 ALTER TABLE `tb_usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-21 21:07:51
