CREATE TABLE [dbo].[Proprietaire]
(
	[idProprietaire] INT IDENTITY NOT NULL, 

    CONSTRAINT [FK_ProprietaireClient] FOREIGN KEY ([idProprietaire]) REFERENCES [Client]([idClient]),

  
    
)
