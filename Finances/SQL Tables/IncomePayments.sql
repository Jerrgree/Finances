﻿CREATE TABLE [dbo].[IncomePayments]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Income Source] INT NOT NULL, 
    [Amount (Net)] MONEY NOT NULL, 
    [Amount (Gross)] MONEY NOT NULL, 
    [Date] DATE NULL
)
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Foreign Key to IncomeSources',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'IncomePayments',
    @level2type = N'COLUMN',
    @level2name = N'Income Source'