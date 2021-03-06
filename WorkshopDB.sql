USE [master]
GO
/****** Object:  Database [WorkshopDB]    Script Date: 23.03.2021 19:21:11 ******/
CREATE DATABASE [WorkshopDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Workshop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Workshop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Workshop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Workshop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [WorkshopDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WorkshopDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WorkshopDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WorkshopDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WorkshopDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WorkshopDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WorkshopDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [WorkshopDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WorkshopDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WorkshopDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WorkshopDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WorkshopDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WorkshopDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WorkshopDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WorkshopDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WorkshopDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WorkshopDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WorkshopDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WorkshopDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WorkshopDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WorkshopDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WorkshopDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WorkshopDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WorkshopDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WorkshopDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WorkshopDB] SET  MULTI_USER 
GO
ALTER DATABASE [WorkshopDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WorkshopDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WorkshopDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WorkshopDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WorkshopDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WorkshopDB] SET QUERY_STORE = OFF
GO
USE [WorkshopDB]
GO
/****** Object:  User [WorkshopAdmin]    Script Date: 23.03.2021 19:21:11 ******/
CREATE USER [WorkshopAdmin] FOR LOGIN [WorkshopAdmin] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [WorkshopAdmin]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 23.03.2021 19:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Task]    Script Date: 23.03.2021 19:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Task](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[PhoneNumber] [varchar](15) NOT NULL,
	[Email] [nvarchar](254) NULL,
	[BikeManufacturer] [nvarchar](50) NOT NULL,
	[BikeModel] [nvarchar](50) NOT NULL,
	[FrameNumber] [nvarchar](50) NULL,
	[AdditionalInfo] [nvarchar](max) NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NULL,
	[Cost] [decimal](9, 2) NULL,
	[TaskDescription] [nvarchar](max) NOT NULL,
	[StatusID] [int] NOT NULL,
 CONSTRAINT [PK_Task] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([Id], [Status]) VALUES (1, N'Przyjęty')
INSERT [dbo].[Status] ([Id], [Status]) VALUES (2, N'Do odbioru')
INSERT [dbo].[Status] ([Id], [Status]) VALUES (3, N'Zrealizowany')
INSERT [dbo].[Status] ([Id], [Status]) VALUES (4, N'Anulowany - do odbioru')
INSERT [dbo].[Status] ([Id], [Status]) VALUES (5, N'Anulowany - odebrany')
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
SET IDENTITY_INSERT [dbo].[Task] ON 

INSERT [dbo].[Task] ([Id], [FirstName], [LastName], [PhoneNumber], [Email], [BikeManufacturer], [BikeModel], [FrameNumber], [AdditionalInfo], [StartDate], [EndDate], [Cost], [TaskDescription], [StatusID]) VALUES (1, N'Tomasz', N'Kasacki', N'664 123 767', N'tomasz12@gmail.com', N'Kross', N'Vento 2 (czarno-limonkowy) 2020', N'LX9370137430', N'Serwisowany regularnie u nas', CAST(N'2021-03-14' AS Date), CAST(N'2021-03-27' AS Date), CAST(121.00 AS Decimal(9, 2)), N'Przegląd sezonowy.', 1)
INSERT [dbo].[Task] ([Id], [FirstName], [LastName], [PhoneNumber], [Email], [BikeManufacturer], [BikeModel], [FrameNumber], [AdditionalInfo], [StartDate], [EndDate], [Cost], [TaskDescription], [StatusID]) VALUES (2, N'Katarzyna', N'Olbryska', N'343 222 787', N'katarzyna@gmail.com', N'Rock Machine', N'Manhattan 90-29', N'LX3242512798', N'Pierwszy raz u nas', CAST(N'2021-03-07' AS Date), CAST(N'2021-03-19' AS Date), CAST(50.15 AS Decimal(9, 2)), N'Wymiana korby', 2)
INSERT [dbo].[Task] ([Id], [FirstName], [LastName], [PhoneNumber], [Email], [BikeManufacturer], [BikeModel], [FrameNumber], [AdditionalInfo], [StartDate], [EndDate], [Cost], [TaskDescription], [StatusID]) VALUES (3, N'Igor', N'Wąski', N'423 323 645', N'igor123@gmail.com', N'Trek', N'Excalibur', N'', N'Stały klient, nowy rower', CAST(N'2021-03-01' AS Date), CAST(N'2021-03-14' AS Date), CAST(150.00 AS Decimal(9, 2)), N'Montaż roweru', 3)
INSERT [dbo].[Task] ([Id], [FirstName], [LastName], [PhoneNumber], [Email], [BikeManufacturer], [BikeModel], [FrameNumber], [AdditionalInfo], [StartDate], [EndDate], [Cost], [TaskDescription], [StatusID]) VALUES (4, N'', N'', N'556 566 978', N'', N'Scott', N'Scale RC 900', N'', N'', CAST(N'2021-03-07' AS Date), NULL, NULL, N'Sprawdzić', 4)
INSERT [dbo].[Task] ([Id], [FirstName], [LastName], [PhoneNumber], [Email], [BikeManufacturer], [BikeModel], [FrameNumber], [AdditionalInfo], [StartDate], [EndDate], [Cost], [TaskDescription], [StatusID]) VALUES (5, N'', N'', N'767 666 234', N'', N'Scott', N'Genius 920', N'', N'', CAST(N'2021-02-27' AS Date), NULL, NULL, N'Test', 5)
SET IDENTITY_INSERT [dbo].[Task] OFF
GO
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_Status] FOREIGN KEY([StatusID])
REFERENCES [dbo].[Status] ([Id])
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_Status]
GO
USE [master]
GO
ALTER DATABASE [WorkshopDB] SET  READ_WRITE 
GO
