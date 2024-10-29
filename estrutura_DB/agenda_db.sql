
use dbAgenda;

create table cadastro(
nome varchar (80) not null,
usuario varchar (30) not null primary key,
telefone varchar(15),
senha varchar (15)not null 
);

select * from cadastro;