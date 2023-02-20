create table Zahtevi(
Naziv_narucioca nvarchar(50) primary key not null,
datum nvarchar(50)  not null,
Pocetna_lokacija nvarchar(50) not null,
Krajnja_lokacija nvarchar(50) not null,

)
drop table Zahtevi
insert into Zahtevi values
insert into Zahtevi values('cao','124214','gg','kk')


create table Odobrenmi_zahtevi(
Naziv_narucioca nvarchar(50) not null,
datum nvarchar(50) not null,
Pocetna_lokacija nvarchar(50) not null,
Krajnja_lokacija nvarchar(50) not null,
datum_odobrenja nvarchar(50) not null,

)
delete from Zahtevi where Naziv_narucioca='cao'

create table Odbijeni_zahtevi(
Naziv_narucioca nvarchar(50) not null,
datum nvarchar(50) not null,
Pocetna_lokacija nvarchar(50) not null,
Krajnja_lokacija nvarchar(50) not null,
datum_odobrenja nvarchar(50) not null,

)


