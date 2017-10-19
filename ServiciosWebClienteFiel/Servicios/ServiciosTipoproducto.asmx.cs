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

public class ServiciosTipoproducto  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionTipoproducto gestionTipoproducto;
	
		
	public ServiciosTipoproducto() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionTipoproducto = new GestionTipoproducto();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tipoproducto))]
	public TipoProductoResponse crearTipoproducto(Tipoproducto obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionTipoproducto.crearTipoproducto(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public TipoProductoResponse editarTipoproducto(Tipoproducto obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionTipoproducto.editarTipoproducto(obj);
            return null; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tipoproducto))]
	public Tipoproducto buscarPrimeroTipoproducto(Tipoproducto obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionTipoproducto.buscarPrimeroTipoproducto(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tipoproducto))]
	public Tipoproducto[] buscarTipoproducto(Tipoproducto obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionTipoproducto.buscarTipoproducto(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tipoproducto))]
	public Tipoproducto[] buscarPaginacionTipoproducto(Tipoproducto obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionTipoproducto.buscarTipoproducto(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tipoproducto))]
	public Tipoproducto[] listarTipoproducto() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionTipoproducto.listarTipoproducto();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tipoproducto))]
	public Tipoproducto[] listarPaginacionTipoproducto(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionTipoproducto.listarTipoproducto(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaTipoproducto(Tipoproducto obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionTipoproducto.contarBusquedaTipoproducto(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public TipoProductoResponse eliminarTipoproducto(Tipoproducto obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionTipoproducto.eliminarTipoproducto(obj);
            return null;
	}
}

}
