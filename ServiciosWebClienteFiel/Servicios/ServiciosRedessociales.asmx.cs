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

public class ServiciosRedessociales  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionRedessociales gestionRedessociales;
	
		
	public ServiciosRedessociales() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionRedessociales = new GestionRedessociales();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Redessociales))]
	public Redessociales crearRedessociales(Redessociales obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionRedessociales.crearRedessociales(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool editarRedessociales(Redessociales obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionRedessociales.editarRedessociales(obj);
            return false; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Redessociales))]
	public Redessociales buscarPrimeroRedessociales(Redessociales obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionRedessociales.buscarPrimeroRedessociales(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Redessociales))]
	public Redessociales[] buscarRedessociales(Redessociales obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionRedessociales.buscarRedessociales(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Redessociales))]
	public Redessociales[] buscarPaginacionRedessociales(Redessociales obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionRedessociales.buscarRedessociales(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Redessociales))]
	public Redessociales[] listarRedessociales() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionRedessociales.listarRedessociales();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Redessociales))]
	public Redessociales[] listarPaginacionRedessociales(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionRedessociales.listarRedessociales(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaRedessociales(Redessociales obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionRedessociales.contarBusquedaRedessociales(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool eliminarRedessociales(Redessociales obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionRedessociales.eliminarRedessociales(obj);
        return false;
	}
}

}
