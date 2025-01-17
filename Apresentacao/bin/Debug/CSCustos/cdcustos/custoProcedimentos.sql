USE [dbCustos]
GO
/****** Object:  Table [dbo].[tblCustos]    Script Date: 08/04/2016 19:23:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCustos](
	[ID_Custos] [int] IDENTITY(1,1) NOT NULL,
	[Gastos] [varchar](50) NULL,
	[Cliente] [varchar](50) NULL,
	[Produto] [varchar](50) NULL,
	[Total] [decimal](16, 2) NULL,
	[Data] [varchar](10) NULL,
	[Quantidade] [int] NULL,
	[Valor] [decimal](16, 2) NULL,
	[Cdc] [varchar](50) NULL,
	[Favorecido] [varchar](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblCustos] ON
INSERT [dbo].[tblCustos] ([ID_Custos], [Gastos], [Cliente], [Produto], [Total], [Data], [Quantidade], [Valor], [Cdc], [Favorecido]) VALUES (2, N'Instalaçao', N'mega pop', N'pop', CAST(126.00 AS Decimal(16, 2)), N'25/06/2016', 12, CAST(10.50 AS Decimal(16, 2)), N'000254578', N'Julimar da julia')
SET IDENTITY_INSERT [dbo].[tblCustos] OFF
/****** Object:  StoredProcedure [dbo].[AlteraCentro_de_Custo_Custotbl]    Script Date: 08/04/2016 19:23:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AlteraCentro_de_Custo_Custotbl]   
	@CDC_Descricao Varchar(50) 

AS
BEGIN

UPDATE tblCusto
SET
CDC=@CDC_Descricao
WHERE
CDC=@CDC_Descricao

SELECT @CDC_Descricao AS Retorno

END
GO
/****** Object:  Table [dbo].[tblCentro_de_Custo]    Script Date: 08/04/2016 19:23:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCentro_de_Custo](
	[ID_CDC] [int] IDENTITY(1,1) NOT NULL,
	[CDC_Descricao] [varchar](20) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblCentro_de_Custo] ON
INSERT [dbo].[tblCentro_de_Custo] ([ID_CDC], [CDC_Descricao]) VALUES (1, N'000254578')
INSERT [dbo].[tblCentro_de_Custo] ([ID_CDC], [CDC_Descricao]) VALUES (2, N'000002525')
SET IDENTITY_INSERT [dbo].[tblCentro_de_Custo] OFF
/****** Object:  StoredProcedure [dbo].[InserirReceita]    Script Date: 08/04/2016 19:23:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InserirReceita]
    @Patrocinio Varchar(50),
	@Data Varchar(10),
	@Valor Varchar(10),
	@cdc varchar(50) 

AS
	BEGIN

	INSERT INTO tblreceita (
Patrocinio ,
Data,
Valor,
Cdc
)
VALUES(
@Patrocinio ,
@Data,
@Valor,
@cdc
)
SELECT @@IDENTITY AS Retorno
END
GO
/****** Object:  StoredProcedure [dbo].[InserirCustos]    Script Date: 08/04/2016 19:23:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InserirCustos]
	@Gastos Varchar(50),
	@Cliente Varchar(50),
	@Produto Varchar(50),
	@Quantidade Varchar(50),
	@Valor Varchar(50),
	@Total Varchar(10),
	@Data Varchar(10),
	@cdc Varchar(50),
	@Favorecido Varchar(100) 

AS
BEGIN

INSERT INTO tblCustos (
Gastos ,
Cliente,
Produto,
Quantidade,
Valor,
Total,
Data,
Cdc,
Favorecido)
VALUES(
@Gastos ,
@Cliente,
@Produto,
@Quantidade,
@Valor,
@Total,
@Data,
@cdc,
@Favorecido )

SELECT @@IDENTITY AS Retorno
END
GO
/****** Object:  StoredProcedure [dbo].[InserirCentroCusto]    Script Date: 08/04/2016 19:23:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InserirCentroCusto]
    @CDC_Descricao Varchar(50)
	
AS
BEGIN

	INSERT INTO tblCentro_de_Custo (
CDC_Descricao
)
VALUES(
@CDC_Descricao
)
SELECT @@IDENTITY AS Retorno
END
GO
/****** Object:  StoredProcedure [dbo].[ExcluirReceita]    Script Date: 08/04/2016 19:23:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExcluirReceita]
	@ID_Receita int
AS
BEGIN

DELETE FROM 
   tblreceita 
WHERE
  ID_Receita=@ID_Receita 

SELECT @ID_Receita AS Retorno

END
GO
/****** Object:  StoredProcedure [dbo].[ExcluirCustos]    Script Date: 08/04/2016 19:23:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExcluirCustos]
@ID_Custos int
AS
BEGIN

DELETE FROM 
   tblCustos 
WHERE
  ID_Custos=@ID_Custos 

SELECT @ID_Custos AS Retorno

END
GO
/****** Object:  StoredProcedure [dbo].[ExcluirCentroCusto]    Script Date: 08/04/2016 19:23:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExcluirCentroCusto]
	@ID_CDC int
AS
BEGIN

DELETE FROM 
   tblCentro_de_Custo 
WHERE
  ID_CDC=@ID_CDC 

SELECT @ID_CDC AS Retorno

END
GO
/****** Object:  StoredProcedure [dbo].[ConsultaReceitaPatrocinio]    Script Date: 08/04/2016 19:23:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultaReceitaPatrocinio]
		@Patrocinio varchar(50)
AS
BEGIN
	SELECT 
    *
FROM           
 tblreceita
WHERE       
 (Patrocinio LIKE '%' + @Patrocinio + '%') 
 END
GO
/****** Object:  StoredProcedure [dbo].[ConsultaCustosGastos]    Script Date: 08/04/2016 19:23:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultaCustosGastos]
	@Gastos varchar(50)
AS
BEGIN
	SELECT 
     *
FROM           
 tblCustos
WHERE       
 (Gastos LIKE '%' + @Gastos + '%') 
 END
GO
/****** Object:  StoredProcedure [dbo].[ConsultaCentroCusto]    Script Date: 08/04/2016 19:23:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultaCentroCusto]
	@CDC_Descricao varchar(50)
AS
BEGIN
	SELECT 
     *
FROM           
 tblCentro_de_Custo
WHERE       
 (CDC_Descricao LIKE '%' + @CDC_Descricao + '%') 
 END
GO
/****** Object:  StoredProcedure [dbo].[AlteraReceita]    Script Date: 08/04/2016 19:23:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AlteraReceita]
@ID_Receita int ,
@Patrocinio varchar(50),
@Data varchar(10),
@Valor varchar(10),
@cdc varchar(50) 

AS
BEGIN

UPDATE tblReceita 
SET
Patrocinio=@Patrocinio,
Data=@Data,
Valor=@Valor,
Cdc=@cdc
WHERE
ID_Receita=@ID_Receita
SELECT @ID_Receita AS Retorno

END
GO
/****** Object:  StoredProcedure [dbo].[AlterarCustos]    Script Date: 08/04/2016 19:23:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AlterarCustos]
    @ID_Custos int,
	@Gastos Varchar(50),
	@Cliente Varchar(50),
	@Produto Varchar(50),
	@Quantidade Varchar(50),
	@Valor Varchar(50),
	@Total Varchar(10),
	@Data Varchar(10) ,
	@cdc Varchar(50),
	@Favorecido Varchar(100)

AS
BEGIN

UPDATE tblCustos 
SET
Gastos=@Gastos,
Cliente=@Cliente,
Produto=@Produto,
Quantidade=@Quantidade,
Valor=@Valor,
Total=@Total,
Data=@Data,
Cdc=@cdc,
Favorecido=@Favorecido
WHERE
ID_Custos=@ID_Custos
SELECT @ID_Custos AS Retorno

END
GO
/****** Object:  StoredProcedure [dbo].[AlterarCentroCusto]    Script Date: 08/04/2016 19:23:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AlterarCentroCusto]
    @ID_CDC int,
	@CDC_Descricao Varchar(50) 

AS
BEGIN

UPDATE tblCentro_de_Custo
SET
CDC_Descricao=@CDC_Descricao
WHERE
ID_CDC=@ID_CDC

SELECT @ID_CDC AS Retorno

END
GO
