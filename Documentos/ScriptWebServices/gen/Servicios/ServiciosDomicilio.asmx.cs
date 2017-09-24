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

public class ServiciosDomicilio  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionDomicilio gestionDomicilio;
	
		
	public ServiciosDomicilio() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionDomicilio = new GestionDomicilio();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Domicilio))]
	public Domicilio crearDomicilio(Domicilio obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionDomicilio.crearDomicilio(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool editarDomicilio(Domicilio obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionDomicilio.editarDomicilio(obj);
            return false; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Domicilio))]
	public Domicilio buscarPrimeroDomicilio(Domicilio obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionDomicilio.buscarPrimeroDomicilio(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Domicilio))]
	public Domicilio[] buscarDomicilio(Domicilio obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionDomicilio.buscarDomicilio(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Domicilio))]
	public Domicilio[] buscarPaginacionDomicilio(Domicilio obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionDomicilio.buscarDomicilio(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Domicilio))]
	public Domicilio[] listarDomicilio() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionDomicilio.listarDomicilio();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Domicilio))]
	public Domicilio[] listarPaginacionDomicilio(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionDomicilio.listarDomicilio(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaDomicilio(Domicilio obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionDomicilio.contarBusquedaDomicilio(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool eliminarDomicilio(Domicilio obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionDomicilio.eliminarDomicilio(obj);
        return false;
	}
}

}
