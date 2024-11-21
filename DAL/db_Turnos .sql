USE [master]
GO
/****** Object:  Database [Turnos_UAI]    Script Date: 20/11/2024 22:11:42 ******/
CREATE DATABASE [Turnos_UAI]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Turnos_UAI', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Turnos_UAI.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Turnos_UAI_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Turnos_UAI_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Turnos_UAI] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Turnos_UAI].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Turnos_UAI] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Turnos_UAI] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Turnos_UAI] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Turnos_UAI] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Turnos_UAI] SET ARITHABORT OFF 
GO
ALTER DATABASE [Turnos_UAI] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Turnos_UAI] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Turnos_UAI] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Turnos_UAI] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Turnos_UAI] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Turnos_UAI] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Turnos_UAI] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Turnos_UAI] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Turnos_UAI] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Turnos_UAI] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Turnos_UAI] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Turnos_UAI] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Turnos_UAI] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Turnos_UAI] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Turnos_UAI] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Turnos_UAI] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Turnos_UAI] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Turnos_UAI] SET RECOVERY FULL 
GO
ALTER DATABASE [Turnos_UAI] SET  MULTI_USER 
GO
ALTER DATABASE [Turnos_UAI] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Turnos_UAI] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Turnos_UAI] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Turnos_UAI] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Turnos_UAI] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Turnos_UAI] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Turnos_UAI', N'ON'
GO
ALTER DATABASE [Turnos_UAI] SET QUERY_STORE = ON
GO
ALTER DATABASE [Turnos_UAI] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Turnos_UAI]
GO
/****** Object:  Table [dbo].[Administrativo]    Script Date: 20/11/2024 22:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrativo](
	[ID_Administrativo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](25) NOT NULL,
	[Telefono] [varchar](25) NOT NULL,
	[Mail] [varchar](25) NOT NULL,
 CONSTRAINT [PK_Administrativo] PRIMARY KEY CLUSTERED 
(
	[ID_Administrativo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clinica]    Script Date: 20/11/2024 22:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clinica](
	[ID_Clinica] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](25) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Telefono] [varchar](25) NOT NULL,
	[Mail] [varchar](25) NOT NULL,
 CONSTRAINT [PK_Clinica] PRIMARY KEY CLUSTERED 
(
	[ID_Clinica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidad]    Script Date: 20/11/2024 22:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidad](
	[ID_Especialidad] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](25) NOT NULL,
 CONSTRAINT [PK_Especialidad] PRIMARY KEY CLUSTERED 
(
	[ID_Especialidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medico]    Script Date: 20/11/2024 22:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medico](
	[ID_Medico] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](25) NOT NULL,
	[DNI] [int] NOT NULL,
	[Nro_Matricula] [int] NOT NULL,
	[Mail] [varchar](50) NULL,
	[Telefono] [varchar](50) NOT NULL,
	[Horario] [int] NOT NULL,
 CONSTRAINT [PK_Medico] PRIMARY KEY CLUSTERED 
(
	[ID_Medico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 20/11/2024 22:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paciente](
	[ID_Paciente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](25) NOT NULL,
	[Telefono] [varchar](25) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Mail] [varchar](25) NOT NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[ID_Paciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turno]    Script Date: 20/11/2024 22:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turno](
	[ID_Turno] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Hora] [int] NOT NULL,
	[ID_Paciente] [int] NOT NULL,
	[ID_Administrativo] [int] NOT NULL,
	[ID_Medico] [int] NOT NULL,
 CONSTRAINT [PK_Turno] PRIMARY KEY CLUSTERED 
(
	[ID_Turno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Administrativo] FOREIGN KEY([ID_Administrativo])
REFERENCES [dbo].[Administrativo] ([ID_Administrativo])
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [FK_Turno_Administrativo]
GO
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Medico] FOREIGN KEY([ID_Medico])
REFERENCES [dbo].[Medico] ([ID_Medico])
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [FK_Turno_Medico]
GO
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Paciente] FOREIGN KEY([ID_Paciente])
REFERENCES [dbo].[Paciente] ([ID_Paciente])
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [FK_Turno_Paciente]
GO
USE [master]
GO
ALTER DATABASE [Turnos_UAI] SET  READ_WRITE 
GO
