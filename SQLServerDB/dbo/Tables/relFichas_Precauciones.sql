CREATE TABLE [dbo].[relFichas_Precauciones]
(
    [IdFicha] INT NOT NULL, 
    [IdPrecaucion] INT NOT NULL,
	CONSTRAINT [PK_relFichas_Precauciones] PRIMARY KEY ([IdFicha], [IdPrecaucion]),
    CONSTRAINT [FK_relFichas_Precauciones_Fichas] FOREIGN KEY ([IdFicha]) REFERENCES [Fichas]([Id]), 
    CONSTRAINT [FK_relFichas_Precauciones_Precauciones] FOREIGN KEY ([IdPrecaucion]) REFERENCES [Precauciones]([Id])
)
