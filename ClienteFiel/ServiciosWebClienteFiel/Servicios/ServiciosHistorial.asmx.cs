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

public class ServiciosHistorial  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionHistorial gestionHistorial;
	
		
	public ServiciosHistorial() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionHistorial = new GestionHistorial();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Historial))]
	public Historial crearHistorial(Historial obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionHistorial.crearHistorial(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool editarHistorial(Historial obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionHistorial.editarHistorial(obj);
            return false; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Historial))]
	public Historial buscarPrimeroHistorial(Historial obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionHistorial.buscarPrimeroHistorial(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Historial))]
	public Historial[] buscarHistorial(Historial obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionHistorial.buscarHistorial(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Historial))]
	public Historial[] buscarPaginacionHistorial(Historial obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionHistorial.buscarHistorial(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Historial))]
	public Historial[] listarHistorial() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionHistorial.listarHistorial();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Historial))]
	public Historial[] listarPaginacionHistorial(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionHistorial.listarHistorial(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaHistorial(Historial obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionHistorial.contarBusquedaHistorial(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool eliminarHistorial(Historial obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionHistorial.eliminarHistorial(obj);
        return false;
	}
}

}
