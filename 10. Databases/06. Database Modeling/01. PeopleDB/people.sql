USE [master]
GO
/****** Object:  Database [People]    Script Date: 09/10/2015 02:35:57 ******/
CREATE DATABASE [People]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'People', FILENAME = N'D:\Programs\Microsoft SQL Server\MSSQL12.ADMIN\MSSQL\DATA\People.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'People_log', FILENAME = N'D:\Programs\Microsoft SQL Server\MSSQL12.ADMIN\MSSQL\DATA\People_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [People] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [People].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [People] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [People] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [People] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [People] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [People] SET ARITHABORT OFF 
GO
ALTER DATABASE [People] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [People] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [People] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [People] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [People] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [People] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [People] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [People] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [People] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [People] SET  DISABLE_BROKER 
GO
ALTER DATABASE [People] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [People] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [People] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [People] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [People] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [People] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [People] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [People] SET RECOVERY FULL 
GO
ALTER DATABASE [People] SET  MULTI_USER 
GO
ALTER DATABASE [People] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [People] SET DB_CHAINING OFF 
GO
ALTER DATABASE [People] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [People] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [People] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'People', N'ON'
GO
USE [People]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 09/10/2015 02:35:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Address_Text] [nvarchar](max) NOT NULL,
	[Town_ID] [int] NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continents]    Script Date: 09/10/2015 02:35:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continents](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Continents] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Country]    Script Date: 09/10/2015 02:35:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Continent_ID] [smallint] NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Person]    Script Date: 09/10/2015 02:35:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](max) NOT NULL,
	[last_name] [nvarchar](max) NOT NULL,
	[address_id] [int] NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Town]    Script Date: 09/10/2015 02:35:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Town](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Country_ID] [int] NOT NULL,
 CONSTRAINT [PK_Town] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Address] ON 

INSERT [dbo].[Address] ([ID], [Address_Text], [Town_ID]) VALUES (1, N'Mladost 1', 1)
INSERT [dbo].[Address] ([ID], [Address_Text], [Town_ID]) VALUES (2, N'Charlottenburg', 2)
INSERT [dbo].[Address] ([ID], [Address_Text], [Town_ID]) VALUES (3, N'Friedrichstrasse', 2)
INSERT [dbo].[Address] ([ID], [Address_Text], [Town_ID]) VALUES (4, N'Jinja Road', 3)
INSERT [dbo].[Address] ([ID], [Address_Text], [Town_ID]) VALUES (5, N'Pudong', 4)
INSERT [dbo].[Address] ([ID], [Address_Text], [Town_ID]) VALUES (6, N'Puxi', 4)
INSERT [dbo].[Address] ([ID], [Address_Text], [Town_ID]) VALUES (8, N'Huairou ', 5)
INSERT [dbo].[Address] ([ID], [Address_Text], [Town_ID]) VALUES (9, N'Gangnam', 7)
INSERT [dbo].[Address] ([ID], [Address_Text], [Town_ID]) VALUES (10, N'Favela', 8)
INSERT [dbo].[Address] ([ID], [Address_Text], [Town_ID]) VALUES (11, N'San Juan de Lurigancho', 6)
SET IDENTITY_INSERT [dbo].[Address] OFF
SET IDENTITY_INSERT [dbo].[Continents] ON 

