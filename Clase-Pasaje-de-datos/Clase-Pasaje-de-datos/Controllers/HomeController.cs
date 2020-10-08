using Clase_Pasaje_de_datos.Helpers;
using Clase_Pasaje_de_datos.Models;
using Entidades;
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
            CookiesHelper.AgregarPaginaVisitada("Index");
            return View();
        }

        public ActionResult Ejemplo_ViewBagViewData()
        {
            CookiesHelper.AgregarPaginaVisitada("Ejemplo_ViewBagViewData");

            ViewBag.FechaActual = DateTime.Now.ToString("dd-MM-yyyy");
            ViewData["HoraActual"] = DateTime.Now.ToString("hh-mm-ss");
            ViewData["FechaCompleta"] = DateTime.Now;

            return View();
        }

        public ActionResult Ejemplo_TempData()
        {
            CookiesHelper.AgregarPaginaVisitada("Ejemplo_TempData");
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
            CookiesHelper.AgregarPaginaVisitada("Ejemplo_TempDataRedirect");
            if (TempData["HoraActual"] == null)
            {
                //Si viene de un redirect donde se le asigno el valor de tempdata, va a ser distinto de null
                TempData["HoraActual"] = DateTime.Now.ToString("hh-mm-ss");
            }
            return View();
        }

        public ActionResult Ejemplo_ViewModel()
        {
            CookiesHelper.AgregarPaginaVisitada("Ejemplo_ViewModel");
            var usuarioActual = new UsuarioVM();
            usuarioActual.Id = 1;
            usuarioActual.NombreCompleto = "Atreyu";
            usuarioActual.FotoPerfil = "data:image/jpeg;base64,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";
            usuarioActual.Rol = "Actor ppal";

            return View(usuarioActual);
        }

        public ActionResult Ejemplo_Session(string id)
        {
            CookiesHelper.AgregarPaginaVisitada("Ejemplo_Session");
            if (!string.IsNullOrEmpty(id))
            {
                if (!SessionHelper.MisSeriesFavoritas.Contains(id))
                {
                    SessionHelper.MisSeriesFavoritas.Add(id);
                }
            }

            List<Serie> seriesRecomendadas = new List<Serie>();
            Serie serie1 = new Serie()
            {
                Nombre = "Modern Family",
                Plataformas = new List<Serie.Plataforma>() { Serie.Plataforma.Netflix }
            };
            seriesRecomendadas.Add(serie1);

            Serie serie2 = new Serie()
            {
                Nombre = "Cobra Kai",
                Plataformas = new List<Serie.Plataforma>() { Serie.Plataforma.Netflix }
            };
            seriesRecomendadas.Add(serie2);

            Serie serie3 = new Serie()
            {
                Nombre = "La Purga",
                Plataformas = new List<Serie.Plataforma>() { Serie.Plataforma.AmazonPrime }
            };
            seriesRecomendadas.Add(serie3);

            //Session["SeriesRecomendadas"] = seriesRecomendadas;
            SessionHelper.SeriesRecomendadas = seriesRecomendadas;

            return View();
        }

        public ActionResult Ejemplo_Cookies()
        {
            CookiesHelper.AgregarPaginaVisitada("Ejemplo_Cookies");
            
            return View();
        }


        public ActionResult Ejemplo_Cache()
        {
            CookiesHelper.AgregarPaginaVisitada("Ejemplo_Cache");
            if (CacheHelper.MisSeriesFavoritasCache.Count == 0)
            {
                Serie serie = new Serie() { Nombre = $"Breaking Bad Temporada {DateTime.Now.Second}" };
                CacheHelper.MisSeriesFavoritasCache.Add(serie);
            }
            
            return View();
        }
        [OutputCache(Duration = 10, VaryByParam = "none", VaryByCustom = "browser")]
        public ActionResult Ejemplo_OutputCache()
        {
            CookiesHelper.AgregarPaginaVisitada("Ejemplo_Cache");
            return View();
        }

        public ActionResult TablaGeneral()
        {
            CookiesHelper.AgregarPaginaVisitada("TablaGeneral");
            return View();
        }
    }
}