Create Database DATOSPROYECTO;

Use DATOSPROYECTO;
Go

Create Table Donantes1 (Id_Donante int primary key identity,
Nombre varchar(50) not null,
GrupoSangu�neo varchar(50)
Cent�metrosC�bicos int,
Direcci�n varchar(50),
Tel�fono int,
)
Create Table Cuenta
(Id_Cuenta int primary key,
donaci�n int,
fk_donante int foreign key references Donantes1(Id_Donante) )

insert into Donantes1 (Id_Donante,Nombre,GrupoSangu�neo,Cent�metrosC�bicos,Direcci�n,Tel�fono) values
(1,'Roberto','AB+','450cc','Barrio El Calvario','23012423')
insert into Donantes1 (Id_Donante,Nombre,GrupoSangu�neo,Cent�metrosC�bicos,Direcci�n,Tel�fono) values
(2,'Paola','A+','450cc','Av. La Sierpe','23013333')
insert into Donantes1 (Id_Donante,Nombre,GrupoSangu�neo,Cent�metrosC�bicos,Direcci�n,Tel�fono) values
(3,'Estefany','O-','450cc','Barrio San Antonio','23019883')

insert into Cuenta (Id_Cuenta,donaci�n,fk_donante)
values (1,450,1);

insert into Cuenta (Id_Cuenta,donaci�n,fk_donante)
values (2,450,2)

insert into Cuenta (Id_Cuenta,donaci�n,fk_donante)
values (3,450,3)

Select * from Donantes1
Select * from Cuenta