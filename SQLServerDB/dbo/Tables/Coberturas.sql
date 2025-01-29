CREATE TABLE [dbo].[Coberturas]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[Sigla] nvarchar(50) NULL,
	[RNOS] nvarchar(50) NULL,
	[Cobertura] nvarchar (200) NOT NULL
)
