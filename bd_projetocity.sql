create database dbprojetocity;

use dbprojetocity;

create table tbUsuario(
Id int not null,
Nome varchar (50) not null,
Email varchar (50) not null,
Senha varchar (50) not null
);

create table tbProdutos(
Id int not null,
Nome varchar (50) not null,
Descricao varchar (120) not null,
Preco decimal not null
);
