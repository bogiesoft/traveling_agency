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
-- Table structure for table `flightdb`
--

DROP TABLE IF EXISTS `flightdb`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `flightdb` (
  `idflightdb` int(11) NOT NULL AUTO_INCREMENT,
  `tlocation` varchar(45) DEFAULT NULL,
  `t1` tinytext,
  `t2` tinytext,
  `t3` tinytext,
  PRIMARY KEY (`idflightdb`),
  UNIQUE KEY `idflightdb_UNIQUE` (`idflightdb`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `flightdb`
--

LOCK TABLES `flightdb` WRITE;
/*!40000 ALTER TABLE `flightdb` DISABLE KEYS */;
INSERT INTO `flightdb` VALUES (1,'Agra','12AM','3PM','6PM'),(2,'Banglore','1PM','4PM','7PM'),(3,'Chennai','2PM','5PM','8PM'),(4,'Delhi','3PM','4:30PM','8:15PM'),(5,'Goa','4PM','6PM','10PM'),(6,'Hyderabad','6AM','4AM','11PM'),(7,'Jammu','8AM','5AM','7AM'),(8,'Kolkata','9AM','5:30AM','9AM'),(9,'Mumbai','10AM','7AM','10AM'),(10,'Pune','9AM','12AM','6PM');
/*!40000 ALTER TABLE `flightdb` ENABLE KEYS */;
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
