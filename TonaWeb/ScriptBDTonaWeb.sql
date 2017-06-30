create table Campana(
idCampana int identity(1,1) not null,
descripcion varchar(50)
constraint pk_camp primary key(idCampana)
)

create table Producto(
idProducto int identity(1,1) not null,
descripcion varchar(100),
imagen image not null,
idCampana int,
Constraint pk_prod primary key(idProducto),
Constraint fk_prod_Camp foreign key (idCampana) references Campana(idCampana)
)