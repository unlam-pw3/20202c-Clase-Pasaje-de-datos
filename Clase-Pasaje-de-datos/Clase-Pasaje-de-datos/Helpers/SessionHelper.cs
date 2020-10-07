using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase_Pasaje_de_datos.Helpers
{
    public static class SessionHelper
    {
        public static List<Serie> SeriesRecomendadas
        {
            get
            {
                if (HttpContext.Current.Session["SeriesRecomendadas"] == null)
                {
                    HttpContext.Current.Session["SeriesRecomendadas"] = new List<Serie>();
                }

                return (List<Serie>) HttpContext.Current.Session["SeriesRecomendadas"];
            }

            set
            {
                HttpContext.Current.Session["SeriesRecomendadas"] = value;
            }
        }

        public static List<string> MisSeriesFavoritas
        {
            get
            {
                if (HttpContext.Current.Session["MisSeriesFavoritas"] == null)
                {
                    HttpContext.Current.Session["MisSeriesFavoritas"] = new List<string>();
                }

                return (List<string>)HttpContext.Current.Session["MisSeriesFavoritas"];
            }

            set
            {
                HttpContext.Current.Session["MisSeriesFavoritas"] = value;
            }
        }
    }
}