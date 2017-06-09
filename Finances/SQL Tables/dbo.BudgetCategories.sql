CREATE TABLE [dbo].[BudgetCategories]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Budget] INT NOT NULL, 
    [Amount] MONEY NOT NULL
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Foreign Key to Budget',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'BudgetCategories',
    @level2type = N'COLUMN',
    @level2name = N'Budget'