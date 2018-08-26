-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 26, 2018 at 04:37 PM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `normals`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `admin_id` int(11) NOT NULL,
  `fname` varchar(45) DEFAULT NULL,
  `lname` varchar(45) DEFAULT NULL,
  `address` varchar(45) DEFAULT NULL,
  `contact` int(11) DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`admin_id`, `fname`, `lname`, `address`, `contact`, `username`, `password`) VALUES
(1, 'asd', 'asd', 'asd', 1, 'test', 'test');

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

CREATE TABLE `attendance` (
  `att_id` int(11) NOT NULL,
  `time_in` datetime NOT NULL,
  `time_out` varchar(45) DEFAULT NULL,
  `emp_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `attendance`
--

INSERT INTO `attendance` (`att_id`, `time_in`, `time_out`, `emp_id`) VALUES
(1, '2018-08-13 22:11:59', NULL, 1),
(2, '2018-08-13 22:13:28', NULL, 1),
(3, '2018-08-13 22:15:48', NULL, 1),
(4, '2018-08-14 10:22:40', NULL, 1),
(5, '2018-08-14 10:23:53', NULL, 1),
(6, '2018-08-14 10:24:28', NULL, 1),
(7, '2018-08-14 10:25:40', NULL, 1),
(8, '2018-08-14 10:27:12', NULL, 1),
(9, '2018-08-14 13:24:28', NULL, 1),
(10, '2018-08-14 13:28:49', NULL, 1),
(11, '2018-08-14 13:31:39', NULL, 1),
(12, '2018-08-14 13:32:42', NULL, 1),
(13, '2018-08-14 13:55:45', '2018-08-14,13-55-45', 1),
(14, '2018-08-14 14:19:25', NULL, 1),
(15, '2018-08-14 14:24:17', NULL, 1),
(16, '2018-08-14 14:31:49', '2018-08-14,14-31-49', 1),
(17, '2018-08-14 14:33:22', '2018-08-14,14-33-22', 2),
(18, '2018-08-14 15:27:40', NULL, 1),
(19, '2018-08-14 15:32:35', NULL, 1),
(20, '2018-08-21 00:16:13', NULL, 1),
(21, '2018-08-21 00:20:19', NULL, 1),
(22, '2018-08-21 00:22:08', NULL, 1),
(23, '2018-08-21 00:24:55', NULL, 1),
(24, '2018-08-21 00:26:13', NULL, 1),
(25, '2018-08-21 00:29:08', NULL, 1),
(26, '2018-08-21 00:30:29', NULL, 1),
(27, '2018-08-21 00:31:54', NULL, 1),
(28, '2018-08-21 00:33:30', NULL, 1),
(29, '2018-08-21 00:34:50', NULL, 1),
(30, '2018-08-21 00:41:40', NULL, 1),
(31, '2018-08-21 00:42:50', NULL, 1),
(32, '2018-08-21 00:46:49', NULL, 1),
(33, '2018-08-21 00:53:09', NULL, 1),
(34, '2018-08-21 00:54:39', NULL, 1),
(35, '2018-08-21 00:55:56', NULL, 1),
(36, '2018-08-21 00:59:12', NULL, 1),
(37, '2018-08-21 01:03:32', NULL, 1),
(38, '2018-08-21 01:05:04', NULL, 1),
(39, '2018-08-21 01:08:44', NULL, 1),
(40, '2018-08-21 01:10:05', NULL, 1),
(41, '2018-08-21 01:15:15', NULL, 1),
(42, '2018-08-21 01:24:19', NULL, 1),
(43, '2018-08-21 01:25:59', NULL, 1),
(44, '2018-08-21 01:27:37', NULL, 1),
(45, '2018-08-21 01:28:31', NULL, 1),
(46, '2018-08-21 01:30:53', NULL, 1),
(47, '2018-08-21 01:31:48', NULL, 1),
(48, '2018-08-21 01:33:18', NULL, 1),
(49, '2018-08-21 01:34:58', NULL, 1),
(50, '2018-08-21 01:36:24', NULL, 1),
(51, '2018-08-21 01:37:48', NULL, 1),
(52, '2018-08-21 01:39:03', NULL, 1),
(53, '2018-08-21 01:40:57', NULL, 1),
(54, '2018-08-21 02:09:16', NULL, 1);

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `cust_id` int(11) NOT NULL,
  `fname` varchar(45) DEFAULT NULL,
  `lname` varchar(45) DEFAULT NULL,
  `addres` varchar(45) DEFAULT NULL,
  `contact` int(11) DEFAULT NULL,
  `emp_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`cust_id`, `fname`, `lname`, `addres`, `contact`, `emp_id`) VALUES
