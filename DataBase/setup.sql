USE TesteDotNetInfinity;
GO

CREATE TABLE Usuario (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL UNIQUE,
    Senha NVARCHAR(255) NOT NULL,
    Perfil NVARCHAR(50) NOT NULL,
    DataDeCadastro DATETIME NOT NULL DEFAULT GETDATE()
);
GO

CREATE TABLE Veiculo (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Placa NVARCHAR(20) NOT NULL UNIQUE,
    Modelo NVARCHAR(255) NOT NULL,
    Ano INT NOT NULL,
    Capacidade DECIMAL(10, 2) NOT NULL,
    DataDeCadastro DATETIME NOT NULL DEFAULT GETDATE()
);
GO

CREATE TABLE Frete (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Origem NVARCHAR(255) NOT NULL,
    Destino NVARCHAR(255) NOT NULL,
    Distancia DECIMAL(10, 2) NOT NULL,
    Peso DECIMAL(10, 2) NOT NULL,
    Status NVARCHAR(50) NOT NULL,
    UsuarioId INT NOT NULL,
    VeiculoId INT NOT NULL,
    DataDeCadastro DATETIME NOT NULL DEFAULT GETDATE(),
    DataDeFinalizacao DATETIME NULL,
    FOREIGN KEY (UsuarioId) REFERENCES Usuario(Id),
    FOREIGN KEY (VeiculoId) REFERENCES Veiculo(Id)
);
GO

CREATE TABLE HistoricoDeFrete (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FreteId INT NOT NULL,
    StatusAnterior NVARCHAR(50) NOT NULL,
    StatusNovo NVARCHAR(50) NOT NULL,
    DataDeMudanca DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (FreteId) REFERENCES Frete(Id)
);
GO
