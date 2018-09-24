use master
go
create database GORDILLO_DB
go
use GORDILLO_DB
go
USE [GORDILLO_DB]
GO

/****** Object:  Table [dbo].[area]    Script Date: 09/23/2018 21:24:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[area](
	[IDarea] [tinyint] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDarea] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[categoria]    Script Date: 09/23/2018 21:25:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[categoria](
	[IDcategoria] [tinyint] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDcategoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[contrato]    Script Date: 09/23/2018 21:25:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[contrato](
	[IDcontrato] [tinyint] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDcontrato] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[convenio]    Script Date: 09/23/2018 21:26:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[convenio](
	[IDconvenio] [tinyint] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDconvenio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO



/****** Object:  Table [dbo].[equipoTelefono]    Script Date: 09/23/2018 21:27:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[equipoTelefono](
	[IMEI] [varchar](50) NOT NULL,
	[modelo] [varchar](50) NOT NULL,
	[marca] [varchar](20) NOT NULL,
	[disponible] [bit] NOT NULL,
	[comentario] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IMEI] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


/****** Object:  Table [dbo].[equipoTelefono]    Script Date: 09/23/2018 21:27:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[equipoTelefono](
	[IMEI] [varchar](50) NOT NULL,
	[modelo] [varchar](50) NOT NULL,
	[marca] [varchar](20) NOT NULL,
	[disponible] [bit] NOT NULL,
	[comentario] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IMEI] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[estadoCivil]    Script Date: 09/23/2018 21:28:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[estadoCivil](
	[IDestadoCivil] [tinyint] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDestadoCivil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[descripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


/****** Object:  Table [dbo].[partido]    Script Date: 09/23/2018 21:29:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[partido](
	[IDpartido] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDpartido] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO



/****** Object:  Table [dbo].[localidad]    Script Date: 09/23/2018 21:28:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[localidad](
	[cp] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[IDpartido] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cp] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[localidad]  WITH CHECK ADD FOREIGN KEY([IDpartido])
REFERENCES [dbo].[partido] ([IDpartido])
GO



/****** Object:  Table [dbo].[tipoUsuario]    Script Date: 09/23/2018 21:29:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tipoUsuario](
	[Idtipo] [tinyint] NOT NULL,
	[decripcion] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Idtipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


/****** Object:  Table [dbo].[usuarios]    Script Date: 09/23/2018 21:29:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[usuarios](
	[nombre] [varchar](20) NOT NULL,
	[clave] [varchar](20) NOT NULL,
	[Idtipo] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD FOREIGN KEY([Idtipo])
REFERENCES [dbo].[tipoUsuario] ([Idtipo])
GO


/****** Object:  Table [dbo].[empleado]    Script Date: 09/23/2018 21:26:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[empleado](
	[fecAlta] [date] NOT NULL,
	[IDcontrato] [tinyint] NOT NULL,
	[IDarea] [tinyint] NOT NULL,
	[IDpuesto] [tinyint] NOT NULL,
	[IDconvenio] [tinyint] NOT NULL,
	[IDcategoria] [tinyint] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[fechaNac] [date] NOT NULL,
	[dni] [int] NOT NULL,
	[cuil] [int] NOT NULL,
	[nacionalidad] [nvarchar](20) NOT NULL,
	[IDestadoCivil] [tinyint] NOT NULL,
	[hijos] [int] NOT NULL,
	[domicilio] [nvarchar](100) NOT NULL,
	[entreCalles] [nvarchar](100) NULL,
	[cp] [int] NOT NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[empleado]  WITH CHECK ADD FOREIGN KEY([cp])
REFERENCES [dbo].[localidad] ([cp])
GO

ALTER TABLE [dbo].[empleado]  WITH CHECK ADD FOREIGN KEY([IDarea])
REFERENCES [dbo].[area] ([IDarea])
GO

ALTER TABLE [dbo].[empleado]  WITH CHECK ADD FOREIGN KEY([IDcategoria])
REFERENCES [dbo].[categoria] ([IDcategoria])
GO

ALTER TABLE [dbo].[empleado]  WITH CHECK ADD FOREIGN KEY([IDcontrato])
REFERENCES [dbo].[contrato] ([IDcontrato])
GO

ALTER TABLE [dbo].[empleado]  WITH CHECK ADD FOREIGN KEY([IDconvenio])
REFERENCES [dbo].[convenio] ([IDconvenio])
GO

ALTER TABLE [dbo].[empleado]  WITH CHECK ADD FOREIGN KEY([IDestadoCivil])
REFERENCES [dbo].[estadoCivil] ([IDestadoCivil])
GO

ALTER TABLE [dbo].[empleado]  WITH CHECK ADD FOREIGN KEY([IDpuesto])
REFERENCES [dbo].[puesto] ([IDpuesto])
GO


go
insert into equipoTelefono (IMEI,modelo, marca,disponible,comentario)
values (1111111111,'Z5','Sony','true','Nuevo'),
       (2222222222,'J7','Samsung','true','Reparado'),
       (3333333333,'6S','Iphone','false','Gerente')
go
insert into convenio
values ('comercio'),
       ('viajantes')
       
go       
insert into area
values ('Depósito'),
       ('Comercial'),
       ('Administración'),
       ('Logística')        
go
insert into contrato
values ('Tiempo determinado'),
       ('Tiempo indeterminado')
go
insert into categoria
values ('Administrativo A'),
       ('Administrativo B'),
       ('Administrativo C'),
       ('Administrativo D'),
       ('Administrativo E'),
       ('Administrativo F'),
       ('Vendedor'),
       ('Vendedor C'),
       ('Vendedor D'),
       ('Personal Auxiliar A'),
       ('Maestranza B'),
       ('Promotor')
go              
insert into estadoCivil
values ('Casado/a'),
       ('Soltero/a'),
       ('Separado/a'),
       ('Divorciado/a'),
       ('Concubinato')
go
insert into usuarios
values('admin','admin',1),
      ('depo','1234',3),
      ('Fernando','456',1),
      ('rrhh','123',2)
