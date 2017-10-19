using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosWebClienteFiel.objetos{

[Serializable]

public partial class Actividad {

	 public long ID_ACTIVIDAD {get;set;}
	 public long ID_EMPRESA {get;set;}
	 public long ID_TIPO_ACTIVIDAD {get;set;}
	 public String NOM_ACTIVIDAD {get;set;}
	 public String DESCRIPCION {get;set;}
	 public DateTime FECHA_DESDE {get;set;}
	 public DateTime FECHA_HASTA {get;set;}
	 public String PUBLICADO {get;set;}

	}

}
