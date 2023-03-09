CREATE VIEW [dbo].[BestLogement] 

AS SELECT DISTINCT L.*
FROM [Logement] AS L
JOIN [Avis] AS A 
ON L.[idLogement] = A.[idLogement]
WHERE (SELECT AVG([note]) FROM Avis WHERE Avis.idLogement = L.IdLogement)>(SELECT AVG([note]) FROM [Avis]);