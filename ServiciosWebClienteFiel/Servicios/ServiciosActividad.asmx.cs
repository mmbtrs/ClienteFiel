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

public class ServiciosActividad  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionActividad gestionActividad;
	
		
	public ServiciosActividad() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionActividad = new GestionActividad();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Actividad))]
	public Actividad crearActividad(Actividad obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionActividad.crearActividad(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool editarActividad(Actividad obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionActividad.editarActividad(obj);
            return false; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Actividad))]
	public Actividad buscarPrimeroActividad(Actividad obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionActividad.buscarPrimeroActividad(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Actividad))]
	public Actividad[] buscarActividad(Actividad obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionActividad.buscarActividad(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Actividad))]
	public Actividad[] buscarPaginacionActividad(Actividad obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionActividad.buscarActividad(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Actividad))]
	public Actividad[] listarActividad() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionActividad.listarActividad();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Actividad))]
	public Actividad[] listarPaginacionActividad(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionActividad.listarActividad(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaActividad(Actividad obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionActividad.contarBusquedaActividad(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool eliminarActividad(Actividad obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionActividad.eliminarActividad(obj);
        return false;
	}
}

}
