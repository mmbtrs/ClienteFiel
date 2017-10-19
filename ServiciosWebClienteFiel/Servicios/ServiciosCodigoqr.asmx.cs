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

public class ServiciosCodigoqr  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionCodigoqr gestionCodigoqr;
	
		
	public ServiciosCodigoqr() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionCodigoqr = new GestionCodigoqr();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Codigoqr))]
	public Codigoqr crearCodigoqr(Codigoqr obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionCodigoqr.crearCodigoqr(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool editarCodigoqr(Codigoqr obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionCodigoqr.editarCodigoqr(obj);
            return false; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Codigoqr))]
	public Codigoqr buscarPrimeroCodigoqr(Codigoqr obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionCodigoqr.buscarPrimeroCodigoqr(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Codigoqr))]
	public Codigoqr[] buscarCodigoqr(Codigoqr obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionCodigoqr.buscarCodigoqr(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Codigoqr))]
	public Codigoqr[] buscarPaginacionCodigoqr(Codigoqr obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionCodigoqr.buscarCodigoqr(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Codigoqr))]
	public Codigoqr[] listarCodigoqr() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionCodigoqr.listarCodigoqr();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Codigoqr))]
	public Codigoqr[] listarPaginacionCodigoqr(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionCodigoqr.listarCodigoqr(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaCodigoqr(Codigoqr obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionCodigoqr.contarBusquedaCodigoqr(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool eliminarCodigoqr(Codigoqr obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionCodigoqr.eliminarCodigoqr(obj);
        return false;
	}
}

}
