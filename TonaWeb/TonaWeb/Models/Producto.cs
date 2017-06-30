using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TonaWeb.Models
{
    public class Producto
    {
       
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public byte[] Imagen { get; set; }
        public int IdCamp { get; set; }
    }
}