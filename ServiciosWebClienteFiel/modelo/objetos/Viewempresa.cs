using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosWebClienteFiel.objetos{

[Serializable]

public partial class Viewempresa {

	 public long ID_EMPRESA {get;set;}
	 public long ID_MUNICIPIO {get;set;}
	 public long ID_IMAGEN {get;set;}
	 public String NIT {get;set;}
	 public String RAZON_SOCIAL {get;set;}
	 public String DIRECCION_CLIENTE {get;set;}
	 public String TELEFONO {get;set;}
	 public String SLOGAN {get;set;}
	 public String LATITUD {get;set;}
	 public String LONGITUD {get;set;}
	 public String SUCURSAL {get;set;}
	 public String NOM_MUNICIPIO {get;set;}
	 public byte[] IMAGEN {get;set;}

	}

}
