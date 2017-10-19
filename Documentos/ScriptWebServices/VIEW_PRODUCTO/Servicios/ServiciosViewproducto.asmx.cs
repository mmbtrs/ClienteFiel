using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;
using System.Web.Services.Protocols;

using ServiciosWebClienteFiel.objetos;
using ServiciosWebClienteFiel.gestion;


namespace ServiciosWebClienteFiel.Servicios  {

/// <summary>
/// Descripción breve de ServicioClase
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.ComponentModel.ToolboxItem(false)]
// Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]

public class ServiciosViewproducto  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionViewproducto gestionViewproducto;
	
		
	public ServiciosViewproducto() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionViewproducto = new GestionViewproducto();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Viewproducto))]
	public Viewproducto crearViewproducto(Viewproducto obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionViewproducto.crearViewproducto(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool editarViewproducto(Viewproducto obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionViewproducto.editarViewproducto(obj);
            return false; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Viewproducto))]
	public Viewproducto buscarPrimeroViewproducto(Viewproducto obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionViewproducto.buscarPrimeroViewproducto(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Viewproducto))]
	public Viewproducto[] buscarViewproducto(Viewproducto obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionViewproducto.buscarViewproducto(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Viewproducto))]
	public Viewproducto[] buscarPaginacionViewproducto(Viewproducto obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionViewproducto.buscarViewproducto(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Viewproducto))]
	public Viewproducto[] listarViewproducto() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionViewproducto.listarViewproducto();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Viewproducto))]
	public Viewproducto[] listarPaginacionViewproducto(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionViewproducto.listarViewproducto(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaViewproducto(Viewproducto obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionViewproducto.contarBusquedaViewproducto(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool eliminarViewproducto(Viewproducto obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionViewproducto.eliminarViewproducto(obj);
        return false;
	}
}

}
