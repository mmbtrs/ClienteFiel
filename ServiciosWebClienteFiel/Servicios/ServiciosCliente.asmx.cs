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

public class ServiciosCliente  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionCliente gestionCliente;
	
		
	public ServiciosCliente() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionCliente = new GestionCliente();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Cliente))]
	public Cliente crearCliente(Cliente obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionCliente.crearCliente(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool editarCliente(Cliente obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionCliente.editarCliente(obj);
            return false; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Cliente))]
	public Cliente buscarPrimeroCliente(Cliente obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionCliente.buscarPrimeroCliente(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Cliente))]
	public Cliente[] buscarCliente(Cliente obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionCliente.buscarCliente(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Cliente))]
	public Cliente[] buscarPaginacionCliente(Cliente obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionCliente.buscarCliente(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Cliente))]
	public Cliente[] listarCliente() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionCliente.listarCliente();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Cliente))]
	public Cliente[] listarPaginacionCliente(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionCliente.listarCliente(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaCliente(Cliente obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionCliente.contarBusquedaCliente(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool eliminarCliente(Cliente obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionCliente.eliminarCliente(obj);
        return false;
	}
}

}
