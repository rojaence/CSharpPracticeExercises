CREATE DATABASE AgrochemicalDB
GO

USE AgrochemicalDB
GO

CREATE TABLE Laboratory
(
	laboratoryId INT PRIMARY KEY IDENTITY,
	laboratoryName VARCHAR(100) NOT NULL
)
GO

CREATE TABLE Brand
(
	brandId INT PRIMARY KEY IDENTITY,
	brandName VARCHAR(100) NOT NULL
)
GO

CREATE TABLE Measure
(
	measureId INT PRIMARY KEY IDENTITY,
	measureName VARCHAR(100) NOT NULL,
	measureUnit VARCHAR(50) NOT NULL
)
GO

CREATE TABLE Agrochemical
(
	agrochemicalId INT PRIMARY KEY IDENTITY,
	laboratoryId INT REFERENCES Laboratory(laboratoryId),
	brandId INT REFERENCES Brand(brandId),
	measureId INT REFERENCES Measure(measureId),
	agrochemicalName VARCHAR(200) NOT NULL,
	measureUnit REAL NOT NULL,
	toxicityLevel TINYINT NOT NULL
)
GO

-- Datos iniciales

-- Datos de empresas como marcas
INSERT Brand (brandName) VALUES ('Agripac')
INSERT Brand (brandName) VALUES ('Rotam')
INSERT Brand (brandName) VALUES ('AgroBayer')
INSERT Brand (brandName) VALUES ('ECUAQUIMICA')
INSERT Brand (brandName) VALUES ('AgroTop')
INSERT Brand (brandName) VALUES ('AgriLimber')
INSERT Brand (brandName) VALUES ('Agriandes')

-- Datos de laboratorios
INSERT Laboratory (laboratoryName) VALUES ('Leili Agrochemistry')
INSERT Laboratory (laboratoryName) VALUES ('BASF')
INSERT Laboratory (laboratoryName) VALUES ('Annquimica')
INSERT Laboratory (laboratoryName) VALUES ('Sinochem Tianjin Co.')
INSERT Laboratory (laboratoryName) VALUES ('Grow More')
INSERT Laboratory (laboratoryName) VALUES ('Daymsa')
INSERT Laboratory (laboratoryName) VALUES ('Klasmann')
INSERT Laboratory (laboratoryName) VALUES ('ExcelAg')
-- Datos de medidas
INSERT Measure (measureName, measureUnit) VALUES ('gramos / litro', 'g/l')
INSERT Measure (measureName, measureUnit) VALUES ('metros cúbicos / hectárea', 'm3/ha')
INSERT Measure (measureName, measureUnit) VALUES ('centímetro cúbico / hectárea', 'cc/ha')
INSERT Measure (measureName, measureUnit) VALUES ('mililitro / Kilogramo', 'ml / Kg')
INSERT Measure (measureName, measureUnit) VALUES ('litro / hectárea', 'l/ha')
INSERT Measure (measureName, measureUnit) VALUES ('Kilogramo / hectárea', 'Kg/ha')
INSERT Measure (measureName, measureUnit) VALUES ('centímetro cúbico / litro', 'cc/l')

-- Datos de agroquímicos
INSERT Agrochemical (agrochemicalName, laboratoryId, brandId, measureId, measureUnit, toxicityLevel)
VALUES('SprayFix', 6, 7, 7, 1.54, 1)
INSERT Agrochemical (agrochemicalName, laboratoryId, brandId, measureId, measureUnit, toxicityLevel)
VALUES('Evergreen', 8, 1, 5, 1, 2)
INSERT Agrochemical (agrochemicalName, laboratoryId, brandId, measureId, measureUnit, toxicityLevel)
VALUES('Diurolaq 80', 4, 1, 6, 3, 3)

-- Procedimientos almacenados para CRUD de agroquímicos

-- CREATE
GO
CREATE PROCEDURE AddAgrochemical
	@laboratoryId INT,
	@brandId INT,
	@measureId INT,
	@name VARCHAR(100),
	@unitValue REAL,
	@toxLevel TINYINT
AS
	INSERT Agrochemical (laboratoryId, brandId, measureId, agrochemicalName, measureUnit, toxicityLevel)
	VALUES (@laboratoryId, @brandId, @measureId, @name, @unitValue, @toxLevel)
GO

-- READ
CREATE PROCEDURE SearchAgrochemical
	@param VARCHAR
AS
	SELECT * FROM Agrochemical WHERE Agrochemical.agrochemicalName LIKE '%'+@param+'%'
GO

-- UPDATE
CREATE PROCEDURE UpdateAgrochemical
	@agrochemicalId INT,
	@laboratoryId INT, 
	@brandId INT,
	@measureId INT,
	@name VARCHAR(100),
	@unitValue REAL,
	@toxLevel TINYINT
AS
	UPDATE Agrochemical
	SET laboratoryId = @laboratoryId, brandId = @brandId, measureId = @measureId, agrochemicalName = @name, measureUnit = @unitValue, toxicityLevel = @toxLevel
	WHERE agrochemicalId = @agrochemicalId
GO

-- DELETE
CREATE PROCEDURE DeleteAgrochemical
	@agrochemicalId INT
AS
	DELETE FROM Agrochemical WHERE Agrochemical.agrochemicalId = @agrochemicalId
GO

-- GET ALL AGROCHEMICALS

CREATE PROCEDURE GetAgrochemicals
@param VARCHAR
AS
	SELECT Agrochemical.agrochemicalId, 
	Agrochemical.agrochemicalName,
	Laboratory.laboratoryName AS 'laboratoryName', 
	Brand.brandName AS 'brandName',
	Measure.measureName AS 'measureName', 
	Measure.measureUnit,
	Agrochemical.measureUnit AS 'measureQuantity', 
	Agrochemical.toxicityLevel AS 'toxicityLevel'
	FROM Agrochemical JOIN Laboratory ON Agrochemical.laboratoryId = Laboratory.laboratoryId
	JOIN Brand ON Agrochemical.brandId = Brand.brandId
	JOIN Measure ON Agrochemical.measureId = Measure.measureId
	WHERE Agrochemical.agrochemicalName LIKE '%'+@param+'%'
GO

-- GET AGROCHEMICAL BY ID
CREATE PROCEDURE GetAgrochemicalById
@agrochemicalId INT
AS
	SELECT * FROM Agrochemical WHERE agrochemicalId = @agrochemicalId
GO