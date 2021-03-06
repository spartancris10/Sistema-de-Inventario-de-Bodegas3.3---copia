USE [master]
GO
/****** Object:  Database [inventario de bodega UNICAH]    Script Date: 07/01/2016 11:39:36 ******/
CREATE DATABASE [inventario de bodega UNICAH] ON  PRIMARY 
( NAME = N'Inventario de Bodegas UNICAH', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Inventario de Bodegas UNICAH.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Inventario de Bodegas UNICAH_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Inventario de Bodegas UNICAH_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [inventario de bodega UNICAH] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [inventario de bodega UNICAH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [inventario de bodega UNICAH] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [inventario de bodega UNICAH] SET ANSI_NULLS OFF
GO
ALTER DATABASE [inventario de bodega UNICAH] SET ANSI_PADDING OFF
GO
ALTER DATABASE [inventario de bodega UNICAH] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [inventario de bodega UNICAH] SET ARITHABORT OFF
GO
ALTER DATABASE [inventario de bodega UNICAH] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [inventario de bodega UNICAH] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [inventario de bodega UNICAH] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [inventario de bodega UNICAH] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [inventario de bodega UNICAH] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [inventario de bodega UNICAH] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [inventario de bodega UNICAH] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [inventario de bodega UNICAH] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [inventario de bodega UNICAH] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [inventario de bodega UNICAH] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [inventario de bodega UNICAH] SET  DISABLE_BROKER
GO
ALTER DATABASE [inventario de bodega UNICAH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [inventario de bodega UNICAH] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [inventario de bodega UNICAH] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [inventario de bodega UNICAH] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [inventario de bodega UNICAH] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [inventario de bodega UNICAH] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [inventario de bodega UNICAH] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [inventario de bodega UNICAH] SET  READ_WRITE
GO
ALTER DATABASE [inventario de bodega UNICAH] SET RECOVERY SIMPLE
GO
ALTER DATABASE [inventario de bodega UNICAH] SET  MULTI_USER
GO
ALTER DATABASE [inventario de bodega UNICAH] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [inventario de bodega UNICAH] SET DB_CHAINING OFF
GO
USE [inventario de bodega UNICAH]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 07/01/2016 11:39:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[IdProducto] [varchar](5) NOT NULL,
	[Nombre] [varchar](20) NULL,
	[Marca] [varchar](10) NULL,
	[Estado] [varchar](10) NULL,
	[Tipo] [varchar](10) NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Entradas]    Script Date: 07/01/2016 11:39:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Entradas](
	[IdEntradas] [varchar](5) NOT NULL,
	[Fecha] [date] NULL,
	[Descripción] [varchar](50) NULL,
	[Usuario] [varchar](20) NULL,
 CONSTRAINT [PK_Entradas] PRIMARY KEY CLUSTERED 
(
	[IdEntradas] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bodega]    Script Date: 07/01/2016 11:39:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bodega](
	[IdBodega] [varchar](5) NOT NULL,
	[Localización] [varchar](10) NULL,
 CONSTRAINT [PK_Bodega] PRIMARY KEY CLUSTERED 
(
	[IdBodega] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Departamento]    Script Date: 07/01/2016 11:39:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departamento](
	[IdDepartamento] [varchar](5) NOT NULL,
	[Nombre] [varchar](20) NULL,
	[Encargado] [varchar](20) NULL,
 CONSTRAINT [PK_Departamento] PRIMARY KEY CLUSTERED 
(
	[IdDepartamento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Bodega_insert]    Script Date: 07/01/2016 11:39:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Bodega_insert]
			@IdBodega varchar(5)
           ,@Localización varchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO [inventario de bodega UNICAH].[dbo].[Bodega]
           ([IdBodega]
           ,[Localización])
     VALUES
           (@IdBodega
           ,@Localización)
END
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Porducto]    Script Date: 07/01/2016 11:39:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Mostrar_Porducto]
as
select * from Producto
GO
/****** Object:  Table [dbo].[Requisición]    Script Date: 07/01/2016 11:39:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Requisición](
	[IdRequisición] [varchar](5) NOT NULL,
	[Fecha] [date] NULL,
	[IdDepartamento] [varchar](5) NULL,
	[Observación] [varchar](50) NULL,
 CONSTRAINT [PK_Requisición] PRIMARY KEY CLUSTERED 
(
	[IdRequisición] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[ProductoGR]    Script Date: 07/01/2016 11:39:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ProductoGR] 

	     @IdProducto varchar(5)
           ,@Nombre varchar(20)
           ,@Marca varchar(10)
           ,@Estado varchar(10)
           ,@Tipo varchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO [inventario de bodega UNICAH].[dbo].[Producto]
           ([IdProducto]
           ,[Nombre]
           ,[Marca]
           ,[Estado]
           ,[Tipo])
     VALUES
           (@IdProducto
           ,@Nombre
           ,@Marca 
           ,@Estado 
           ,@Tipo)
END
GO
/****** Object:  Table [dbo].[Inventario]    Script Date: 07/01/2016 11:39:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inventario](
	[IdInventario] [varchar](5) NOT NULL,
	[IdProducto] [varchar](5) NULL,
	[Medida] [varchar](10) NULL,
	[Existencia_Inicial] [int] NULL,
	[Existencia_Final] [int] NULL,
	[IdBodega] [varchar](5) NULL,
 CONSTRAINT [PK_Inventario] PRIMARY KEY CLUSTERED 
(
	[IdInventario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Filtro_Producto]    Script Date: 07/01/2016 11:39:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Filtro_Producto]
@Filtro Varchar	(50)
As
SELECT     IdProducto, Nombre, Marca, Estado, Tipo
FROM         Producto
where IdProducto like @Filtro + '%' and Nombre like @Filtro + '%'
GO
/****** Object:  Table [dbo].[Detalle Entradas]    Script Date: 07/01/2016 11:39:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Detalle Entradas](
	[IdInventario] [varchar](5) NULL,
	[IdEntradas] [varchar](5) NULL,
	[Cantidad] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Salidas]    Script Date: 07/01/2016 11:39:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Salidas](
	[IdSalidas] [varchar](5) NOT NULL,
	[IdRequisición] [varchar](5) NULL,
	[Fecha] [date] NULL,
	[Usuario] [varchar](20) NULL,
 CONSTRAINT [PK_Salidas] PRIMARY KEY CLUSTERED 
(
	[IdSalidas] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Invertario_inser]    Script Date: 07/01/2016 11:39:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Invertario_inser] 
	@IdInventario varchar(5)
           ,@IdProducto varchar(5)
           ,@Medida varchar(10)
           ,@IdBodega varchar(5)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
INSERT INTO [inventario de bodega UNICAH].[dbo].[Inventario]
           ([IdInventario]
           ,[IdProducto]
           ,[Medida]
           ,[IdBodega])
     VALUES
           (@IdInventario
           ,@IdProducto
           ,@Medida
           ,@IdBodega)
END
GO
/****** Object:  Table [dbo].[Detalle Solicitud]    Script Date: 07/01/2016 11:39:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Detalle Solicitud](
	[IdProducto] [varchar](5) NULL,
	[IdRequisición] [varchar](5) NULL,
	[Cantidad] [int] NULL,
	[Medida] [varchar](10) NULL,
	[Estado_de_Entrega] [varchar](15) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Detalle Salidas]    Script Date: 07/01/2016 11:39:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Detalle Salidas](
	[IdInventario] [varchar](5) NULL,
	[IdSalidas] [varchar](5) NULL,
	[Cantidad] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_Requisición_Departamento]    Script Date: 07/01/2016 11:39:36 ******/
