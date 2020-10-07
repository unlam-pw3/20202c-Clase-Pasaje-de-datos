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

        public ActionResult Ejemplo_TempData()
        {
            //los valores quedan guardados por un request extra
            if (TempData["HoraActual"] == null)
            {
                //Si viene de un redirect donde se le asigno el valor de tempdata, va a ser distinto de null
                TempData["HoraActual"] = DateTime.Now.ToString("hh-mm-ss");
            }

            return RedirectToAction("Ejemplo_TempDataRedirect");
        }

        public ActionResult Ejemplo_TempDataRedirect()
        {
            if (TempData["HoraActual"] == null)
            {
                //Si viene de un redirect donde se le asigno el valor de tempdata, va a ser distinto de null
                TempData["HoraActual"] = DateTime.Now.ToString("hh-mm-ss");
            }
            return View();
        }
    }
}