CREATE TABLE [dbo].[Products] (
    [Id]    INT             IDENTITY (1, 1) NOT NULL,
    [Name]  NVARCHAR (MAX)  NULL,
    [Price] DECIMAL (18, 2) NOT NULL,
    [Stock] INT             NOT NULL,
    [Type] NVARCHAR(MAX) NULL, 
    CONSTRAINT [PK_dbo.Products] PRIMARY KEY CLUSTERED ([Id] ASC)
);

