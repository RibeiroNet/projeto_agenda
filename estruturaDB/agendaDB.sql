create database dbAgenda; 
use dbAgenda;

create table tbUsuarios (
nome varchar (50) not null,
usuario varchar (40) primary key, 
telefone varchar (20),
senha varchar(10) not null
);


create table tb_Categoria (
cod_categoria int auto_increment primary key,
nome_categoria varchar(20) not null
);

select cod_categoria as 'Código', nome_categoria as 'Categoria'
from tb_categoria;

create trigger trInsertCategoria 
before
insert
on tb_Categoria for each row 
begin 