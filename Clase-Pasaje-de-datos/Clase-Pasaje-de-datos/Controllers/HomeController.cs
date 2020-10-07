using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clase_Pasaje_de_datos.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ejemplo_ViewBagViewData()
        {
            ViewBag.FechaActual = DateTime.Now.ToString("dd-MM-yyyy");
            ViewData["HoraActual"] = DateTime.Now.ToString("hh-mm-ss");
            ViewData["FechaCompleta"] = DateTime.Now;

            return View();
        }
    }
}