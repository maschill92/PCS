CREATE DATABASE  IF NOT EXISTS `pcs` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `pcs`;
-- MySQL dump 10.13  Distrib 5.6.13, for Win32 (x86)
--
-- Host: localhost    Database: pcs
-- ------------------------------------------------------
-- Server version	5.6.17

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
-- Table structure for table `cataloger`
--

DROP TABLE IF EXISTS `cataloger`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cataloger` (
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `fName` varchar(45) NOT NULL,
  `lName` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `sex` char(1) NOT NULL,
  `dateOfBirth` date NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cataloger`
--

LOCK TABLES `cataloger` WRITE;
/*!40000 ALTER TABLE `cataloger` DISABLE KEYS */;
INSERT INTO `cataloger` VALUES ('cat','cat','Data','Cat','datacat@pcs.com','M','1969-01-01'),('root','root','Roo','Tee','root@pcs.com','F','1999-02-02');
/*!40000 ALTER TABLE `cataloger` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cell`
--

DROP TABLE IF EXISTS `cell`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cell` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(128) NOT NULL,
  `description` varchar(128) DEFAULT NULL,
  `blockId` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `cell_cellBlock.fk_idx` (`blockId`),
  CONSTRAINT `cell_cellBlock.fk` FOREIGN KEY (`blockId`) REFERENCES `cell_block` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cell`
--

LOCK TABLES `cell` WRITE;
/*!40000 ALTER TABLE `cell` DISABLE KEYS */;
INSERT INTO `cell` VALUES (1,'Drunk Tank Cell','',1),(2,'101',NULL,2),(3,'1000',NULL,3),(4,'2000',NULL,4),(5,'3000',NULL,5);
/*!40000 ALTER TABLE `cell` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cell_block`
--

DROP TABLE IF EXISTS `cell_block`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cell_block` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(128) NOT NULL,
  `description` varchar(128) NOT NULL,
  `prisonId` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `cellBlock_prisonId.fk_idx` (`prisonId`),
  CONSTRAINT `cellBlock_prisonId.fk` FOREIGN KEY (`prisonId`) REFERENCES `prison` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cell_block`
--

LOCK TABLES `cell_block` WRITE;
/*!40000 ALTER TABLE `cell_block` DISABLE KEYS */;
INSERT INTO `cell_block` VALUES (1,'Block 1','Drunk Tank',1),(2,'Block 2','Isolated',1),(3,'A Block','Class A Felons',2),(4,'B Block','Class B Felons',2),(5,'C Block','Misdemeanors',2);
/*!40000 ALTER TABLE `cell_block` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dba`
--

DROP TABLE IF EXISTS `dba`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dba` (
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `fName` varchar(45) NOT NULL,
  `lName` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `sex` char(1) NOT NULL,
  `dateOfBirth` date NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dba`
--

LOCK TABLES `dba` WRITE;
/*!40000 ALTER TABLE `dba` DISABLE KEYS */;
INSERT INTO `dba` VALUES ('dba','dba','Dee','Ba','dba@pcs.com','M','1990-05-03'),('root','root','Roo','Tee','root@pcs.com','F','1999-02-02');
/*!40000 ALTER TABLE `dba` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `offense`
--

DROP TABLE IF EXISTS `offense`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `offense` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `location` varchar(128) NOT NULL,
  `type` varchar(128) NOT NULL,
  `description` varchar(128) NOT NULL,
  `date` date NOT NULL,
  `prisonerId` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `offense_prisonerId.fk_idx` (`prisonerId`),
  CONSTRAINT `offense_prisonerId.fk` FOREIGN KEY (`prisonerId`) REFERENCES `prisoner` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `offense`
--

LOCK TABLES `offense` WRITE;
/*!40000 ALTER TABLE `offense` DISABLE KEYS */;
INSERT INTO `offense` VALUES (1,'Grand Forks, ND','Disorderly Conduct','Ran through the streets at night shouting','2010-01-01',1),(2,'Hilsboro, ND','Armed Robbery','Burger King robbery','2011-01-01',2),(3,'Grand Forks, ND','Providing Alchol to Minors','Bad stuff','2013-01-01',3),(4,'Grand Forks, ND','Destruction of Property','Dug a large hole in someones backyard.','2014-01-01',4),(5,'The Mushroom Kingdom','Murder','Killed several Goombas','1985-01-01',5),(6,'The Mushroom Kingdom','Possession of Drugs','Mushrooms','1985-01-01',5),(7,'Bismarck, ND','Selling Illegal Items','Blackmarket stuff','2000-01-01',6),(8,'Jamestown, ND','Reckless Driving','120 mph in a 65 mpg zone','2004-01-01',7),(9,'Dickinson, ND','Possession of Illegal Drugs','Bad stuff','1999-01-01',8),(10,'Bismarck, ND','Grand Theft Auto','Bad stuff','2001-01-01',9),(11,'Minot, ND','Slander','Said some stuff about some people','1970-01-01',10);
/*!40000 ALTER TABLE `offense` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prison`
--

DROP TABLE IF EXISTS `prison`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prison` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(128) NOT NULL,
  `location` varchar(128) NOT NULL,
  `description` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prison`
--

LOCK TABLES `prison` WRITE;
/*!40000 ALTER TABLE `prison` DISABLE KEYS */;
INSERT INTO `prison` VALUES (1,'Grand Forks County Jail','Grand Forks, North Dakota',NULL),(2,'North Dakota State Penitentiary','Bismarck, ND',NULL);
/*!40000 ALTER TABLE `prison` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prisoner`
--

DROP TABLE IF EXISTS `prisoner`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prisoner` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fName` varchar(45) NOT NULL,
  `lName` varchar(45) NOT NULL,
  `dateOfBirth` date NOT NULL,
  `sex` char(1) NOT NULL,
  `cellId` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `prisoner_cellId.fk_idx` (`cellId`),
  CONSTRAINT `prisoner_cellId.fk` FOREIGN KEY (`cellId`) REFERENCES `cell` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prisoner`
--

LOCK TABLES `prisoner` WRITE;
/*!40000 ALTER TABLE `prisoner` DISABLE KEYS */;
INSERT INTO `prisoner` VALUES (1,'Larrie','Dom','1945-01-01','M',1),(2,'Dederick','Paulie','1970-01-01','M',1),(3,'Arn','Neal','1965-01-01','M',2),(4,'Davin','Cletis','1986-01-01','M',2),(5,'Mario','Mario','1985-09-13','M',3),(6,'Georgie','Keiran','1980-01-01','M',3),(7,'Abram','Leland','1978-01-01','M',4),(8,'Humphrey','Shawn','1996-01-01','M',4),(9,'Sandford','Rolo','1969-01-01','M',5),(10,'Caleb','Earle','1992-01-01','M',5);
/*!40000 ALTER TABLE `prisoner` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-05-02 11:52:00
