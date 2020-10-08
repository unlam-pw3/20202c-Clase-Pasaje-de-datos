using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase_Pasaje_de_datos.Helpers
{
    public static class CookiesHelper
    {
        public static void AgregarPaginaVisitada(string nombre)
        {
            if (HttpContext.Current.Request.Cookies["PaginasVisitadas"] == null)
            {
                var cookie = new HttpCookie("PaginasVisitadas");
                cookie.Value = string.Join(",", new List<string>() { nombre });
                cookie.SameSite = SameSiteMode.Lax;
                HttpContext.Current.Response.Cookies.Add(cookie);
            }
            else
            {
                HttpCookie cookie = HttpContext.Current.Request.Cookies["PaginasVisitadas"];
                List<string> paginasVisitadas = cookie.Value.Split(',').ToList();
                paginasVisitadas.Add(nombre);

                cookie.Value = string.Join(",", paginasVisitadas);
                cookie.SameSite = SameSiteMode.Lax;
                HttpContext.Current.Response.Cookies.Remove("PaginasVisitadas");
                HttpContext.Current.Response.Cookies.Add(cookie);
            }
        }

        public static List<string> ObtenerPaginasVisitadas()
        {
            if (HttpContext.Current.Request.Cookies["PaginasVisitadas"] == null)
            {
                return new List<string>();
            }
            else
            {
                HttpCookie cookie = HttpContext.Current.Request.Cookies["PaginasVisitadas"];
                List<string> paginasVisitadas = cookie.Value.Split(',').ToList();

                return paginasVisitadas;
            }
        }
    }
}