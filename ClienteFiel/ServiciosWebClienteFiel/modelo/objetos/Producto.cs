using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosWebClienteFiel.objetos{

[Serializable]

public partial class Producto {

	 public long ID_PRODUCTO {get;set;}
	 public long ID_IMAGEN {get;set;}
	 public long ID_TIPO_PRODUCTO {get;set;}
	 public long ID_EMPRESA {get;set;}
	 public String NOM_PRODUCTO {get;set;}
	 public long PRECIO {get;set;}
	 public String DESCRIPCION {get;set;}

	}

}
