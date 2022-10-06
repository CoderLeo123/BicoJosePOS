CREATE TABLE [dbo].[tblCart] (
    [Num] INT NOT NULL IDENTITY,
    [Item_ID] VARCHAR(50) NULL, 
    [Transaction_No] INT NULL, 
    [Quantity] INT NULL, 
    [Price] DECIMAL NULL, 
    [Total] DECIMAL NULL, 
    [Date] DATE NULL, 
    [Status] VARCHAR(50) NULL, 
    [Discount] DECIMAL NULL, 
    [Stock_Num] INT NULL, 
    PRIMARY KEY CLUSTERED ([Num] ASC)
);

