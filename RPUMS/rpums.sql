-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 01, 2023 at 10:14 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `rpums`
--

-- --------------------------------------------------------

--
-- Table structure for table `landlord`
--

CREATE TABLE `landlord` (
  `landlord_id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `username` text NOT NULL,
  `password` varchar(30) NOT NULL,
  `pin` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `landlord`
--

INSERT INTO `landlord` (`landlord_id`, `name`, `username`, `password`, `pin`) VALUES
(1, 'admin', 'admin', 'admin1', 123456),
(2, 'Leinn Lontiong', 'leinnlontiong', 'admin0051', 124345),
(3, 'Leinn Lontiong', 'leinnlontiong', 'admin0051', 124345);

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `payment_id` int(11) NOT NULL,
  `tenant_id` int(5) NOT NULL,
  `status` text NOT NULL,
  `balance` int(10) NOT NULL,
  `due` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `payment`
--

INSERT INTO `payment` (`payment_id`, `tenant_id`, `status`, `balance`, `due`) VALUES
(1, 1, 'Paid', 0, '2023-05-21'),
(2, 2, 'Paid', 0, '2023-05-21'),
(3, 3, 'Paid', 0, '2023-05-21'),
(4, 4, 'Paid', 0, '2023-05-21'),
(5, 5, 'Paid', 0, '2023-05-21'),
(6, 6, 'Paid', 0, '2023-05-21'),
(7, 7, 'Unpaid', 30000, '2023-05-21'),
(8, 8, 'Paid', 0, '2023-05-21'),
(9, 9, 'Unpaid', 15000, '2023-05-01'),
(10, 10, 'Unpaid', 50000, '2023-05-21'),
(11, 11, 'Unpaid', 30000, '2023-05-21'),
(12, 12, 'Unpaid', 21000, '2023-05-21'),
(13, 13, 'Paid', 0, '2023-05-21'),
(14, 14, 'Unpaid', 50000, '2023-05-21');

-- --------------------------------------------------------

--
-- Table structure for table `personnel`
--

CREATE TABLE `personnel` (
  `personnel_id` int(11) NOT NULL,
  `profession` text NOT NULL,
  `name` text NOT NULL,
  `contactno` bigint(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `personnel`
--

INSERT INTO `personnel` (`personnel_id`, `profession`, `name`, `contactno`) VALUES
(1, 'Carpenter', 'Personnel 1', 9214768982),
(2, 'Plumber', 'Personnel  2', 9214768983),
(3, 'Electrician', 'Personnel 3', 9214768984),
(4, 'Carpenter', 'Personnel 4', 9234567897),
(5, 'Plumber', 'Personnel 5', 9278768986),
(6, 'Electrician', 'Personnel 6', 9214768987),
(7, 'Carpenter', 'Personnel 7', 9214768988);

-- --------------------------------------------------------

--
-- Table structure for table `tenant`
--

CREATE TABLE `tenant` (
  `tenant_id` int(11) NOT NULL,
  `name` text NOT NULL,
  `age` int(2) NOT NULL,
  `unit_id` int(5) NOT NULL,
  `gender` text NOT NULL,
  `contactno` bigint(11) NOT NULL,
  `email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tenant`
--

INSERT INTO `tenant` (`tenant_id`, `name`, `age`, `unit_id`, `gender`, `contactno`, `email`) VALUES
(1, 'Tenant 1', 19, 5, 'Male', 9123456789, 'tenant1@gmail.com'),
(2, 'Tenant 2', 25, 8, 'Female', 9123456788, 'tenant2@gmail.com'),
(3, 'Tenant 3', 26, 19, 'Female', 9876543211, 'tenant3@gmail.com'),
(4, 'Tenant 4', 30, 15, 'Male', 9876543222, 'tenant4@gmail.com'),
(5, 'Tenant 5', 35, 4, 'Male', 9876543233, 'tenant5@gmail.com'),
(6, 'Tenant 6', 40, 11, 'Female', 9876543214, 'tenant6@gmail.com'),
(7, 'Tenant 7', 20, 13, 'Female', 9876543212, 'tenant7@gmail.com'),
(8, 'Tenant 8', 50, 1, 'Male', 9876543211, 'tenant8@gmail.com'),
(9, 'Tenant 9', 45, 3, 'Male', 9876543456, 'tenant9@gmail.com'),
(10, 'Tenant 10', 38, 17, 'Male', 9876543456, 'tenant10@gmail.com'),
(11, 'Tenant 11', 43, 14, 'Male', 9876787689, 'tenant11@gmail.com'),
(12, 'Tenant 12', 35, 12, 'Male', 9536412384, 'tenant12@yahoo.com'),
(13, 'Tenant 13', 52, 6, 'Female', 9536412384, 'tenant13@yahoo.com'),
(14, 'Tenant 14', 42, 18, 'Male', 9346576526, 'tenant14@yahoo,com');

-- --------------------------------------------------------

--
-- Table structure for table `unit`
--

CREATE TABLE `unit` (
  `unit_id` int(11) NOT NULL,
  `status` text NOT NULL,
  `type` text NOT NULL,
  `unit` varchar(4) NOT NULL,
  `monthly_rent` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `unit`
--

INSERT INTO `unit` (`unit_id`, `status`, `type`, `unit`, `monthly_rent`) VALUES
(1, 'Unavailable', 'Studio', 'A101', 15000),
(2, 'Available', 'Studio', 'A102', 10000),
(3, 'Unavailable', 'Studio', 'A103', 15000),
(4, 'Unavailable', 'Studio', 'A104', 10000),
(5, 'Unavailable', 'Studio', 'A105', 15000),
(6, 'Unavailable', 'Studio', 'B101', 15000),
(7, 'Available', 'Studio', 'B102', 10000),
(8, 'Unavailable', 'Studio', 'B103', 15000),
(9, 'Available', 'Studio', 'B104', 10000),
(10, 'Available', 'Studio', 'B105', 15000),
(11, 'Unavailable', 'Bi-level', 'c101', 20000),
(12, 'Unavailable', 'Bi-level', 'c102', 21000),
(13, 'Unavailable', 'Bi-level', 'c103', 30000),
(14, 'Unavailable', 'Bi-level', 'c104', 30000),
(15, 'Unavailable', 'Bi-level', 'c105', 30000),
(16, 'Available', 'Penthouse', 'D101', 25000),
(17, 'Unavailable', 'Penthouse', 'D102', 50000),
(18, 'Unavailable', 'Penthouse', 'D103', 50000),
(19, 'Unavailable', 'Penthouse', 'D104', 60000),
(20, 'Available', 'Penthouse', 'D105', 70000),
(21, 'Available', 'Penthouse', 'D106', 80000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `landlord`
--
ALTER TABLE `landlord`
  ADD PRIMARY KEY (`landlord_id`);

--
-- Indexes for table `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`payment_id`),
  ADD KEY `payment_tenant` (`tenant_id`);

--
-- Indexes for table `personnel`
--
ALTER TABLE `personnel`
  ADD PRIMARY KEY (`personnel_id`);

--
-- Indexes for table `tenant`
--
ALTER TABLE `tenant`
  ADD PRIMARY KEY (`tenant_id`),
  ADD KEY `tenant_unit` (`unit_id`);

--
-- Indexes for table `unit`
--
ALTER TABLE `unit`
  ADD PRIMARY KEY (`unit_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `landlord`
--
ALTER TABLE `landlord`
  MODIFY `landlord_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `payment`
--
ALTER TABLE `payment`
  MODIFY `payment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `personnel`
--
ALTER TABLE `personnel`
  MODIFY `personnel_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tenant`
--
ALTER TABLE `tenant`
  MODIFY `tenant_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `unit`
--
ALTER TABLE `unit`
  MODIFY `unit_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `payment`
--
ALTER TABLE `payment`
  ADD CONSTRAINT `payment_tenant` FOREIGN KEY (`tenant_id`) REFERENCES `tenant` (`tenant_id`);

--
-- Constraints for table `tenant`
--
ALTER TABLE `tenant`
  ADD CONSTRAINT `tenant_unit` FOREIGN KEY (`unit_id`) REFERENCES `unit` (`unit_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
