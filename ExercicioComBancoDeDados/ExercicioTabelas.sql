drop table if exists registro
drop table if exists bebidas 
drop table if exists classificacao


create table classificacao(
	id_classificacao int primary key identity(1,1),
	descricao_classificacao varchar(50)
);

create table bebidas(
	id_bebida int primary key identity(1,1),
	nome_bebida varchar(100),
	teor_alcoolico int,
	id_classificacao int  foreign key references classificacao(id_classificacao)
);



--create table registro(
--	id_registro int primary key identity(1,1),
--	id_bebida int foreign key references bebidas(bebidaId),
--	teorAlcoolicoBebidas int 

--);

insert into classificacao(descricao_classificacao) values ('Whisky'), ('Vinho');


insert into bebidas(nome_bebida,teor_alcoolico,id_classificacao) values
('Jack Daniels', 40, 1),
('Chivas Regal 12 Years', 40, 1),
('Johnnie Walker Black Label', 40, 1);

insert into bebidas(nome_bebida, teor_alcoolico,id_classificacao) values
('Cabernet Sauvignon', 13, 2),
('Chardonnay', 12, 2),
('Merlot', 14, 2);

select * from  bebidas, classificacao where classificacao.id = bebidas.tipoBebidaId;

select
	b.id_bebida,
	b.nome_bebida,
	b.teor_alcoolico,
	cl.id_classificacao,
	cl.descricao_classificacao
from 
	bebidas b
inner join classificacao cl on (b.id_classificacao = cl.id_classificacao)
where 
	b.teor_alcoolico > 13
and cl.descricao_classificacao = 'Vinho'

select 
     classificacao.id_classificacao as 'Id',
      classificacao.descricao_classificacao as 'TipoBebida',
      bebidas.nome_bebida as 'Nome',
      bebidas.teor_alcoolico as 'TeorAlcoolico'
	  from bebidas
     inner join classificacao on (bebidas.id_classificacao = classificacao.id_classificacao);

	 update bebidas set nome_bebida = 'Chandon', teor_alcoolico = 15, id_classificacao = 2 where id_bebida = 9;

drop table if exists hortifruti
drop table if exists categoria

create table categoria(
	id_categoria int primary key identity(1,1),
	nome_categoria varchar(100),

);
create table hortifruti(
	id_hortifruti int primary key identity(1,1),
	nome_hortifruti varchar(100),
	preco_hortifruti decimal(6,2),
	quantidade_hortifruti int,
	id_categoria int foreign key references categoria(id_categoria),
);

insert into categoria(nome_categoria) values ('Frutas'),('Verduras');

--insert into bebidas(nome_bebida,teor_alcoolico,id_classicacao) values
insert into hortifruti(nome_hortifruti,preco_hortifruti,quantidade_hortifruti,id_categoria) values
('Maçã',5.00,150,1),
('Banana',3.00,200,1),
('Laranja',6.50,150,1);

insert into hortifruti(nome_hortifruti,preco_hortifruti,quantidade_hortifruti,id_categoria) values
('Alface',4.50,100,2),
('Cenoura',2.80,120,2),
('Couve',3.20,80,2);

select
	ht.id_categoria,
	ct.nome_categoria,
	ht.nome_hortifruti,
	ht.quantidade_hortifruti,
	ht.preco_hortifruti,
	ht.preco_hortifruti * ht.quantidade_hortifruti as preco_multiplicado
from
	categoria ct
inner join hortifruti ht on (ct.id_categoria = ht.id_categoria);


--select
--	ct.nome_categoria as 'Tipo',
--	ht.nome_hortifruti as 'Nome',
--	ht.quantidade_hortifruti as 'Quantidade',
--	ht.preco_hortifruti as 'valor',
--	'' teorAlcoolico
--from
--	categoria ct
--inner join hortifruti ht on (ct.id_categoria = ht.id_categoria)
--union
--select 
--      classificacao.descricao_classificacao as 'Tipo',
--      bebidas.nome_bebida as 'Nome',
--	    0 quantiade,
--	    0 valor,
--		bebidas.teor_alcoolico as 'TeorAlcoolico'
--	  from bebidas
--     inner join classificacao on (bebidas.id_classificacao = classificacao.id_classificacao);




-- Verifica se a tabela 'pacientes' já existe, e caso exista, remove-a.
DROP TABLE IF EXISTS pacientes;

-- Cria uma nova tabela chamada 'pacientes' com duas colunas:
-- 'id' é uma chave primária (PRIMARY KEY) e incrementa automaticamente (IDENTITY).
-- 'nome' é uma coluna de texto com até 100 caracteres.
CREATE TABLE pacientes(
    id INT PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(100)
);

-- Insere um registro na tabela 'pacientes' com o nome 'Joana'.
INSERT INTO pacientes(nome) VALUES ('Joana');

-- Seleciona todos os registros da tabela 'pacientes' para exibição.
SELECT * FROM pacientes;

-- Adiciona uma nova coluna chamada 'cpf' do tipo texto (VARCHAR) à tabela 'pacientes'.
ALTER TABLE pacientes ADD cpf VARCHAR;

-- Altera a definição da coluna 'cpf' para que tenha no máximo 14 caracteres.
ALTER TABLE pacientes ALTER COLUMN cpf VARCHAR(14);

-- Adiciona uma nova coluna chamada 'descricao' com até 100 caracteres à tabela 'pacientes'.
ALTER TABLE pacientes ADD descricao VARCHAR(100);

-- Remove a coluna 'descricao' da tabela 'pacientes'.
ALTER TABLE pacientes DROP COLUMN descricao;

-- Atualiza o valor da coluna 'cpf' para '090.789.520-65' no registro onde o nome é 'Andre'.
UPDATE pacientes SET cpf = '090.789.520-65' WHERE nome = 'Andre';

alter table pacientes add idade int;

DROP TABLE IF EXISTS livros;
create table livros(
	id int primary key identity(1,1),
	titulo varchar(100),
	autor varchar(100),
	anoPublicacao int
);

insert into livros(titulo,autor,anoPublicacao) values('Dom Quixote', 'Miguel de Cervantes', 1605);
insert into livros(titulo,autor,anoPublicacao) values('1984', 'George Orwell', 1949);;
insert into livros(titulo,autor,anoPublicacao) values('O Pequeno Príncipe', 'Antoine de Saint-Exupéry', 1943);
insert into livros(titulo,autor,anoPublicacao) values('Orgulho e Preconceito', 'Jane Austen', 1813);
insert into livros(titulo,autor,anoPublicacao) values('Cem Anos de Solidão', 'Gabriel García Márquez', 1967);

select * from livros;

alter table livros add genero varchar(50);

UPDATE pacientes SET cpf = '090.789.520-65' WHERE nome = 'Andre';


update livros set genero = ' Distopia e Ficção Científica' where titulo = '1984';



create table alunos
(
	id int primary key identity(1,1),
	nome varchar(100),
	serie varchar(100)
);

select * from alunos;

INSERT INTO Alunos (Nome, Serie) VALUES ('João Silva', '5ª Série');
INSERT INTO Alunos (Nome, Serie) VALUES ('Maria Oliveira', '6ª Série');
INSERT INTO Alunos (Nome, Serie) VALUES ('Pedro Santos', '7ª Série');
INSERT INTO Alunos (Nome, Serie) VALUES ('Ana Costa', '8ª Série');
INSERT INTO Alunos (Nome, Serie) VALUES ('Lucas Pereira', '9ª Série');
INSERT INTO Alunos (Nome, Serie) VALUES ('Clara Almeida', '1º Ano');
