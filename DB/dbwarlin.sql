-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: 172.16.0.2    Database: dbwarlin
-- ------------------------------------------------------
-- Server version	5.6.11

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `empleados` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(40) NOT NULL,
  `Apellido` varchar(40) NOT NULL,
  `Cedula` char(11) NOT NULL,
  `Fecha_Nacimiento` date NOT NULL,
  `Telefono` char(10) NOT NULL,
  `Estado_civil` char(1) NOT NULL,
  `Genero` char(1) NOT NULL,
  `Direccion` varchar(255) NOT NULL,
  `Email` varchar(60) NOT NULL,
  `Condicion` char(1) NOT NULL,
  `Fecha_Ingreso` date NOT NULL,
  `Fecha_Salida` date DEFAULT NULL,
  `Id_Nacionalida` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Cedula` (`Cedula`),
  KEY `Id_Nacionalida` (`Id_Nacionalida`),
  CONSTRAINT `empleados_ibfk_1` FOREIGN KEY (`Id_Nacionalida`) REFERENCES `nacionalidades` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados`
--

LOCK TABLES `empleados` WRITE;
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
INSERT INTO `empleados` VALUES (1,'warlin','sano','003004001','2019-04-23','8293290694','S','M','c/ principal casa 145','warlinsano@gmail.com','A','2019-04-02','2019-04-02',1),(2,'Jhoan','Baez','00301115747','1989-04-21','8095697044','S','M','URBANIZACION AESA','jhoanbaez214@gmail.com','S','2015-03-08',NULL,1),(31,'sara roa','montas','22222222222','1989-04-20','8095697044','C','F','URBANIZACION AESA   ','jhoanbaez214@gmail.com','S','2015-03-08','2019-04-18',15),(32,'SONIA','CARASGO','33333333333','1989-04-15','8095611111','V','F','PERA        ','SONIA@gmail.com','L','2015-03-04','2019-04-10',1),(33,'Jhoan','Baez','2233','1989-04-21','8095697044','D','M','URBANIZACION AESA    ','jhoanbaez214@gmail.com','V','2015-03-08','2019-04-26',9),(35,'jony','Baez','22333','1989-04-21','8095697044','C','M','URBANIZACION AESA   ','jhoanbaez214@gmail.com','L','2015-03-08','2019-04-26',8),(37,'pedro','perez','44444444444','1989-04-15','8095611111','C','F','PERA          ','SONIA@gmail.com','A','2015-03-04','2019-04-26',6),(38,'jhoan m anuel','hjjj','88888888888','2019-04-26','9999999999','S','M','bhhhh ','ggg','A','2019-04-26',NULL,14);
/*!40000 ALTER TABLE `empleados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historial_usuario`
--

DROP TABLE IF EXISTS `historial_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `historial_usuario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Id_usuario` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Hora` time NOT NULL,
  `Accion` varchar(50) NOT NULL,
  `sobre_registro_id` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=233 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historial_usuario`
--

LOCK TABLES `historial_usuario` WRITE;
/*!40000 ALTER TABLE `historial_usuario` DISABLE KEYS */;
INSERT INTO `historial_usuario` VALUES (163,1,'2019-04-26','04:52:44','INICIO SECCION',1),(164,1,'2019-04-26','04:56:43','INICIO SECCION',1),(165,1,'2019-04-26','05:02:56','INICIO SECCION',1),(166,1,'2019-04-26','05:03:22','INSERTO EMPLEADO',0),(167,1,'2019-04-26','05:05:53','INSERTO EMPLEADO',0),(168,1,'2019-04-26','05:08:50','INICIO SECCION',1),(169,1,'2019-04-26','05:12:05','INICIO SECCION',1),(170,1,'2019-04-26','05:14:35','INICIO SECCION',1),(171,1,'2019-04-26','05:15:57','INICIO SECCION',1),(172,1,'2019-04-26','05:16:13','INSERTO EMPLEADO',0),(173,1,'2019-04-26','05:16:34','INSERTO EMPLEADO',0),(174,1,'2019-04-26','05:16:51','INSERTO EMPLEADO',0),(175,1,'2019-04-26','05:28:49','INICIO SECCION',1),(176,1,'2019-04-26','05:29:39','INICIO SECCION',1),(177,1,'2019-04-26','05:35:05','INICIO SECCION',1),(178,1,'2019-04-26','05:40:02','INICIO SECCION',1),(179,1,'2019-04-26','05:40:56','INICIO SECCION',1),(180,1,'2019-04-26','05:52:21','INICIO SECCION',1),(181,1,'2019-04-26','06:01:25','INICIO SECCION',1),(182,1,'2019-04-26','06:09:11','INICIO SECCION',1),(183,1,'2019-04-26','06:10:50','INICIO SECCION',1),(184,2,'2019-04-26','06:14:39','INTENTO INICIAR SECCION CON USUARIO DE SUSPENDIDO',2),(185,1,'2019-04-26','06:14:53','INICIO SECCION',1),(186,1,'2019-04-26','06:18:10','INICIO SECCION',1),(187,1,'2019-04-26','06:18:17','CERROR SECCION',1),(188,2,'2019-04-26','06:20:12','INTENTO INICIAR SECCION CON USUARIO DE SUSPENDIDO',2),(189,1,'2019-04-26','06:25:51','INICIO SECCION',1),(190,1,'2019-04-26','06:48:54','INICIO SECCION',1),(191,1,'2019-04-26','06:49:56','ACTUALIZO EMPLEADO',31),(192,1,'2019-04-26','07:15:54','INICIO SECCION',1),(193,1,'2019-04-26','07:17:54','INICIO SECCION',1),(194,1,'2019-04-26','07:18:48','ACTUALIZO EMPLEADO',32),(195,1,'2019-04-26','07:19:06','ACTUALIZO EMPLEADO',32),(196,1,'2019-04-26','07:19:46','ACTUALIZO EMPLEADO',32),(197,1,'2019-04-26','07:19:54','ACTUALIZO EMPLEADO',33),(198,1,'2019-04-26','07:19:55','CREO USUARIO',33),(199,1,'2019-04-26','07:21:30','INICIO SECCION',1),(200,1,'2019-04-26','07:21:48','ACTUALIZO EMPLEADO',32),(201,1,'2019-04-26','07:22:06','ACTUALIZO EMPLEADO',32),(202,1,'2019-04-26','07:22:06','CREO USUARIO',32),(203,1,'2019-04-26','07:34:13','INICIO SECCION',1),(204,1,'2019-04-26','07:34:31','ACTUALIZO EMPLEADO',32),(205,1,'2019-04-26','07:34:52','ACTUALIZO EMPLEADO',32),(206,1,'2019-04-26','07:38:15','INICIO SECCION',1),(207,1,'2019-04-26','07:38:48','INSERTO EMPLEADO',0),(208,1,'2019-04-26','07:39:08','INSERTO EMPLEADO',0),(209,1,'2019-04-26','08:25:10','INICIO SECCION',1),(210,1,'2019-04-26','08:25:59','INICIO SECCION',1),(211,1,'2019-04-26','08:32:01','INICIO SECCION',1),(212,1,'2019-04-26','08:33:46','INICIO SECCION',1),(213,1,'2019-04-26','08:35:07','ACTUALIZO EMPLEADO',31),(214,1,'2019-04-26','08:40:14','INICIO SECCION',1),(215,1,'2019-04-26','08:43:36','INICIO SECCION',1),(216,1,'2019-04-26','08:44:19','INICIO SECCION',1),(217,1,'2019-04-26','08:46:42','INICIO SECCION',1),(218,1,'2019-04-26','08:47:20','CERROR SECCION',1),(219,1,'2019-04-26','08:47:34','INICIO SECCION',1),(220,1,'2019-04-26','08:53:26','INICIO SECCION',1),(221,1,'2019-04-26','08:57:37','INSERTO EMPLEADO',0),(222,1,'2019-04-26','08:59:14','ACTUALIZO EMPLEADO',35),(223,1,'2019-04-26','08:59:51','ACTUALIZO EMPLEADO',37),(224,1,'2019-04-26','09:00:48','ACTUALIZO EMPLEADO',33),(225,1,'2019-04-26','09:01:30','ACTUALIZO EMPLEADO',33),(226,1,'2019-04-26','09:04:26','INICIO SECCION',1),(227,1,'2019-04-26','09:04:37','ACTUALIZO EMPLEADO',35),(228,1,'2019-04-26','09:10:10','INICIO SECCION',1),(229,1,'2019-04-26','09:10:50','CERROR SECCION',1),(230,1,'2019-04-26','09:14:58','INICIO SECCION',1),(231,1,'2019-04-26','09:36:28','INICIO SECCION',1),(232,1,'2019-04-26','09:37:31','INICIO SECCION',1);
/*!40000 ALTER TABLE `historial_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nacionalidades`
--

DROP TABLE IF EXISTS `nacionalidades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `nacionalidades` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(40) NOT NULL,
  `Estado` tinyint(1) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Nombre` (`Nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nacionalidades`
--

LOCK TABLES `nacionalidades` WRITE;
/*!40000 ALTER TABLE `nacionalidades` DISABLE KEYS */;
INSERT INTO `nacionalidades` VALUES (1,'DOMINICANO',1),(3,'ECUATORIANO',0),(4,'ESPAÑOL',1),(5,'TURCO',1),(6,'IRAKI',1),(8,'RUSO',1),(9,'TAIWANES',1),(10,'PANAMEÑO',1),(11,'PUERTO RIQUEÑO',1),(12,'PERUANO',1),(13,'UK',1),(14,'US',1),(15,'AFRICANO',1),(16,'COREANO',1);
/*!40000 ALTER TABLE `nacionalidades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `usuarios` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Empleado` int(11) NOT NULL,
  `Usuario` varchar(40) NOT NULL,
  `Pwd` char(128) NOT NULL,
  `Estado` tinyint(1) NOT NULL,
  `Tipo_usuario` varchar(30) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Usuario` (`Usuario`),
  KEY `Id_Empleado` (`Id_Empleado`),
  CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`Id_Empleado`) REFERENCES `empleados` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,1,'warlin','MQAyADMANAA=',1,'Admin'),(2,2,'Jhoan','MQAyADMANAA=',1,'Admin'),(4,32,'SONIA32','UwBPAE4ASQBBADMAMgA=',1,'Normal');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-05-05 19:41:22
