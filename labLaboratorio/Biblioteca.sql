create database Biblioteca



create table Areas(
areCodigo varchar(30) primary key,
areNombre varchar(30) not null,
areTiempo varchar(30) not null

) 

create table Usuarios(
usuDocumento varchar(30) primary key,
usuNombre varchar(30) not null,
usuDireccion varchar(30) not null,
usuTelefono varchar(10) not null,
usuCorreo varchar(30) not null,
usuEstado varchar(30) not null

) 


create table Prestamos(
preCodigo varchar(30)  primary key,
facFecha Date not null,
preUsuario varchar(30) foreign key references Usuarios(usuDocumento)
)


create table Sanciones(
sanCodigo varchar(30)  primary key,
sanPrestamo varchar(30) foreign key references Prestamos(preCodigo),
sanDiasSancion int not null,
sanFehaInicio date not null,
sanFechaFin date not null
)

create table libros(
libCodigo varchar(30) primary key,
libNombre varchar(30) not null,
libNumPag int not null,
libEditorial varchar(30) not null,
libArea varchar(30) foreign key references Areas(areCodigo)
)

create table DetallePrestamo(
dtpPrestamo varchar(30) foreign key  references Prestamos(preCodigo),
dtpLibro varchar(30) foreign key references Libros(libCodigo),
dtpCantidad int not null,
dtpFechaFin Date not null,
dtpFechaDev Date,
primary key(dtpPrestamo,dtpLibro)
)