INSERT [dbo].[Continents] ([ID], [Name]) VALUES (3, N'Africa              ')
INSERT [dbo].[Continents] ([ID], [Name]) VALUES (7, N'Antarctica          ')
INSERT [dbo].[Continents] ([ID], [Name]) VALUES (5, N'Asia                ')
INSERT [dbo].[Continents] ([ID], [Name]) VALUES (8, N'Australia           ')
INSERT [dbo].[Continents] ([ID], [Name]) VALUES (4, N'Europe              ')
INSERT [dbo].[Continents] ([ID], [Name]) VALUES (1, N'North America       ')
INSERT [dbo].[Continents] ([ID], [Name]) VALUES (6, N'South America       ')
SET IDENTITY_INSERT [dbo].[Continents] OFF
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([ID], [Name], [Continent_ID]) VALUES (1, N'Uganda', 3)
INSERT [dbo].[Country] ([ID], [Name], [Continent_ID]) VALUES (2, N'China', 5)
INSERT [dbo].[Country] ([ID], [Name], [Continent_ID]) VALUES (4, N'Bulgaria', 4)
INSERT [dbo].[Country] ([ID], [Name], [Continent_ID]) VALUES (5, N'Germany', 4)
INSERT [dbo].[Country] ([ID], [Name], [Continent_ID]) VALUES (6, N'Peru', 1)
INSERT [dbo].[Country] ([ID], [Name], [Continent_ID]) VALUES (7, N'Brazil', 6)
INSERT [dbo].[Country] ([ID], [Name], [Continent_ID]) VALUES (8, N'South Korea', 5)
SET IDENTITY_INSERT [dbo].[Country] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([id], [first_name], [last_name], [address_id]) VALUES (1, N'Ivan', N'Vazov', 1)
INSERT [dbo].[Person] ([id], [first_name], [last_name], [address_id]) VALUES (2, N'Oliverk', N'Kahn', 2)
INSERT [dbo].[Person] ([id], [first_name], [last_name], [address_id]) VALUES (3, N'Michael', N'Ballack', 2)
INSERT [dbo].[Person] ([id], [first_name], [last_name], [address_id]) VALUES (4, N'Jens', N'Lehman', 3)
INSERT [dbo].[Person] ([id], [first_name], [last_name], [address_id]) VALUES (5, N'Manuel', N'Neuer', 3)
INSERT [dbo].[Person] ([id], [first_name], [last_name], [address_id]) VALUES (6, N'Phill', N'Lewis', 4)
INSERT [dbo].[Person] ([id], [first_name], [last_name], [address_id]) VALUES (7, N'Scott', N'Hicks', 4)
INSERT [dbo].[Person] ([id], [first_name], [last_name], [address_id]) VALUES (8, N'Liu', N'Bei', 5)
INSERT [dbo].[Person] ([id], [first_name], [last_name], [address_id]) VALUES (9, N'Tao', N'Qian', 5)
INSERT [dbo].[Person] ([id], [first_name], [last_name], [address_id]) VALUES (10, N'Zhang', N'Fei', 6)
INSERT [dbo].[Person] ([id], [first_name], [last_name], [address_id]) VALUES (11, N'Guan', N'Yu', 6)
INSERT [dbo].[Person] ([id], [first_name], [last_name], [address_id]) VALUES (12, N'Lu', N'Su', 8)
INSERT [dbo].[Person] ([id], [first_name], [last_name], [address_id]) VALUES (13, N'Zhou', N'Yu', 8)
INSERT [dbo].[Person] ([id], [first_name], [last_name], [address_id]) VALUES (14, N'Jang', N'Min Chul', 9)
INSERT [dbo].[Person] ([id], [first_name], [last_name], [address_id]) VALUES (15, N'Jung', N'Jon Hyun', 9)
INSERT [dbo].[Person] ([id], [first_name], [last_name], [address_id]) VALUES (16, N'Zé', N'Pequeno', 10)
INSERT [dbo].[Person] ([id], [first_name], [last_name], [address_id]) VALUES (17, N'Pedro', N'Gonzales', 11)
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Town] ON 

INSERT [dbo].[Town] ([ID], [Name], [Country_ID]) VALUES (1, N'Sofia', 4)
INSERT [dbo].[Town] ([ID], [Name], [Country_ID]) VALUES (2, N'Berlin', 5)
INSERT [dbo].[Town] ([ID], [Name], [Country_ID]) VALUES (3, N'Kampala', 1)
INSERT [dbo].[Town] ([ID], [Name], [Country_ID]) VALUES (4, N'Shanghai', 2)
INSERT [dbo].[Town] ([ID], [Name], [Country_ID]) VALUES (5, N'Beijing', 2)
INSERT [dbo].[Town] ([ID], [Name], [Country_ID]) VALUES (6, N'Lima', 6)
INSERT [dbo].[Town] ([ID], [Name], [Country_ID]) VALUES (7, N'Seoul', 8)
INSERT [dbo].[Town] ([ID], [Name], [Country_ID]) VALUES (8, N'Rio de Janeiro', 7)
SET IDENTITY_INSERT [dbo].[Town] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UX_Name]    Script Date: 09/10/2015 02:35:57 ******/
ALTER TABLE [dbo].[Continents] ADD  CONSTRAINT [UX_Name] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UX_Country_Name]    Script Date: 09/10/2015 02:35:57 ******/
ALTER TABLE [dbo].[Country] ADD  CONSTRAINT [UX_Country_Name] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Town] FOREIGN KEY([Town_ID])
REFERENCES [dbo].[Town] ([ID])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_Town]
GO
ALTER TABLE [dbo].[Country]  WITH CHECK ADD  CONSTRAINT [FK_Country_Continents] FOREIGN KEY([Continent_ID])
REFERENCES [dbo].[Continents] ([ID])
GO
ALTER TABLE [dbo].[Country] CHECK CONSTRAINT [FK_Country_Continents]
GO
ALTER TABLE [dbo].[Town]  WITH CHECK ADD  CONSTRAINT [FK_Town_Country] FOREIGN KEY([Country_ID])
REFERENCES [dbo].[Country] ([ID])
GO
ALTER TABLE [dbo].[Town] CHECK CONSTRAINT [FK_Town_Country]
GO
USE [master]
GO
ALTER DATABASE [People] SET  READ_WRITE 
GO
