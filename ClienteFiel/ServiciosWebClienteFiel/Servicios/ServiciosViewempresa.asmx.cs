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

public class ServiciosViewempresa  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionViewempresa gestionViewempresa;
	
		
	public ServiciosViewempresa() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionViewempresa = new GestionViewempresa();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Viewempresa))]
	public Viewempresa crearViewempresa(Viewempresa obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionViewempresa.crearViewempresa(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool editarViewempresa(Viewempresa obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionViewempresa.editarViewempresa(obj);
            return false; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Viewempresa))]
	public Viewempresa buscarPrimeroViewempresa(Viewempresa obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionViewempresa.buscarPrimeroViewempresa(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Viewempresa))]
	public Viewempresa[] buscarViewempresa(Viewempresa obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionViewempresa.buscarViewempresa(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Viewempresa))]
	public Viewempresa[] buscarPaginacionViewempresa(Viewempresa obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionViewempresa.buscarViewempresa(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Viewempresa))]
	public Viewempresa[] listarViewempresa() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionViewempresa.listarViewempresa();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Viewempresa))]
	public Viewempresa[] listarPaginacionViewempresa(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionViewempresa.listarViewempresa(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaViewempresa(Viewempresa obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionViewempresa.contarBusquedaViewempresa(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool eliminarViewempresa(Viewempresa obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionViewempresa.eliminarViewempresa(obj);
        return false;
	}
}

}
