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

public class ServiciosTop  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionTop gestionTop;
	
		
	public ServiciosTop() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionTop = new GestionTop();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Top))]
	public Top crearTop(Top obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionTop.crearTop(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool editarTop(Top obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionTop.editarTop(obj);
            return false; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Top))]
	public Top buscarPrimeroTop(Top obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionTop.buscarPrimeroTop(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Top))]
	public Top[] buscarTop(Top obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionTop.buscarTop(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Top))]
	public Top[] buscarPaginacionTop(Top obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionTop.buscarTop(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Top))]
	public Top[] listarTop() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionTop.listarTop();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Top))]
	public Top[] listarPaginacionTop(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionTop.listarTop(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaTop(Top obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionTop.contarBusquedaTop(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool eliminarTop(Top obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionTop.eliminarTop(obj);
        return false;
	}
}

}
