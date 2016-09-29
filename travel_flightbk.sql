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
-- Table structure for table `flightbk`
--

DROP TABLE IF EXISTS `flightbk`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `flightbk` (
  `bookingid` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) DEFAULT NULL,
  `triptype` varchar(45) DEFAULT NULL,
  `dfrom` varchar(45) DEFAULT NULL,
  `dto` varchar(45) DEFAULT NULL,
  `departure` tinytext,
  `treturn` tinytext,
  `noofp` int(11) DEFAULT NULL,
  `class` tinytext,
  `timming` tinytext,
  `airline` tinytext,
  `bookingtime` tinytext,
  `p1` varchar(45) DEFAULT NULL,
  `p1_age` varchar(45) DEFAULT NULL,
  `p1_gender` varchar(45) DEFAULT NULL,
  `p2` varchar(45) DEFAULT NULL,
  `p2_age` varchar(45) DEFAULT NULL,
  `p2_gender` varchar(45) DEFAULT NULL,
  `p3` varchar(45) DEFAULT NULL,
  `p3_age` varchar(45) DEFAULT NULL,
  `p3_gender` varchar(45) DEFAULT NULL,
  `p4` varchar(45) DEFAULT NULL,
  `p4_age` varchar(45) DEFAULT NULL,
  `p4_gender` varchar(45) DEFAULT NULL,
  `p5` varchar(45) DEFAULT NULL,
  `p5_age` varchar(45) DEFAULT NULL,
  `p5_gender` varchar(45) DEFAULT NULL,
  `p6` varchar(45) DEFAULT NULL,
  `p6_age` varchar(45) DEFAULT NULL,
  `p6_gender` varchar(45) DEFAULT NULL,
  `paymentstatus` tinytext,
  `totalfare` int(11) DEFAULT NULL,
  PRIMARY KEY (`bookingid`),
  UNIQUE KEY `bookingid_UNIQUE` (`bookingid`),
  UNIQUE KEY `username_UNIQUE` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `flightbk`
--

LOCK TABLES `flightbk` WRITE;
/*!40000 ALTER TABLE `flightbk` DISABLE KEYS */;
INSERT INTO `flightbk` VALUES (1,'saurabh29',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `flightbk` ENABLE KEYS */;
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
