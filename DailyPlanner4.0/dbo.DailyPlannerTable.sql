CREATE TABLE [dbo].[DailyPlannerTable] (
    [id]          INT            IDENTITY (1, 1) NOT NULL,
    [Task]        NVARCHAR (MAX) NOT NULL,
    [Date]        DATETIME       NOT NULL,
    [Description] NVARCHAR (MAX) NOT NULL, 
    [Type] NCHAR(10) NOT NULL
);

