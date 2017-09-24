using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosWebClienteFiel.objetos{

[Serializable]

public partial class Domicilio {

	 public long ID_DOMICILIO {get;set;}
	 public long ID_CLIENTE {get;set;}
	 public long ID_USUARIO {get;set;}
	 public DateTime FECHA_DOMICILIO {get;set;}
	 public DateTime HORA_DOMICILIO {get;set;}
	 public DateTime FECHA_VERIFICACION {get;set;}
	 public DateTime HORA_VERIFICACION {get;set;}
	 public String DIRECCION {get;set;}
	 public String TELEFONO {get;set;}
	 public String BARRIO {get;set;}
	 public String ESTADO {get;set;}
	 public String OBSERVACIONES {get;set;}
	 public long TOTAL {get;set;}

	}

}
