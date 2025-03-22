
Create database ClinicaBD
go 

use ClinicaBD
go

create table Usuario(
IdUsuario int identity(1,1) Cliente
Usuario varchar(20),
Pass varchar(20),
Estado bit
)

select * from cliente

EXEC sp_rename 'Cliente.IdClientes', 'IdCliente', 'COLUMN';

update cliente
	set PrimerNombre = 'Mario'
where IdCliente = 1

create table Cliente(
IdCliente int identity(1,1) primary key,
PrimerNombre varchar(50) not null,
SegundoNombre varchar(50),
PrimerApellido varchar(50) not null,
SegundoApellido varchar(50),
Direccion varchar(200),
Cedula varchar(20) not null,
Telefono int,
Correo varchar(30),
Estado bit
)

create table Trabajador(
IdTrabajador int identity(1,1)  primary key,
PrimerNombre varchar(50) not null,
SegundoNombre varchar(50),
PrimerApellido varchar(50) not null,
SegundoApellido varchar(50),
Dirección varchar(200),
Cedula varchar(20) not null,
Telefono int,
Correo varchar(30),
Estado bit
)

create table HistorialCitas(
IdHistorial int identity(1,1)  primary key,
IdTrabajador int,
IdCliente int,
Diagnostico varchar(1000),
EstadoCita varchar(20),
FechaCreacion datetime,
CreadoPor int,
FechaModificacion datetime,
ModificadoPor int
constraint fk_Historial_Trabajador FOREIGN  key (IdTrabajador)  References Trabajador(IdTrabajador),
constraint fk_Historial_Clientes FOREIGN  key (IdCliente)  References Cliente(IdCliente),
CONSTRAINT CHK_TipoMovimiento CHECK (EstadoCita IN ('Completado', 'Programada', 'Cancelada'))
)


truncate table usuario

select * 
from Usuario
where Usuario = 'Yamil'
	and Pass = '1234'

update Usuario 
	set Estado = 1
where IdUsuario = 1