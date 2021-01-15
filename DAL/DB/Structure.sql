-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 15, 2021 at 06:21 PM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: bdtheque
--

-- --------------------------------------------------------

--
-- Table structure for table album
--

CREATE TABLE album (
  album_id int(11) NOT NULL,
  album_img varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  album_titre varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  album_categorie int(11) DEFAULT NULL,
  album_serie int(11) DEFAULT NULL,
  album_editeur int(11) DEFAULT NULL );

-- --------------------------------------------------------

--
-- Table structure for table album_auteurs
--

CREATE TABLE album_auteurs(
  album_id int(11) NOT NULL,
  auteur_id int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table album_genres
--

CREATE TABLE album_genres (
  album_id int(11) NOT NULL,
  genre_id int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table auteur
--

CREATE TABLE auteur (
  auteur_id int(11) NOT NULL,
  auteur_prenom varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  auteur_nom varchar(255) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table categorie
--

CREATE TABLE categorie (
  categorie_id int(11) NOT NULL,
  categorie_nom varchar(255) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table editeur
--

CREATE TABLE editeur (
  editeur_id int(11) NOT NULL,
  editeur_nom varchar(255) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table genre
--

CREATE TABLE genre (
  genre_id int(11) NOT NULL,
  genre_nom varchar(255) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table serie
--

CREATE TABLE serie (
  serie_id int(11) NOT NULL,
  serie_nom varchar(255) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table user_bibliotheque
--

CREATE TABLE user_bibliotheque (
  user_id int(11) NOT NULL,
  album_id int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table user_wishlist
--

CREATE TABLE user_wishlist (
  user_id int(11) NOT NULL,
  album_id int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table utilisateur
--

CREATE TABLE utilisateur (
  user_id int(11) NOT NULL,
  user_login varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  user_mdp varchar(255) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table album
--
ALTER TABLE album
  ADD PRIMARY KEY (album_id),
  ADD KEY album_categorie (album_categorie),
  ADD KEY album_serie (album_serie),
  ADD KEY album_editeur (album_editeur);

--
-- Indexes for table album_auteurs
--
ALTER TABLE album_auteurs
  ADD KEY auteur_id (auteur_id),
  ADD KEY album_id (album_id);

--
-- Indexes for table album_genres
--
ALTER TABLE album_genres
  ADD KEY genre_id (genre_id),
  ADD KEY album_id (album_id);

--
-- Indexes for table auteur
--
ALTER TABLE auteur
  ADD PRIMARY KEY (auteur_id);

--
-- Indexes for table categorie
--
ALTER TABLE categorie
  ADD PRIMARY KEY (categorie_id);

--
-- Indexes for table editeur
--
ALTER TABLE editeur
  ADD PRIMARY KEY (editeur_id);

--
-- Indexes for table genre
--
ALTER TABLE genre
  ADD PRIMARY KEY (genre_id);

--
-- Indexes for table serie
--
ALTER TABLE serie
  ADD PRIMARY KEY (serie_id);

--
-- Indexes for table user_bibliotheque
--
ALTER TABLE user_bibliotheque
  ADD KEY album_id (album_id),
  ADD KEY user_id (user_id);

--
-- Indexes for table user_wishlist
--
ALTER TABLE user_wishlist
  ADD KEY album_id (album_id),
  ADD KEY user_id (user_id);

--
-- Indexes for table utilisateur
--
ALTER TABLE utilisateur
  ADD PRIMARY KEY (user_id);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table album
--
ALTER TABLE album
  MODIFY album_id int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table auteur
--
ALTER TABLE auteur
  MODIFY auteur_id int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table categorie
--
ALTER TABLE categorie
  MODIFY categorie_id int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table editeur
--
ALTER TABLE editeur
  MODIFY editeur_id int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table genre
--
ALTER TABLE genre
  MODIFY genre_id int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table serie
--
ALTER TABLE serie
  MODIFY serie_id int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table utilisateur
--
ALTER TABLE utilisateur
  MODIFY user_id int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table album
--
ALTER TABLE album
  ADD CONSTRAINT FK_626C7D19 FOREIGN KEY (album_categorie) REFERENCES categorie (categorie_id),
  ADD CONSTRAINT FK_A04FBBCA FOREIGN KEY (album_editeur) REFERENCES editeur (editeur_id),
  ADD CONSTRAINT FK_FC022276 FOREIGN KEY (album_serie) REFERENCES serie (serie_id);

--
-- Constraints for table album_auteurs
--
ALTER TABLE album_auteurs
  ADD CONSTRAINT FK_17F9210E FOREIGN KEY (album_id) REFERENCES album (album_id),
  ADD CONSTRAINT FK_B76B6EF5 FOREIGN KEY (auteur_id) REFERENCES auteur (auteur_id);

--
-- Constraints for table album_genres
--
ALTER TABLE album_genres
  ADD CONSTRAINT FK_302F1FA FOREIGN KEY (genre_id) REFERENCES genre (genre_id),
  ADD CONSTRAINT FK_D55B450F FOREIGN KEY (album_id) REFERENCES album (album_id);

--
-- Constraints for table user_bibliotheque
--
ALTER TABLE user_bibliotheque
  ADD CONSTRAINT FK_59FE47A5 FOREIGN KEY (user_id) REFERENCES utilisateur (user_id),
  ADD CONSTRAINT FK_9BE833CB FOREIGN KEY (album_id) REFERENCES album (album_id);

--
-- Constraints for table user_wishlist
--
ALTER TABLE user_wishlist
  ADD CONSTRAINT FK_19388BAE FOREIGN KEY (user_id) REFERENCES utilisateur (user_id),
  ADD CONSTRAINT FK_FD64E53C FOREIGN KEY (album_id) REFERENCES album (album_id);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
