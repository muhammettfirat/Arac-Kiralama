CREATE TABLE [dbo].[Müsteri] (
    [ID]      INT            NOT NULL IDENTITY,
    [Tc]      NVARCHAR (50)  NOT NULL,
    [AdSoyad] NVARCHAR (50)  NOT NULL,
    [Telefon] NVARCHAR (50)  NOT NULL,
    [Adres]   NVARCHAR (150) NOT NULL,
    [Email]   NVARCHAR (50)  NOT NULL,
    CONSTRAINT [PK_Müsteri] PRIMARY KEY CLUSTERED ([ID] ASC)
);