ALTER TABLE [dbo].[Requisición]  WITH CHECK ADD  CONSTRAINT [FK_Requisición_Departamento] FOREIGN KEY([IdDepartamento])
REFERENCES [dbo].[Departamento] ([IdDepartamento])
GO
ALTER TABLE [dbo].[Requisición] CHECK CONSTRAINT [FK_Requisición_Departamento]
GO
/****** Object:  ForeignKey [FK_Inventario_Bodega]    Script Date: 07/01/2016 11:39:36 ******/
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD  CONSTRAINT [FK_Inventario_Bodega] FOREIGN KEY([IdBodega])
REFERENCES [dbo].[Bodega] ([IdBodega])
GO
ALTER TABLE [dbo].[Inventario] CHECK CONSTRAINT [FK_Inventario_Bodega]
GO
/****** Object:  ForeignKey [FK_Inventario_Producto]    Script Date: 07/01/2016 11:39:36 ******/
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD  CONSTRAINT [FK_Inventario_Producto] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Producto] ([IdProducto])
GO
ALTER TABLE [dbo].[Inventario] CHECK CONSTRAINT [FK_Inventario_Producto]
GO
/****** Object:  ForeignKey [FK_Detalle Entradas_Entradas]    Script Date: 07/01/2016 11:39:36 ******/
ALTER TABLE [dbo].[Detalle Entradas]  WITH CHECK ADD  CONSTRAINT [FK_Detalle Entradas_Entradas] FOREIGN KEY([IdEntradas])
REFERENCES [dbo].[Entradas] ([IdEntradas])
GO
ALTER TABLE [dbo].[Detalle Entradas] CHECK CONSTRAINT [FK_Detalle Entradas_Entradas]
GO
/****** Object:  ForeignKey [FK_Detalle Entradas_Inventario]    Script Date: 07/01/2016 11:39:36 ******/
ALTER TABLE [dbo].[Detalle Entradas]  WITH CHECK ADD  CONSTRAINT [FK_Detalle Entradas_Inventario] FOREIGN KEY([IdInventario])
REFERENCES [dbo].[Inventario] ([IdInventario])
GO
ALTER TABLE [dbo].[Detalle Entradas] CHECK CONSTRAINT [FK_Detalle Entradas_Inventario]
GO
/****** Object:  ForeignKey [FK_Salidas_Requisición]    Script Date: 07/01/2016 11:39:36 ******/
ALTER TABLE [dbo].[Salidas]  WITH CHECK ADD  CONSTRAINT [FK_Salidas_Requisición] FOREIGN KEY([IdRequisición])
REFERENCES [dbo].[Requisición] ([IdRequisición])
GO
ALTER TABLE [dbo].[Salidas] CHECK CONSTRAINT [FK_Salidas_Requisición]
GO
/****** Object:  ForeignKey [FK_Detalle Solicitud_Producto]    Script Date: 07/01/2016 11:39:36 ******/
ALTER TABLE [dbo].[Detalle Solicitud]  WITH CHECK ADD  CONSTRAINT [FK_Detalle Solicitud_Producto] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Producto] ([IdProducto])
GO
ALTER TABLE [dbo].[Detalle Solicitud] CHECK CONSTRAINT [FK_Detalle Solicitud_Producto]
GO
/****** Object:  ForeignKey [FK_Detalle Solicitud_Requisición]    Script Date: 07/01/2016 11:39:36 ******/
ALTER TABLE [dbo].[Detalle Solicitud]  WITH CHECK ADD  CONSTRAINT [FK_Detalle Solicitud_Requisición] FOREIGN KEY([IdRequisición])
REFERENCES [dbo].[Requisición] ([IdRequisición])
GO
ALTER TABLE [dbo].[Detalle Solicitud] CHECK CONSTRAINT [FK_Detalle Solicitud_Requisición]
GO
/****** Object:  ForeignKey [FK_Detalle Salidas_Inventario]    Script Date: 07/01/2016 11:39:36 ******/
ALTER TABLE [dbo].[Detalle Salidas]  WITH CHECK ADD  CONSTRAINT [FK_Detalle Salidas_Inventario] FOREIGN KEY([IdInventario])
REFERENCES [dbo].[Inventario] ([IdInventario])
GO
ALTER TABLE [dbo].[Detalle Salidas] CHECK CONSTRAINT [FK_Detalle Salidas_Inventario]
GO
/****** Object:  ForeignKey [FK_Detalle Salidas_Salidas]    Script Date: 07/01/2016 11:39:36 ******/
ALTER TABLE [dbo].[Detalle Salidas]  WITH CHECK ADD  CONSTRAINT [FK_Detalle Salidas_Salidas] FOREIGN KEY([IdSalidas])
REFERENCES [dbo].[Salidas] ([IdSalidas])
GO
ALTER TABLE [dbo].[Detalle Salidas] CHECK CONSTRAINT [FK_Detalle Salidas_Salidas]
GO
