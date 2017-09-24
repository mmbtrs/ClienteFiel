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

public class ServiciosImagen  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionImagen gestionImagen;
	
		
	public ServiciosImagen() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionImagen = new GestionImagen();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Imagen))]
	public Imagen crearImagen(Imagen obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionImagen.crearImagen(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool editarImagen(Imagen obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionImagen.editarImagen(obj);
            return false; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Imagen))]
	public Imagen buscarPrimeroImagen(Imagen obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionImagen.buscarPrimeroImagen(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Imagen))]
	public Imagen[] buscarImagen(Imagen obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionImagen.buscarImagen(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Imagen))]
	public Imagen[] buscarPaginacionImagen(Imagen obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionImagen.buscarImagen(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Imagen))]
	public Imagen[] listarImagen() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionImagen.listarImagen();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Imagen))]
	public Imagen[] listarPaginacionImagen(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionImagen.listarImagen(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaImagen(Imagen obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionImagen.contarBusquedaImagen(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool eliminarImagen(Imagen obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionImagen.eliminarImagen(obj);
        return false;
	}
}

}
