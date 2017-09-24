using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosWebClienteFiel.objetos{

[Serializable]

public partial class Historialdescuento {

	 public long ID_HISTORIAL_DESCUENTO {get;set;}
	 public long ID_IMAGEN {get;set;}
	 public long ID_DESCUENTO {get;set;}
	 public long ID_USUARIO {get;set;}
	 public DateTime FECHA {get;set;}
	 public DateTime HORA {get;set;}
	 public String NUM_FACTURA {get;set;}

	}

}
