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

public class ServiciosDetalledomicilio  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionDetalledomicilio gestionDetalledomicilio;
	
		
	public ServiciosDetalledomicilio() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionDetalledomicilio = new GestionDetalledomicilio();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Detalledomicilio))]
	public Detalledomicilio crearDetalledomicilio(Detalledomicilio obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionDetalledomicilio.crearDetalledomicilio(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool editarDetalledomicilio(Detalledomicilio obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionDetalledomicilio.editarDetalledomicilio(obj);
            return false; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Detalledomicilio))]
	public Detalledomicilio buscarPrimeroDetalledomicilio(Detalledomicilio obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionDetalledomicilio.buscarPrimeroDetalledomicilio(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Detalledomicilio))]
	public Detalledomicilio[] buscarDetalledomicilio(Detalledomicilio obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionDetalledomicilio.buscarDetalledomicilio(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Detalledomicilio))]
	public Detalledomicilio[] buscarPaginacionDetalledomicilio(Detalledomicilio obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionDetalledomicilio.buscarDetalledomicilio(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Detalledomicilio))]
	public Detalledomicilio[] listarDetalledomicilio() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionDetalledomicilio.listarDetalledomicilio();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Detalledomicilio))]
	public Detalledomicilio[] listarPaginacionDetalledomicilio(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionDetalledomicilio.listarDetalledomicilio(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaDetalledomicilio(Detalledomicilio obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionDetalledomicilio.contarBusquedaDetalledomicilio(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool eliminarDetalledomicilio(Detalledomicilio obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionDetalledomicilio.eliminarDetalledomicilio(obj);
        return false;
	}
}

}
