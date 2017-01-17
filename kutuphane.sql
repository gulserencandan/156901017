-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 17 Oca 2017, 17:53:50
-- Sunucu sürümü: 10.1.16-MariaDB
-- PHP Sürümü: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `kutuphane`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kutuphane`
--

CREATE TABLE `kutuphane` (
  `kitapNo` int(11) NOT NULL,
  `kitapAdi` varchar(255) COLLATE utf8_turkish_ci NOT NULL,
  `yazarAdi` varchar(255) COLLATE utf8_turkish_ci NOT NULL,
  `yayinEvi` varchar(255) COLLATE utf8_turkish_ci NOT NULL,
  `kitapTuru` varchar(255) COLLATE utf8_turkish_ci NOT NULL,
  `baskiSayisi` int(11) NOT NULL,
  `stokSatisi` int(11) NOT NULL,
  `gelisTarihi` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `kutuphane`
--
ALTER TABLE `kutuphane`
  ADD PRIMARY KEY (`kitapNo`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `kutuphane`
--
ALTER TABLE `kutuphane`
  MODIFY `kitapNo` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
