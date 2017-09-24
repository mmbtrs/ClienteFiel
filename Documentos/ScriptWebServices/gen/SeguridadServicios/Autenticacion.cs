using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWebClienteFiel.Servicios
{
    public class Autenticacion : System.Web.Services.Protocols.SoapHeader
    {
        public string usuario { get; set; }
        public string contrasena { get; set; }

        public bool esValido()
        {
            return true;
        }

    }
}
