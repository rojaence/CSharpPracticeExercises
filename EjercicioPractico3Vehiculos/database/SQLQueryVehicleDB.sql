CREATE DATABASE VehicleDB
GO

USE VehicleDB
GO

CREATE TABLE Brand
(
	brandId INT PRIMARY KEY IDENTITY,
	brandName VARCHAR(200) NOT NULL
)
GO

CREATE TABLE Country
(
	countryId INT PRIMARY KEY IDENTITY,
	countryName VARCHAR(100) NOT NULL
)
GO

CREATE TABLE VehicleType
(
	vehicleTypeId INT PRIMARY KEY IDENTITY,
	typeName VARCHAR(100)
)
GO

CREATE TABLE Vehicle
(
	vehicleId INT PRIMARY KEY IDENTITY,
	brandId INT REFERENCES Brand(brandId),
	countryId INT REFERENCES Country(countryId),
	vehicleTypeId INT REFERENCES VehicleType(vehicleTypeId),
	modelName VARCHAR(200) NOT NULL,
	modelYear INT NOT NULL,
	price REAL NOT NULL,
)
GO

-- Initial data

-- Brand data
INSERT Brand (brandName) VALUES ('Chevrolet')
INSERT Brand (brandName) VALUES ('Nissan')
INSERT Brand (brandName) VALUES ('Mitsubishi')
INSERT Brand (brandName) VALUES ('Mercedes Benz')
INSERT Brand (brandName) VALUES ('Ford')
INSERT Brand (brandName) VALUES ('Renault')
INSERT Brand (brandName) VALUES ('Bentley')
INSERT Brand (brandName) VALUES ('Citroen')
INSERT Brand (brandName) VALUES ('Fiat')
INSERT Brand (brandName) VALUES ('Ferrary')
INSERT Brand (brandName) VALUES ('Honda')
INSERT Brand (brandName) VALUES ('Hyundai')
INSERT Brand (brandName) VALUES ('Kia')

-- Country data
INSERT Country (countryName) VALUES ('China') 
INSERT Country (countryName) VALUES ('Unión Europea')
INSERT Country (countryName) VALUES ('Estados Unidos')
INSERT Country (countryName) VALUES ('Japón')
INSERT Country (countryName) VALUES ('Alemania')
INSERT Country (countryName) VALUES ('México')
INSERT Country (countryName) VALUES ('Brasil')
INSERT Country (countryName) VALUES ('Francia')
INSERT Country (countryName) VALUES ('Canadá')
INSERT Country (countryName) VALUES ('Italia')

-- Vehicle Type
INSERT VehicleType (typeName) VALUES ('Auto')
INSERT VehicleType (typeName) VALUES ('SUV & Crossover')
INSERT VehicleType (typeName) VALUES ('Camioneta')
INSERT VehicleType (typeName) VALUES ('Camión')

-- Vehicle data
INSERT Vehicle (brandId, countryId, vehicleTypeId, modelName, modelYear, price) VALUES (12, 5, 1, 'Grand i10', 2014, 14990) 
INSERT Vehicle (brandId, countryId, vehicleTypeId, modelName, modelYear, price) VALUES (1, 7, 2,'Groove LT', 2019, 23590)
INSERT Vehicle (brandId, countryId, vehicleTypeId, modelName, modelYear, price) VALUES (13, 3, 1,'Río Sedan', 2021, 32990)
INSERT Vehicle (brandId, countryId, vehicleTypeId, modelName, modelYear, price) VALUES (1, 7, 4,'NLR 511 EIV', 2018, 89990)
GO
-- Store procedures

-- CREATE
CREATE PROCEDURE AddVehicle
	@brandId INT,
	@countryId INT,
	@vehicleTypeId INT,
	@modelName VARCHAR(200),
	@modelYear INT,
	@price REAL
AS
	INSERT Vehicle (brandId, countryId, vehicleTypeId, modelName, modelYear, price) VALUES (@brandId, @countryId, @vehicleTypeId, @modelName, @modelYear, @price)	
GO


--USE VehicleDB
--DROP PROCEDURE GetVehicles

-- READ
CREATE PROCEDURE GetVehicles
	@param VARCHAR
AS
	SELECT 
		Vehicle.vehicleId, 
		Brand.brandName,
		Country.countryName,
		VehicleType.typeName,
		Vehicle.modelName,
		Vehicle.modelYear,
		Vehicle.price
	FROM 
		Vehicle 
		JOIN Brand ON Vehicle.brandId = Brand.brandId
		JOIN Country ON Vehicle.countryId = Country.countryId 
		JOIN VehicleType ON Vehicle.vehicleTypeId = VehicleType.vehicleTypeId
	WHERE Vehicle.modelName LIKE '%'+@param+'%'
GO


-- UPDATE
CREATE PROCEDURE UpdateVehicle
	@vehicleId INT,
	@brandId INT,
	@countryId INT,
	@vehicleTypeId INT,
	@modelName VARCHAR(200),
	@modelYear INT,
	@price REAL
AS
	UPDATE Vehicle
	SET brandId = @brandId, countryId = @countryId, vehicleTypeId = @vehicleTypeId, modelName = @modelName, modelYear = @modelYear, price = @price
	WHERE vehicleId = @vehicleId
GO

-- DELETE
CREATE PROCEDURE DeleteVehicle
	@vehicleId INT
AS
	DELETE FROM Vehicle WHERE vehicleId = @vehicleId
GO

