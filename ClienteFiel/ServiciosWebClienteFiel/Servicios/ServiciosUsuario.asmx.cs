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

public class ServiciosUsuario  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionUsuario gestionUsuario;
	
		
	public ServiciosUsuario() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionUsuario = new GestionUsuario();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Usuario))]
	public Usuario crearUsuario(Usuario obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionUsuario.crearUsuario(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool editarUsuario(Usuario obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionUsuario.editarUsuario(obj);
            return false; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Usuario))]
	public Usuario buscarPrimeroUsuario(Usuario obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionUsuario.buscarPrimeroUsuario(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Usuario))]
	public Usuario[] buscarUsuario(Usuario obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionUsuario.buscarUsuario(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Usuario))]
	public Usuario[] buscarPaginacionUsuario(Usuario obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionUsuario.buscarUsuario(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Usuario))]
	public Usuario[] listarUsuario() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionUsuario.listarUsuario();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Usuario))]
	public Usuario[] listarPaginacionUsuario(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionUsuario.listarUsuario(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaUsuario(Usuario obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionUsuario.contarBusquedaUsuario(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool eliminarUsuario(Usuario obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionUsuario.eliminarUsuario(obj);
        return false;
	}
}

}
