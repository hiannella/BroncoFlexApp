CREATE TABLE [dbo].[Laboratorios]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Fecha] DATE NULL, 
    [Hto] DECIMAL(2, 1) NULL, 
    [Hb] DECIMAL(1, 1) NULL, 
    [GB] INT NULL, 
    [Plaquetas] INT NULL, 
    [Urea] TINYINT NULL, 
    [Creatinina] DECIMAL(1, 1) NULL, 
    [TP] TINYINT NULL, 
    [KPTT] TINYINT NULL,
    [IdFicha] INT NOT NULL
    CONSTRAINT [FK_Fichas_Laboratorios] FOREIGN KEY ([IdFicha]) REFERENCES [Fichas]([Id])
)
