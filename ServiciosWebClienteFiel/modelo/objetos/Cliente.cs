using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosWebClienteFiel.objetos{

[Serializable]

public partial class Cliente {

	 public long ID_CLIENTE {get;set;}
	 public long ID_EMPRESA {get;set;}
	 public long ID_IMAGEN {get;set;}
	 public long ID_TIPO_IDENTIFICACION {get;set;}
	 public long ID_CODIGO_QR {get;set;}
	 public String IDENTIFICACION {get;set;}
	 public String NOMBRES {get;set;}
	 public String APELLIDOS {get;set;}
	 public String CORREO {get;set;}
	 public String DIRECCION_CLIENTE {get;set;}
	 public String TELEFONO {get;set;}
	 public DateTime FECHA_NACIMIENTO {get;set;}
	 public String SEXO {get;set;}

	}

}
