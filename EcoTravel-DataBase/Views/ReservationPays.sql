CREATE VIEW [dbo].[ReservationPays]
	AS SELECT [idReservation],
			  [dateDebut],
			  [dateFin],
			  L.[pays]
	FROM [Reservation] AS R
	JOIN [Logement] as L
	ON R.[idLogement] = L.[idLogement]

