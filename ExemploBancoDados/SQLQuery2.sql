drop table if exists times
drop table if exists series


create table series(
	id int primary key identity(1,1),
	nome varchar(100)
);

create table times(
	id int primary key identity(1,1),
	nome varchar(100),
	estado varchar(10),
	id_serie int not null,

	-- foreign key(coluna da tabela filha) references nome_tabela_pai(pk da tabela pai)
	foreign key(id_serie) references series(id)
	-- pk -> Primary Key (Chave primaria)
	-- fk -> Foreign Key (Chave estrangeira) ligaçao para a tabela pai
);



insert into series (nome) values
('serie A'), -- Gerar o id 1
('serie B'), -- Gerar o id 2
('serie C'); -- Gerar o id 3


INSERT INTO times (nome, estado, id_serie) VALUES ('Londrina', 'PR', 2);
INSERT INTO times (nome, estado, id_serie) VALUES ('Atlético-MG', 'MG', 1);
INSERT INTO times (nome, estado, id_serie) VALUES ('Atlético-PR', 'PR', 1);
INSERT INTO times (nome, estado, id_serie) VALUES ('Bahia', 'BA', 1);
INSERT INTO times (nome, estado, id_serie) VALUES ('Botafogo', 'RJ', 1);
INSERT INTO times (nome, estado, id_serie) VALUES ('Corinthians', 'SP', 1);
INSERT INTO times (nome, estado, id_serie) VALUES ('Cruzeiro', 'MG', 1);
INSERT INTO times (nome, estado, id_serie) VALUES ('Sampaio Corrêa', 'MA', 2);
INSERT INTO times (nome, estado, id_serie) VALUES ('Cuiabá', 'MT', 1);
INSERT INTO times (nome, estado, id_serie) VALUES ('Flamengo', 'RJ', 1);
INSERT INTO times (nome, estado, id_serie) VALUES ('Ceará', 'CE', 2);
INSERT INTO times (nome, estado, id_serie) VALUES ('Guarani', 'SP', 2);
INSERT INTO times (nome, estado, id_serie) VALUES ('Juventude', 'RS', 2);
INSERT INTO times (nome, estado, id_serie) VALUES ('Mirassol', 'SP', 2);
INSERT INTO times (nome, estado, id_serie) VALUES ('Ponte Preta', 'SP', 2);
INSERT INTO times (nome, estado, id_serie) VALUES ('Fluminense', 'RJ', 1);
INSERT INTO times (nome, estado, id_serie) VALUES ('Chapecoense', 'SC', 2);
INSERT INTO times (nome, estado, id_serie) VALUES ('Santos', 'SP', 2);
INSERT INTO times (nome, estado, id_serie) VALUES ('Goiás', 'GO', 1);
INSERT INTO times (nome, estado, id_serie) VALUES ('Grêmio', 'RS', 1);
INSERT INTO times (nome, estado, id_serie) VALUES ('Ituano', 'SP', 2);
INSERT INTO times (nome, estado, id_serie) VALUES ('Avaí', 'SC', 2);
INSERT INTO times (nome, estado, id_serie) VALUES ('Palmeiras', 'SP', 1);
INSERT INTO times (nome, estado, id_serie) VALUES ('Fortaleza', 'CE', 1);
INSERT INTO times (nome, estado, id_serie) VALUES ('Criciúma', 'SC', 2);
INSERT INTO times (nome, estado, id_serie) VALUES ('Vasco', 'RJ', 1);
INSERT INTO times (nome, estado, id_serie) VALUES ('Internacional', 'RS', 1);
INSERT INTO times (nome, estado, id_serie) VALUES ('ABC', 'RN', 2);
INSERT INTO times (nome, estado, id_serie) VALUES ('Novorizontino', 'SP', 2);
INSERT INTO times (nome, estado, id_serie) VALUES ('São Paulo', 'SP', 1);
INSERT INTO times (nome, estado, id_serie) VALUES ('Sport', 'PE', 2);
INSERT INTO times (nome, estado, id_serie) VALUES ('Vitória', 'BA', 2);


select id,nome,estado, id_serie from times


select
	series.nome,
	times.nome
	from times
	inner join series on(times.id_serie = series.id)
	--where series.nome = 'serie B'
	order by series.nome asc,times.nome asc ;

	select
		series.nome,
		times.nome
		from times 
		inner join series on (times.id_serie = series.id);

--													fk									pk
-- inner join nome_tabela_pai on (nome_tabela_filha.nome_coluna_filha = nome_tabela_pai.nome_coluna_pk)

select
	series.nome as 'Serie',
	times.id as 'id',
	times.nome as 'Nome',
	times.estado as 'Estado'
	from times
	inner join series on(times.id_serie = series.id);


