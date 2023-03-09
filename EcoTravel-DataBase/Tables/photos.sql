CREATE TABLE [dbo].[photos]
(
	[IdPhoto] INT NOT NULL , 
    [idLogement] INT NOT NULL, 
    [photo] NVARCHAR(255) UNIQUE NOT NULL, 
    CONSTRAINT [PK_photos] PRIMARY KEY ([IdPhoto]), 
    CONSTRAINT [FK_photos_ToTable] FOREIGN KEY ([idLogement]) REFERENCES [Logement]([idLogement]), 
    CONSTRAINT [CK_Photo_photo] CHECK (LEN([photo]) >= 5 AND ([photo] LIKE '%_.png' OR [photo] LIKE '%_.jpg')), 
   
)
