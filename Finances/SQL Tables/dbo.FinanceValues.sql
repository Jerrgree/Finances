CREATE TABLE [dbo].[FinanceValues] (
    [Id]       INT        NOT NULL IDENTITY,
    [name]     NCHAR (10) NOT NULL,
    [value]    MONEY      NOT NULL,
    [maxValue] MONEY      NULL,
    [type]     NCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([name] ASC)
);

