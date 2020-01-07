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
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `masters`
--

LOCK TABLES `masters` WRITE;
/*!40000 ALTER TABLE `masters` DISABLE KEYS */;
INSERT INTO `masters` VALUES (2,'Малашенкович','Никита','Дмитриевич','Пентхаус в Лас-Вегасе','+375(29)8763626'),(3,'Ушакова','Ника','Валерьевна','г.Минск, ул.Эссаналиева 24','+375(44)7208923'),(5,'Пальценогов','Артемий','Безпапич','Курасовщина-Сити','+375(25)4350998'),(6,'Савицкая','Анастасия','Сергеевна','г.Миснк','+375(44)3453434'),(10,'Малиновская','Александра','Сергеевна','ул.Солтыса','+375(29)2343232'),(11,'Пакистанский','Бегемот','Отецевич','Мадагаскар','+375(29)3223232'),(12,'Прокопенко','Наталия','Владимировна','ул.Карбышева 10','+375(44)7890000'),(13,'Корсак','Кирилл','Александрович','ул. Эссаналиева 9','+375(44)7344620'),(14,'Каховская','Марина','Сергеевна','г.Минск ул. Толбухина','+375(29)3452211'),(15,'Лазовеночка','Андруша','Михалыч','Каменка','+375(29)8080234');
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
) ENGINE=InnoDB AUTO_INCREMENT=77 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_service`
--

LOCK TABLES `order_service` WRITE;
/*!40000 ALTER TABLE `order_service` DISABLE KEYS */;
INSERT INTO `order_service` VALUES (43,50,1),(44,50,4),(45,51,6),(48,54,3),(49,54,5),(50,55,17),(51,56,8),(52,57,5),(53,57,6),(54,58,1),(55,59,1),(56,59,8),(57,60,14),(58,61,15),(59,62,16),(60,64,13),(61,65,12),(68,73,11),(69,74,1),(70,75,2),(71,78,3),(72,79,6),(73,80,10),(74,81,8),(75,82,4),(76,82,6);
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
) ENGINE=InnoDB AUTO_INCREMENT=83 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (50,'2020-01-08 00:00:00',5),(51,'2020-01-17 00:00:00',3),(54,'2020-01-16 00:00:00',5),(55,'2020-01-06 00:00:00',6),(56,'2020-01-15 00:00:00',12),(57,'2020-01-07 00:00:00',3),(58,'2020-01-23 00:00:00',11),(59,'2020-01-30 00:00:00',14),(60,'2020-02-09 00:00:00',13),(61,'2020-03-07 00:00:00',12),(62,'2020-01-23 00:00:00',2),(63,'2020-01-23 00:00:00',2),(64,'2020-01-31 00:00:00',10),(65,'2020-01-31 00:00:00',3),(73,'2020-01-22 00:00:00',14),(74,'2020-01-01 00:00:00',5),(75,'2020-01-06 00:00:00',5),(76,'2019-12-28 00:00:00',5),(77,'2019-12-28 00:00:00',5),(78,'2019-12-28 00:00:00',5),(79,'2019-12-02 00:00:00',10),(80,'2019-11-05 00:00:00',13),(81,'2019-12-10 00:00:00',6),(82,'2020-01-01 00:00:00',11);
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
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `service`
--

LOCK TABLES `service` WRITE;
/*!40000 ALTER TABLE `service` DISABLE KEYS */;
INSERT INTO `service` VALUES (1,'Стрижка женская',10),(2,'Стрижка мужская',7),(3,'Укладка волос с использованием браша/утюжка',18),(4,'Окрашивание волос',35),(5,'Сложное окрашивание',80),(6,'Верхний пучок',70),(7,'Нижний пучок',70),(8,'Фактурный высокий хвост',75),(9,'Пляжные локоны',35),(10,'Голивудская волна',45),(11,'Косоплетение',10),(12,'Афрокосички',280),(13,'Зи-зи',240),(14,'Синегалы',260),(15,'Дреды',300),(16,'ДЕ дреды',350),(17,'Афролоконы',40),(18,'Низкий фактурный хвост',60),(30,'Окраска бровей',20),(31,'Ламинирование ресниц',30);
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

-- Dump completed on 2020-01-08  1:30:47