(1, 'asd', 'asd', 'asd', 3, 1),
(2, 'asd', 'asd', 'asd', 1, 1),
(3, 'asd', 'asd', 'asd', 1, 1),
(4, 'asd', 'asd', 'asd', 1, 1),
(5, 'asd', 'asd', 'asd', 0, 1),
(6, 'asd', 'asd', 'asd', 2, 1),
(7, 'asd', 'asd', 'asd', 2, 1),
(8, 'asd', 'asd', 'asd', 1, 1),
(9, 'asd', 'asd', 'asd', 1, 1),
(10, 'asd', 'asd', 'asd', 1, 1),
(11, 'asd', 'asd', 'asd', 1, 1),
(12, 'asd', 'asd', 'asd', 1, 1),
(13, 'asd', 'asd', 'asd', 1, 1),
(14, 'asd', 'asd', 'asd', 1, 1),
(15, 'asd', 'asd', 'asd', 1, 1),
(16, 'asd', 'asd', 'asd', 1, 1),
(17, 'jerry', 'endaya', 'taguig', 23, 1),
(18, 'jerry', 'endaya', 'taguig', 23, 1),
(19, 'asd', 'asd', 'asd', 2, 1),
(20, 'asd', 'asd', 'asd', 1, 1),
(21, 'asd', 'asd', 'asd', 1, 1),
(22, 'asd', 'asd', 'asd', 1, 1),
(23, 'asd', 'asd', 'asd', 1, 1),
(24, 'asd', 'asd', 'asd', 1, 1),
(25, 'asd', 'asdd', 'dd', 1, 1),
(26, 'asd', 'asd', 'asd', 1, 1),
(27, 'asd', 'asd', 'asd', 1, 1),
(28, 'asd', 'asd', 'asd', 1, 1),
(29, 'asd', 'asd', 'asd', 1, 1),
(30, 'asd', 'asd', 'asd', 1, 1),
(31, 'asd', 'asd', 'asd', 1, 1),
(32, 'asd', 'asd', 'sd', 1, 1),
(33, 'asd', 'asd', 'asd', 1, 1),
(34, 'asd', 'asd', 'asd', 1, 1),
(35, 'asd', 'asd', 'asd', 1, 1),
(36, 'asd', 'asd', 'asd', 1, 1),
(37, 'asd', 'asd', 'asd', 1, 1),
(38, 'asd', 'asd', 'asd', 1, 1),
(39, 'asd', 'asd', 'asd', 2, 1),
(40, 'asd', 'asd', 'asd', 2, 1);

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `emp_id` int(11) NOT NULL,
  `fname` varchar(45) DEFAULT NULL,
  `lname` varchar(45) DEFAULT NULL,
  `address` varchar(45) DEFAULT NULL,
  `contact` int(11) DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `admin_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`emp_id`, `fname`, `lname`, `address`, `contact`, `username`, `password`, `admin_id`) VALUES
(1, 'sad', 'asd', 'asd', 1, 'test', 'test', 1),
(2, 'asd', 'sss', 'taguig', 121, 'bbb', 'bbb', 1);

-- --------------------------------------------------------

--
-- Table structure for table `item`
--

CREATE TABLE `item` (
  `item_id` int(11) NOT NULL,
  `desc` varchar(45) DEFAULT NULL,
  `size` varchar(45) DEFAULT NULL,
  `price` decimal(5,2) DEFAULT NULL,
  `quantity` int(11) NOT NULL,
  `sup_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `item`
--

INSERT INTO `item` (`item_id`, `desc`, `size`, `price`, `quantity`, `sup_id`) VALUES
(1, 'rdshorts', 'M', '200.00', 47, 1),
(2, 'rdpants', 'M', '350.00', 188, 2),
(3, 'rdpants', 'S', '350.00', 286, 3),
(4, 'rdtshirt', 'M', '350.00', 50, 4);

-- --------------------------------------------------------

--
-- Table structure for table `purchase`
--

