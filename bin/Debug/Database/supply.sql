-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 03, 2025 at 11:23 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `supply`
--

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `ID` int(11) NOT NULL,
  `FN` varchar(100) DEFAULT NULL,
  `MI` varchar(10) DEFAULT NULL,
  `LN` varchar(100) DEFAULT NULL,
  `usertype` varchar(50) DEFAULT NULL,
  `department` varchar(255) DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL,
  `username` varchar(100) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `clue` varchar(255) DEFAULT NULL,
  `passkey` varchar(255) DEFAULT NULL,
  `failedtries` int(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`ID`, `FN`, `MI`, `LN`, `usertype`, `department`, `status`, `username`, `password`, `clue`, `passkey`, `failedtries`) VALUES
(1, 'Lowil', 'T', 'Butic', 'UserAdmin', NULL, 'deactivated', 'useradmin', 'b3bd15ddc98e60b7cb9ab84f6306f2c964fb2d9501da6600bb7dba610f85ec46', 'yes', '7375', 0),
(75, 'Reymer', 'N', 'Dulawan', 'Admin', NULL, 'active', 'admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 'role', '', 0),
(77, 'New', 'D', 'User', 'Client', NULL, 'inactive', 'client1', '1917e33407c28366c8e3b975b17e7374589312676b90229adb4ce6e58552e223', 'clinet1', '9861', 4),
(82, 'Benjie', 'L', 'Calingayan', 'Client', NULL, 'active', 'benjie', '5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5', 'clue', '5131', 1),
(83, 'Michael', 'D', 'Pinkihan', 'UserAdmin', NULL, 'active', 'michael', '5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5', '12345', NULL, NULL),
(84, 'Kyle', 'B', 'Towanna', 'Client', NULL, 'pending', 'kyle', '5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5', 'my name', NULL, 2),
(85, 'asdsad', 'S', 'asdasd', 'Client', 'Maintenance', 'pending', 'client2', 'dd7a0efe793ff761651a97f81d0c83ad1fdcd580ca9c07af48f3eec212ad8169', '1', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `employeeid` int(11) NOT NULL,
  `employeename` varchar(255) DEFAULT NULL,
  `employeedesignation` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `equipment`
--

CREATE TABLE `equipment` (
  `propertynumber` varchar(155) NOT NULL,
  `description` text DEFAULT NULL,
  `unit` varchar(50) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL,
  `cost` decimal(12,2) DEFAULT NULL,
  `type` varchar(100) DEFAULT NULL,
  `qr` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `equipment`
--

INSERT INTO `equipment` (`propertynumber`, `description`, `unit`, `quantity`, `date`, `status`, `cost`, `type`, `qr`) VALUES
('10001', 'Pick up\r\n\r\nColor : Black\r\nPlate Number : AYG104\r\nModel : Toyota', '1', 1, '2025-12-02', 'IN', 100000.00, 'more', NULL),
('10002', 'Generator', '1', 1, '2025-12-01', 'OUT', 40000.00, 'less', NULL),
('10003', 'Dump Truck\r\n\r\nColor : Black\r\nPlate Number : AUG296\r\nModel : Toyota', '1', 1, '2025-12-03', 'OUT', 900000.00, 'more', NULL),
('prrty123456', 'Toyota Pick Up\r\n\r\nColor : Black\r\nPlate Number : ATF 1323', 'unit', 1, '2025-12-03', 'OUT', 1000000.00, 'more', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `equipment_inout`
--

CREATE TABLE `equipment_inout` (
  `equipmentinoutid` int(11) NOT NULL,
  `sliptype` varchar(100) DEFAULT NULL,
  `sliptypeid` varchar(15) DEFAULT NULL,
  `propertynumber` varchar(255) DEFAULT NULL,
  `remarks` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `equipment_inout`
--

INSERT INTO `equipment_inout` (`equipmentinoutid`, `sliptype`, `sliptypeid`, `propertynumber`, `remarks`) VALUES
(85, 'PAR', '2025-12-00001', '10001', NULL),
(86, 'PAR', '2025-12-00002', '10002', NULL),
(87, 'PAR', '2025-12-00003', '10003', NULL),
(88, 'PAR', '2025-12-00004', 'prrty123456', NULL),
(89, 'PRS', '2025-00001', '10001', '');

-- --------------------------------------------------------

--
-- Table structure for table `gas`
--

CREATE TABLE `gas` (
  `stocknumber` varchar(255) NOT NULL,
  `gasid` int(11) NOT NULL,
  `office` varchar(255) DEFAULT NULL,
  `gasdate` date DEFAULT NULL,
  `quantitytobeissued` int(11) DEFAULT NULL,
  `unit` varchar(50) DEFAULT NULL,
  `description` text DEFAULT NULL,
  `balanceafterthisuse` int(11) DEFAULT NULL,
  `purpose` text DEFAULT NULL,
  `requestedby` varchar(255) DEFAULT NULL,
  `requestedbydesignation` varchar(255) DEFAULT NULL,
  `approvalrecommendedby` varchar(255) DEFAULT NULL,
  `approvalrecommendedbydesignation` varchar(255) DEFAULT NULL,
  `approvedforissuanceby` varchar(255) DEFAULT NULL,
  `approvedforissuancebydesignation` varchar(255) DEFAULT NULL,
  `issuedby` varchar(255) DEFAULT NULL,
  `issuedbydesignation` varchar(255) DEFAULT NULL,
  `receivedby` varchar(255) DEFAULT NULL,
  `receivedbydesignation` varchar(255) DEFAULT NULL,
  `requestedbyid` varchar(255) DEFAULT NULL,
  `approvalrecommendedbyid` varchar(255) DEFAULT NULL,
  `approvedforissuancebyid` varchar(255) DEFAULT NULL,
  `issuedbyid` varchar(255) DEFAULT NULL,
  `receivedbyid` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `gas`
--

INSERT INTO `gas` (`stocknumber`, `gasid`, `office`, `gasdate`, `quantitytobeissued`, `unit`, `description`, `balanceafterthisuse`, `purpose`, `requestedby`, `requestedbydesignation`, `approvalrecommendedby`, `approvalrecommendedbydesignation`, `approvedforissuanceby`, `approvedforissuancebydesignation`, `issuedby`, `issuedbydesignation`, `receivedby`, `receivedbydesignation`, `requestedbyid`, `approvalrecommendedbyid`, `approvedforissuancebyid`, `issuedbyid`, `receivedbyid`) VALUES
('2025-00001', 13, 'Construction', '2025-12-02', 2, '1', 'Diesel', 0, 'for travel', 'Chamberlaine B. Kimmayong', 'Engineer', 'Rodrigo R. Duterte', 'Maintenance Head', 'Bongbong M. Marcos', 'Staff', 'Reymer N. Dulawan', 'Department It head', 'Chamberlaine B. Kimmayong', 'Engineer', '2025-00001', NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `ics`
--

CREATE TABLE `ics` (
  `icsno` varchar(255) NOT NULL,
  `icsdate` date NOT NULL,
  `purpose` varchar(500) DEFAULT NULL,
  `total` decimal(18,2) DEFAULT NULL,
  `receivedfrom` varchar(255) DEFAULT NULL,
  `receivedfromdesignation` varchar(255) DEFAULT NULL,
  `receivedby` varchar(255) DEFAULT NULL,
  `receivedbydesignation` varchar(255) DEFAULT NULL,
  `receivedfromsignatureid` int(11) DEFAULT NULL,
  `receivedbysignature` longblob DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `oic`
--

CREATE TABLE `oic` (
  `oicid` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `designation` varchar(255) DEFAULT NULL,
  `office` varchar(255) DEFAULT NULL,
  `oicsignature` longblob DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `oic`
--

INSERT INTO `oic` (`oicid`, `name`, `designation`, `office`, `oicsignature`) VALUES
(12, 'Reymer N. Dulawan', 'Department It head', 'None', NULL),
(13, 'Benjie L. Calingayan', 'Admin', 'None', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `oicaccount`
--

CREATE TABLE `oicaccount` (
  `oicaccountid` int(11) NOT NULL,
  `oicid` varchar(255) NOT NULL,
  `ID` varchar(255) NOT NULL,
  `defaultuser` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `oicaccount`
--

INSERT INTO `oicaccount` (`oicaccountid`, `oicid`, `ID`, `defaultuser`) VALUES
(18, '12', '75', '1'),
(19, '13', '75', '0'),
(20, '13', '82', '1');

-- --------------------------------------------------------

--
-- Table structure for table `par`
--

CREATE TABLE `par` (
  `parnumber` varchar(15) NOT NULL,
  `date` date DEFAULT NULL,
  `note` text DEFAULT NULL,
  `recommendingapproval` varchar(255) DEFAULT NULL,
  `approvedby` varchar(255) DEFAULT NULL,
  `issuedby` varchar(255) DEFAULT NULL,
  `receivedby` varchar(255) DEFAULT NULL,
  `recommendingapprovaldesignation` varchar(255) DEFAULT NULL,
  `approvedbydesignation` varchar(255) DEFAULT NULL,
  `issuedbydesignation` varchar(255) DEFAULT NULL,
  `receivedbydesignation` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `par`
--

INSERT INTO `par` (`parnumber`, `date`, `note`, `recommendingapproval`, `approvedby`, `issuedby`, `receivedby`, `recommendingapprovaldesignation`, `approvedbydesignation`, `issuedbydesignation`, `receivedbydesignation`) VALUES
('2025-12-00001', '2025-12-02', '', 'Rowill B. Butic', 'Chamberlaine B. Kimmayong', 'Reymer Dulawan', 'Reymer N. Dulawan', 'Foreman', 'Department Head', 'Engineer', 'Engineer'),
('2025-12-00002', '2025-12-02', '', 'Rowill B. Butic', 'Reyval B. Pinkihan', 'Reymer Dulawan', 'Baut B. Bautista', 'Foreman', 'Department Head', 'Department Engineer', 'Engineer'),
('2025-12-00003', '2025-12-02', '', 'Joshua B. Umiting', 'Paciel N. Kindipan', 'Reymer Dulawan', 'Rodrigo D. Duterte', 'Guard', 'Department Head', 'Chief Officer', 'Engineer'),
('2025-12-00004', '2025-12-03', '', 'Kyle B. Towanna', 'Rowill D. Butic', 'Reymer N. Dulawan', 'Jasper T. Tomas', 'YEs', 'ENG', 'Department It head', 'Foreman');

-- --------------------------------------------------------

--
-- Table structure for table `path`
--

CREATE TABLE `path` (
  `PathID` int(11) NOT NULL,
  `path` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `path`
--

INSERT INTO `path` (`PathID`, `path`) VALUES
(3, 'C:\\Users\\pktow\\Desktop');

-- --------------------------------------------------------

--
-- Table structure for table `prs`
--

CREATE TABLE `prs` (
  `prsnumber` varchar(15) NOT NULL,
  `date` date DEFAULT NULL,
  `office` varchar(255) DEFAULT NULL,
  `purpose` text DEFAULT NULL,
  `note` text DEFAULT NULL,
  `returnedby` varchar(255) DEFAULT NULL,
  `returnedbydesignation` varchar(255) DEFAULT NULL,
  `receivedby` varchar(255) DEFAULT NULL,
  `receivedbydesignation` varchar(255) DEFAULT NULL,
  `approvedby` varchar(255) DEFAULT NULL,
  `approvedbydesignation` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `prs`
--

INSERT INTO `prs` (`prsnumber`, `date`, `office`, `purpose`, `note`, `returnedby`, `returnedbydesignation`, `receivedby`, `receivedbydesignation`, `approvedby`, `approvedbydesignation`) VALUES
('2025-00001', '2025-12-03', 'Construction', 'Return to Stock', '', 'Reymer N. Dulawan', 'Engineer', '', '', 'Rowill D. Butic', 'Yes');

-- --------------------------------------------------------

--
-- Table structure for table `ris`
--

CREATE TABLE `ris` (
  `risnumber` varchar(18) NOT NULL,
  `userid` varchar(255) DEFAULT NULL,
  `office` varchar(255) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL,
  `emailadd` varchar(255) DEFAULT NULL,
  `phonenumber` varchar(50) DEFAULT NULL,
  `requestedby` varchar(255) DEFAULT NULL,
  `approvedby` varchar(255) DEFAULT NULL,
  `issuedby` varchar(255) DEFAULT NULL,
  `recievedby` varchar(255) DEFAULT NULL,
  `requestedbydesignation` varchar(255) DEFAULT NULL,
  `approvedbydesignation` varchar(255) DEFAULT NULL,
  `issuedbydesignation` varchar(255) DEFAULT NULL,
  `receivedbydesignation` varchar(255) DEFAULT NULL,
  `purpose` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ris`
--

INSERT INTO `ris` (`risnumber`, `userid`, `office`, `date`, `status`, `emailadd`, `phonenumber`, `requestedby`, `approvedby`, `issuedby`, `recievedby`, `requestedbydesignation`, `approvedbydesignation`, `issuedbydesignation`, `receivedbydesignation`, `purpose`) VALUES
('2025-12-00001', NULL, 'Construction', '2025-12-02', 'approved', 'rey@gmail.com', '09216629438', 'Reymer B Dulawan', 'Rowill B Butic', 'Reymer N. Dulawan', 'Chamby B Kimmayong', 'Finance Office', 'Maintenance Office', 'Department It head', 'Finance', ''),
('2025-12-00002', NULL, 'Maintenance', '2025-12-02', 'approved', 'joy@gmail.com', '09215278356', 'rey B mer', 'Bongbong M Marcos', 'Reymer N. Dulawan', 'Rodrigo N Duterte', 'Finance', 'Maintenance', 'Department It head', 'Fiannce', ''),
('2025-12-00003', NULL, 'Finance', '2025-12-03', 'approved', 'client@gmail.com', '09444444444', 'Rowill D Butic', 'Reymer B Toan', 'Reymer N. Dulawan', 'Kyle B Towanna', 'Kaminero', 'Head', 'Department It head', 'Bo oy', 'purpose'),
('2025-12-00004', NULL, 'Construction', '2025-12-03', 'approved', 'asdsa@asd.com', '09111111111', 'asd D asdas', 'sdsa S sadas', 'Reymer N. Dulawan', 'sdsad S sdsada', 'sdasd', 'sdsad', 'Department It head', 'sdsad', ''),
('2025-12-00005', NULL, 'Finance', '2025-12-03', 'approved', 'ads@asd.co', '09111111111', 'sdsa S sadasd', 'sdsa S asdasd', 'Reymer N. Dulawan', 'adasd S asdsad', 'sdsad', 'asdsad', 'Department It head', 'sdsad', '');

-- --------------------------------------------------------

--
-- Table structure for table `ris_supply`
--

CREATE TABLE `ris_supply` (
  `rissupplyid` int(11) NOT NULL,
  `risnumber` varchar(15) DEFAULT NULL,
  `stockno` varchar(15) DEFAULT NULL,
  `remarks` text DEFAULT NULL,
  `requested_qty` int(11) NOT NULL,
  `approval` int(1) NOT NULL,
  `approved_qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ris_supply`
--

INSERT INTO `ris_supply` (`rissupplyid`, `risnumber`, `stockno`, `remarks`, `requested_qty`, `approval`, `approved_qty`) VALUES
(66, '2025-12-00001', '2025-00002', 'good', 2, 1, 2),
(67, '2025-12-00002', '2025-00002', '', 9, 1, 0),
(68, '2025-12-00003', '2025-00002', '', 5, 1, 5),
(71, '2025-12-00004', '2025-00002', '', 4, 1, 4),
(72, '2025-12-00005', '2025-00003', '', 17, 1, 17);

-- --------------------------------------------------------

--
-- Table structure for table `rrsp`
--

CREATE TABLE `rrsp` (
  `rrspnumber` varchar(15) NOT NULL,
  `date` date DEFAULT NULL,
  `returnedby` varchar(255) DEFAULT NULL,
  `returnedbydesignation` varchar(255) DEFAULT NULL,
  `receivedby` varchar(255) DEFAULT NULL,
  `receivedbydesignation` varchar(255) DEFAULT NULL,
  `returnedbyid` int(11) DEFAULT NULL,
  `receivedbyid` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `supply`
--

CREATE TABLE `supply` (
  `stockno` varchar(18) NOT NULL,
  `item` varchar(255) DEFAULT NULL,
  `description` text DEFAULT NULL,
  `unit` varchar(50) DEFAULT NULL,
  `supplybalance` int(11) DEFAULT 0,
  `qr` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `supply`
--

INSERT INTO `supply` (`stockno`, `item`, `description`, `unit`, `supplybalance`, `qr`) VALUES
('2025-00001', 'paperclip', 'paperclip', '1 box', 10, '2025-00001'),
('2025-00002', 'paper', 'paper', '5 rim', 98, '2025-00002'),
('2025-00003', 'ballpen', 'ballpen', '3 boxes', 8, '2025-00003'),
('2025-00004', 'Ink', 'Ink', 'Pieace', 100, '2025-00004');

-- --------------------------------------------------------

--
-- Table structure for table `supplystock`
--

CREATE TABLE `supplystock` (
  `supplystockid` int(11) NOT NULL,
  `stockid` int(11) DEFAULT NULL,
  `stockno` varchar(15) DEFAULT NULL,
  `risnumber` varchar(15) DEFAULT NULL,
  `supplystockdate` date DEFAULT NULL,
  `reference` varchar(255) DEFAULT NULL,
  `receiptqty` int(11) DEFAULT NULL,
  `qtyrequest` int(11) DEFAULT NULL,
  `qtybalance` int(11) DEFAULT NULL,
  `office` varchar(255) DEFAULT NULL,
  `noofdaystoconsume` varchar(255) DEFAULT NULL,
  `reorderpoint` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `supplystock`
--

INSERT INTO `supplystock` (`supplystockid`, `stockid`, `stockno`, `risnumber`, `supplystockdate`, `reference`, `receiptqty`, `qtyrequest`, `qtybalance`, `office`, `noofdaystoconsume`, `reorderpoint`) VALUES
(149, 1, '2025-00001', NULL, '2025-12-02', NULL, 10, NULL, 10, 'Supply Unit', NULL, '0'),
(150, 1, '2025-00002', NULL, '2025-12-02', NULL, 3, NULL, 3, 'Supply Unit', NULL, '0'),
(151, 1, '2025-00003', NULL, '2025-12-02', NULL, 5, NULL, 5, 'Supply Unit', NULL, '0'),
(152, 2, '2025-00002', NULL, '2025-12-02', NULL, 5, NULL, 5, 'Supply Unit', NULL, 'Lagawe Trading'),
(153, 2, '2025-00003', NULL, '2025-12-02', NULL, 10, NULL, 10, 'Supply Unit', NULL, '09216376328'),
(154, 3, '2025-00002', NULL, '2025-12-02', NULL, 1, NULL, 1, 'Supply Unit', NULL, 'trading'),
(155, 1, '2025-00002', '2025-12-00001', '2025-12-02', NULL, 3, 2, 1, 'Supply Unit', 'Chamby B Kimmayong', '0'),
(156, 1, '2025-00002', '2025-12-00003', '2025-12-02', NULL, 3, 1, 0, 'Supply Unit', 'Kyle B Towanna', '0'),
(157, 2, '2025-00002', '2025-12-00003', '2025-12-02', NULL, 5, 4, 1, 'Supply Unit', 'Kyle B Towanna', 'Lagawe Trading'),
(158, 1, '2025-00004', NULL, '2025-12-03', NULL, 100, NULL, 100, 'Supply Unit', NULL, 'Lagawe Trading'),
(159, 4, '2025-00002', NULL, '2025-12-03', NULL, 100, NULL, 100, 'Supply Unit', NULL, 'Mansingh'),
(160, 2, '2025-00002', '2025-12-00004', '2025-12-02', NULL, 5, 1, 0, 'Supply Unit', 'sdsad S sdsada', 'Lagawe Trading'),
(161, 3, '2025-00002', '2025-12-00004', '2025-12-02', NULL, 1, 1, 0, 'Supply Unit', 'sdsad S sdsada', 'trading'),
(162, 4, '2025-00002', '2025-12-00004', '2025-12-03', NULL, 100, 2, 98, 'Supply Unit', 'sdsad S sdsada', 'Mansingh'),
(163, 3, '2025-00003', NULL, '2025-12-03', NULL, 10, NULL, 10, 'Supply Unit', NULL, ''),
(164, 1, '2025-00003', '2025-12-00005', '2025-12-02', NULL, 5, 5, 0, 'Supply Unit', 'adasd S asdsad', '0'),
(165, 2, '2025-00003', '2025-12-00005', '2025-12-02', NULL, 10, 10, 0, 'Supply Unit', 'adasd S asdsad', '09216376328'),
(166, 3, '2025-00003', '2025-12-00005', '2025-12-03', NULL, 10, 2, 8, 'Supply Unit', 'adasd S asdsad', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`employeeid`);

--
-- Indexes for table `equipment`
--
ALTER TABLE `equipment`
  ADD PRIMARY KEY (`propertynumber`);

--
-- Indexes for table `equipment_inout`
--
ALTER TABLE `equipment_inout`
  ADD PRIMARY KEY (`equipmentinoutid`);

--
-- Indexes for table `gas`
--
ALTER TABLE `gas`
  ADD PRIMARY KEY (`gasid`);

--
-- Indexes for table `ics`
--
ALTER TABLE `ics`
  ADD PRIMARY KEY (`icsno`);

--
-- Indexes for table `oic`
--
ALTER TABLE `oic`
  ADD PRIMARY KEY (`oicid`);

--
-- Indexes for table `oicaccount`
--
ALTER TABLE `oicaccount`
  ADD PRIMARY KEY (`oicaccountid`);

--
-- Indexes for table `par`
--
ALTER TABLE `par`
  ADD PRIMARY KEY (`parnumber`);

--
-- Indexes for table `path`
--
ALTER TABLE `path`
  ADD PRIMARY KEY (`PathID`);

--
-- Indexes for table `prs`
--
ALTER TABLE `prs`
  ADD PRIMARY KEY (`prsnumber`);

--
-- Indexes for table `ris`
--
ALTER TABLE `ris`
  ADD PRIMARY KEY (`risnumber`);

--
-- Indexes for table `ris_supply`
--
ALTER TABLE `ris_supply`
  ADD PRIMARY KEY (`rissupplyid`);

--
-- Indexes for table `rrsp`
--
ALTER TABLE `rrsp`
  ADD PRIMARY KEY (`rrspnumber`);

--
-- Indexes for table `supply`
--
ALTER TABLE `supply`
  ADD PRIMARY KEY (`stockno`);

--
-- Indexes for table `supplystock`
--
ALTER TABLE `supplystock`
  ADD PRIMARY KEY (`supplystockid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `account`
--
ALTER TABLE `account`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=86;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `employeeid` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `equipment_inout`
--
ALTER TABLE `equipment_inout`
  MODIFY `equipmentinoutid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=90;

--
-- AUTO_INCREMENT for table `gas`
--
ALTER TABLE `gas`
  MODIFY `gasid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `oic`
--
ALTER TABLE `oic`
  MODIFY `oicid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `oicaccount`
--
ALTER TABLE `oicaccount`
  MODIFY `oicaccountid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `path`
--
ALTER TABLE `path`
  MODIFY `PathID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `ris_supply`
--
ALTER TABLE `ris_supply`
  MODIFY `rissupplyid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=73;

--
-- AUTO_INCREMENT for table `supplystock`
--
ALTER TABLE `supplystock`
  MODIFY `supplystockid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=167;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
