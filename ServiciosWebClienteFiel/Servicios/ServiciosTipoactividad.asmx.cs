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

public class ServiciosTipoactividad  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionTipoactividad gestionTipoactividad;
	
		
	public ServiciosTipoactividad() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionTipoactividad = new GestionTipoactividad();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tipoactividad))]
	public TipoactividadResponse crearTipoactividad(Tipoactividad obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionTipoactividad.crearTipoactividad(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public TipoactividadResponse editarTipoactividad(Tipoactividad obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionTipoactividad.editarTipoactividad(obj);
            return null; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tipoactividad))]
	public Tipoactividad buscarPrimeroTipoactividad(Tipoactividad obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionTipoactividad.buscarPrimeroTipoactividad(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tipoactividad))]
	public Tipoactividad[] buscarTipoactividad(Tipoactividad obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionTipoactividad.buscarTipoactividad(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tipoactividad))]
	public Tipoactividad[] buscarPaginacionTipoactividad(Tipoactividad obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionTipoactividad.buscarTipoactividad(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tipoactividad))]
	public Tipoactividad[] listarTipoactividad() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionTipoactividad.listarTipoactividad();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tipoactividad))]
	public Tipoactividad[] listarPaginacionTipoactividad(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionTipoactividad.listarTipoactividad(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaTipoactividad(Tipoactividad obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionTipoactividad.contarBusquedaTipoactividad(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public TipoactividadResponse eliminarTipoactividad(Tipoactividad obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionTipoactividad.eliminarTipoactividad(obj);
        return null;
	}
}

}
