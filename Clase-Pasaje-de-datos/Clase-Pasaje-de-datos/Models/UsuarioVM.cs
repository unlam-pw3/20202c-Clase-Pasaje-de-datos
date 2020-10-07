using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase_Pasaje_de_datos.Models
{
    public class UsuarioVM
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Rol { get; set; }
        public string FotoPerfil { get; set; }
    }
}