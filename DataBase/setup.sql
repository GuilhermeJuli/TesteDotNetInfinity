-- Criação do banco de dados
CREATE DATABASE TesteDotNetInfinity;
GO

-- Seleção do banco de dados
USE TesteDotNetInfinity;
GO

-- Tabela CadastroFrete
CREATE TABLE CadastroFrete (
    Id INT PRIMARY KEY IDENTITY(1,1),
    NomedaEmpresa NVARCHAR(255) NOT NULL,
    NomeDestinatario NVARCHAR(255) NOT NULL,
    Distancia FLOAT NOT NULL
);
GO

-- Tabela CadastroTerceiro
CREATE TABLE CadastroTerceiro (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(255) NOT NULL,
    CNPJ NVARCHAR(14) NOT NULL
);
GO

-- Tabela ListaDeEntrega
CREATE TABLE ListaDeEntrega (
    Id INT PRIMARY KEY IDENTITY(1,1),
    DataEntrega DATETIME NOT NULL,
    Endereco NVARCHAR(255) NOT NULL,
    Status NVARCHAR(50) NOT NULL
);
GO
