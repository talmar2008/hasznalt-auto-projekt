-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1:3307
-- Létrehozás ideje: 2026. Okt 12. 12:44
-- Kiszolgáló verziója: 10.4.28-MariaDB
-- PHP verzió: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `hasznalt_autok`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `autok`
--

CREATE TABLE `autok` (
  `id` int(11) NOT NULL,
  `marka` varchar(30) DEFAULT NULL,
  `modell` varchar(30) DEFAULT NULL,
  `evjarat` int(11) DEFAULT NULL,
  `ar` int(11) DEFAULT NULL,
  `kilometer` int(11) DEFAULT NULL,
  `uzemanyag` varchar(15) DEFAULT NULL,
  `teljesitmeny` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `autok`
--

INSERT INTO `autok` (`id`, `marka`, `modell`, `evjarat`, `ar`, `kilometer`, `uzemanyag`, `teljesitmeny`) VALUES
(1, 'Toyota', 'Corolla', 2020, 5490000, 78500, 'Benzin', 132),
(2, 'Volkswagen', 'Golf', 2019, 4990000, 92300, 'Dízel', 150),
(3, 'Ford', 'Focus', 2021, 5790000, 45200, 'Benzin', 125),
(4, 'BMW', '320i', 2018, 7290000, 106500, 'Benzin', 184),
(5, 'Skoda', 'Octavia', 2022, 6490000, 38100, 'Benzin', 150),
(6, 'Audi', 'A4', 2020, 7990000, 67400, 'Dízel', 163),
(7, 'Mercedes-Benz', 'A180', 2019, 6990000, 55200, 'Benzin', 136),
(8, 'Kia', 'Ceed', 2021, 5290000, 41700, 'Benzin', 120),
(9, 'Hyundai', 'i30', 2020, 4690000, 63800, 'Benzin', 140),
(10, 'Opel', 'Astra', 2018, 3890000, 112400, 'Dízel', 136);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `autok`
--
ALTER TABLE `autok`
  ADD PRIMARY KEY (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
