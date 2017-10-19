using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosWebClienteFiel.objetos{

[Serializable]

public partial class Viewproducto {

	 public long ID_PRODUCTO {get;set;}
	 public long ID_IMAGEN {get;set;}
	 public long ID_TIPO_PRODUCTO {get;set;}
	 public long ID_EMPRESA {get;set;}
	 public String NOM_PRODUCTO {get;set;}
	 public long PRECIO {get;set;}
	 public String DESCRIPCION {get;set;}
	 public String IMAGEN {get;set;}
	 public String NOM_TIPO_PRODUCTO {get;set;}
	 public String NIT {get;set;}
	 public String RAZON_SOCIAL {get;set;}
	 public String SUCURSAL {get;set;}

	}

}
