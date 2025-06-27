-- MariaDB dump 10.19  Distrib 10.4.32-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: Quiz
-- ------------------------------------------------------
-- Server version	10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `antwort`
--

DROP TABLE IF EXISTS `antwort`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `antwort` (
  `antwortID` int(11) NOT NULL AUTO_INCREMENT,
  `FID` int(11) DEFAULT NULL,
  `GDID` int(11) DEFAULT NULL,
  PRIMARY KEY (`antwortID`),
  KEY `FID` (`FID`),
  KEY `GDID` (`GDID`),
  CONSTRAINT `antwort_ibfk_1` FOREIGN KEY (`FID`) REFERENCES `frage` (`frageID`),
  CONSTRAINT `antwort_ibfk_2` FOREIGN KEY (`GDID`) REFERENCES `geodaten` (`GeoDatenID`)
) ENGINE=InnoDB AUTO_INCREMENT=157 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `antwort`
--

LOCK TABLES `antwort` WRITE;
/*!40000 ALTER TABLE `antwort` DISABLE KEYS */;
INSERT INTO `antwort` VALUES (1,1,2),(2,2,2),(3,3,2),(4,4,2),(5,5,2),(6,6,2),(7,7,3),(8,8,3),(9,9,3),(10,10,3),(11,11,3),(12,12,3),(13,13,4),(14,14,4),(15,15,4),(16,16,4),(17,17,4),(18,18,4),(19,19,5),(20,20,5),(21,21,5),(22,22,5),(23,23,5),(24,24,5),(25,25,6),(26,26,6),(27,27,6),(28,28,6),(29,29,6),(30,30,6),(31,31,7),(32,32,7),(33,33,7),(34,34,7),(35,35,7),(36,36,7),(37,37,8),(38,38,8),(39,39,8),(40,40,8),(41,41,8),(42,42,8),(43,43,9),(44,44,9),(45,45,9),(46,46,9),(47,47,9),(48,48,9),(49,49,10),(50,50,10),(51,51,10),(52,52,10),(53,53,10),(54,54,10),(55,55,11),(56,56,11),(57,57,11),(58,58,11),(59,59,11),(60,60,11),(61,61,12),(62,62,12),(63,63,12),(64,64,12),(65,65,12),(66,66,12),(67,67,13),(68,68,13),(69,69,13),(70,70,13),(71,71,13),(72,72,13),(73,73,14),(74,74,14),(75,75,14),(76,76,14),(77,77,14),(78,78,14),(79,79,15),(80,80,15),(81,81,15),(82,82,15),(83,83,15),(84,84,15),(85,85,16),(86,86,16),(87,87,16),(88,88,16),(89,89,16),(90,90,16),(91,91,17),(92,92,17),(93,93,17),(94,94,17),(95,95,17),(96,96,17),(97,97,18),(98,98,18),(99,99,18),(100,100,18),(101,101,18),(102,102,18),(103,103,19),(104,104,19),(105,105,19),(106,106,19),(107,107,19),(108,108,19),(109,109,20),(110,110,20),(111,111,20),(112,112,20),(113,113,20),(114,114,20),(115,115,21),(116,116,21),(117,117,21),(118,118,21),(119,119,21),(120,120,21),(121,121,22),(122,122,22),(123,123,22),(124,124,22),(125,125,22),(126,126,22),(127,127,23),(128,128,23),(129,129,23),(130,130,23),(131,131,23),(132,132,23),(133,133,24),(134,134,24),(135,135,24),(136,136,24),(137,137,24),(138,138,24),(139,139,25),(140,140,25),(141,141,25),(142,142,25),(143,143,25),(144,144,25),(145,145,26),(146,146,26),(147,147,26),(148,148,26),(149,149,26),(150,150,26),(151,151,27),(152,152,27),(153,153,27),(154,154,27),(155,155,27),(156,156,27);
/*!40000 ALTER TABLE `antwort` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `benutzer`
--

DROP TABLE IF EXISTS `benutzer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `benutzer` (
  `benutzerID` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) DEFAULT NULL,
  `passwort` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`benutzerID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `benutzer`
--

LOCK TABLES `benutzer` WRITE;
/*!40000 ALTER TABLE `benutzer` DISABLE KEYS */;
INSERT INTO `benutzer` VALUES (1,'Luffy','12345'),(2,'Quizmaster1','54321'),(3,'benutzer1','passwort');
/*!40000 ALTER TABLE `benutzer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `frage`
--

DROP TABLE IF EXISTS `frage`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `frage` (
  `frageID` int(11) NOT NULL AUTO_INCREMENT,
  `fragetyp` varchar(50) DEFAULT NULL,
  `frageinhalt` varchar(150) DEFAULT NULL,
  `QID` int(11) DEFAULT NULL,
  `GDID` int(11) DEFAULT NULL,
  `AID` int(11) DEFAULT NULL,
  PRIMARY KEY (`frageID`),
  KEY `QID` (`QID`),
  KEY `GDID` (`GDID`),
  KEY `fk_richtige_antwort` (`AID`),
  CONSTRAINT `fk_richtige_antwort` FOREIGN KEY (`AID`) REFERENCES `antwort` (`antwortID`),
  CONSTRAINT `frage_ibfk_1` FOREIGN KEY (`QID`) REFERENCES `quiz` (`quizID`),
  CONSTRAINT `frage_ibfk_2` FOREIGN KEY (`GDID`) REFERENCES `geodaten` (`GeoDatenID`)
) ENGINE=InnoDB AUTO_INCREMENT=157 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `frage`
--

LOCK TABLES `frage` WRITE;
/*!40000 ALTER TABLE `frage` DISABLE KEYS */;
INSERT INTO `frage` VALUES (1,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Deutschland?',NULL,2,NULL),(2,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Berlin?',NULL,2,NULL),(3,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,2,NULL),(4,'Land_zu_Flagge','Welche Flagge gehoert zu Deutschland?',NULL,2,NULL),(5,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Berlin?',NULL,2,NULL),(6,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,2,NULL),(7,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Frankreich?',NULL,3,NULL),(8,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Paris?',NULL,3,NULL),(9,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,3,NULL),(10,'Land_zu_Flagge','Welche Flagge gehoert zu Frankreich?',NULL,3,NULL),(11,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Paris?',NULL,3,NULL),(12,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,3,NULL),(13,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Italien?',NULL,4,NULL),(14,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Rom?',NULL,4,NULL),(15,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,4,NULL),(16,'Land_zu_Flagge','Welche Flagge gehoert zu Italien?',NULL,4,NULL),(17,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Rom?',NULL,4,NULL),(18,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,4,NULL),(19,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Spanien?',NULL,5,NULL),(20,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Madrid?',NULL,5,NULL),(21,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,5,NULL),(22,'Land_zu_Flagge','Welche Flagge gehoert zu Spanien?',NULL,5,NULL),(23,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Madrid?',NULL,5,NULL),(24,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,5,NULL),(25,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Polen?',NULL,6,NULL),(26,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Warschau?',NULL,6,NULL),(27,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,6,NULL),(28,'Land_zu_Flagge','Welche Flagge gehoert zu Polen?',NULL,6,NULL),(29,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Warschau?',NULL,6,NULL),(30,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,6,NULL),(31,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Niederlande?',NULL,7,NULL),(32,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Amsterdam?',NULL,7,NULL),(33,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,7,NULL),(34,'Land_zu_Flagge','Welche Flagge gehoert zu Niederlande?',NULL,7,NULL),(35,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Amsterdam?',NULL,7,NULL),(36,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,7,NULL),(37,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Schweden?',NULL,8,NULL),(38,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Stockholm?',NULL,8,NULL),(39,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,8,NULL),(40,'Land_zu_Flagge','Welche Flagge gehoert zu Schweden?',NULL,8,NULL),(41,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Stockholm?',NULL,8,NULL),(42,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,8,NULL),(43,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Norwegen?',NULL,9,NULL),(44,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Oslo?',NULL,9,NULL),(45,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,9,NULL),(46,'Land_zu_Flagge','Welche Flagge gehoert zu Norwegen?',NULL,9,NULL),(47,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Oslo?',NULL,9,NULL),(48,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,9,NULL),(49,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Oesterreich?',NULL,10,NULL),(50,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Wien?',NULL,10,NULL),(51,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,10,NULL),(52,'Land_zu_Flagge','Welche Flagge gehoert zu Oesterreich?',NULL,10,NULL),(53,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Wien?',NULL,10,NULL),(54,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,10,NULL),(55,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Schweiz?',NULL,11,NULL),(56,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Bern?',NULL,11,NULL),(57,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,11,NULL),(58,'Land_zu_Flagge','Welche Flagge gehoert zu Schweiz?',NULL,11,NULL),(59,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Bern?',NULL,11,NULL),(60,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,11,NULL),(61,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Belgien?',NULL,12,NULL),(62,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Brüssel?',NULL,12,NULL),(63,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,12,NULL),(64,'Land_zu_Flagge','Welche Flagge gehoert zu Belgien?',NULL,12,NULL),(65,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Brüssel?',NULL,12,NULL),(66,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,12,NULL),(67,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Portugal',NULL,13,NULL),(68,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Lissabon?',NULL,13,NULL),(69,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,13,NULL),(70,'Land_zu_Flagge','Welche Flagge gehoert zu Portugal?',NULL,13,NULL),(71,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Lissabon?',NULL,13,NULL),(72,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,13,NULL),(73,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Griechenland?',NULL,14,NULL),(74,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Athen?',NULL,14,NULL),(75,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,14,NULL),(76,'Land_zu_Flagge','Welche Flagge gehoert zu Griechenland?',NULL,14,NULL),(77,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Athen?',NULL,14,NULL),(78,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,14,NULL),(79,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von China?',NULL,15,NULL),(80,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Peking?',NULL,15,NULL),(81,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,15,NULL),(82,'Land_zu_Flagge','Welche Flagge gehoert zu China?',NULL,15,NULL),(83,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Peking?',NULL,15,NULL),(84,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,15,NULL),(85,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Japan?',NULL,16,NULL),(86,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Tokio?',NULL,16,NULL),(87,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,16,NULL),(88,'Land_zu_Flagge','Welche Flagge gehoert zu Japan?',NULL,16,NULL),(89,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Tokio?',NULL,16,NULL),(90,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,16,NULL),(91,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Indien?',NULL,17,NULL),(92,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Neu-Delhi?',NULL,17,NULL),(93,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,17,NULL),(94,'Land_zu_Flagge','Welche Flagge gehoert zu Indien?',NULL,17,NULL),(95,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Neu-Delhi?',NULL,17,NULL),(96,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,17,NULL),(97,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Thailand?',NULL,18,NULL),(98,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Bangkok?',NULL,18,NULL),(99,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,18,NULL),(100,'Land_zu_Flagge','Welche Flagge gehoert zu Thailand?',NULL,18,NULL),(101,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Bangkok?',NULL,18,NULL),(102,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,18,NULL),(103,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Suedkorea?',NULL,19,NULL),(104,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Seoul?',NULL,19,NULL),(105,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,19,NULL),(106,'Land_zu_Flagge','Welche Flagge gehoert zu Suedkorea?',NULL,19,NULL),(107,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Seoul?',NULL,19,NULL),(108,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,19,NULL),(109,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Vietnam?',NULL,20,NULL),(110,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Haoi?',NULL,20,NULL),(111,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,20,NULL),(112,'Land_zu_Flagge','Welche Flagge gehoert zu Vietnam?',NULL,20,NULL),(113,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Haoi?',NULL,20,NULL),(114,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,20,NULL),(115,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Indonesien?',NULL,21,NULL),(116,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Jakarta?',NULL,21,NULL),(117,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,21,NULL),(118,'Land_zu_Flagge','Welche Flagge gehoert zu Indonesien?',NULL,21,NULL),(119,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Jakarta?',NULL,21,NULL),(120,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,21,NULL),(121,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Malaysia?',NULL,22,NULL),(122,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Kuala Lumpur?',NULL,22,NULL),(123,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,22,NULL),(124,'Land_zu_Flagge','Welche Flagge gehoert zu Malaysia?',NULL,22,NULL),(125,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Kuala Lumpur?',NULL,22,NULL),(126,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,22,NULL),(127,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Philippinen?',NULL,23,NULL),(128,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Manila?',NULL,23,NULL),(129,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,23,NULL),(130,'Land_zu_Flagge','Welche Flagge gehoert zu Philippinen?',NULL,23,NULL),(131,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Manila?',NULL,23,NULL),(132,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,23,NULL),(133,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Singapur?',NULL,24,NULL),(134,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Singapur?',NULL,24,NULL),(135,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,24,NULL),(136,'Land_zu_Flagge','Welche Flagge gehoert zu Singapur?',NULL,24,NULL),(137,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Singapur?',NULL,24,NULL),(138,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,24,NULL),(139,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Iran?',NULL,25,NULL),(140,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Teheran?',NULL,25,NULL),(141,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,25,NULL),(142,'Land_zu_Flagge','Welche Flagge gehoert zu Iran?',NULL,25,NULL),(143,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Teheran?',NULL,25,NULL),(144,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,25,NULL),(145,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Tuerkei?',NULL,26,NULL),(146,'Hauptstadt_zu_Land','Zu welchem Land gehoert die Hauptstadt Ankara?',NULL,26,NULL),(147,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,26,NULL),(148,'Land_zu_Flagge','Welche Flagge gehoert zu Tuerkei?',NULL,26,NULL),(149,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Ankara?',NULL,26,NULL),(150,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,26,NULL),(151,'Land_zu_Hauptstadt','Wie heißt die Hauptstadt von Bangladesch?',NULL,27,NULL),(152,'Hauptstadt_zu_Land','Zu welchem Land gehoert die HauptstadtDhaka?',NULL,27,NULL),(153,'Flagge_zu_Land','Zu welchem Land gehoert diese Flagge?',NULL,27,NULL),(154,'Land_zu_Flagge','Welche Flagge gehoert zu Bangladesch?',NULL,27,NULL),(155,'Hauptstadt_zu_Flagge','Welche Flagge gehoert zur Hauptstadt Dhaka?',NULL,27,NULL),(156,'Flagge_zu_Hauptstadt','Welche Hauptstadt gehoert zu dieser Flagge?',NULL,27,NULL);
/*!40000 ALTER TABLE `frage` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `geodaten`
--

DROP TABLE IF EXISTS `geodaten`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `geodaten` (
  `GeoDatenID` int(11) NOT NULL AUTO_INCREMENT,
  `kontinent` varchar(50) DEFAULT NULL,
  `land` varchar(50) DEFAULT NULL,
  `hauptstadt` varchar(50) DEFAULT NULL,
  `flagge` blob DEFAULT NULL,
  PRIMARY KEY (`GeoDatenID`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `geodaten`
--

LOCK TABLES `geodaten` WRITE;
/*!40000 ALTER TABLE `geodaten` DISABLE KEYS */;
INSERT INTO `geodaten` VALUES (2,'Europa','Deutschland','Berlin','Deutschland'),(3,'Europa','Frankreich','Paris','Frankreich'),(4,'Europa','Italien','Rom','Italien'),(5,'Europa','Spanien','Madrid','Spanien'),(6,'Europa','Polen','Warschau','Polen'),(7,'Europa','Niederlande','Amsterdam','Niederlande'),(8,'Europa','Schweden','Stockholm','Schweden'),(9,'Europa','Norwegen','Oslo','Norwegen'),(10,'Europa','Oesterreich','Wien','Oesterreich'),(11,'Europa','Schweiz','Bern','Schweiz'),(12,'Europa','Belgien','Bruessel','Belgien'),(13,'Europa','Portugal','Lissabon','Portugal'),(14,'Europa','Griechenland','Athen','Griechenland'),(15,'Asien','China','Peking','China'),(16,'Asien','Japan','Tokio','Japan'),(17,'Asien','Indien','Neu-Delhi','Indien'),(18,'Asien','Thailand','Bangkok','Thailand'),(19,'Asien','Suedkorea','Seoul','Suedkorea'),(20,'Asien','Vietnam','Haoi','Vietnam'),(21,'Asien','Indonesien','Jakarta','Indonesien'),(22,'Asien','Malaysia','Kuala Lumpur','Malaysia'),(23,'Asien','Philippinen','Manila','Philippinen'),(24,'Asien','Singapur','Singapur','Singapur'),(25,'Asien','Iran','Teheran','Iran'),(26,'Asien','Tuerkei','Ankara','Tuerkei'),(27,'Asien','Bangladesch','Dhaka','Bangladesch');
/*!40000 ALTER TABLE `geodaten` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `quiz`
--

DROP TABLE IF EXISTS `quiz`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `quiz` (
  `quizID` int(11) NOT NULL AUTO_INCREMENT,
  `punktzahl` int(11) DEFAULT 0,
  `highscore` int(11) DEFAULT 0,
  `BID` int(11) DEFAULT NULL,
  PRIMARY KEY (`quizID`),
  KEY `BID` (`BID`),
  CONSTRAINT `quiz_ibfk_1` FOREIGN KEY (`BID`) REFERENCES `benutzer` (`benutzerID`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `quiz`
--

LOCK TABLES `quiz` WRITE;
/*!40000 ALTER TABLE `quiz` DISABLE KEYS */;
INSERT INTO `quiz` VALUES (1,10,10,1),(2,0,10,1),(3,0,10,1),(4,9,10,1),(5,0,10,1),(6,0,10,1),(7,0,10,1),(8,0,10,1),(9,0,10,1),(10,0,10,1),(11,0,10,1),(12,0,10,1),(13,0,10,1),(14,0,10,1),(15,0,10,1),(16,0,10,1),(17,0,10,1),(18,0,10,1),(19,0,10,1),(20,0,10,1),(21,0,10,1);
/*!40000 ALTER TABLE `quiz` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-06-27 12:30:02
