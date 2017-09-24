using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;
using System.Web.Services.Protocols;

using ServiciosWebClienteFiel.objetos;
using ServiciosWebClienteFiel.gestion;
using ServiciosWebClienteFiel.ObjectsResponse;

namespace ServiciosWebClienteFiel.Servicios  {

/// <summary>
/// Descripción breve de ServicioClase
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.ComponentModel.ToolboxItem(false)]
// Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]

public class ServiciosError  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionError gestionError;
	
		
	public ServiciosError() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionError = new GestionError();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Error))]
	public ErrorResponse crearError(Error obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionError.crearError(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public ErrorResponse editarError(Error obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionError.editarError(obj);
            return null; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Error))]
	public Error buscarPrimeroError(Error obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionError.buscarPrimeroError(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Error))]
	public Error[] buscarError(Error obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionError.buscarError(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Error))]
	public Error[] buscarPaginacionError(Error obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionError.buscarError(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Error))]
	public Error[] listarError() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionError.listarError();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Error))]
	public Error[] listarPaginacionError(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionError.listarError(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaError(Error obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionError.contarBusquedaError(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public ErrorResponse eliminarError(Error obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionError.eliminarError(obj);
        return null;
	}
}

}
