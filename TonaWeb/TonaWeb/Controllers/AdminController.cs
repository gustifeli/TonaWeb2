using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TonaWeb.Models;

namespace TONA.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult AddProduct()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult AddProducto(Producto producto)
        {
            var servProd = new ServiceProducto();
            servProd.CrearProducto(producto);
            return RedirectToAction("AddProduct", "Admin");
        }
        public ActionResult Admin()
        {
            return View();
        }
        

    }
}