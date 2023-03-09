CREATE TABLE [dbo].[Proprietaire]
(
	[idClient] INT IDENTITY NOT NULL, 

    CONSTRAINT [FK_ProprietaireClient] FOREIGN KEY ([idClient]) REFERENCES [Client]([idClient]),

  
    
)
