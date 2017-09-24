using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWebClienteFiel.ObjectsResponse
{
    public abstract class Response
    {
        public bool correcto;
        public string error;
        public string numero;
    }
}