CREATE TABLE [dbo].[Budgets] (
    [Id]    INT           NOT NULL IDENTITY,
    [Name]  VARCHAR (100) NOT NULL,
    [Value] MONEY         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

