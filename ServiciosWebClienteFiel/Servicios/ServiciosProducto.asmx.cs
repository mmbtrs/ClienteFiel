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

public class ServiciosProducto  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionProducto gestionProducto;
	
		
	public ServiciosProducto() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionProducto = new GestionProducto();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Producto))]
	public ProductoResponse crearProducto(Producto obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionProducto.crearProducto(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public ProductoResponse editarProducto(Producto obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionProducto.editarProducto(obj);
            return null; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Producto))]
	public Producto buscarPrimeroProducto(Producto obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionProducto.buscarPrimeroProducto(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Producto))]
	public Producto[] buscarProducto(Producto obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionProducto.buscarProducto(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Producto))]
	public Producto[] buscarPaginacionProducto(Producto obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionProducto.buscarProducto(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Producto))]
	public Producto[] listarProducto() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionProducto.listarProducto();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Producto))]
	public Producto[] listarPaginacionProducto(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionProducto.listarProducto(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaProducto(Producto obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionProducto.contarBusquedaProducto(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public ProductoResponse eliminarProducto(Producto obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionProducto.eliminarProducto(obj);
        return null;
	}
}

}
