-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: localhost    Database: barbershop
-- ------------------------------------------------------
-- Server version	8.0.17

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
-- Table structure for table `masters`
--

DROP TABLE IF EXISTS `masters`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `masters` (
  `id_master` int(11) NOT NULL AUTO_INCREMENT,
  `Surname` text NOT NULL,
  `Name` text NOT NULL,
  `Patronymic` text NOT NULL,
  `Adress` text NOT NULL,
  `Phone` text NOT NULL,
  PRIMARY KEY (`id_master`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `masters`
--

LOCK TABLES `masters` WRITE;
/*!40000 ALTER TABLE `masters` DISABLE KEYS */;
INSERT INTO `masters` VALUES (2,'Малашенкович','Никита','Дмитриевич','Пентхаус  в Лас-Вегасе','+375298763626'),(3,'Ушакова','Ника','Валерьевна','г.Минск, ул.Эссаналиева 24','+375447208923'),(5,'Пальценогов','Артемий','Безпапич','Курасовщина-сити','+357254350998'),(6,'Савицкая','Анастасия','Сергеевна','г.Миснк','+375(44)3453434'),(10,'Малиновская','Александра','Сергеевна','ул.Солтыса','+375(29)2343232'),(11,'Пакистанский','Бегемот','Отецевич','Мадагаскар','+375(29)3223232'),(12,'Прокопенко','Наталия','Владимировна','ул.Карбышева 10','+375(44)7890000');
/*!40000 ALTER TABLE `masters` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order_service`
--

DROP TABLE IF EXISTS `order_service`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order_service` (
  `id_order_service` int(11) NOT NULL AUTO_INCREMENT,
  `id_order` int(11) NOT NULL,
  `id_service` int(11) NOT NULL,
  PRIMARY KEY (`id_order_service`),
  KEY `FK_order_line_idx` (`id_order`),
  KEY `FK_service_line_idx` (`id_service`),
  CONSTRAINT `FK_order_line` FOREIGN KEY (`id_order`) REFERENCES `orders` (`id_order`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_service_line` FOREIGN KEY (`id_service`) REFERENCES `service` (`id_service`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_service`
--

LOCK TABLES `order_service` WRITE;
/*!40000 ALTER TABLE `order_service` DISABLE KEYS */;
INSERT INTO `order_service` VALUES (2,17,5),(3,17,3),(4,17,7),(8,19,5),(9,19,2),(10,19,4),(11,20,4),(12,23,4),(13,23,18),(16,25,2),(17,25,4),(18,26,11),(19,26,6),(20,27,8),(21,28,13),(22,29,1),(23,30,3),(24,30,8);
/*!40000 ALTER TABLE `order_service` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `id_order` int(11) NOT NULL AUTO_INCREMENT,
  `Date` datetime NOT NULL,
  `id_master` int(11) NOT NULL,
  PRIMARY KEY (`id_order`),
  KEY `FK_master_order_idx` (`id_master`),
  CONSTRAINT `FK_master_order` FOREIGN KEY (`id_master`) REFERENCES `masters` (`id_master`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (13,'2029-12-20 00:00:00',3),(15,'2025-12-20 00:00:00',6),(17,'2026-12-20 00:00:00',5),(19,'2026-12-20 19:00:00',5),(20,'2020-12-20 19:00:00',5),(23,'2019-12-27 00:00:00',3),(25,'2019-12-28 00:00:00',5),(26,'2019-12-27 00:00:00',11),(27,'2019-12-25 00:00:00',10),(28,'2019-12-29 00:00:00',11),(29,'2019-12-27 00:00:00',2),(30,'2019-12-23 00:00:00',3);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `service`
--

DROP TABLE IF EXISTS `service`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `service` (
  `id_service` int(11) NOT NULL AUTO_INCREMENT,
  `name_service` text NOT NULL,
  `price` int(4) NOT NULL,
  PRIMARY KEY (`id_service`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `service`
--

LOCK TABLES `service` WRITE;
/*!40000 ALTER TABLE `service` DISABLE KEYS */;
INSERT INTO `service` VALUES (1,'Стрижка женская',7),(2,'Стрижка мужская',7),(3,'Укладка волос с использованием браша/утюжка',18),(4,'Окрашивание волос',35),(5,'Сложное окрашивание',80),(6,'Верхний пучок',70),(7,'Нижний пучок',65),(8,'Фактурный высокий хвост',75),(9,'Пляжные локоны',35),(10,'Голивудская волна',45),(11,'Косоплетение',10),(12,'Афрокосички',280),(13,'Зи-зи',240),(14,'Синегалы',260),(15,'Дреды',300),(16,'ДЕ дреды',350),(17,'Афролоконы',40),(18,'Низкий фактурный хвост',60);
/*!40000 ALTER TABLE `service` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'barbershop'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-12-21  1:11:19
