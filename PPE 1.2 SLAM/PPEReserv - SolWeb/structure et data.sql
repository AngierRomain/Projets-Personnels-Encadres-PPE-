-- phpMyAdmin SQL Dump
-- version 4.0.3
-- http://www.phpmyadmin.net
--
-- Client: 127.0.0.1
-- Généré le: Lun 26 Septembre 2016 à 11:27
-- Version du serveur: 5.6.12-log
-- Version de PHP: 5.5.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données: `reserv`
--
CREATE DATABASE IF NOT EXISTS `reserv` DEFAULT CHARACTER SET latin1 COLLATE latin1_general_ci;
USE `reserv`;

-- --------------------------------------------------------

--
-- Structure de la table `empr`
--

CREATE TABLE IF NOT EXISTS `empr` (
  `eid` varchar(5) NOT NULL,
  `enom` varchar(30) NOT NULL,
  PRIMARY KEY (`eid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `empr`
--

INSERT INTO `empr` (`eid`, `enom`) VALUES
('LBB', 'Ligue de basket ball'),
('LF', 'Ligue de football'),
('LN', 'Ligue Natation'),
('LVB', 'Ligue Volley Ball');

-- --------------------------------------------------------

--
-- Structure de la table `res`
--

CREATE TABLE IF NOT EXISTS `res` (
  `rdate` date NOT NULL,
  `rdemij` char(1) NOT NULL,
  `rcomment` varchar(200) NOT NULL,
  `ridsalle` varchar(5) NOT NULL,
  `ridempr` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`rdate`,`rdemij`,`ridsalle`),
  KEY `ridsalle` (`ridsalle`),
  KEY `ridempr` (`ridempr`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `res`
--

INSERT INTO `res` (`rdate`, `rdemij`, `rcomment`, `ridsalle`, `ridempr`) VALUES
('2016-09-16', 'A', 'Réunion de conseil<br/>pour l''arbitrage', 'C', 'LF'),
('2016-09-17', 'A', 'Conseil de sécurite dans les vestiaires', 'B', 'LF'),
('2016-09-17', 'A', 'Scolaires : éveil des jeunes<br/>au basket', 'C', 'LBB'),
('2016-09-19', 'A', 'Réunion bureau LNF Nord Est', 'W', 'LF'),
('2016-09-26', 'P', 'Conf : sécurité accès', 'B', 'LN'),
('2016-09-28', 'P', 'Préparation sélections régionales', 'W', 'LVB'),
('2016-09-30', 'A', 'Jumelage avec clubs anglais', 'C', 'LF'),
('2016-09-30', 'P', 'Conférence sur le recrutement<br/>\r\net l''encadrement des jeunes professionnels', 'C', 'LF'),
('2016-10-01', 'A', 'Réunion du CE', 'B', 'LBB'),
('2016-10-01', 'P', 'Réunion BTS SIO', 'M', 'LF'),
('2016-10-02', 'P', 'Entraineurs : travailler l''adresse<br/>à 3 points', 'C', 'LBB'),
('2016-10-02', 'P', 'Recrutement de jeunes volleyeurs', 'W', 'LVB'),
('2016-10-03', 'P', 'Congrès régional :<br/>\r\néquipement électronique des sites', 'B', 'LN'),
('2016-10-05', 'A', 'Réception des dirigeants<br/>\r\nde la LNF du Japon.', 'M', 'LF'),
('2016-10-12', 'A', 'Réception pour <b>L. Manaudou</b><br/>\r\net de <b>A. Bernard</b>.', 'M', 'LN'),
('2016-10-14', 'A', 'Stage national :<br/>entrainement haut niveau', 'B', 'LN');

-- --------------------------------------------------------

--
-- Structure de la table `salle`
--

CREATE TABLE IF NOT EXISTS `salle` (
  `sid` varchar(5) NOT NULL,
  `snom` varchar(30) NOT NULL,
  `snbplaces` int(3) NOT NULL,
  `smhp` tinyint(1) NOT NULL,
  `slecteurdvd` tinyint(1) NOT NULL,
  `stele` tinyint(1) NOT NULL,
  `sinternet` tinyint(1) NOT NULL,
  `slargescreen` tinyint(1) NOT NULL,
  PRIMARY KEY (`sid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `salle`
--

INSERT INTO `salle` (`sid`, `snom`, `snbplaces`, `smhp`, `slecteurdvd`, `stele`, `sinternet`, `slargescreen`) VALUES
('B', 'Beethoven', 45, 1, 0, 0, 0, 0),
('C', 'Chopin', 172, 0, 1, 0, 0, 0),
('M', 'Mozart', 140, 1, 1, 1, 1, 1),
('W', 'Wagner', 36, 0, 0, 0, 0, 0);

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `res`
--
ALTER TABLE `res`
  ADD CONSTRAINT `res_ibfk_1` FOREIGN KEY (`ridsalle`) REFERENCES `salle` (`sid`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `res_ibfk_2` FOREIGN KEY (`ridempr`) REFERENCES `empr` (`eid`) ON DELETE SET NULL ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
