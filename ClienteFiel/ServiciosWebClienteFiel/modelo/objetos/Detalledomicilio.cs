using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosWebClienteFiel.objetos{

[Serializable]

public partial class Detalledomicilio {

	 public long ID_DETALLE_DOMICILIO {get;set;}
	 public long ID_DOMICILIO {get;set;}
	 public long ID_PRODUCTO {get;set;}
	 public String OBSERVACION {get;set;}
	 public long CANTIDAD {get;set;}
	 public long SUBTOTAL {get;set;}

	}

}
