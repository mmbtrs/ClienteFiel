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

public class ServiciosTipoidentificacion  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionTipoidentificacion gestionTipoidentificacion;
	
		
	public ServiciosTipoidentificacion() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionTipoidentificacion = new GestionTipoidentificacion();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tipoidentificacion))]
	public Tipoidentificacion crearTipoidentificacion(Tipoidentificacion obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionTipoidentificacion.crearTipoidentificacion(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool editarTipoidentificacion(Tipoidentificacion obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionTipoidentificacion.editarTipoidentificacion(obj);
            return false; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tipoidentificacion))]
	public Tipoidentificacion buscarPrimeroTipoidentificacion(Tipoidentificacion obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionTipoidentificacion.buscarPrimeroTipoidentificacion(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tipoidentificacion))]
	public Tipoidentificacion[] buscarTipoidentificacion(Tipoidentificacion obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionTipoidentificacion.buscarTipoidentificacion(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tipoidentificacion))]
	public Tipoidentificacion[] buscarPaginacionTipoidentificacion(Tipoidentificacion obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionTipoidentificacion.buscarTipoidentificacion(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tipoidentificacion))]
	public Tipoidentificacion[] listarTipoidentificacion() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionTipoidentificacion.listarTipoidentificacion();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tipoidentificacion))]
	public Tipoidentificacion[] listarPaginacionTipoidentificacion(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionTipoidentificacion.listarTipoidentificacion(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaTipoidentificacion(Tipoidentificacion obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionTipoidentificacion.contarBusquedaTipoidentificacion(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool eliminarTipoidentificacion(Tipoidentificacion obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionTipoidentificacion.eliminarTipoidentificacion(obj);
        return false;
	}
}

}
