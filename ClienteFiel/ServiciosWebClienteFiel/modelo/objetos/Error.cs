using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosWebClienteFiel.objetos{

[Serializable]

public partial class Error {

	 public long ID_ERROR {get;set;}
	 public String ERROR {get;set;}
	 public String MENSAJE_PARA_USUARIO {get;set;}
	 public String POSIBLE_SOLUCION {get;set;}
     public String CAMPO_DE_BUSQUEDA { get; set; }

	}

}
