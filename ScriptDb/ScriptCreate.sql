--CREATE DATABASE ProyectoDiciembre

CREATE TABLE TipoIdentificacion (
	id INT IDENTITY(1, 101) PRIMARY KEY,
	tipoIdentificacion VARCHAR(3) NOT NULL
)

CREATE TABLE Personas (
	id INT IDENTITY(1, 1) PRIMARY KEY,
	nombres VARCHAR(50) NOT NULL,
	apellidos VARCHAR(50) NOT NULL,
	numeroIdentificacion VARCHAR(10) NOT NULL,
	email VARCHAR(50) NOT NULL,
	fechaCreacion DATETIME DEFAULT GETDATE(),
	tipoDocumento VARCHAR(3) NOT NULL,

	FOREIGN KEY (tipoDocumento) REFERENCES TipoIdentificacion(id)
)

CREATE TABLE Usuarios (
	id INT IDENTITY(1, 1) PRIMARY KEY,
	usuario INT
	pass VARCHAR()
	fechaCreacion DATETIME DEFAULT GETDATE()
)