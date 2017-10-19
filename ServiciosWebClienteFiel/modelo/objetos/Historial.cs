using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosWebClienteFiel.objetos{

[Serializable]

public partial class Historial {

	 public long ID_HISTORIAL {get;set;}
	 public long ID_CLIENTE {get;set;}
	 public long ID_IMAGEN {get;set;}
	 public long ID_HISTORIAL_DESCUENTO {get;set;}
	 public long ID_USUARIO {get;set;}
	 public DateTime FECHA {get;set;}
	 public DateTime HORA {get;set;}
	 public String NUM_FACTURA_VISITA {get;set;}
	 public long VALOR_FACTURA {get;set;}
	 public String ORIGEN {get;set;}
	 public String ESTADO {get;set;}

	}

}
