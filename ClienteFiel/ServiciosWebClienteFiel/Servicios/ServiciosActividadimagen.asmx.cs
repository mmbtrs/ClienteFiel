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

public class ServiciosActividadimagen  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionActividadimagen gestionActividadimagen;
	
		
	public ServiciosActividadimagen() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionActividadimagen = new GestionActividadimagen();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Actividadimagen))]
	public Actividadimagen crearActividadimagen(Actividadimagen obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionActividadimagen.crearActividadimagen(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool editarActividadimagen(Actividadimagen obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionActividadimagen.editarActividadimagen(obj);
            return false; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Actividadimagen))]
	public Actividadimagen buscarPrimeroActividadimagen(Actividadimagen obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionActividadimagen.buscarPrimeroActividadimagen(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Actividadimagen))]
	public Actividadimagen[] buscarActividadimagen(Actividadimagen obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionActividadimagen.buscarActividadimagen(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Actividadimagen))]
	public Actividadimagen[] buscarPaginacionActividadimagen(Actividadimagen obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionActividadimagen.buscarActividadimagen(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Actividadimagen))]
	public Actividadimagen[] listarActividadimagen() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionActividadimagen.listarActividadimagen();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Actividadimagen))]
	public Actividadimagen[] listarPaginacionActividadimagen(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionActividadimagen.listarActividadimagen(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaActividadimagen(Actividadimagen obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionActividadimagen.contarBusquedaActividadimagen(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool eliminarActividadimagen(Actividadimagen obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionActividadimagen.eliminarActividadimagen(obj);
        return false;
	}
}

}
