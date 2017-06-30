using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TonaWeb.Models
{
    public class ServiceProducto
    {
        public void CrearProducto(TonaWeb.Models.Producto producto)
        {
            var db = new BaseDatosDataContext();
            db.Producto.InsertOnSubmit(new TonaWeb.Producto()
            {

                descripcion = producto.Descripcion,
                imagen = producto.Imagen,
                //idCampana = producto.IdCamp,
            });
            db.SubmitChanges();
        }
    }
}