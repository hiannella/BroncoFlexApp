CREATE TABLE [dbo].[Personal]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nombres] NVARCHAR(50) NOT NULL, 
    [Apellidos] NVARCHAR(50) NOT NULL,
    [NroMatricula] VARCHAR(6) NULL,
    [NroLegajo] VARCHAR(6) NULL, 
    [IdCargo] INT NOT NULL, 
    CONSTRAINT [FK_Personal_Cargo] FOREIGN KEY ([IdCargo]) REFERENCES [Cargos]([Id])
)
