DROP SCHEMA IF EXISTS `pcs`;
CREATE SCHEMA `pcs`;

CREATE TABLE `pcs`.`cataloger` (
  `username` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `fName` VARCHAR(45) NOT NULL,
  `lName` VARCHAR(45) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `sex` CHAR NOT NULL,
  `dateOfBirth` DATE NOT NULL,
  PRIMARY KEY (`username`));

CREATE TABLE `pcs`.`dba` (
  `username` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `fName` VARCHAR(45) NOT NULL,
  `lName` VARCHAR(45) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `sex` CHAR NOT NULL,
  `dateOfBirth` DATE NOT NULL,
  PRIMARY KEY (`username`));

CREATE TABLE `pcs`.`prison` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(128) NOT NULL,
  `location` VARCHAR(128) NOT NULL,
  `description` VARCHAR(128),
  PRIMARY KEY (`id`));

CREATE TABLE `pcs`.`cell_block` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(128) NOT NULL,
  `description` VARCHAR(128),
  `prisonId` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `cellBlock_prisonId.fk_idx` (`prisonId` ASC),
  CONSTRAINT `cellBlock_prisonId.fk`
    FOREIGN KEY (`prisonId`)
    REFERENCES `pcs`.`prison` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE);

CREATE TABLE `pcs`.`cell` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(128) NOT NULL,
  `description` VARCHAR(128),
  `blockId` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `cell_cellBlock.fk_idx` (`blockId` ASC),
  CONSTRAINT `cell_cellBlock.fk`
    FOREIGN KEY (`blockId`)
    REFERENCES `pcs`.`cell_block` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE);

CREATE TABLE `pcs`.`prisoner` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `fName` VARCHAR(45) NOT NULL,
  `lName` VARCHAR(45) NOT NULL,
  `dateOfBirth` DATE NOT NULL,
  `sex` CHAR NOT NULL,
  `cellId` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `prisoner_cellId.fk_idx` (`cellId` ASC),
  CONSTRAINT `prisoner_cellId.fk`
    FOREIGN KEY (`cellId`)
    REFERENCES `pcs`.`cell` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE);

CREATE TABLE `pcs`.`offense` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `location` VARCHAR(128) NOT NULL,
  `type` VARCHAR(128) NOT NULL,
  `description` VARCHAR(128),
  `date` DATE NOT NULL,
  `prisonerId` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `offense_prisonerId.fk_idx` (`prisonerId` ASC),
  CONSTRAINT `offense_prisonerId.fk`
    FOREIGN KEY (`prisonerId`)
    REFERENCES `pcs`.`prisoner` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE);

