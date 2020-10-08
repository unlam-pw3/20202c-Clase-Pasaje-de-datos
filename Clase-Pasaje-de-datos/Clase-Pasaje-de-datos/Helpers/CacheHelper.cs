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
                //https://docs.microsoft.com/es-es/dotnet/api/system.web.httpapplicationstate.lock?redirectedfrom=MSDN&view=netframework-4.8#System_Web_HttpApplicationState_Lock
                //en caso querer que ciertas operaciones sobre objetos compartidos en application se debe usar lock y unlock para mejorar la eficiencia
                HttpContext.Current.Application.Lock();

                if (HttpContext.Current.Cache["MisSeriesFavoritasCache"] == null)
                {
                    HttpContext.Current.Cache.Insert("MisSeriesFavoritasCache", new List<Serie>(), null, DateTime.Now.AddSeconds(20), new TimeSpan()) ;
                }
                List<Serie> series = (List<Serie>)HttpContext.Current.Cache["MisSeriesFavoritasCache"];

                HttpContext.Current.Application.UnLock();

                return series;

            }

            set
            {
                HttpContext.Current.Application.Lock();
                HttpContext.Current.Cache.Insert("MisSeriesFavoritasCache", value, null, DateTime.Now.AddSeconds(20), new TimeSpan()) ;
                HttpContext.Current.Application.UnLock();
            }
        }
    }
}