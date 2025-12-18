-- Criação do banco de dados
CREATE DATABASE FinanceiroDB;
GO

USE FinanceiroDB;
GO

-- Criação da tabela LancamentosDiarios
CREATE TABLE LancamentosDiarios (
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    TipoLancamento NVARCHAR(20) NOT NULL CHECK (TipoLancamento IN ('Credito', 'Debito')),
    Valor MONEY NOT NULL,
    DataLancamento DATETIME NOT NULL DEFAULT GETDATE()
);
GO

-- Inserts de teste
INSERT INTO LancamentosDiarios (TipoLancamento, Valor, DataLancamento)
VALUES ('Credito', 1500.00, '2025-12-17 10:30:00');

INSERT INTO LancamentosDiarios (TipoLancamento, Valor, DataLancamento)
VALUES ('Debito', 250.75, '2025-12-17 15:45:00');

INSERT INTO LancamentosDiarios (TipoLancamento, Valor, DataLancamento)
VALUES ('Credito', 320.00, '2025-12-18 09:00:00');

INSERT INTO LancamentosDiarios (TipoLancamento, Valor, DataLancamento)
VALUES ('Debito', 100.00, '2025-12-18 11:20:00');
GO