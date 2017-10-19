using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosWebClienteFiel.objetos{

[Serializable]

public partial class Top {

	 public long ID_TOP {get;set;}
	 public long ID_EMPRESA {get;set;}
	 public long ID_IMAGEN {get;set;}
	 public String NOM_TOP {get;set;}
	 public String URL {get;set;}

	}

}
