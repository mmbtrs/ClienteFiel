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

public class ServiciosTiporedsocial  : System.Web.Services.WebService {
	
	public Autenticacion autenticacion;	
	GestionTiporedsocial gestionTiporedsocial;
	
		
	public ServiciosTiporedsocial() {
		
		crearObjetos();
	}
	
	
    private void crearObjetos(){
		gestionTiporedsocial = new GestionTiporedsocial();
	
	}
	

	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tiporedsocial))]
	public TiporedsocialResponse crearTiporedsocial(Tiporedsocial obj) {
	       if (autenticacion != null && autenticacion.esValido()) 
				return gestionTiporedsocial.crearTiporedsocial(obj); 
           return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public TiporedsocialResponse editarTiporedsocial(Tiporedsocial obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionTiporedsocial.editarTiporedsocial(obj);
            return null; 
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tiporedsocial))]
	public Tiporedsocial buscarPrimeroTiporedsocial(Tiporedsocial obj) {
			if (autenticacion != null && autenticacion.esValido()) 
				return gestionTiporedsocial.buscarPrimeroTiporedsocial(obj);
            return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tiporedsocial))]
	public Tiporedsocial[] buscarTiporedsocial(Tiporedsocial obj) {
	   if (autenticacion != null && autenticacion.esValido()) 
    		return gestionTiporedsocial.buscarTiporedsocial(obj);
       return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tiporedsocial))]
	public Tiporedsocial[] buscarPaginacionTiporedsocial(Tiporedsocial obj,int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
				return gestionTiporedsocial.buscarTiporedsocial(obj, pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tiporedsocial))]
	public Tiporedsocial[] listarTiporedsocial() {
	    if (autenticacion != null && autenticacion.esValido()) 
		      return gestionTiporedsocial.listarTiporedsocial();
	    return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	[XmlInclude(typeof(Tiporedsocial))]
	public Tiporedsocial[] listarPaginacionTiporedsocial(int pag,int numReg) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionTiporedsocial.listarTiporedsocial(pag, numReg);
		return null;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public int contarBusquedaTiporedsocial(Tiporedsocial obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionTiporedsocial.contarBusquedaTiporedsocial(obj);
        return -1;
	}
	
	[WebMethod]
	[SoapHeader("autenticacion")]
	public TiporedsocialResponse eliminarTiporedsocial(Tiporedsocial obj) {
		if (autenticacion != null && autenticacion.esValido()) 
			return gestionTiporedsocial.eliminarTiporedsocial(obj);
        return null;
	}
}

}
