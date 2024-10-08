

CREATE DATABASE PROMOTORES
go

--
USE PROMOTORES

-- 

drop table Prospecto

Create table Prospecto(
Nombre varchar (50) Primary key,
Primer_Apellido varchar (40) not null,
Segundo_Apellido varchar (40) not null,
Calle varchar (50) not null,
Numero int not null,
Colonia varchar (50) not null,
Codigo_Postal int not null,
Telefono varchar (50) not null,
RFC varchar (50) not null
)


select * from Prospecto

insert into Prospecto
values('Cecy','Ochoa','Campos','Severiano',24345,'Patria',80198,'1234567803','CEOC2410ASHSLDFN04')



CREATE TABLE Documentos
(
Nombre_Documentos varchar(50) primary key not null
)

select * from Documentos

insert into Documentos
values ('Documentacion')
CREATE TABLE Estatus_Prospecto
(
Enviado varchar (50) not null,
Autorizado varchar (50) not null,
Rechazado varchar (50) not null
)

select * from Estatus_Prospecto

insert into Estatus_Prospecto
values ('Enviado','Autorizado','Rechazado')
