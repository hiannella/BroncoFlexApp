CREATE TABLE [dbo].[relFichas_Pendientes]
(
	[IdFicha] INT NOT NULL,
	[IdPendiente] INT NOT NULL
	CONSTRAINT [PK_relFichas_Pendientes] PRIMARY KEY ([IdFicha], [IdPendiente]),
    CONSTRAINT [FK_relFichas_Pendientes_Fichas] FOREIGN KEY ([IdFicha]) REFERENCES [Fichas]([Id]), 
    CONSTRAINT [FK_relFichas_Pendientes_Pendientes] FOREIGN KEY ([IdPendiente]) REFERENCES [Pendientes]([Id])
)
