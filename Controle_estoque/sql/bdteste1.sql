DROP TABLE usuario;


create table usuario
(
id_usuario int primary key identity,
tipo_usuario varchar(40),
senha_usuario varchar(20) not null,
nome_usuario text not null,
registro_usuario int UNIQUE not null,
setor_usuario varchar(40) not null
)

insert into usuario
(tipo_usuario, senha_usuario, nome_usuario, registro_usuario, setor_usuario)
values('Administrador','a','Ali', '1','TI')

select * from usuario

DROP TABLE produto;

create table produto
(
id int primary key identity,
nome varchar(50)  not null,
descricao varchar(50),
validade varchar(50)  not null,
setor varchar(50) not null,
qtdmin float not null,
qtdmax float not null,
qtdatual float not null,
emailfor varchar(50) not null,
emailcom varchar(50) not null,
data DATETIME NOT NULL DEFAULT(GETDATE())
)

select * from  produto