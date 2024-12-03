-- criando e usando o banco de dados --
create database dbAgenda; 
use dbAgenda;

-- criando as tabelas do BCD --
create table tbUsuarios (
nome varchar (50) not null,
usuario varchar (40) primary key, 
telefone varchar (20),
senha varchar(10) not null
);

create table tb_Categoria (
cod_categoria int auto_increment primary key,
nome_categoria varchar(20) not null,
usuario varchar(20)
);

create table tb_Contato (
contato varchar(80) not null,
cod_contato int auto_increment primary key, 
telefone varchar(15),
categoria varchar(30)
);

create table tbLog (
cod_log int auto_increment primary key,
usuario varchar(40),
datahora datetime not null,
descricao varchar(70)
);

-- criando logs da tabela categoria (inserir) --
delimiter $$
create trigger trInsertCategoria 
before
insert
on tb_Categoria for each row 
begin 
   set new.usuario = user();
   end;
$$

delimiter ;

-- criando logs da tabela categoria (deletar) --
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

-- criando logs da tabela categoria (inserir) --
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

-- criando logs da tabela categoria  (alterar)--
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

-- criando logs da tabela contatos  (inserir)--
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

-- criando logs da tabela contatos  (alterar)--
delimiter $$
create trigger trLogUpdateContato
after
update
on tb_contato for each row 
begin
insert into tbLog
    (usuario,
    datahora,
    descricao)
    values
    (user(),
    current_date(),
    concat('O contato', old.contato, 'foi alterado para', new.contato)
    );
  end;
  $$
delimiter ;  

-- criando logs da tabela contatos  (deletar)--
delimiter $$
create trigger trLogDeleteContato
after
delete
on tb_Contato for each row 
begin
insert into tbLog
    (usuario,
    datahora,
    descricao)
    values
    (user(),
    current_date(),
    concat('O contato', old.contato, 'foi excluído.')
    );
  end;
  $$
delimiter ;  

-- criando logs da tabela usuario (alterar) --

delimiter $$
create trigger trLogUpdateSenha
after
update
on tbusuarios for each row 
begin
insert into tbLog
    (usuario,
    datahora,
    descricao)
    values
    (user(),
    current_date(),
    concat('A senha', old.senha, 'foi alterada para', new.senha)
    );
  end;
  $$
delimiter ;  

-- criando logs da tabela usuario (deletar)--
delimiter $$
create trigger trLogDeleteUsuario
after
delete
on tbusuarios for each row 
begin
insert into tbLog
    (usuario,
    datahora,
    descricao)
    values
    (user(),
    current_date(),
    concat('O usuário', old.usuario, 'foi excluído.')
    );
  end;
  $$
delimiter ;  


