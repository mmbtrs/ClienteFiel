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

public class ServiciosDepartamento  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionDepartamento gestionDepartamento;
	
		
	public ServiciosDepartamento() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionDepartamento = new GestionDepartamento();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Departamento))]
	public DepartamentoResponse crearDepartamento(Departamento obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionDepartamento.crearDepartamento(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public DepartamentoResponse editarDepartamento(Departamento obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionDepartamento.editarDepartamento(obj);
            return null; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Departamento))]
	public Departamento buscarPrimeroDepartamento(Departamento obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionDepartamento.buscarPrimeroDepartamento(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Departamento))]
	public Departamento[] buscarDepartamento(Departamento obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionDepartamento.buscarDepartamento(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Departamento))]
	public Departamento[] buscarPaginacionDepartamento(Departamento obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionDepartamento.buscarDepartamento(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Departamento))]
	public Departamento[] listarDepartamento() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionDepartamento.listarDepartamento();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Departamento))]
	public Departamento[] listarPaginacionDepartamento(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionDepartamento.listarDepartamento(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaDepartamento(Departamento obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionDepartamento.contarBusquedaDepartamento(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public DepartamentoResponse eliminarDepartamento(Departamento obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionDepartamento.eliminarDepartamento(obj);
        return null;
	}
}

}
