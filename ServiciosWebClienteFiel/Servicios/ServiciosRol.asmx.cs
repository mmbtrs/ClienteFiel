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

public class ServiciosRol  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionRol gestionRol;
	
		
	public ServiciosRol() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionRol = new GestionRol();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Rol))]
	public Rol crearRol(Rol obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionRol.crearRol(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool editarRol(Rol obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionRol.editarRol(obj);
            return false; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Rol))]
	public Rol buscarPrimeroRol(Rol obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionRol.buscarPrimeroRol(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Rol))]
	public Rol[] buscarRol(Rol obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionRol.buscarRol(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Rol))]
	public Rol[] buscarPaginacionRol(Rol obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionRol.buscarRol(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Rol))]
	public Rol[] listarRol() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionRol.listarRol();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Rol))]
	public Rol[] listarPaginacionRol(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionRol.listarRol(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaRol(Rol obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionRol.contarBusquedaRol(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool eliminarRol(Rol obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionRol.eliminarRol(obj);
        return false;
	}
}

}
