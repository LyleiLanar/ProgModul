CREATE DATABASE autoberles2;

CREATE TABLE `autoberles2`.`berlok` ( `id` INT NOT NULL AUTO_INCREMENT , `nev` VARCHAR(100) NOT NULL , `jogositvany` VARCHAR(15) NOT NULL , `telefonszam` VARCHAR(20) NULL , PRIMARY KEY (`id`)) ENGINE = InnoDB;
CREATE TABLE `autoberles2`.`autok` ( `id` INT NOT NULL AUTO_INCREMENT , `rendszam` VARCHAR(6) NOT NULL , `tipus` VARCHAR(100) NOT NULL , `evjarat` INT NULL , `szin` VARCHAR(30) NULL , PRIMARY KEY (`id`), UNIQUE `rendszam` (`rendszam`)) ENGINE = InnoDB;
CREATE TABLE `autoberles2`.`kolcsonzes` ( `id` INT NOT NULL AUTO_INCREMENT , `berloid` INT NOT NULL , `autoid` INT NOT NULL , `berletkezdete` DATE NOT NULL , `napokszama` INT NULL , `napidij` INT NOT NULL , PRIMARY KEY (`id`)) ENGINE = InnoDB;
ALTER TABLE `kolcsonzes` ADD INDEX(`berloid`);
ALTER TABLE `kolcsonzes` ADD INDEX(`autoid`);

INSERT INTO `autok` (`id`, `rendszam`, `tipus`, `evjarat`, `szin`) VALUES (NULL, 'ABC456', 'Ford Ka', '2003', 'Pink'), (NULL, 'ABC123', 'Volkswagen Golf', '2011', 'Fehér'), (NULL, 'ABC157', 'Ford Mondeo', '2015', 'Fekete'), (NULL, 'ABC448', 'Volkswagen Golf', '2012', 'Kék');
INSERT INTO `berlok` (`id`, `nev`, `jogositvany`, `telefonszam`) VALUES (NULL, 'Kandúr Károly', 'LR337157', '06-41-334112'), (NULL, 'Gipsz Jakab', 'VE445112', '06-41-555223');
INSERT INTO `kolcsonzes` (`id`, `berloid`, `autoid`, `berletkezdete`, `napokszama`, `napidij`) VALUES (NULL, '1', '3', '2017-04-23', NULL, '12500'), (NULL, '2', '2', '2017-04-25', NULL, '9999'), (NULL, '1', '', '', NULL, '');
UPDATE `kolcsonzes` SET `napokszama` = '6' WHERE `kolcsonzes`.`id` = 1;;
SELECT berlok.nev,(kolcsonzes.napokszama*kolcsonzes.napidij) as fizess FROM `kolcsonzes` INNER JOIN berlok On kolcsonzes.berloid = berlok.id where berlok.nev='Kandúr Károly';
SELECT autok.rendszam, berlok.nev from kolcsonzes INNER JOIN autok ON kolcsonzes.autoid= autok.id INNER JOIN berlok on kolcsonzes.berloid = berlok.id WHERE kolcsonzes.napokszama is null;


Kortársmiújság

ALTER TABLE `versek` ADD INDEX(`szerzoid`);
ALTER TABLE `versek` ADD INDEX(`verstipusid`);

SELECT szerzok.nev as 'Szerzők' FROM szerzok ORDER BY szerzok.nev ASC;

SELECT versek.cim as 'Haiku versek' FROM versek inner JOIN verstipusok on verstipusok.id = versek.verstipusid where verstipusok.elnevezes= 'Haiku';

SELECT szerzok.nev as 'Legrégebbi felhasználó' FROM szerzok order by szerzok.reg_date ASC LIMIT 1;

SELECT szerzok.nev, versek.cim FROM versek INNER JOIN szerzok on szerzok.id = versek.szerzoid
where szerzok.reg_date>'2012-01-01 00:00:00' and szerzok.reg_date<'2013-01-01 00:00:00'

SELECT COUNT(szerzok.id) FROM szerzok WHERE szerzok.nev LIKE 'K%';

SELECT versek.cim,count(versek.cim) as db FROM versek GROUP by versek.cim HAVING db>1;