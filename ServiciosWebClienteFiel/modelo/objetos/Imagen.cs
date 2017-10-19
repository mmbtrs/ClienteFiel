using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosWebClienteFiel.objetos{

[Serializable]

public partial class Imagen {

	 public long ID_IMAGEN {get;set;}
	 public String RUTA {get;set;}
	 public byte[] IMAGEN {get;set;}

	}

}
