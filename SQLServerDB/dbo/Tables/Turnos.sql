CREATE TABLE [dbo].[Turnos]
(
    [Id] INT NOT NULL PRIMARY KEY,
	[Fecha] DATE NOT NULL, 
    [Hora] TIME NULL, 
    [Descripcion] NVARCHAR(250) NULL, 
    [IdColor] INT NOT NULL,
    [PedidoQuirofano] BIT NOT NULL, 
    [ReservaCama] BIT NOT NULL, 
    [Urgencia] BIT NOT NULL,
	[Confirmado] BIT NOT NULL,
    [IdFicha] INT NOT NULL
    --CONSTRAINT [AK_Fichas_Turnos] UNIQUE ([IdFicha]),
    CONSTRAINT [FK_Fichas_Turnos] FOREIGN KEY ([IdFicha]) REFERENCES [Fichas]([Id]),
    CONSTRAINT [FK_Turnos_Colores] FOREIGN KEY ([IdColor]) REFERENCES [Colores]([Id])
)
