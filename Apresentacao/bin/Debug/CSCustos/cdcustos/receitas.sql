USE [dbCustos]
GO

/****** Object:  Table [dbo].[tblreceita]    Script Date: 08/04/2016 19:23:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblreceita](
	[ID_Receita] [int] IDENTITY(1,1) NOT NULL,
	[Patrocinio] [varchar](50) NULL,
	[Data] [varchar](10) NULL,
	[Valor] [decimal](16, 2) NULL,
	[Cdc] [varchar](50) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


