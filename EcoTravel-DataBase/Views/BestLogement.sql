CREATE VIEW [dbo].[BestLogement] 

AS SELECT L.*
FROM [Logement] AS L
JOIN [Avis] AS A 
ON L.[idLogement] = A.[idLogement]
GROUP BY L.[idLogement]
Having AVG(A.[note])>(SELECT AVG([note]) FROM [Avis]);