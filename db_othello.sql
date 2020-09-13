create database db_othello
go

use db_othello
go

create table Jugador(
Usuario varchar(15) not null primary key,
Nombre varchar(20) not null,
Apellido varchar(20) not null,
Contraseña varchar(30) not null, 
Fecha_nac date not null,
Correo varchar(30) not null,
Pais varchar(30) not null
)
go

create table Tipo_partida(
Id_tipo int identity primary key,
tipo varchar(10) not null
)
go

create table Ficha(
Id_ficha int identity primary key, 
Color varchar(8) not null,
No_fila int not null,
No_columna int not null
)
go

create table Tablero(
Id_tablero int identity primary key,
No_fichas_blancas int not null,
No_fichas_negras int not null
)
go

create table Tablero_Ficha(
Id_partida_jugador int identity primary key,
Id_tablero int foreign key references Tablero(Id_tablero) not null,
Id_ficha int foreign key references Ficha(Id_ficha) not null
)
go

create table Partida(
Id_partida int identity primary key,
Id_tipo int foreign key references Tipo_partida(Id_tipo) not null,
Id_tablero int foreign key references Tablero(Id_tablero) not null
)
go

create table Partida_Jugador(
Id_partida_jugador int identity primary key,
Id_partida int foreign key references Partida(Id_partida) not null,
Usuario varchar(15) foreign key references Jugador(Usuario) not null
)
go