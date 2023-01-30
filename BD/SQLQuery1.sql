CREATE DATABASE GA1;

USE GA1;

CREATE TABLE Escuela(
	nombre varchar(50) NOT NULL PRIMARY KEY,
	contraseña varchar(50) NOT NULL,
	rol varchar(50) NOT NULL
);

CREATE TABLE Alumno(
	id int NOT NULL PRIMARY KEY,
	nombre varchar(50) NOT NULL,
	correo varchar(50) NOT NULL,
	pais varchar(50) NOT NULL,
	numero varchar(50) NOT NULL
);

INSERT INTO Escuela VALUES('Cris', '123', 'Administrador')
INSERT INTO Escuela VALUES('Cristopher', '123', 'Usuario')
INSERT INTO Escuela VALUES('Secretaria', '123', 'Secretaria')

INSERT INTO Alumno VALUES(1, 'Cristopher Ramirez', 'cris@gmail.com', 'Guatemala', '27364912')

SELECT * FROM Escuela