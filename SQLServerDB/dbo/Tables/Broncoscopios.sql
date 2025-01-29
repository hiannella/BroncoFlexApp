CREATE TABLE [dbo].[Broncoscopios]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Modelo] NVARCHAR(100) NOT NULL, 
    [NroPatrimonio] nvarchar(6) NULL,
    [EsVideo] BIT NOT NULL, 
    [EsEBUS] BIT NOT NULL, 
    [Diametro] DECIMAL(2, 1) NULL, 
    [Canal] DECIMAL(2, 1) NULL 
)
