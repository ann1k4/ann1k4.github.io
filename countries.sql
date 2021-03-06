USE [master]
GO
/****** Object:  Database [Countries]    Script Date: 24/08/2014 10:31:09 p.m. ******/
CREATE DATABASE [Countries]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Countries', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQL\MSSQL\DATA\Countries.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Countries_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQL\MSSQL\DATA\Countries_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Countries] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Countries].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Countries] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Countries] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Countries] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Countries] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Countries] SET ARITHABORT OFF 
GO
ALTER DATABASE [Countries] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Countries] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Countries] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Countries] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Countries] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Countries] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Countries] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Countries] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Countries] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Countries] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Countries] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Countries] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Countries] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Countries] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Countries] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Countries] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Countries] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Countries] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Countries] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Countries] SET  MULTI_USER 
GO
ALTER DATABASE [Countries] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Countries] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Countries] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Countries] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Countries]
GO
/****** Object:  StoredProcedure [dbo].[AddDataRound1]    Script Date: 24/08/2014 10:31:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddDataRound1]
	
	@country varchar(50),
	@matches int,
	@win int,
	@lost int,
	@ranking int,
	@newranking int 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into T_Data (Country,Matches,Win,Lost,Ranking,NewRanking) values(@country,@matches,@win,	@lost,@ranking,@newranking)
END

GO
/****** Object:  StoredProcedure [dbo].[AddDataRound2]    Script Date: 24/08/2014 10:31:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddDataRound2]
	
	@country varchar(50),
	@matches int,
	@win int,
	@lost int,
	@ranking int,
	@newranking int 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update  T_Data  set Matches=@matches,Win=@win,Lost=@lost,Ranking=@ranking,NewRanking=@newranking where Country=@country
END

GO
/****** Object:  StoredProcedure [dbo].[DataRound2]    Script Date: 24/08/2014 10:31:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DataRound2]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Country,Ranking from T_Data where Win <> 0
END

GO
/****** Object:  StoredProcedure [dbo].[deletedata]    Script Date: 24/08/2014 10:31:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[deletedata]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from T_Data
END

GO
/****** Object:  StoredProcedure [dbo].[SelectCountries]    Script Date: 24/08/2014 10:31:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SelectCountries] 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Nombre,Ranking from T_Country,T_Ranking where T_Country.Idcountry=T_Ranking.IdCountry
END

GO
/****** Object:  Table [dbo].[T_Country]    Script Date: 24/08/2014 10:31:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_Country](
	[Idcountry] [int] NOT NULL,
	[Nombre] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_Data]    Script Date: 24/08/2014 10:31:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_Data](
	[Country] [varchar](50) NULL,
	[Matches] [int] NULL,
	[Win] [nchar](10) NULL,
	[Lost] [nchar](10) NULL,
	[Ranking] [nchar](10) NULL,
	[NewRanking] [nchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_Ranking]    Script Date: 24/08/2014 10:31:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Ranking](
	[IdCountry] [int] NOT NULL,
	[Ranking] [int] NULL
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [Countries] SET  READ_WRITE 
GO
