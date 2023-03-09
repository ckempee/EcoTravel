CREATE TABLE [dbo].[Client]
(
	[IdClient] INT IDENTITY NOT NULL, 
    [nom] NVARCHAR(50) UNIQUE NOT NULL, 
    [prenom] NVARCHAR(50) NOT NULL, 
    [email] NVARCHAR(255) NOT NULL, 
    [pays] NVARCHAR(50) NOT NULL, 
    [telephone] NVARCHAR(50) NOT NULL,
    [password] VARBINARY(64) NOT NULL, 
    CONSTRAINT [PK_Client] PRIMARY KEY ([IdClient]), 
    CONSTRAINT [UK_Client_email] UNIQUE ([email]),
    CONSTRAINT [CK_Client_email] CHECK ([email] LIKE ('%__@__%.__%')),
    CONSTRAINT [CK_Client_telephone] CHECK (ISNUMERIC(REPLACE(REPLACE(REPLACE([telephone], '+', '00'), '/', ''), '.', '')) = 1),
    CONSTRAINT [CK_Client_nom] CHECK (LEN([nom]) >= 1), 
    CONSTRAINT [CK_Client_prenom] CHECK (LEN([prenom]) >= 1) 
)
