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

public class ServiciosHistorialdescuento  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionHistorialdescuento gestionHistorialdescuento;
	
		
	public ServiciosHistorialdescuento() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionHistorialdescuento = new GestionHistorialdescuento();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Historialdescuento))]
	public Historialdescuento crearHistorialdescuento(Historialdescuento obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionHistorialdescuento.crearHistorialdescuento(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool editarHistorialdescuento(Historialdescuento obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionHistorialdescuento.editarHistorialdescuento(obj);
            return false; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Historialdescuento))]
	public Historialdescuento buscarPrimeroHistorialdescuento(Historialdescuento obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionHistorialdescuento.buscarPrimeroHistorialdescuento(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Historialdescuento))]
	public Historialdescuento[] buscarHistorialdescuento(Historialdescuento obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionHistorialdescuento.buscarHistorialdescuento(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Historialdescuento))]
	public Historialdescuento[] buscarPaginacionHistorialdescuento(Historialdescuento obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionHistorialdescuento.buscarHistorialdescuento(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Historialdescuento))]
	public Historialdescuento[] listarHistorialdescuento() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionHistorialdescuento.listarHistorialdescuento();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Historialdescuento))]
	public Historialdescuento[] listarPaginacionHistorialdescuento(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionHistorialdescuento.listarHistorialdescuento(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaHistorialdescuento(Historialdescuento obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionHistorialdescuento.contarBusquedaHistorialdescuento(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool eliminarHistorialdescuento(Historialdescuento obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionHistorialdescuento.eliminarHistorialdescuento(obj);
        return false;
	}
}

}
