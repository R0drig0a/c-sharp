DROP TABLE IF EXISTS Bairros;
DROP TABLE IF EXISTS Cidades;
DROP TABLE IF EXISTS Estados;

-- Criando a tabela de Estados
CREATE TABLE Estados (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(50),
    Sigla NVARCHAR(2)
);

-- Criando a tabela de Cidades
CREATE TABLE Cidades (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(50),
    EstadoId INT FOREIGN KEY REFERENCES Estados(Id)
);

-- Criando a tabela de Bairros
CREATE TABLE Bairros (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(50),
    CidadeId INT FOREIGN KEY REFERENCES Cidades(Id)
);

-- Inserindo os dados na tabela de Estados
INSERT INTO Estados (Nome, Sigla) VALUES ('Rio Grande do Sul', 'RS');
INSERT INTO Estados (Nome, Sigla) VALUES ('Paraná', 'PR');
INSERT INTO Estados (Nome, Sigla) VALUES ('Santa Catarina', 'SC');

-- Inserindo os dados na tabela de Cidades
-- Cidades do Rio Grande do Sul
INSERT INTO Cidades (Nome, EstadoId) VALUES ('Porto Alegre', 1);
INSERT INTO Cidades (Nome, EstadoId) VALUES ('Caxias do Sul', 1);
INSERT INTO Cidades (Nome, EstadoId) VALUES ('Pelotas', 1);

-- Cidades do Paraná
INSERT INTO Cidades (Nome, EstadoId) VALUES ('Curitiba', 2);
INSERT INTO Cidades (Nome, EstadoId) VALUES ('Londrina', 2);
INSERT INTO Cidades (Nome, EstadoId) VALUES ('Maringá', 2);

-- Cidades de Santa Catarina
INSERT INTO Cidades (Nome, EstadoId) VALUES ('Blumenau', 3);
INSERT INTO Cidades (Nome, EstadoId) VALUES ('Timbó', 3);
INSERT INTO Cidades (Nome, EstadoId) VALUES ('Pomerode', 3);

-- Inserindo os dados na tabela de Bairros
-- Bairros de Porto Alegre
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Centro', 1);
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Moinhos de Vento', 1);
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Cidade Baixa', 1);

-- Bairros de Caxias do Sul
INSERT INTO Bairros (Nome, CidadeId) VALUES ('São Pelegrino', 2);
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Desvio Rizzo', 2);
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Nossa Senhora de Lourdes', 2);

-- Bairros de Pelotas
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Centro', 3);
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Fragata', 3);
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Areal', 3);

-- Bairros de Curitiba
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Centro', 4);
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Batel', 4);
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Bigorrilho', 4);

-- Bairros de Londrina
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Centro', 5);
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Gleba Palhano', 5);
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Jardim Shangri-lá', 5);

-- Bairros de Maringá
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Zona 7', 6);
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Jardim Alvorada', 6);
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Parque das Grevíleas', 6);

-- Bairros de Blumenau
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Velha', 7);
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Garcia', 7);
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Ponta Aguda', 7);

-- Bairros de Timbó
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Centro', 8);
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Araponguinhas', 8);
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Mulde', 8);

-- Bairros de Pomerode
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Centro', 9);
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Testo Central', 9);
INSERT INTO Bairros (Nome, CidadeId) VALUES ('Pomerode Fundos', 9);

select Estados.nome
    from Estados order by Estados.nome asc;

    select
     Estados.nome,
     Cidades.nome
        from Cidades
        inner join Estados on(Cidades.EstadoId = Estados.id);


 Exec sp_help 'Cidades';

  select 
    Estados.nome as 'Estado',
    cidades.nome as 'Cidade',
    Bairros.nome as 'Bairro'
    from Bairros
    inner join Cidades on (Bairros.CidadeId = Cidades.id)
    inner join Estados on (cidades.EstadoId = Estados.id);
       

       