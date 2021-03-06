USE [master]
GO
/****** Object:  Database [Dictionary]    Script Date: 09/10/2015 22:32:49 ******/
CREATE DATABASE [Dictionary]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Dictionary', FILENAME = N'D:\Programs\Microsoft SQL Server\MSSQL12.ADMIN\MSSQL\DATA\Dictionary.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Dictionary_log', FILENAME = N'D:\Programs\Microsoft SQL Server\MSSQL12.ADMIN\MSSQL\DATA\Dictionary_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Dictionary] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Dictionary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Dictionary] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Dictionary] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Dictionary] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Dictionary] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Dictionary] SET ARITHABORT OFF 
GO
ALTER DATABASE [Dictionary] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Dictionary] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Dictionary] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Dictionary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Dictionary] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Dictionary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Dictionary] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Dictionary] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Dictionary] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Dictionary] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Dictionary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Dictionary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Dictionary] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Dictionary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Dictionary] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Dictionary] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Dictionary] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Dictionary] SET RECOVERY FULL 
GO
ALTER DATABASE [Dictionary] SET  MULTI_USER 
GO
ALTER DATABASE [Dictionary] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Dictionary] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Dictionary] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Dictionary] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Dictionary] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Dictionary', N'ON'
GO
USE [Dictionary]
GO
/****** Object:  Table [dbo].[Explanation]    Script Date: 09/10/2015 22:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Explanation](
	[ID] [int] NOT NULL,
	[text] [nvarchar](max) NOT NULL,
	[language_code] [nvarchar](3) NOT NULL,
	[word_ID] [int] NOT NULL,
 CONSTRAINT [PK_Explanation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Language]    Script Date: 09/10/2015 22:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Language](
	[code] [nvarchar](3) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Language] PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Synonym]    Script Date: 09/10/2015 22:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Synonym](
	[ID] [int] NOT NULL,
	[language_code] [nvarchar](3) NOT NULL,
 CONSTRAINT [PK_synonym] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Word]    Script Date: 09/10/2015 22:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Word](
	[ID] [int] NOT NULL,
 CONSTRAINT [PK_Word] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Words_Translated]    Script Date: 09/10/2015 22:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Words_Translated](
	[ID] [int] NOT NULL,
	[language_code] [nvarchar](3) NOT NULL,
	[word_ID] [int] NOT NULL,
	[synonym_ID] [int] NOT NULL,
	[translation] [nvarchar](431) NOT NULL,
 CONSTRAINT [PK_Words_Translated] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Explanation]  WITH CHECK ADD  CONSTRAINT [FK_Explanation_Language] FOREIGN KEY([language_code])
REFERENCES [dbo].[Language] ([code])
GO
ALTER TABLE [dbo].[Explanation] CHECK CONSTRAINT [FK_Explanation_Language]
GO
ALTER TABLE [dbo].[Explanation]  WITH CHECK ADD  CONSTRAINT [FK_Explanation_Word] FOREIGN KEY([word_ID])
REFERENCES [dbo].[Word] ([ID])
GO
ALTER TABLE [dbo].[Explanation] CHECK CONSTRAINT [FK_Explanation_Word]
GO
ALTER TABLE [dbo].[Synonym]  WITH CHECK ADD  CONSTRAINT [FK_synonym_Language] FOREIGN KEY([language_code])
REFERENCES [dbo].[Language] ([code])
GO
ALTER TABLE [dbo].[Synonym] CHECK CONSTRAINT [FK_synonym_Language]
GO
ALTER TABLE [dbo].[Words_Translated]  WITH CHECK ADD  CONSTRAINT [FK_word_language_Language] FOREIGN KEY([language_code])
REFERENCES [dbo].[Language] ([code])
GO
ALTER TABLE [dbo].[Words_Translated] CHECK CONSTRAINT [FK_word_language_Language]
GO
ALTER TABLE [dbo].[Words_Translated]  WITH CHECK ADD  CONSTRAINT [FK_word_language_synonym] FOREIGN KEY([synonym_ID])
REFERENCES [dbo].[Synonym] ([ID])
GO
ALTER TABLE [dbo].[Words_Translated] CHECK CONSTRAINT [FK_word_language_synonym]
GO
ALTER TABLE [dbo].[Words_Translated]  WITH CHECK ADD  CONSTRAINT [FK_word_language_Word] FOREIGN KEY([word_ID])
REFERENCES [dbo].[Word] ([ID])
GO
ALTER TABLE [dbo].[Words_Translated] CHECK CONSTRAINT [FK_word_language_Word]
GO
USE [master]
GO
ALTER DATABASE [Dictionary] SET  READ_WRITE 
GO
