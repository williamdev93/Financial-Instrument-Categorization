-- Criação da tabela para armazenar os instrumentos financeiros
CREATE TABLE FinancialInstruments (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    MarketValue DECIMAL(18,2),
    Type NVARCHAR(100)
);

-- Criação da tabela para armazenar as categorias dos instrumentos
CREATE TABLE InstrumentCategories (
    InstrumentID INT,
    Category NVARCHAR(100)
);

-- Inserção de dados de exemplo na tabela FinancialInstruments
INSERT INTO FinancialInstruments (MarketValue, Type)
VALUES 
    (800000, 'Stock'),
    (1500000, 'Bond'),
    (6000000, 'Derivative'),
    (300000, 'Stock');

-- Procedure para categorizar os instrumentos financeiros
CREATE PROCEDURE CategorizeFinancialInstruments
AS
BEGIN
    -- Inserção das categorias diretamente na tabela InstrumentCategories
    INSERT INTO InstrumentCategories (InstrumentID, Category)
    SELECT 
        ID,
        CASE 
            WHEN MarketValue < 1000000 THEN 'Low Value'
            WHEN MarketValue >= 1000000 AND MarketValue <= 5000000 THEN 'Medium Value'
            ELSE 'High Value'
        END AS Category
    FROM FinancialInstruments;
END;