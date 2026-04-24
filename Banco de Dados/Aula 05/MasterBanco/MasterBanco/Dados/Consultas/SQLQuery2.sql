--Criação do Banco de Dados --
CREATE TABLE Contas(
Id INT IDENTITY(1, 1)PRIMARY KEY,
Titular NVARCHAR(30)NOT NULL,
Numero_Da_Conta INT NOT NULL UNIQUE,
Saldo DECIMAl(10,2) NOT NULL
);
GO