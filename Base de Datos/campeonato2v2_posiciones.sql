-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: campeonato2v2
-- ------------------------------------------------------
-- Server version	5.7.42-log

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
-- Table structure for table `posiciones`
--

DROP TABLE IF EXISTS `posiciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `posiciones` (
  `id_posicion` int(11) NOT NULL AUTO_INCREMENT,
  `id_equipo` int(11) DEFAULT '0',
  `P_jug` int(11) DEFAULT '0',
  `P_gan` int(11) DEFAULT '0',
  `P_emp` int(11) DEFAULT '0',
  `P_per` int(11) DEFAULT '0',
  `G_fav` int(11) DEFAULT '0',
  `G_con` int(11) DEFAULT '0',
  `Dif_G` int(11) DEFAULT '0',
  `Puntaje` int(11) DEFAULT '0',
  PRIMARY KEY (`id_posicion`),
  KEY `id_equipo` (`id_equipo`)
) ENGINE=MyISAM AUTO_INCREMENT=50 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `posiciones`
--

LOCK TABLES `posiciones` WRITE;
/*!40000 ALTER TABLE `posiciones` DISABLE KEYS */;
INSERT INTO `posiciones` VALUES (2,1,0,0,0,0,0,0,0,0),(3,4,0,0,0,0,0,0,0,0),(4,9,0,0,0,0,0,0,0,0),(5,6,0,0,0,0,0,0,0,0),(6,3,0,0,0,0,0,0,0,0),(7,7,0,0,0,0,0,0,0,0),(8,8,0,0,0,0,0,0,0,0),(9,5,0,0,0,0,0,0,0,0),(10,30,0,0,0,0,0,0,0,0),(11,28,0,0,0,0,0,0,0,0),(12,33,0,0,0,0,0,0,0,0),(13,35,0,0,0,0,0,0,0,0),(14,32,0,0,0,0,0,0,0,0),(15,31,0,0,0,0,0,0,0,0),(16,29,0,0,0,0,0,0,0,0),(17,34,0,0,0,0,0,0,0,0),(18,30,0,0,0,0,0,0,0,0),(19,28,0,0,0,0,0,0,0,0),(20,33,0,0,0,0,0,0,0,0),(21,35,0,0,0,0,0,0,0,0),(22,32,0,0,0,0,0,0,0,0),(23,31,0,0,0,0,0,0,0,0),(24,29,0,0,0,0,0,0,0,0),(25,34,0,0,0,0,0,0,0,0),(26,30,0,0,0,0,0,0,0,0),(27,28,0,0,0,0,0,0,0,0),(28,33,0,0,0,0,0,0,0,0),(29,35,0,0,0,0,0,0,0,0),(30,32,0,0,0,0,0,0,0,0),(31,31,0,0,0,0,0,0,0,0),(32,29,0,0,0,0,0,0,0,0),(33,34,0,0,0,0,0,0,0,0),(34,30,0,0,0,0,0,0,0,0),(35,28,0,0,0,0,0,0,0,0),(36,33,0,0,0,0,0,0,0,0),(37,35,0,0,0,0,0,0,0,0),(38,32,0,0,0,0,0,0,0,0),(39,31,0,0,0,0,0,0,0,0),(40,29,0,0,0,0,0,0,0,0),(41,34,0,0,0,0,0,0,0,0),(42,30,0,0,0,0,0,0,0,0),(43,28,0,0,0,0,0,0,0,0),(44,33,0,0,0,0,0,0,0,0),(45,35,0,0,0,0,0,0,0,0),(46,32,0,0,0,0,0,0,0,0),(47,31,0,0,0,0,0,0,0,0),(48,29,0,0,0,0,0,0,0,0),(49,34,0,0,0,0,0,0,0,0);
/*!40000 ALTER TABLE `posiciones` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-09-03 14:35:21
