-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : dim. 01 déc. 2024 à 15:34
-- Version du serveur : 8.0.31
-- Version de PHP : 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `pokemon_tcg`
--

-- --------------------------------------------------------

--
-- Structure de la table `boosters`
--

DROP TABLE IF EXISTS `boosters`;
CREATE TABLE IF NOT EXISTS `boosters` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `description` text,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `boosters`
--

INSERT INTO `boosters` (`id`, `name`, `description`) VALUES
(1, 'Booster Feu', 'Un booster contenant des cartes de type Feu.'),
(2, 'Booster Eau', 'Un booster contenant des cartes de type Eau.'),
(3, 'Booster Électrik', 'Un booster contenant des cartes de type Électrik.');

-- --------------------------------------------------------

--
-- Structure de la table `booster_cards`
--

DROP TABLE IF EXISTS `booster_cards`;
CREATE TABLE IF NOT EXISTS `booster_cards` (
  `booster_id` int NOT NULL,
  `card_id` int NOT NULL,
  PRIMARY KEY (`booster_id`,`card_id`),
  KEY `card_id` (`card_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `booster_cards`
--

INSERT INTO `booster_cards` (`booster_id`, `card_id`) VALUES
(1, 1),
(1, 2),
(1, 3),
(1, 4),
(1, 5),
(1, 6),
(1, 7),
(1, 8),
(1, 9),
(1, 10),
(1, 11),
(1, 12),
(1, 13),
(1, 14),
(1, 15),
(1, 16),
(1, 17),
(1, 18),
(1, 19),
(1, 20),
(1, 21),
(1, 22),
(1, 23),
(1, 24),
(1, 25),
(1, 26),
(1, 27),
(1, 28),
(1, 29),
(1, 30),
(1, 31),
(1, 32),
(1, 33),
(1, 34),
(2, 35),
(2, 36),
(2, 37),
(2, 38),
(2, 39),
(2, 40),
(2, 41),
(2, 42),
(2, 43),
(2, 44),
(2, 45),
(2, 46),
(2, 47),
(2, 48),
(2, 49),
(2, 50),
(2, 51),
(2, 52),
(2, 53),
(2, 54),
(2, 55),
(2, 56),
(2, 57),
(2, 58),
(2, 59),
(2, 60),
(2, 61),
(2, 62),
(2, 63),
(2, 64),
(2, 65),
(2, 66),
(2, 67),
(2, 68),
(3, 69),
(3, 70),
(3, 71),
(3, 72),
(3, 73),
(3, 74),
(3, 75),
(3, 76),
(3, 77),
(3, 78),
(3, 79),
(3, 80),
(3, 81),
(3, 82),
(3, 83),
(3, 84),
(3, 85),
(3, 86),
(3, 87),
(3, 88),
(3, 89),
(3, 90),
(3, 91),
(3, 92),
(3, 93),
(3, 94),
(3, 95),
(3, 96),
(3, 97),
(3, 98),
(3, 99),
(3, 100),
(3, 101),
(3, 102);

-- --------------------------------------------------------

--
-- Structure de la table `collection`
--

DROP TABLE IF EXISTS `collection`;
CREATE TABLE IF NOT EXISTS `collection` (
  `IdCollection` int NOT NULL AUTO_INCREMENT,
  `IdCarte` int DEFAULT NULL,
  `Quantité` int DEFAULT NULL,
  PRIMARY KEY (`IdCollection`),
  KEY `IdCarte` (`IdCarte`)
) ENGINE=MyISAM AUTO_INCREMENT=77 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `pokemon_cards`
--

DROP TABLE IF EXISTS `pokemon_cards`;
CREATE TABLE IF NOT EXISTS `pokemon_cards` (
  `id` int NOT NULL,
  `name` varchar(255) NOT NULL,
  `type` varchar(50) DEFAULT NULL,
  `image_url` text,
  `drop_rate` float DEFAULT NULL,
  `rarete` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `pokemon_cards`
--

INSERT INTO `pokemon_cards` (`id`, `name`, `type`, `image_url`, `drop_rate`, `rarete`) VALUES
(1, 'Alakazam', 'Psy', 'Images/Pokemon-cards/Alakazam.png', 14.8681, 'Ultra Rare'),
(2, 'Tortank', 'Eau', 'Images/Pokemon-cards/Blastoise.png', 9.33209, 'Ultra Rare'),
(3, 'Leveinard', 'Normal', 'Images/Pokemon-cards/Chansey.png', 18.48, 'Rare'),
(4, 'Dracaufeu', 'Feu', 'Images/Pokemon-cards/Charizard.png', 27.5218, 'Ultra Rare'),
(5, 'Mélofée', 'Normal', 'Images/Pokemon-cards/Clefairy.png', 25.3704, 'Rare'),
(6, 'Léviator', 'Eau', 'Images/Pokemon-cards/Gyarados.png', 11.2301, 'Ultra Rare'),
(7, 'Tygnon', 'Combat', 'Images/Pokemon-cards/Hitmonchan.png', 25.6608, 'Rare'),
(8, 'Mackogneur', 'Combat', 'Images/Pokemon-cards/Machamp.png', 17.028, 'Rare'),
(9, 'Magnéton', 'Électrik', 'Images/Pokemon-cards/Magneton.png', 21.384, 'Rare'),
(10, 'Mewtwo', 'Psy', 'Images/Pokemon-cards/Mewtwo.png', 13.2864, 'Ultra Rare'),
(11, 'Nidoking', 'Plante', 'Images/Pokemon-cards/Nidoking.png', 16.9488, 'Rare'),
(12, 'Feunard', 'Feu', 'Images/Pokemon-cards/Ninetales.png', 22.8888, 'Rare'),
(13, 'Tartard', 'Eau', 'Images/Pokemon-cards/Poliwrath.png', 23.9976, 'Rare'),
(14, 'Raichu', 'Électrik', 'Images/Pokemon-cards/Raichu.png', 24.948, 'Rare'),
(15, 'Florizarre', 'Plante', 'Images/Pokemon-cards/Venusaur.png', 31.476, 'Ultra Rare'),
(16, 'Électhor', 'Électrik', 'Images/Pokemon-cards/Zapdos.png', 15.0262, 'Ultra Rare'),
(17, 'Dardargnan', 'Plante', 'Images/Pokemon-cards/Beedrill.png', 19.9056, 'Rare'),
(18, 'Draco', 'Normal', 'Images/Pokemon-cards/Dragonair.png', 21.7008, 'Rare'),
(19, 'Triopikeur', 'Combat', 'Images/Pokemon-cards/Dugtrio.png', 25.53, 'Commune'),
(20, 'Élektek', 'Électrik', 'Images/Pokemon-cards/Electabuzz.png', 23.65, 'Commune'),
(21, 'Électrode', 'Électrik', 'Images/Pokemon-cards/Electrode.png', 23.4432, 'Rare'),
(22, 'Roucoups', 'Normal', 'Images/Pokemon-cards/Pidgeotto.png', 17.25, 'Commune'),
(23, 'Arcanin', 'Feu', 'Images/Pokemon-cards/Arcanine.png', 21.34, 'Commune'),
(24, 'Reptincel', 'Feu', 'Images/Pokemon-cards/Charmeleon.png', 24.93, 'Commune'),
(25, 'Lamantine', 'Eau', 'Images/Pokemon-cards/Dewgong.png', 15.65, 'Commune'),
(26, 'Minidraco', 'Normal', 'Images/Pokemon-cards/Dratini.png', 18.47, 'Commune'),
(27, 'Canarticho', 'Normal', 'Images/Pokemon-cards/Farfetchd.png', 15.38, 'Commune'),
(28, 'Caninos', 'Feu', 'Images/Pokemon-cards/Growlithe.png', 21.5, 'Commune'),
(29, 'Spectrum', 'Psy', 'Images/Pokemon-cards/Haunter.png', 14.388, 'Rare'),
(30, 'Herbizarre', 'Plante', 'Images/Pokemon-cards/Ivysaur.png', 17.32, 'Commune'),
(31, 'Lippoutou', 'Psy', 'Images/Pokemon-cards/Jynx.png', 22.48, 'Commune'),
(32, 'Kadabra', 'Psy', 'Images/Pokemon-cards/Kadabra.png', 15.48, 'Commune'),
(33, 'Coconfort', 'Plante', 'Images/Pokemon-cards/Kakuna.png', 24.94, 'Commune'),
(34, 'Machopeur', 'Combat', 'Images/Pokemon-cards/Machoke.png', 18.25, 'Commune'),
(35, 'Magicarpe', 'Eau', 'Images/Pokemon-cards/Magikarp.png', 16.45, 'Commune'),
(36, 'Magmar', 'Feu', 'Images/Pokemon-cards/Magmar.png', 27.49, 'Commune'),
(37, 'Nidorino', 'Plante', 'Images/Pokemon-cards/Nidorino.png', 28.11, 'Commune'),
(38, 'Têtarte', 'Eau', 'Images/Pokemon-cards/Poliwhirl.png', 28.06, 'Commune'),
(39, 'Porygon', 'Normal', 'Images/Pokemon-cards/Porygon.png', 22.8888, 'Rare'),
(40, 'Rattatac', 'Normal', 'Images/Pokemon-cards/Raticate.png', 15.81, 'Commune'),
(41, 'Otaria', 'Eau', 'Images/Pokemon-cards/Seel.png', 16.03, 'Commune'),
(42, 'Carabaffe', 'Eau', 'Images/Pokemon-cards/Wartortle.png', 17.71, 'Commune'),
(43, 'Abra', 'Psy', 'Images/Pokemon-cards/Abra.png', 25.49, 'Commune'),
(44, 'Bulbizarre', 'Plante', 'Images/Pokemon-cards/Bulbasaur.png', 29.32, 'Commune'),
(45, 'Chenipan', 'Plante', 'Images/Pokemon-cards/Caterpie.png', 25.12, 'Commune'),
(46, 'Salamèche', 'Feu', 'Images/Pokemon-cards/Charmander.png', 22.66, 'Commune'),
(47, 'Taupiqueur', 'Combat', 'Images/Pokemon-cards/Diglett.png', 22.94, 'Commune'),
(48, 'Doduo', 'Normal', 'Images/Pokemon-cards/Doduo.png', 16.7, 'Commune'),
(49, 'Soporifik', 'Psy', 'Images/Pokemon-cards/Drowzee.png', 29.68, 'Commune'),
(50, 'Fantominus', 'Psy', 'Images/Pokemon-cards/Gastly.png', 23.32, 'Commune'),
(51, 'Smogo', 'Plante', 'Images/Pokemon-cards/Koffing.png', 27.57, 'Commune'),
(52, 'Machoc', 'Combat', 'Images/Pokemon-cards/Machop.png', 22.86, 'Commune'),
(53, 'Magnéti', 'Électrik', 'Images/Pokemon-cards/Magnemite.png', 16.62, 'Commune'),
(54, 'Chrysacier', 'Plante', 'Images/Pokemon-cards/Metapod.png', 29.49, 'Commune'),
(55, 'Nidoran ♂', 'Plante', 'Images/Pokemon-cards/NidoranM.png', 22.62, 'Commune'),
(56, 'Onix', 'Combat', 'Images/Pokemon-cards/Onix.png', 24.6, 'Commune'),
(57, 'Roucool', 'Normal', 'Images/Pokemon-cards/Pidgey.png', 25.14, 'Commune'),
(58, 'Pikachu', 'Électrik', 'Images/Pokemon-cards/Pikachu.png', 19.2984, 'Rare'),
(59, 'Ptitard', 'Eau', 'Images/Pokemon-cards/Poliwag.png', 19.17, 'Commune'),
(60, 'Ponyta', 'Feu', 'Images/Pokemon-cards/Ponyta.png', 15.07, 'Commune'),
(61, 'Rattata', 'Normal', 'Images/Pokemon-cards/Rattata.png', 17.87, 'Commune'),
(62, 'Sabelette', 'Combat', 'Images/Pokemon-cards/Sandshrew.png', 29.12, 'Commune'),
(63, 'Carapuce', 'Eau', 'Images/Pokemon-cards/Squirtle.png', 16.99, 'Commune'),
(64, 'Staross', 'Eau', 'Images/Pokemon-cards/Starmie.png', 24.288, 'Rare'),
(65, 'Stari', 'Eau', 'Images/Pokemon-cards/Staryu.png', 27.03, 'Commune'),
(66, 'Saquedeneu', 'Plante', 'Images/Pokemon-cards/Tangela.png', 22.33, 'Commune'),
(67, 'Voltorbe', 'Électrik', 'Images/Pokemon-cards/Voltorb.png', 15.58, 'Commune'),
(68, 'Goupix', 'Feu', 'Images/Pokemon-cards/Vulpix.png', 25.91, 'Commune'),
(69, 'Aspicot', 'Plante', 'Images/Pokemon-cards/Weedle.png', 22.81, 'Commune'),
(70, 'Poupée Mélofée', 'Dresseur', 'Images/Pokemon-cards/Clefairy-Doll.png', 18.744, 'Rare'),
(71, 'Ordinateur', 'Dresseur', 'Images/Pokemon-cards/Computer-Search.png', 20.3016, 'Rare'),
(72, 'Spray Anti-évolution', 'Dresseur', 'Images/Pokemon-cards/Devolution-Spray.png', 18.9024, 'Rare'),
(73, 'Imposteur Chen', 'Dresseur', 'Images/Pokemon-cards/Imposter-Professor-Oak.png', 20.7204, 'Ultra Rare'),
(74, 'Cherche Objet', 'Dresseur', 'Images/Pokemon-cards/Item-Finder.png', 18.744, 'Rare'),
(75, 'Fillette', 'Dresseur', 'Images/Pokemon-cards/Lass.png', 19.3776, 'Rare'),
(76, 'Eleveur Pokémon', 'Dresseur', 'Images/Pokemon-cards/Pokemon-Breeder.png', 14.3088, 'Rare'),
(77, 'Échangeur Pokémon', 'Dresseur', 'Images/Pokemon-cards/Pokemon-Trader.png', 13.4376, 'Rare'),
(78, 'Super Retrait d\'Énergie', 'Dresseur', 'Images/Pokemon-cards/Super-Energy-Removal.png', 24.2352, 'Rare'),
(79, 'Ramassage', 'Dresseur', 'Images/Pokemon-cards/Scoop-Up.png', 16.93, 'Commune'),
(80, 'Défenseur', 'Dresseur', 'Images/Pokemon-cards/Defender.png', 16.99, 'Commune'),
(81, 'Récupérateur d\'Énergie', 'Dresseur', 'Images/Pokemon-cards/Energy-Retrieval.png', 19.16, 'Commune'),
(82, 'Total Soin', 'Dresseur', 'Images/Pokemon-cards/Full-Heal.png', 29.86, 'Commune'),
(83, 'Maintenance', 'Dresseur', 'Images/Pokemon-cards/Maintenance.png', 16.78, 'Commune'),
(84, 'Plus de Puissance', 'Dresseur', 'Images/Pokemon-cards/PlusPower.png', 24.35, 'Commune'),
(85, 'Centre Pokémon', 'Dresseur', 'Images/Pokemon-cards/Pokemon-Center.png', 26.41, 'Commune'),
(86, 'Flûte Pokémon', 'Dresseur', 'Images/Pokemon-cards/Pokemon-Flute.png', 28.98, 'Commune'),
(87, 'Pokédex', 'Dresseur', 'Images/Pokemon-cards/Pokedex.png', 20.66, 'Commune'),
(88, 'Chen', 'Dresseur', 'Images/Pokemon-cards/Professor-Oak.png', 14.4144, 'Rare'),
(89, 'Rappel', 'Dresseur', 'Images/Pokemon-cards/Revive.png', 17.556, 'Rare'),
(90, 'Super Potion', 'Dresseur', 'Images/Pokemon-cards/Super-Potion.png', 20.64, 'Commune'),
(91, 'Léo', 'Dresseur', 'Images/Pokemon-cards/Bill.png', 28.32, 'Commune'),
(92, 'Retrait d\'Énergie', 'Dresseur', 'Images/Pokemon-cards/Energy-Retrieval.png', 19.69, 'Commune'),
(93, 'Bourrasque', 'Dresseur', 'Images/Pokemon-cards/Gust-of-Wind.png', 28.48, 'Commune'),
(94, 'Potion', 'Dresseur', 'Images/Pokemon-cards/Potion.png', 23.34, 'Commune'),
(95, 'Échange', 'Dresseur', 'Images/Pokemon-cards/Switch.png', 16.23, 'Commune'),
(96, 'Double Énergie Incolore', 'Énergie', 'Images/Pokemon-cards/Double-Colorless-Energy.png', 23.72, 'Énergie'),
(97, 'Énergie Combat', 'Énergie', 'Images/Pokemon-cards/Fighting-Energy.png', 22.37, 'Énergie'),
(98, 'Énergie Feu', 'Énergie', 'Images/Pokemon-cards/Fire-Energy.png', 20.7, 'Énergie'),
(99, 'Énergie Plante', 'Énergie', 'Images/Pokemon-cards/Grass-Energy.png', 21.39, 'Énergie'),
(100, 'Énergie Électrik', 'Énergie', 'Images/Pokemon-cards/Lightning-Energy.png', 24.84, 'Énergie'),
(101, 'Énergie Psy', 'Énergie', 'Images/Pokemon-cards/Psychic-Energy.png', 20.05, 'Énergie'),
(102, 'Énergie Eau', 'Énergie', 'Images/Pokemon-cards/Water-Energy.png', 20.71, 'Énergie');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
