CREATE TABLE [dbo].[Indisponibilite]
(
	[IdIndisponibilite] INT IDENTITY NOT NULL, 
    [dateDebut] DATE NOT NULL, 
    [dateFin] DATE NOT NULL, 
    [idClient] INT NOT NULL, 
    [idLogement] INT NOT NULL, 
    CONSTRAINT [PK_Indisponibilite] PRIMARY KEY ([IdIndisponibilite]), 
    CONSTRAINT [FK_Indisponibilite_Logement] FOREIGN KEY ([idLogement]) REFERENCES [Logement]([idLogement]), 
    CONSTRAINT [FK_Indisponibilite_Client] FOREIGN KEY ([idClient]) REFERENCES [Client]([idClient]),
     CONSTRAINT [CK_Reservation_dateDebutDispo] CHECK ([dateDebut] >= GETDATE()),
    CONSTRAINT [CK_Reservation_dateFinDispo] CHECK ([dateFin] > [dateDebut])
)
