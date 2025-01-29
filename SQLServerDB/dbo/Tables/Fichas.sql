CREATE TABLE [dbo].[Fichas]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [Fecha] DATE NOT NULL,
 	[IdPaciente] INT NOT NULL,
    [Ambulatorio] BIT NOT NULL,
    [IdServicio] INT NULL,
    [EnfermedadActual] NVARCHAR(250) NULL, 
    [Antecedentes] NVARCHAR(250) NULL,
    [EstudiosPrevios] NVARCHAR(250) NULL, 
    [Medicacion] NVARCHAR(250) NULL,
    [IdMedicoAtencion] INT NOT NULL, 
    [IdAnestesiaPrevista] INT NOT NULL,
    [Observaciones] NVARCHAR(250) NULL, 
    CONSTRAINT [FK_Ficha_Paciente] FOREIGN KEY ([IdPaciente]) REFERENCES [Pacientes]([Id]), 
    CONSTRAINT [FK_Ficha_Servicios] FOREIGN KEY ([IdServicio]) REFERENCES [Servicios]([Id]),
    CONSTRAINT [FK_Ficha_Personal] FOREIGN KEY ([IdMedicoAtencion]) REFERENCES [Personal]([Id]), 
    CONSTRAINT [FK_Ficha_Anestesia] FOREIGN KEY ([IdAnestesiaPrevista]) REFERENCES [Anestesias]([Id])
)
