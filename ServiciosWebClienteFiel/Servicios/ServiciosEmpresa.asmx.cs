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

public class ServiciosEmpresa  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionEmpresa gestionEmpresa;
	
		
	public ServiciosEmpresa() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionEmpresa = new GestionEmpresa();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Empresa))]
	public EmpresaResponse crearEmpresa(Empresa obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionEmpresa.crearEmpresa(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public EmpresaResponse editarEmpresa(Empresa obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionEmpresa.editarEmpresa(obj);
            return null; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Empresa))]
	public Empresa buscarPrimeroEmpresa(Empresa obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionEmpresa.buscarPrimeroEmpresa(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Empresa))]
	public Empresa[] buscarEmpresa(Empresa obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionEmpresa.buscarEmpresa(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Empresa))]
	public Empresa[] buscarPaginacionEmpresa(Empresa obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionEmpresa.buscarEmpresa(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Empresa))]
	public Empresa[] listarEmpresa() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionEmpresa.listarEmpresa();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Empresa))]
	public Empresa[] listarPaginacionEmpresa(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionEmpresa.listarEmpresa(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaEmpresa(Empresa obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionEmpresa.contarBusquedaEmpresa(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public EmpresaResponse eliminarEmpresa(Empresa obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionEmpresa.eliminarEmpresa(obj);
        return null;
	}
}

}
