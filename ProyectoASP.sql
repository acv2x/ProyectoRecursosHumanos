CREATE DATABASE ProyectoASP

USE ProyectoASP

CREATE TABLE Empleados(
ID_EMP int not null IDENTITY primary key,
CodigoEmpleado nvarchar(50) not null,
Nombre nvarchar(50),
Apellido nvarchar(50),
Telefono nvarchar(50),
ID_DEP int,
ID_CAR int,
FechaIngreso nvarchar(50),
Salario nvarchar(50),
Estatus nvarchar(50)
)

CREATE TABLE Departamentos(
ID_DEP int not null IDENTITY primary key,
Codigo nvarchar(50),
Departamento nvarchar(50)
)

CREATE TABLE Cargos(
ID_CAR int IDENTITY Primary Key,
Cargo nvarchar(50)
)

CREATE TABLE Nominas(
ID_NOM int not null IDENTITY primary key,
Año int,
Mes nvarchar(15),
MontoTotal nvarchar(50),
)

CREATE TABLE Salidas(
ID_SAL int not null IDENTITY Primary Key,
ID_EMP int,
TipoSalida nvarchar(50),
Motivo nvarchar(500),
FechaSalida nvarchar(50)
)

CREATE TABLE Vacaciones(
ID_VAC int not null IDENTITY Primary Key,
ID_EMP int,
Desde nvarchar(50),
Hasta nvarchar(50),
CorrespondienteA int,
Comentario nvarchar(500)
)

CREATE TABLE Permisos(
ID_PER int not null IDENTITY Primary Key,
ID_EMP int,
Desde nvarchar(50),
Hasta nvarchar(50),
Comentario nvarchar(500)
)

CREATE TABLE Licencias(
ID_LIC int not null IDENTITY Primary Key,
ID_EMP int,
Desde nvarchar(50),
Hasta nvarchar(50),
Motivo nvarchar(500),
Comentario nvarchar(500)
)

/*1ER PROCEDIMIENTO*/
CREATE PROCEDURE Empleados_Activos
@Nombre nvarchar(50),
@Departamento int
as 
BEGIN 
	SELECT * FROM Empleados WHERE Estatus= 'Activo' AND Nombre = @Nombre OR ID_DEP = @Departamento
END

/* 2do procedimiento*/

CREATE PROCEDURE Empleados_Inactivos
as
BEGIN
	SELECT * FROM Empleados WHERE Estatus = 'Inactivo' 
END

/* 3ro procedimiento*/
CREATE PROCEDURE PROC_Departamento
as
BEGIN 
	SELECT * FROM Departamentos
END

/* 4T0 procedimiento*/
CREATE PROCEDURE PROC_Cargos
as
BEGIN	
	SELECT * FROM Cargos
END

/* 5T0 procedimiento*/
CREATE PROCEDURE PROC_EMPLEADOporMES
@Mes nvarchar(50)
as
BEGIN 
	SELECT * FROM Empleados WHERE FechaIngreso LIKE '%'+(@Mes)+'%'
END


/* 6T0 procedimiento*/
CREATE PROCEDURE Proc_SalidasMES
@Mes nvarchar(50)
as
BEGIN 
	SELECT * FROM Salidas WHERE FechaSalida LIKE '%'+(@Mes)+'%'
END

/* 7MO PROCEDIMIENTO*/
CREATE PROCEDURE Proc_PermisosEMP
@IDEMP NVARCHAR(10)
as
BEGIN
	SELECT * FROM Permisos WHERE ID_EMP = @IDEMP
END

/* 8VO PROCEDIMIENTO*/
CREATE PROCEDURE BuscaNomina
@año nvarchar(15),
@mes nvarchar(15)
as
BEGIN
	SELECT * FROM Nominas WHERE Año = @año or Mes = @mes
END






