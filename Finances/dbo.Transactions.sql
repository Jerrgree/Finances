CREATE TABLE [dbo].[Transactions] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Note]   NVARCHAR (50) NULL,
    [Amount] MONEY         NOT NULL,
    [Source] INT           NOT NULL,
    [Date] DATE NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Foreign key to FinanceValues', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Transactions', @level2type = N'COLUMN', @level2name = N'Source';

