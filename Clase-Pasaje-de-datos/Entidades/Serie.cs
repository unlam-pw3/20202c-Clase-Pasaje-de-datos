using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Serie
    {
        public enum Plataforma
        {
            Netflix = 1,
            AmazonPrime = 2,
            HBO = 3,
            Disney = 4,
            Hulu = 5,
            Crunchyroll = 6
        }
       
        public string Nombre { get; set; }
        public List<Plataforma> Plataformas { get; set; }
    }
}
