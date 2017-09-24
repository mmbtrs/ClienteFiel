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

public class ServiciosRolopcion  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionRolopcion gestionRolopcion;
	
		
	public ServiciosRolopcion() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionRolopcion = new GestionRolopcion();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Rolopcion))]
	public Rolopcion crearRolopcion(Rolopcion obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionRolopcion.crearRolopcion(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool editarRolopcion(Rolopcion obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionRolopcion.editarRolopcion(obj);
            return false; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Rolopcion))]
	public Rolopcion buscarPrimeroRolopcion(Rolopcion obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionRolopcion.buscarPrimeroRolopcion(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Rolopcion))]
	public Rolopcion[] buscarRolopcion(Rolopcion obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionRolopcion.buscarRolopcion(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Rolopcion))]
	public Rolopcion[] buscarPaginacionRolopcion(Rolopcion obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionRolopcion.buscarRolopcion(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Rolopcion))]
	public Rolopcion[] listarRolopcion() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionRolopcion.listarRolopcion();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Rolopcion))]
	public Rolopcion[] listarPaginacionRolopcion(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionRolopcion.listarRolopcion(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaRolopcion(Rolopcion obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionRolopcion.contarBusquedaRolopcion(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool eliminarRolopcion(Rolopcion obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionRolopcion.eliminarRolopcion(obj);
        return false;
	}
}

}
