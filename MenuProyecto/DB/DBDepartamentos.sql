--TABLA INSERCION DE IMAGENES A BASE DE DATOS

-- Creacion de la base de datos
create database prueba

-- Uso de la base de datos 
use prueba


-- Creacion de la tabla 
create table departamentos(
	id int PRIMARY KEY IDENTITY (1,1) NOT NULL ,
	imagen image,
	nombre_departamento varchar (50) NULL,
	distancia varchar (20) NULL,
	poblacion varchar (20)  NULL,
	municipios varchar (50) NULL
)

go
--procedimiento almacenado para insertar la imagen
create proc spinsertar_imagen
@imagen image,
@nombre_departamento varchar (50),
@distancia varchar (20),
@poblacion varchar (20),
@municipios varchar (50)
as
insert into departamentos (imagen, nombre_departamento, distancia, poblacion, municipios ) values (@imagen, @nombre_departamento, @distancia, @poblacion, @municipios )
go
--procedimiento almacenado ver la imagen
create proc spmostrar_imagenn
@nombre_departamento varchar (50)


as
 select * from departamentos where nombre_departamento = @nombre_departamento
go

create proc spmostrar_datos
@nombre_departamento varchar(50)


as
 select nombre_departamento, distancia, poblacion, municipios from departamentos where nombre_departamento = @nombre_departamento
go


-- Funciones De La Tabla
select id, nombre_departamento, distancia, poblacion, municipios from departamentos
select * from departamentos
drop table departamentos

drop database prueba