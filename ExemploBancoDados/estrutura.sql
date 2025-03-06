drop table if exists produtos 

create table produtos(
	id int primary key identity(1,1),
	nome varchar(100)
);

select id,nome from produtos
insert into produtos(nome) values('Coca-Cola');
insert into produtos(nome) values('Sansung');

update produtos set nome = 'Samsung' where id = 2

delete from produtos where id = 1

drop table if exists computadores
create table computadores(
	id int primary key identity(1,1),
	processador varchar(60) not null,
	memoriaRam int not null, -- not null quer dizer que a coluna é obrigatoria ou seja o insert tera que conter essa coluna
	fonte int not null,
	placaDeVideo varchar(40),
	preco decimal(10,2) -- vai ter 10 digitos no total sendo 2 deles apos a virgula. ex: 22391715.28


)
insert into computadores (processador, memoriaRam, fonte, placaDeVideo, preco) values('i7',16,600,'Rtx 3060', 5000.10);
insert into computadores(processador, memoriaRam, fonte, preco) values('i9', 32, 1000, 4900.25 )

select id, processador,memoriaRam,fonte,placaDeVideo,preco from computadores
