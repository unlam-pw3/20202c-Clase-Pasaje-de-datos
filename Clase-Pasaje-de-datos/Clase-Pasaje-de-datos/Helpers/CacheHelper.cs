using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase_Pasaje_de_datos.Helpers
{
    public static class CacheHelper
    { 

        public static List<Serie> MisSeriesFavoritasCache
        {
            get
            {
                if (HttpContext.Current.Cache["MisSeriesFavoritasCache"] == null)
                {
                    HttpContext.Current.Cache.Insert("MisSeriesFavoritasCache", new List<Serie>(), null, DateTime.Now.AddSeconds(20), new TimeSpan()) ;
                }

                return (List<Serie>)HttpContext.Current.Cache["MisSeriesFavoritasCache"];
            }

            set
            {
                HttpContext.Current.Cache.Insert("MisSeriesFavoritasCache", value, null, DateTime.Now.AddSeconds(20), new TimeSpan()) ;
            }
        }
    }
}