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

public class ServiciosMunicipio  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionMunicipio gestionMunicipio;
	
		
	public ServiciosMunicipio() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionMunicipio = new GestionMunicipio();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Municipio))]
	public Municipio crearMunicipio(Municipio obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionMunicipio.crearMunicipio(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool editarMunicipio(Municipio obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionMunicipio.editarMunicipio(obj);
            return false; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Municipio))]
	public Municipio buscarPrimeroMunicipio(Municipio obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionMunicipio.buscarPrimeroMunicipio(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Municipio))]
	public Municipio[] buscarMunicipio(Municipio obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionMunicipio.buscarMunicipio(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Municipio))]
	public Municipio[] buscarPaginacionMunicipio(Municipio obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionMunicipio.buscarMunicipio(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Municipio))]
	public Municipio[] listarMunicipio() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionMunicipio.listarMunicipio();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Municipio))]
	public Municipio[] listarPaginacionMunicipio(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionMunicipio.listarMunicipio(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaMunicipio(Municipio obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionMunicipio.contarBusquedaMunicipio(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool eliminarMunicipio(Municipio obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionMunicipio.eliminarMunicipio(obj);
        return false;
	}
}

}
