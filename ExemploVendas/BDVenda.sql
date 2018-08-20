CREATE DATABASE BDVenda;
go
USE BDVenda;

CREATE TABLE Produto(
Cod int identity primary key,
Descricao varchar(30) not null,
ValorUnit money not null,
Qtd int not null check (Qtd >= 0)
);

CREATE TABLE Cliente(
Cod int identity primary key,
Nome varchar(30) not null
);

CREATE TABLE Venda(
Cod int identity primary key,
CodCli int not null foreign key references Cliente(Cod),
DataVenda date not null default getdate()
);

CREATE TABLE VendaItens(
Cod int identity primary key,
CodVenda int not null foreign key references Venda(Cod),
CodProd int not null foreign key references Produto(Cod),
Qtd int not null check (Qtd >= 0),
ValorUnit money not null
);

GO

INSERT INTO Produto(Descricao, Qtd, ValorUnit) VALUES ('Mouse', 15, 9.9);
INSERT INTO Produto(Descricao, Qtd, ValorUnit) VALUES ('Teclado', 10, 29.95);
INSERT INTO Produto(Descricao, Qtd, ValorUnit) VALUES ('Memoria Ram', 5, 80);

INSERT INTO Cliente(Nome) VALUES ('Maria');
INSERT INTO Cliente(Nome) VALUES ('Jose');
INSERT INTO Cliente(Nome) VALUES ('Pedro');

GO

/* GATILHO */

CREATE TRIGGER BaixaEstoque
ON VendaItens
AFTER INSERT
AS
DECLARE @qtdVendida int; 
DECLARE @codProd INT;

SELECT 
@qtdVendida = qtd, 
@codProd = CodProd
FROM inserted

UPDATE Produto
SET Qtd = Qtd - @qtdVendida
WHERE Cod = @codProd;

use master;

drop database BDVenda;