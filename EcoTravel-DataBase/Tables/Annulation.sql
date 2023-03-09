CREATE TABLE [dbo].[Annulation]
(
	[IdClient] INT NOT NULL, 
    [idReservation] INT NOT NULL, 
    [dateAnnulation] DATE NOT NULL, 
    CONSTRAINT [FK_Client] FOREIGN KEY ([idClient]) REFERENCES [Client]([idClient]), 
    CONSTRAINT [FK_Reservation] FOREIGN KEY ([idReservation]) REFERENCES [Reservation]([idReservation]) 
)
