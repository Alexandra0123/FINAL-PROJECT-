-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 08, 2023 at 07:33 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `loginportal`
--

-- --------------------------------------------------------

--
-- Table structure for table `schedule1`
--

CREATE TABLE `schedule1` (
  `courseid` int(11) NOT NULL,
  `username` varchar(150) NOT NULL,
  `subjectName` varchar(150) NOT NULL,
  `instructor` varchar(150) NOT NULL,
  `room` varchar(150) NOT NULL,
  `time_` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tasks`
--

CREATE TABLE `tasks` (
  `id` int(11) NOT NULL,
  `username` varchar(255) DEFAULT NULL,
  `name` varchar(255) DEFAULT NULL,
  `subject` varchar(255) DEFAULT NULL,
  `deadline` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tasks`
--

INSERT INTO `tasks` (`id`, `username`, `name`, `subject`, `deadline`) VALUES
(11, 'ss', 'Activity 4', 'OOP', '2023-11-17'),
(57, 'alex', 'System', 'Advanced Computer Programming', '2023-12-06'),
(58, 'alex', 'Critic Paper', 'ASEAN Literature', '2023-12-04'),
(59, 'alex', 'Activity by Group', 'ASEAN Literature', '2023-12-04'),
(60, 'alex', 'Connecting DBMS ', 'Database Management System', '2023-12-10'),
(61, 'alex', 'Video', 'Database Management System', '2023-12-06'),
(62, 'alex', 'Final Project', 'Object Oriented Programming', '2023-12-10'),
(63, 'alex', 'Documentation', 'Object Oriented Programming', '2023-12-10'),
(64, 'alex', 'Laboratory Activity', 'Physics', '2023-12-01'),
(65, 'alex', 'Packet Tracer', 'Computer Networking', '2023-12-02'),
(66, 'alex', 'Final Exam', 'Discrete Math', '2023-12-03'),
(67, 'mark', 'task', 'sub', '2023-12-01');

-- --------------------------------------------------------

--
-- Table structure for table `user_information`
--

CREATE TABLE `user_information` (
  `USER_ID` int(5) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `first_Name` varchar(100) NOT NULL,
  `last_Name` varchar(100) NOT NULL,
  `Address` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user_information`
--

INSERT INTO `user_information` (`USER_ID`, `username`, `password`, `first_Name`, `last_Name`, `Address`) VALUES
(1, 'Mark', 'Bunyi', 'Mark Erolle', 'Bunyi', 'Lipa City, Batangas'),
(2, 'Peter', 'Abirdbirdbird', 'Peter', 'Grifin', 'Quahog, Rhode Island'),
(3, 'Jose', 'Rizal', 'Jose Protacio', 'Rizal', 'Laguna, Philippines'),
(4, 'Juan', 'Tamad', 'Juan Antonio', 'Pilosopo', 'Marikina, Philippines'),
(11, 'alex', 'anonuevo', 'alexandra', 'anonuevo', 'ibaan');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `schedule1`
--
ALTER TABLE `schedule1`
  ADD PRIMARY KEY (`courseid`);

--
-- Indexes for table `tasks`
--
ALTER TABLE `tasks`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user_information`
--
ALTER TABLE `user_information`
  ADD PRIMARY KEY (`USER_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `schedule1`
--
ALTER TABLE `schedule1`
  MODIFY `courseid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tasks`
--
ALTER TABLE `tasks`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=68;

--
-- AUTO_INCREMENT for table `user_information`
--
ALTER TABLE `user_information`
  MODIFY `USER_ID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