CREATE TABLE `purchase` (
  `purch_id` int(11) NOT NULL,
  `purch_date` datetime DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `item_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `purchase`
--

INSERT INTO `purchase` (`purch_id`, `purch_date`, `quantity`, `item_id`) VALUES
(1, '2018-08-13 22:12:02', 4, 1),
(2, '2018-08-14 10:32:30', 4, 1),
(3, '2018-08-14 10:33:21', 2, 1),
(4, '2018-08-14 10:39:42', 2, 1),
(5, '2018-08-14 15:27:44', 2, 1),
(6, '2018-08-14 15:27:44', 5, 1),
(7, '2018-08-21 00:30:31', 2, 2),
(8, '2018-08-21 00:46:52', 2, 1),
(9, '2018-08-21 00:55:58', 2, 1),
(10, '2018-08-21 00:55:58', 2, 1),
(11, '2018-08-21 00:55:58', 2, 2),
(12, '2018-08-21 00:59:15', 4, 1),
(13, '2018-08-21 01:05:06', 2, 1),
(14, '2018-08-21 01:05:06', 2, 1),
(15, '2018-08-21 01:05:06', 2, 1),
(16, '2018-08-21 01:05:06', 2, 2),
(17, '2018-08-21 01:05:06', 2, 2),
(18, '2018-08-21 01:05:06', 2, 2),
(19, '2018-08-21 02:09:25', NULL, 2);

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

CREATE TABLE `reservation` (
  `res_id` int(11) NOT NULL,
  `res_date` datetime DEFAULT NULL,
  `res_p_u_date` datetime DEFAULT NULL,
  `cust_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `reservation`
--

INSERT INTO `reservation` (`res_id`, `res_date`, `res_p_u_date`, `cust_id`) VALUES
(1, '2018-08-13 00:00:00', '2018-08-13 00:00:00', 2),
(2, '2018-08-13 00:00:00', '2018-08-13 00:00:00', 3),
(3, '2018-08-13 00:00:00', '2018-08-13 00:00:00', 4),
(4, '2018-08-14 00:00:00', '2018-08-14 00:00:00', 5),
(5, '2018-08-14 00:00:00', '2018-08-14 00:00:00', 6),
(6, '2018-08-14 00:00:00', '2018-08-14 00:00:00', 7),
(7, '2018-08-14 00:00:00', '2018-08-14 00:00:00', 8),
(8, '2018-08-14 00:00:00', '2018-08-14 00:00:00', 12),
(9, '2018-08-14 00:00:00', '2018-08-14 00:00:00', 13),
(10, '2018-08-14 00:00:00', '2018-08-14 00:00:00', 14),
(11, '2018-08-14 00:00:00', '2018-08-14 00:00:00', 15),
(12, '2018-08-14 00:00:00', '2018-08-14 00:00:00', 16),
(13, '2018-08-14 00:00:00', '2018-08-14 00:00:00', 19),
(14, '2018-08-21 00:00:00', '2018-08-21 00:00:00', 32),
(15, '2018-08-21 00:00:00', '2018-08-21 00:00:00', 33),
(16, '2018-08-21 00:00:00', '2018-08-21 00:00:00', 34),
(17, '2018-08-21 00:00:00', '2018-08-21 00:00:00', 35),
(18, '2018-08-21 00:00:00', '2018-08-21 00:00:00', 36),
(19, '2018-08-21 00:00:00', '2018-08-21 00:00:00', 37),
(20, '2018-08-21 00:00:00', '2018-08-21 00:00:00', 38),
(21, '2018-08-21 00:00:00', '2018-08-21 00:00:00', 39);

-- --------------------------------------------------------

--
-- Table structure for table `resline`
--

CREATE TABLE `resline` (
  `item_id` int(11) NOT NULL,
  `res_id` int(11) NOT NULL,
  `quantity` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `resline`
--

INSERT INTO `resline` (`item_id`, `res_id`, `quantity`) VALUES
(1, 7, 2),
(1, 8, 2),
(1, 9, 2),
(1, 10, 5),
(1, 11, 2),
(1, 12, 2),
(1, 13, 4),
(1, 17, 2),
(2, 17, 2),
(1, 18, 2),
(3, 18, 2),
(3, 18, 0),
(1, 19, 2),
(3, 19, 2),
(3, 19, 0),
(1, 20, 2),
(3, 20, 2),
(3, 20, 0),
(1, 21, 2),
(3, 21, 2);

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `sup_id` int(11) NOT NULL,
  `sup_name` varchar(45) DEFAULT NULL,
  `sup_lname` varchar(45) DEFAULT NULL,
  `sup_address` varchar(45) DEFAULT NULL,
  `sup_contact` int(11) DEFAULT NULL,
  `admin_id` int(11) NOT NULL,
  `sup_costprice` decimal(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`sup_id`, `sup_name`, `sup_lname`, `sup_address`, `sup_contact`, `admin_id`, `sup_costprice`) VALUES
(1, 'asd', 'asd', 'asd', 1, 1, '100.00'),
(2, 'asd', 'asd', 'asd', 1, 1, '200.00'),
(3, 'jerry', 'endaya', 'taguig', 2, 1, '150.00'),
(4, 'ivy', 'deguzman', 'taguig', 231, 1, '150.00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`admin_id`);

--
-- Indexes for table `attendance`
--
ALTER TABLE `attendance`
  ADD PRIMARY KEY (`att_id`),
  ADD KEY `fk_attendance_employee1_idx` (`emp_id`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`cust_id`),
  ADD KEY `fk_customer_employee1_idx` (`emp_id`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`emp_id`),
  ADD KEY `fk_employee_admin_idx` (`admin_id`);

--
-- Indexes for table `item`
--
ALTER TABLE `item`
  ADD PRIMARY KEY (`item_id`),
  ADD KEY `fk_item_Supplier1_idx` (`sup_id`);

--
-- Indexes for table `purchase`
--
ALTER TABLE `purchase`
  ADD PRIMARY KEY (`purch_id`),
  ADD KEY `fk_purchase_item1_idx` (`item_id`);

--
-- Indexes for table `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`res_id`),
  ADD KEY `fk_reservation_customer1_idx` (`cust_id`);

--
-- Indexes for table `resline`
--
ALTER TABLE `resline`
  ADD KEY `fk_item_has_reservation_reservation1_idx` (`res_id`),
  ADD KEY `fk_item_has_reservation_item1_idx` (`item_id`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`sup_id`),
  ADD KEY `fk_Supplier_admin1_idx` (`admin_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `admin_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `attendance`
--
ALTER TABLE `attendance`
  MODIFY `att_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=55;
--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `cust_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;
--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `emp_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `item`
--
ALTER TABLE `item`
  MODIFY `item_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `purchase`
--
ALTER TABLE `purchase`
  MODIFY `purch_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
--
-- AUTO_INCREMENT for table `reservation`
--
ALTER TABLE `reservation`
  MODIFY `res_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `sup_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `attendance`
--
ALTER TABLE `attendance`
  ADD CONSTRAINT `fk_attendance_employee1` FOREIGN KEY (`emp_id`) REFERENCES `employee` (`emp_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `customer`
--
ALTER TABLE `customer`
  ADD CONSTRAINT `fk_customer_employee1` FOREIGN KEY (`emp_id`) REFERENCES `employee` (`emp_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `employee`
--
ALTER TABLE `employee`
  ADD CONSTRAINT `fk_employee_admin` FOREIGN KEY (`admin_id`) REFERENCES `admin` (`admin_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `item`
--
ALTER TABLE `item`
  ADD CONSTRAINT `fk_item_Supplier1` FOREIGN KEY (`sup_id`) REFERENCES `supplier` (`sup_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `purchase`
--
ALTER TABLE `purchase`
  ADD CONSTRAINT `fk_purchase_item1` FOREIGN KEY (`item_id`) REFERENCES `item` (`item_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `fk_reservation_customer1` FOREIGN KEY (`cust_id`) REFERENCES `customer` (`cust_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `resline`
--
ALTER TABLE `resline`
  ADD CONSTRAINT `fk_item_has_reservation_item1` FOREIGN KEY (`item_id`) REFERENCES `item` (`item_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_item_has_reservation_reservation1` FOREIGN KEY (`res_id`) REFERENCES `reservation` (`res_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `supplier`
--
ALTER TABLE `supplier`
  ADD CONSTRAINT `fk_Supplier_admin1` FOREIGN KEY (`admin_id`) REFERENCES `admin` (`admin_id`) ON DELETE NO ACTION ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
