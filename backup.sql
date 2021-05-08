CREATE DATABASE  IF NOT EXISTS `practica2`;
USE `practica2`;
-- MySQL dump 10.13  Distrib 8.0.24, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: practica2
-- ------------------------------------------------------
-- Server version	8.0.24

--
-- Table structure for table `distributors`
--

DROP TABLE IF EXISTS `distributors`;
CREATE TABLE `distributors` (
  `id_distributors` varchar(50) NOT NULL,
  `fecha_registro` date NOT NULL,
  PRIMARY KEY (`id_distributors`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


--
-- Dumping data for table `distributors`
--

LOCK TABLES `distributors` WRITE;
INSERT INTO `distributors` VALUES ('A1','2021-05-02'),('C4','2021-05-14'),('F1','2021-05-08');
UNLOCK TABLES;

--
-- Table structure for table `addresses`
--

DROP TABLE IF EXISTS `addresses`;
CREATE TABLE `addresses` (
  `id_addesses` int NOT NULL AUTO_INCREMENT,
  `calle` varchar(60) NOT NULL,
  `no_ext` varchar(45) NOT NULL,
  `colonia` varchar(60) NOT NULL,
  `id_distributors` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_addesses`),
  KEY `id_distributors_idx` (`id_distributors`),
  CONSTRAINT `id_distributors` FOREIGN KEY (`id_distributors`) REFERENCES `distributors` (`id_distributors`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `addresses`
--

LOCK TABLES `addresses` WRITE;
INSERT INTO `addresses` VALUES (1,'Mora','929','Valle Bonito','A1'),(4,'Zacatecas','814','Sanchez Celiz','C4'),(5,'Insurgentes','50','Flamingos','F1');
UNLOCK TABLES;


--
-- Table structure for table `persons`
--

DROP TABLE IF EXISTS `persons`;
CREATE TABLE `persons` (
  `id_persons` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `apellidoP` varchar(45) NOT NULL,
  `apellidoM` varchar(45) NOT NULL,
  `id_distributors` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`id_persons`),
  KEY `id_distributors_idx` (`id_distributors`),
  CONSTRAINT `id_distributors2` FOREIGN KEY (`id_distributors`) REFERENCES `distributors` (`id_distributors`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `persons`
--

LOCK TABLES `persons` WRITE;
INSERT INTO `persons` VALUES (1,'Luz','Alcantar','Peralta','A1'),(4,'Emilio','Gil','Delgado','C4'),(5,'Perla','Figueroa','Juarez','F1');
UNLOCK TABLES;


delimiter $$
CREATE PROCEDURE obtenerDatos(id VARCHAR(30))
BEGIN
	SELECT CONCAT(p.nombre, ' ',p.apellidoP, ' ', p.apellidoM) AS 
	nombre_completo, a.calle, a.no_ext, a.colonia FROM distributors d 
	INNER JOIN persons p ON d.id_distributors=p.id_distributors 
	INNER JOIN addresses a ON d.id_distributors=a.id_distributors WHERE d.id_distributors=id;
END$$
delimiter ;

-- Dump completed on 2021-05-08 11:39:05
