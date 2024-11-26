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

create table tb_Contato (
contato varchar(80) not null,
telefone varchar(15) primary key,
categoria varchar(30)
);

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


create table tbLog (
usuario varchar(40),
datahora datetime not null primary key,
descricao varchar(70)
);

delimiter $$
create trigger trLogDeleteCategoria
after
delete
on tb_categoria for each row 
begin
insert into tbLog
    (usuario,
    datahora,
    descricao)
    values
    (user(),
    current_date(),
    concat('A categoria', old.nome_categoria, 'foi excluída.')
    );
  end;
  $$
delimiter ;  

delimiter $$
create trigger trLogInsertCategoria
before
insert
on tb_categoria for each row 
begin
insert into tbLog
    (usuario,
    datahora,
    descricao)
    values
    (user(),
    current_date(),
    concat('A categoria', new.nome_categoria, 'foi adicionada.')
    );
  end;
  $$
delimiter ;  


delimiter $$
create trigger trLogUpdateCategoria
after
update
on tb_categoria for each row 
begin
insert into tbLog
    (usuario,
    datahora,
    descricao)
    values
    (user(),
    current_date(),
    concat('A categoria', old.nome_categoria, 'foi renomeada para', new.nome_categoria)
    );
  end;
  $$
delimiter ;  

//log do frm contatos 
delimiter $$
create trigger trLogInsertContato
after
insert
on tb_Contato for each row 
begin
insert into tbLog
    (usuario,
    datahora,
    descricao)
    values
    (user(),
    current_timestamp(),
    concat('O contato', new.contato, 'foi inserido.')
    );
  end;
  $$
delimiter ;  











