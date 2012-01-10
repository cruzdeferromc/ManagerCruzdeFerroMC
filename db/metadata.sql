CREATE DATABASE [36Manager_testes]
COLLATE Latin1_General_CI_AI
GO

ALTER DATABASE [36Manager_testes] SET COMPATIBILITY_LEVEL = 90
GO

ALTER DATABASE [36Manager_testes] SET RECOVERY SIMPLE 
GO

USE [36Manager_testes]
GO

CREATE TABLE [dbo].[cfEvento](
	[cfEventoID] [int] IDENTITY(1,1) NOT NULL,
	[cfEventoMotoClube] [nvarchar](512) NULL,
	[cfEventoDataInicio] [nvarchar](512) NULL,
	[cfEventoDataFim] [nvarchar](512) NULL,
	[cfEventoCidade] [nvarchar](512) NULL,
	[cfEventoLogradouro] [nvarchar](512) NULL,
	[cfEventoCep] [nvarchar](512) NULL,
	[cfEventoEstado] [nvarchar](512) NULL,
	[cfEventoEntrada] [nvarchar](512) NULL,
 CONSTRAINT [PK_cfEvento] PRIMARY KEY CLUSTERED 
(
	[cfEventoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[cfFaccao](
	[cfFaccaoID] [int] IDENTITY(1,1) NOT NULL,
	[cfFaccaoCidade] [nvarchar](512) NULL,
	[cfFaccaoEmail] [nvarchar](512) NULL,
	[cfFaccaoPossuiSede] [bit] NULL,
	[cfFaccaoLogradouro] [nvarchar](512) NULL,
	[cfFaccaoCep] [nvarchar](512) NULL,
	[cfFaccaoEstado] [nvarchar](512) NULL,
 CONSTRAINT [PK_cfFaccao] PRIMARY KEY CLUSTERED 
(
	[cfFaccaoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[cfIntegrante](
	[cfIntegranteID] [int] IDENTITY(1,1) NOT NULL,
	[cfIntegranteName] [nvarchar](512) NULL,
	[cfIntegranteHierarquia] [int] NULL,
	[cfIntegranteCidade] [nvarchar](512) NULL,
	[cfIntegranteLogradouro] [nvarchar](512) NULL,
	[cfIntegranteCep] [nvarchar](512) NULL,
	[cfIntegranteEstado] [nvarchar](512) NULL,
	[cfIntegranteCelular] [nvarchar](50) NULL,
	[cfIntegranteTelefone] [nvarchar](50) NULL,
	[cfIntegranteFoto] [nvarchar](max) NULL,
	[cfIntegrante_cfFaccaoID] [int] NULL,
 CONSTRAINT [PK_cfIntegrante] PRIMARY KEY CLUSTERED 
(
	[cfIntegranteID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO