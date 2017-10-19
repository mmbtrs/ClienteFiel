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

public class ServiciosDescuento  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionDescuento gestionDescuento;
	
		
	public ServiciosDescuento() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionDescuento = new GestionDescuento();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Descuento))]
	public Descuento crearDescuento(Descuento obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionDescuento.crearDescuento(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool editarDescuento(Descuento obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionDescuento.editarDescuento(obj);
            return false; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Descuento))]
	public Descuento buscarPrimeroDescuento(Descuento obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionDescuento.buscarPrimeroDescuento(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Descuento))]
	public Descuento[] buscarDescuento(Descuento obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionDescuento.buscarDescuento(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Descuento))]
	public Descuento[] buscarPaginacionDescuento(Descuento obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionDescuento.buscarDescuento(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Descuento))]
	public Descuento[] listarDescuento() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionDescuento.listarDescuento();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Descuento))]
	public Descuento[] listarPaginacionDescuento(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionDescuento.listarDescuento(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaDescuento(Descuento obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionDescuento.contarBusquedaDescuento(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public bool eliminarDescuento(Descuento obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionDescuento.eliminarDescuento(obj);
        return false;
	}
}

}
