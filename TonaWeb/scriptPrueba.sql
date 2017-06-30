select * from Producto
insert into Producto(descripcion, imagen, idCampana)
values('descripcion', 'C:\Users\gusti\OneDrive\Documentos', 1);

select * from  Producto p, Campana c where  c.idCampana = 1 