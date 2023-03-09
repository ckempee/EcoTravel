CREATE PROCEDURE [dbo].[SP_Reservations_Now]
    @id_client INT
AS
BEGIN
    SELECT L.*, R.[dateDebut], R.[dateFin]
    FROM [Logement] AS L
    JOIN [Reservation] AS R
    ON R.[idLogement] = L.[idLogement]
    JOIN [Annulation] AS A
    ON A.[idReservation] = R.[IdReservation]
    WHERE R.[dateDebut] >= GETDATE() 
    AND A.[dateAnnulation] IS NULL
    AND R.[idClient] = @id_client
END