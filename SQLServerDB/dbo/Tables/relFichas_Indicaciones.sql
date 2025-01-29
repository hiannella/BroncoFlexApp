CREATE TABLE [dbo].[relFichas_Indicaciones]
(
	[IdFicha] INT NOT NULL,
	[IdIndicacion] INT NOT NULL
	CONSTRAINT [PK_relFichas_Indicaciones] PRIMARY KEY ([IdFicha], [IdIndicacion]),
    CONSTRAINT [FK_relFichas_Indicaciones_Fichas] FOREIGN KEY ([IdFicha]) REFERENCES [Fichas]([Id]), 
    CONSTRAINT [FK_relFichas_Indicaciones_Indicaciones] FOREIGN KEY ([IdIndicacion]) REFERENCES [Indicaciones]([Id])

)
