﻿CREATE TABLE [dbo].[Logement]
(
	[IdLogement] INT IDENTITY NOT NULL, 
    [nom] NVARCHAR(50) NOT NULL, 
    [rue] NVARCHAR(255) NOT NULL, 
    [numero] NVARCHAR(50) NOT NULL, 
    [codePostal] NVARCHAR(50) NOT NULL, 
    [pays] NVARCHAR(50) NOT NULL, 
    [latitude] DECIMAL(10, 7) NOT NULL, 
    [longitude] DECIMAL(10, 7) NOT NULL, 
    [descriptionCourte] NVARCHAR(255) NOT NULL, 
    [descriptionLongue] VARCHAR(MAX) NOT NULL, 
    [nbChambre] TINYINT NOT NULL, 
    [nbPiece] TINYINT NOT NULL, 
    [PrixNuit] MONEY NOT NULL, 
    [capacite] TINYINT NOT NULL, 
    [salleDeBain] TINYINT NOT NULL, 
    [WC] TINYINT NOT NULL DEFAULT 1, 
    [Balcon] BIT NOT NULL DEFAULT 0, 
    [AirCo] BIT NOT NULL DEFAULT 0, 
    [wifi] BIT NOT NULL DEFAULT 1, 
    [miniBar] BIT NOT NULL DEFAULT 0, 
    [animauxAdmis] BIT NOT NULL DEFAULT 1, 
    [piscine] BIT NOT NULL DEFAULT 0, 
    [voiturier] BIT NOT NULL DEFAULT 0, 
    [roomservice] BIT NOT NULL DEFAULT 0, 
    [idType] INT NOT NULL, 
    [idClient] INT NOT NULL, 
    [dateCreation] DATE NOT NULL DEFAULT GETDATE(), 
    CONSTRAINT [PK_Logement] PRIMARY KEY ([IdLogement]), 
    
   
    CONSTRAINT [CK_Logement_prixNuit] CHECK ([prixNuit] >= 0),
    CONSTRAINT [CK_Logement_nbChambre] CHECK ([nbChambre] >= 1),
    CONSTRAINT [CK_Logement_nbPiece] CHECK ([nbPiece] >= 1),
    CONSTRAINT [CK_Logement_capacite] CHECK ([capacite] >= 1),
    CONSTRAINT [CK_Logement_Description] CHECK (LEN([descriptionCourte]) < LEN([descriptionLongue])),
    CONSTRAINT [FK_LogementType] FOREIGN KEY ([idType]) REFERENCES [Type]([idtype]), 
    CONSTRAINT [FK_Logement_Client] FOREIGN KEY ([idClient]) REFERENCES [Client]([idClient]), 
    
)