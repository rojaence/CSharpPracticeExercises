USE [master]
GO
/****** Object:  Database [AgrochemicalDB]    Script Date: 07/06/2022 7:34:41 ******/
CREATE DATABASE [AgrochemicalDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AgrochemicalDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AgrochemicalDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AgrochemicalDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AgrochemicalDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AgrochemicalDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AgrochemicalDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AgrochemicalDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AgrochemicalDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AgrochemicalDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AgrochemicalDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AgrochemicalDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [AgrochemicalDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AgrochemicalDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AgrochemicalDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AgrochemicalDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AgrochemicalDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AgrochemicalDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AgrochemicalDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AgrochemicalDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AgrochemicalDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AgrochemicalDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [AgrochemicalDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AgrochemicalDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AgrochemicalDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AgrochemicalDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AgrochemicalDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AgrochemicalDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AgrochemicalDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AgrochemicalDB] SET RECOVERY FULL 
GO
ALTER DATABASE [AgrochemicalDB] SET  MULTI_USER 
GO
ALTER DATABASE [AgrochemicalDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AgrochemicalDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AgrochemicalDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AgrochemicalDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AgrochemicalDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AgrochemicalDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'AgrochemicalDB', N'ON'
GO
ALTER DATABASE [AgrochemicalDB] SET QUERY_STORE = OFF
GO
USE [AgrochemicalDB]
GO
/****** Object:  Table [dbo].[Agrochemical]    Script Date: 07/06/2022 7:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agrochemical](
	[agrochemicalId] [int] IDENTITY(1,1) NOT NULL,
	[laboratoryId] [int] NULL,
	[brandId] [int] NULL,
	[measureId] [int] NULL,
	[agrochemicalName] [varchar](200) NOT NULL,
	[measureUnit] [real] NOT NULL,
	[toxicityLevel] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[agrochemicalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brand]    Script Date: 07/06/2022 7:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brand](
	[brandId] [int] IDENTITY(1,1) NOT NULL,
	[brandName] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[brandId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Laboratory]    Script Date: 07/06/2022 7:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Laboratory](
	[laboratoryId] [int] IDENTITY(1,1) NOT NULL,
	[laboratoryName] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[laboratoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Measure]    Script Date: 07/06/2022 7:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Measure](
	[measureId] [int] IDENTITY(1,1) NOT NULL,
	[measureName] [varchar](100) NOT NULL,
	[measureUnit] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[measureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Agrochemical]  WITH CHECK ADD FOREIGN KEY([brandId])
REFERENCES [dbo].[Brand] ([brandId])
GO
ALTER TABLE [dbo].[Agrochemical]  WITH CHECK ADD FOREIGN KEY([laboratoryId])
REFERENCES [dbo].[Laboratory] ([laboratoryId])
GO
ALTER TABLE [dbo].[Agrochemical]  WITH CHECK ADD FOREIGN KEY([measureId])
REFERENCES [dbo].[Measure] ([measureId])
GO
/****** Object:  StoredProcedure [dbo].[AddAgrochemical]    Script Date: 07/06/2022 7:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddAgrochemical]
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
/****** Object:  StoredProcedure [dbo].[DeleteAgrochemical]    Script Date: 07/06/2022 7:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- DELETE
CREATE PROCEDURE [dbo].[DeleteAgrochemical]
	@agrochemicalId INT
AS
	DELETE FROM Agrochemical WHERE Agrochemical.agrochemicalId = @agrochemicalId
GO
/****** Object:  StoredProcedure [dbo].[GetAgrochemicalById]    Script Date: 07/06/2022 7:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- GET AGROCHEMICAL BY ID
CREATE PROCEDURE [dbo].[GetAgrochemicalById]
@agrochemicalId INT
AS
	SELECT * FROM Agrochemical WHERE agrochemicalId = @agrochemicalId
GO
/****** Object:  StoredProcedure [dbo].[GetAgrochemicals]    Script Date: 07/06/2022 7:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- GET ALL AGROCHEMICALS

CREATE PROCEDURE [dbo].[GetAgrochemicals]
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
/****** Object:  StoredProcedure [dbo].[SearchAgrochemical]    Script Date: 07/06/2022 7:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- READ
CREATE PROCEDURE [dbo].[SearchAgrochemical]
	@param VARCHAR
AS
	SELECT * FROM Agrochemical WHERE Agrochemical.agrochemicalName LIKE '%'+@param+'%'
GO
/****** Object:  StoredProcedure [dbo].[UpdateAgrochemical]    Script Date: 07/06/2022 7:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- UPDATE
CREATE PROCEDURE [dbo].[UpdateAgrochemical]
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
USE [master]
GO
ALTER DATABASE [AgrochemicalDB] SET  READ_WRITE 
GO
