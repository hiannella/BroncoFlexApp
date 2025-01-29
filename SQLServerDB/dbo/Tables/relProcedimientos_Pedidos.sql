CREATE TABLE [dbo].[relProcedimientos_Pedidos]
(
	[IdProcedimiento] INT NOT NULL,
	[IdMuestra] INT NOT NULL,
	[IdDeterminacion] INT NOT NULL
	CONSTRAINT [PK_relProcedimientos_Pedidos] PRIMARY KEY ([IdProcedimiento], [IdMuestra], [IdDeterminacion]),
    CONSTRAINT [FK_relProcedimientos_Pedidos_Procedimientos] FOREIGN KEY ([IdProcedimiento]) REFERENCES [Procedimientos]([Id]),
	CONSTRAINT [FK_relProcedimientos_Pedidos_Muestras] FOREIGN KEY ([IdMuestra]) REFERENCES [Muestras]([Id]),
	CONSTRAINT [FK_relProcedimientos_Pedidos_Determinaciones] FOREIGN KEY ([IdDeterminacion]) REFERENCES [Determinaciones]([Id])
)
