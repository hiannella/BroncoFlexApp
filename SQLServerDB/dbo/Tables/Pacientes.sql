CREATE TABLE [dbo].[Pacientes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[TipoDocumento] varchar(29) NULL,
	[NroDocumento] varchar(50) NULL,
	[FechaNacimiento] datetime2 NOT NULL,
	[Nombres] nvarchar(50) NOT NULL,
	[Apellidos] nvarchar(50) NOT NULL,
	[Domicilio] nvarchar(200) NULL,
	[GooglePlacesID] nvarchar(200) NULL,
	[NroTelefonoLinea] varchar(50) NULL,
	[NroTelefonoMovil] varchar(50) NULL,
	[Email] varchar(150) NULL,
	[IdCobertura] int NOT NULL,
	[NroAfiliado] nvarchar(50) NULL, 
    CONSTRAINT [FK_Paciente_Cobertura] FOREIGN KEY ([IdCobertura]) REFERENCES [Coberturas]([Id])
)
