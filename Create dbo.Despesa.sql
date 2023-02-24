USE [Web.GestorFinanceiro.App.Data]
GO

/****** Object: Table [dbo].[Despesa] Script Date: 23/02/2023 18:08:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Despesa] (
    [ID_DESPESA]        INT IDENTITY             NOT NULL,
    [NOME_DESPESA]      VARCHAR (70)    NOT NULL,
    [RECORRENTE]        BIT             NOT NULL,
    [TIPO_DESPESA]      INT             NOT NULL,
    [DATA_DESPESA]      DATETIME        NULL,
    [VALOR_DESPESA]     DECIMAL (20, 2) NOT NULL,
    [DESCRICAO_DESPESA] VARCHAR (200)   NULL,
    [DATA_ALTERACAO]    DATETIME        NOT NULL,
    [OPERACAO]          INT             NOT NULL,
    [SITUACAO]          INT             NOT NULL
);





DROP TABLE dbo.Despesa