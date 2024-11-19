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

delimiter $$
create trigger trInsertCategoria 
before
insert
on tb_Categoria for each row 
begin 
   set new.usuario = current_user();
   end;
$$

delimiter ;
insert into tb_Categoria(categoria)
values ("amigos")

select * from tb_Categoria;

create user 'User1'@'%' identified by '12345678';

select * from tbUsuarios;

select * from mysql.user;