-- MySQL dump 10.13  Distrib 5.6.23, for Win64 (x86_64)
--
-- Host: localhost    Database: travel
-- ------------------------------------------------------
-- Server version	5.6.25-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `hotelbk`
--

DROP TABLE IF EXISTS `hotelbk`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hotelbk` (
  `idhotelbk` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(45) DEFAULT NULL,
  `location` varchar(45) DEFAULT NULL,
  `checkin` tinytext,
  `checkout` tinytext,
  `bookingtime` tinytext,
  `nofr` varchar(45) DEFAULT NULL,
  `adultr1` varchar(45) DEFAULT NULL,
  `childrenr1` varchar(45) DEFAULT NULL,
  `typer1` varchar(45) DEFAULT NULL,
  `bedr1` varchar(45) DEFAULT NULL,
  `adultr2` varchar(45) DEFAULT NULL,
  `childrenr2` varchar(45) DEFAULT NULL,
  `typer2` varchar(45) DEFAULT NULL,
  `bedr2` varchar(45) DEFAULT NULL,
  `adultr3` varchar(45) DEFAULT NULL,
  `childrenr3` varchar(45) DEFAULT NULL,
  `typer3` varchar(45) DEFAULT NULL,
  `bedr3` varchar(45) DEFAULT NULL,
  `adultr4` varchar(45) DEFAULT NULL,
  `childrenr4` varchar(45) DEFAULT NULL,
  `typer4` varchar(45) DEFAULT NULL,
  `bedr4` varchar(45) DEFAULT NULL,
  `hotelname` varchar(45) DEFAULT NULL,
  `address` mediumtext,
  `contactinfo` tinytext,
  `totalfare` varchar(45) DEFAULT NULL,
  `paymentstatus` tinytext,
  PRIMARY KEY (`idhotelbk`),
  UNIQUE KEY `idhotelbk_UNIQUE` (`idhotelbk`),
  UNIQUE KEY `username_UNIQUE` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hotelbk`
--

LOCK TABLES `hotelbk` WRITE;
/*!40000 ALTER TABLE `hotelbk` DISABLE KEYS */;
INSERT INTO `hotelbk` VALUES (1,'saurabh29',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `hotelbk` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-09-14  3:14:25
