create database dbAgenda; 
use dbAgenda;

create table tbUsuarios (
nome varchar (50) not null,
usuario varchar (40) primary key, 
telefone varchar (20),
senha varchar(10) not null
);