-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: cfif31.ru    Database: ISPr25-22_SafiulinaAD_pr
-- ------------------------------------------------------
-- Server version	8.0.45-0ubuntu0.24.04.1

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
-- Table structure for table `addres_delivery`
--

DROP TABLE IF EXISTS `addres_delivery`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `addres_delivery` (
  `idaddres_delivery` int NOT NULL AUTO_INCREMENT,
  `addres_delivery_name` varchar(45) NOT NULL,
  PRIMARY KEY (`idaddres_delivery`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `addres_delivery`
--

LOCK TABLES `addres_delivery` WRITE;
/*!40000 ALTER TABLE `addres_delivery` DISABLE KEYS */;
INSERT INTO `addres_delivery` VALUES (1,'420151, г. Лесной, ул. Вишневая, 32'),(2,'125061, г. Лесной, ул. Подгорная, 8'),(3,'630370, г. Лесной, ул. Шоссейная, 24'),(4,'400562, г. Лесной, ул. Зеленая, 32'),(5,'614510, г. Лесной, ул. Маяковского, 47'),(6,'410542, г. Лесной, ул. Светлая, 46'),(7,'620839, г. Лесной, ул. Цветочная, 8'),(8,'443890, г. Лесной, ул. Коммунистическая, 1'),(9,'603379, г. Лесной, ул. Спортивная, 46'),(10,'603721, г. Лесной, ул. Гоголя, 41'),(11,'410172, г. Лесной, ул. Северная, 13'),(12,'614611, г. Лесной, ул. Молодежная, 50'),(13,'454311, г.Лесной, ул. Новая, 19'),(14,'660007, г.Лесной, ул. Октябрьская, 19'),(15,'603036, г. Лесной, ул. Садовая, 4'),(16,'394060, г.Лесной, ул. Фрунзе, 43'),(17,'410661, г. Лесной, ул. Школьная, 50'),(18,'625590, г. Лесной, ул. Коммунистическая, 20'),(19,'625683, г. Лесной, ул. 8 Марта'),(20,'450983, г.Лесной, ул. Комсомольская, 26'),(21,'394782, г. Лесной, ул. Чехова, 3'),(22,'603002, г. Лесной, ул. Дзержинского, 28'),(23,'450558, г. Лесной, ул. Набережная, 30'),(24,'344288, г. Лесной, ул. Чехова, 1'),(25,'614164, г.Лесной,  ул. Степная, 30'),(26,'394242, г. Лесной, ул. Коммунистическая, 43'),(27,'660540, г. Лесной, ул. Солнечная, 25'),(28,'125837, г. Лесной, ул. Шоссейная, 40'),(29,'125703, г. Лесной, ул. Партизанская, 49'),(30,'625283, г. Лесной, ул. Победы, 46'),(31,'614753, г. Лесной, ул. Полевая, 35'),(32,'426030, г. Лесной, ул. Маяковского, 44'),(33,'450375, г. Лесной ул. Клубная, 44'),(34,'625560, г. Лесной, ул. Некрасова, 12'),(35,'630201, г. Лесной, ул. Комсомольская, 17'),(36,'190949, г. Лесной, ул. Мичурина, 26');
/*!40000 ALTER TABLE `addres_delivery` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `category`
--

DROP TABLE IF EXISTS `category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `category` (
  `idcategory` int NOT NULL AUTO_INCREMENT,
  `category_name` varchar(45) NOT NULL,
  PRIMARY KEY (`idcategory`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `category`
--

LOCK TABLES `category` WRITE;
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category` VALUES (1,'Женская обувь'),(2,'Мужская обувь');
/*!40000 ALTER TABLE `category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `manufacturer`
--

DROP TABLE IF EXISTS `manufacturer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `manufacturer` (
  `idmanufacturer` int NOT NULL AUTO_INCREMENT,
  `manufacturer_name` varchar(45) NOT NULL,
  PRIMARY KEY (`idmanufacturer`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `manufacturer`
--

LOCK TABLES `manufacturer` WRITE;
/*!40000 ALTER TABLE `manufacturer` DISABLE KEYS */;
INSERT INTO `manufacturer` VALUES (1,'Kari'),(2,'Marco Tozzi'),(3,'Рос'),(4,'Rieker'),(5,'Alessio Nesca'),(6,'CROSBY');
/*!40000 ALTER TABLE `manufacturer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order_details`
--

DROP TABLE IF EXISTS `order_details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order_details` (
  `idorder_details` int NOT NULL AUTO_INCREMENT,
  `article` varchar(45) NOT NULL,
  `count` int NOT NULL,
  `order_id` int NOT NULL,
  PRIMARY KEY (`idorder_details`),
  KEY `order_id_idx` (`order_id`),
  CONSTRAINT `order_id` FOREIGN KEY (`order_id`) REFERENCES `orders` (`idorder`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_details`
--

LOCK TABLES `order_details` WRITE;
/*!40000 ALTER TABLE `order_details` DISABLE KEYS */;
INSERT INTO `order_details` VALUES (1,'А112Т4',2,1),(2,'F635R4',2,1),(3,'H782T5',1,2),(4,'G783F5',1,2),(5,'J384T6',10,3),(6,'D572U8',10,3),(7,'F572H7',5,4),(8,'D329H3',4,4),(9,'А112Т4',2,5),(10,'F635R4',2,5),(11,'H782T5',1,6),(12,'G783F5',1,6),(13,'J384T6',10,7),(14,'D572U8',10,7),(15,'F572H7',5,8),(16,'D329H3',4,8),(17,'B320R5',5,9),(18,'G432E4',1,9),(19,'S213E3',5,10),(20,'E482R4',5,10);
/*!40000 ALTER TABLE `order_details` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `idorder` int NOT NULL AUTO_INCREMENT,
  `data_orders` date NOT NULL,
  `data_delivery` date NOT NULL,
  `address_delivery_id` int NOT NULL,
  `fullname_id` int NOT NULL,
  `code` int NOT NULL,
  `status_orders_id` int NOT NULL,
  PRIMARY KEY (`idorder`),
  KEY `address_delivery_id_idx` (`address_delivery_id`),
  KEY `fullname_id_idx` (`fullname_id`),
  KEY `status_orders_id_idx` (`status_orders_id`),
  CONSTRAINT `address_delivery_id` FOREIGN KEY (`address_delivery_id`) REFERENCES `addres_delivery` (`idaddres_delivery`),
  CONSTRAINT `fullname_id` FOREIGN KEY (`fullname_id`) REFERENCES `user` (`iduser`),
  CONSTRAINT `status_orders_id` FOREIGN KEY (`status_orders_id`) REFERENCES `status_orders` (`idstatus_orders`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,'2025-02-27','2025-04-20',1,4,901,1),(2,'2022-09-28','2025-04-21',11,1,902,1),(3,'2025-03-21','2025-04-22',2,2,903,1),(4,'2025-02-20','2025-04-23',11,3,904,1),(5,'2025-03-17','2025-04-24',2,4,905,1),(6,'2025-03-01','2025-04-25',15,1,906,1),(7,'2025-04-30','2025-04-26',3,2,907,1),(8,'2025-03-31','2025-04-27',19,3,908,2),(9,'2025-04-02','2025-04-28',5,4,909,2),(10,'2025-04-03','2025-04-29',19,4,910,2);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `idproduct` int NOT NULL AUTO_INCREMENT,
  `article` varchar(45) NOT NULL,
  `product_name_id` int NOT NULL,
  `unit_id` int NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `supplier_id` int NOT NULL,
  `manufacturer_id` int NOT NULL,
  `category_id` int NOT NULL,
  `discount` int DEFAULT NULL,
  `count` int NOT NULL,
  `description` varchar(100) NOT NULL,
  `photo` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idproduct`),
  KEY `product_name_id_idx` (`product_name_id`),
  KEY `unit_id_idx` (`unit_id`),
  KEY `supplier_id_idx` (`supplier_id`),
  KEY `manufacturer_id_idx` (`manufacturer_id`),
  KEY `category_id_idx` (`category_id`),
  CONSTRAINT `category_id` FOREIGN KEY (`category_id`) REFERENCES `category` (`idcategory`),
  CONSTRAINT `manufacturer_id` FOREIGN KEY (`manufacturer_id`) REFERENCES `manufacturer` (`idmanufacturer`),
  CONSTRAINT `product_name_id` FOREIGN KEY (`product_name_id`) REFERENCES `product_name` (`idproduct_name`),
  CONSTRAINT `supplier_id` FOREIGN KEY (`supplier_id`) REFERENCES `supplier` (`idsupplier`),
  CONSTRAINT `unit_id` FOREIGN KEY (`unit_id`) REFERENCES `unit` (`idunit`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES (1,'А112Т4',1,1,4990.00,1,1,1,3,6,'Женские Ботинки демисезонные 1','1.jpg'),(2,'F635R4',1,1,3244.00,2,2,1,2,13,'Ботинки 2 женские демисезонные, размер 39, цвет бежевый','2.jpg'),(3,'H782T5',2,1,4499.00,1,1,2,4,5,'Туфли 1 мужские классика MYZ21AW-450A, размер 43, цвет: черный','3.jpg'),(4,'G783F5',1,1,5900.00,1,3,2,2,8,'Мужские ботинки 3-Обувь кожаные с натуральным мехом','4.jpg'),(5,'J384T6',1,1,3800.00,2,4,2,2,16,'B3430/14 Полуботинки мужские 4','5.jpg'),(6,'D572U8',3,1,4100.00,2,3,2,3,6,'129615-4 К3совки мужские','6.jpg'),(7,'F572H7',2,1,2700.00,1,2,1,2,14,'Туфли 2 женские летние, размер 39, цвет черный','7.jpg'),(8,'D329H3',4,1,1890.00,2,5,1,4,4,'Полуботинки 5 женские 3-30797-47, размер 37, цвет: бордовый','8.jpg'),(9,'B320R5',2,1,4300.00,1,4,1,2,6,'Туфли 4 женские демисезонные, размер 41, цвет коричневый','9.jpg'),(10,'G432E4',2,1,2800.00,1,1,1,3,15,'Туфли 1 женские TR-YR-413017, размер 37, цвет: черный','10.jpg'),(11,'S213E3',4,1,2156.00,2,6,2,3,6,'407700/01-01 Полуботинки мужские 6',''),(12,'E482R4',4,1,1800.00,1,1,1,2,14,'Полуботинки 1 женские MYZ20S-149, размер 41, цвет: черный',''),(13,'S634B5',5,1,5500.00,2,6,2,3,0,'Кеды Caprice мужские демисезонные, размер 42, цвет черный',''),(14,'K345R4',4,1,2100.00,2,6,2,2,3,'407700/01-02 Полуботинки мужские 6',''),(15,'O754F4',2,1,5400.00,2,4,1,4,18,'Туфли женские демисезонные 4 артикул 55073-68/37',''),(16,'G531F4',1,1,6600.00,1,1,1,12,9,'Ботинки женские зимние ROMER арт. 893167-01 Черный',''),(17,'J542F5',6,1,500.00,1,1,2,13,0,'Тапочки мужские Арт.70701-55-67син р.41',''),(18,'B431R5',1,1,2700.00,2,4,2,2,5,'Мужские кожаные ботинки/мужские ботинки',''),(19,'P764G4',2,1,6800.00,1,6,1,15,15,'Туфли женские, ARGO, размер 38',''),(20,'C436G5',1,1,10200.00,1,5,1,15,9,'Ботинки женские, ARGO, размер 40',''),(21,'F427R5',1,1,11800.00,2,4,1,15,11,'Ботинки на молнии с декоративной пряжкой FRAU',''),(22,'N457T5',4,1,4600.00,1,6,1,3,13,'Полуботинки Ботинки черные зимние, мех',''),(23,'D364R4',2,1,12400.00,1,1,1,16,5,'Туфли Luiza Belly женские Kate-lazo черные из натуральной замши',''),(24,'S326R5',6,1,9900.00,2,6,2,17,15,'Мужские кожаные тапочки \"Профиль С.Дали\" ',''),(25,'L754R4',4,1,1700.00,1,1,1,2,7,'Полуботинки 1 женские WB2020SS-26, размер 38, цвет: черный',''),(26,'M542T5',3,1,2800.00,2,4,2,18,3,'К3совки мужские TOFA',''),(27,'D268G5',2,1,4399.00,2,4,1,3,12,'Туфли 4 женские демисезонные, размер 36, цвет коричневый',''),(28,'T324F5',7,1,4699.00,1,6,1,2,5,'Сапоги замша Цвет: синий',''),(29,'K358H6',6,1,599.00,1,4,2,20,2,'Тапочки мужские син р.41',''),(30,'H535R5',1,1,2300.00,2,4,1,2,7,'Женские Ботинки демисезонные','');
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product_name`
--

DROP TABLE IF EXISTS `product_name`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product_name` (
  `idproduct_name` int NOT NULL AUTO_INCREMENT,
  `product_names` varchar(45) NOT NULL,
  PRIMARY KEY (`idproduct_name`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product_name`
--

LOCK TABLES `product_name` WRITE;
/*!40000 ALTER TABLE `product_name` DISABLE KEYS */;
INSERT INTO `product_name` VALUES (1,'Ботинки'),(2,'Туфли'),(3,'К3совки'),(4,'Полуботинки'),(5,'Кеды'),(6,'Тапочки'),(7,'Сапоги');
/*!40000 ALTER TABLE `product_name` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role` (
  `idrole` int NOT NULL AUTO_INCREMENT,
  `role_name` varchar(45) NOT NULL,
  PRIMARY KEY (`idrole`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` VALUES (1,'Администратор'),(2,'Менеджер'),(3,'Авторизованный клиент');
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `status_orders`
--

DROP TABLE IF EXISTS `status_orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `status_orders` (
  `idstatus_orders` int NOT NULL AUTO_INCREMENT,
  `status_name` varchar(45) NOT NULL,
  PRIMARY KEY (`idstatus_orders`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `status_orders`
--

LOCK TABLES `status_orders` WRITE;
/*!40000 ALTER TABLE `status_orders` DISABLE KEYS */;
INSERT INTO `status_orders` VALUES (1,'Звершен'),(2,'Новый');
/*!40000 ALTER TABLE `status_orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier`
--

DROP TABLE IF EXISTS `supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supplier` (
  `idsupplier` int NOT NULL AUTO_INCREMENT,
  `supplier_name` varchar(45) NOT NULL,
  PRIMARY KEY (`idsupplier`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier`
--

LOCK TABLES `supplier` WRITE;
/*!40000 ALTER TABLE `supplier` DISABLE KEYS */;
INSERT INTO `supplier` VALUES (1,'Kari'),(2,'Обувь для вас');
/*!40000 ALTER TABLE `supplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `unit`
--

DROP TABLE IF EXISTS `unit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `unit` (
  `idunit` int NOT NULL AUTO_INCREMENT,
  `unit_name` varchar(45) NOT NULL,
  PRIMARY KEY (`idunit`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unit`
--

LOCK TABLES `unit` WRITE;
/*!40000 ALTER TABLE `unit` DISABLE KEYS */;
INSERT INTO `unit` VALUES (1,'шт.');
/*!40000 ALTER TABLE `unit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `iduser` int NOT NULL AUTO_INCREMENT,
  `user_role_id` varchar(45) NOT NULL,
  `user_surname` varchar(45) NOT NULL,
  `user_name` varchar(45) NOT NULL,
  `user_patronomic` varchar(45) NOT NULL,
  `login` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  PRIMARY KEY (`iduser`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'1','Никифорова','Весения','Николаевна','94d5ous@gmail.com','uzWC67'),(2,'1','Сазонов','Руслан','Германович','uth4iz@mail.com','2L6KZG'),(3,'1','Одинцов','Серафим','Артёмович','yzls62@outlook.com','JlFRCZ'),(4,'2','Степанов','Михаил','Артёмович','1diph5e@tutanota.com','8ntwUp'),(5,'2','Ворсин','Петр','Евгеньевич','tjde7c@yahoo.com','YOyhfR'),(6,'2','Старикова','Елена','Павловна','wpmrc3do@tutanota.com','RSbvHv'),(7,'3','Михайлюк','Анна','Вячеславовна','5d4zbu@tutanota.com','rwVDh9'),(8,'3','Ситдикова','Елена','Анатольевна','ptec8ym@yahoo.com','LdNyos'),(9,'3','Ворсин','Петр','Евгеньевич','1qz4kw@mail.com','gynQMT'),(10,'3','Старикова','Елена','Павловна','4np6se@mail.com','AtnDjr');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-05-29 14:55:43
