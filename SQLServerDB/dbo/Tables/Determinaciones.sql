CREATE TABLE [dbo].[Determinaciones]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Determinacion] NVARCHAR(100) NOT NULL, 
    [Piso] NVARCHAR(2) NULL, 
    [Sector] NVARCHAR(50) NULL, 
    [EsDerivado] BIT NOT NULL, 
    [CentroReceptor] NVARCHAR(50) NULL, 
    [Comentarios] NVARCHAR(250) NULL 
)
