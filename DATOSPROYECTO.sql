Create Database DATOSPROYECTO;

Use DATOSPROYECTO;
Go

Create Table Donantes1 (Id_Donante int primary key identity,
Nombre varchar(50) not null,
Edad int,
Direcci�n varchar(50),
Tel�fono int,
GrupoSangu�neo varchar(10),
Genero varchar(10),
)
Create Table Cuenta
(Id_Cuenta int primary key,
donaci�n int,
fk_donante int foreign key references Donantes1(Id_Donante) )

insert into Donantes1 (Id_Donante,Nombre,Edad,Direcci�n,Tel�fono,GrupoSangu�neo,G�nero) values
(1,'Roberto','37','Barrio El Calvario','23012426','AB+','M')
insert into Donantes1 (Id_Donante,Nombre,Edad,Direcci�n,Tel�fono,GrupoSangu�neo,G�nero) values
(2,'Paola','19','Av. La Sierpe','23013331','A+','F')
insert into Donantes1 (Id_Donante,Nombre,Edad,Direcci�n,Tel�fono,GrupoSangu�neo,G�nero) values
(3,'Estefany','23','Barrio San Antonio','23019883','O-','F')
insert into Donantes1 (Id_Donante,Nombre,Edad,Direcci�n,Tel�fono,GrupoSangu�neo,G�nero) values
(4,'Julio','20','Barrio Moraz�n','23012676','B+','M')
insert into Donantes1 (Id_Donante,Nombre,Edad,Direcci�n,Tel�fono,GrupoSangu�neo,G�nero) values
(5,'Myke','26','Dulce Nombre','23032012','A+','F')
insert into Donantes1 (Id_Donante,Nombre,Edad,Direcci�n,Tel�fono,GrupoSangu�neo,G�nero) values
(6,'Gisselle','35','Av. Colonias','22204943','A-','F')
insert into Donantes1 (Id_Donante,Nombre,Edad,Direcci�n,Tel�fono,GrupoSangu�neo,G�nero) values
(7,'Pedro','42','Av. Colonias','22202189','B+','M')
insert into Donantes1 (Id_Donante,Nombre,Edad,Direcci�n,Tel�fono,GrupoSangu�neo,G�nero) values
(8,'Mar�a','55','Av. Monte Piedad','23013256','A+','F')
insert into Donantes1 (Id_Donante,Nombre,Edad,Direcci�n,Tel�fono,GrupoSangu�neo,G�nero) values
(9,'Victoria','46','Av. Centro','23018933','A-','F')


Select * from Donantes1
Select * from Cuenta