using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosWebClienteFiel.objetos{

[Serializable]

public partial class Descuento {

	 public long ID_DESCUENTO {get;set;}
	 public long ID_EMPRESA {get;set;}
	 public String NOM_DESCUENTO {get;set;}
	 public String DESCRIPCION {get;set;}
	 public DateTime FECHA_DESDE {get;set;}
	 public DateTime FECHA_FIN {get;set;}
	 public String FORMULA {get;set;}
	 public String PUBLICADO {get;set;}

	}

}
