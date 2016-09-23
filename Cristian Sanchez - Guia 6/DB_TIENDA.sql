CREATE DATABASE TIENDA
GO

USE TIENDA
GO

CREATE TABLE PRODUCTOS
(
ID_PRODUCTO int identity(1,1),
NOMBRE varchar(120) not null,
DESCRIPCION varchar(255) not null,
constraint PK_PRODUCTO primary key(ID_PRODUCTO)
)

CREATE TABLE CLIENTES
(
ID_CLIENTE int identity(1,1),
NOMBRE varchar(45) not null,
APELLIDO varchar(45) not null,
EDAD int not null,
constraint PK_CLIENTES primary key(ID_CLIENTE)
)

CREATE TABLE PEDIDOS
(
ID_PEDIDO int identity(1,1),
FECHACREACION date not null,
ID_CLIENTE int not null,
constraint PK_PEDIDOS primary key(ID_PEDIDO),
constraint FK_CLIENTES foreign key(ID_CLIENTE)
references CLIENTES(ID_CLIENTE)
)

CREATE TABLE LINEAPEDIDOS
(
ID_LINEAPEDIDO int identity(1,1),
UNIDADES int not null,
ID_PEDIDO int not null,
ID_PRODUCTO int not null,
constraint PK_LINEAPEDIDOS primary key(ID_LINEAPEDIDO),
constraint FK_PEDIDOS foreign key(ID_PEDIDO)
references PEDIDOS(ID_PEDIDO),
constraint FK_PRODUCTOS foreign key(ID_PRODUCTO)
references PRODUCTOS(ID_PRODUCTO)
)