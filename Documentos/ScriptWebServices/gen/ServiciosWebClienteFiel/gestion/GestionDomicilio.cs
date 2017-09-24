using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;

using AccesoDatos;

using ServiciosWebClienteFiel.dao;
using ServiciosWebClienteFiel.objetos;



namespace ServiciosWebClienteFiel.gestion {

public partial class GestionDomicilio {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionDomicilio() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Domicilio obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public Domicilio crearDomicilio(Domicilio obj) {
		List<Domicilio> lista = null;
        Domicilio obj_new = new Domicilio();
		try {
            DomicilioDao dao = new DomicilioDao();
            conn = conexion.conectar();
            int id = Funciones.obtenerId(conn, "DOMICILIO");
            obj.ID_DOMICILIO = id;
            dao.create(conn, obj);
            //verificar existencia
            obj_new.ID_DOMICILIO = obj.ID_DOMICILIO;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Domicilio)lista[0];
            }
            else {
                obj_new.ID_DOMICILIO = -1;
            }
        } catch (Exception e) {
            
            obj_new.ID_DOMICILIO = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj_new;
    }
	
	/**
     * Edita un registro en la tabla
     * @param Domicilio obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public bool editarDomicilio(Domicilio obj) {
        bool resultado;
        resultado = false;
        try {
			DomicilioDao dao = new DomicilioDao();
            conn = conexion.conectar();
            dao.save(conn, obj);
            resultado = true;
        } catch (Exception e) {
            
            resultado = false;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return resultado;
    }
    
    /**
     * Busca el primer registro que coincida con los datos enviados
     * @param Domicilio obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Domicilio buscarPrimeroDomicilio(Domicilio obj) {
        List<Domicilio> lista = null;
        try {
			DomicilioDao dao = new DomicilioDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Domicilio)lista[0];
            }
            else {
				obj.ID_DOMICILIO = -1;
            }
        } catch (Exception e) {
            
            obj.ID_DOMICILIO = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Domicilio obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Domicilio[] buscarDomicilio(Domicilio obj) {
        Domicilio[] result=null;
		List<Domicilio> lista = null;
        try {
			DomicilioDao dao = new DomicilioDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
			if(lista != null && lista.Count > 0)
			   result = lista.ToArray();
        } catch (Exception e) {
            result=null;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return result;
    }
	
	/**
     * Busca los registros que coincidan con los datos enviados
     * @param Domicilio obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Domicilio[] buscarDomicilio(Domicilio obj,int pagina, int numRegPagina) {
        Domicilio[] result=null;
		List<Domicilio> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				DomicilioDao dao = new DomicilioDao();
				conn = conexion.conectar();
				lista = dao.searchMatching(conn, obj,limInf,limSup);
				if(lista != null && lista.Count > 0)
					result = lista.ToArray();
			} catch (Exception e) {
				result=null;
			} finally {
			 if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			    conn.Close();
			}
		}
        return result;
    }
    
    /**
     * Consulta todos los registros de la tabla
     * @param Domicilio obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Domicilio[] listarDomicilio() {
        Domicilio[] result=null;
		List<Domicilio> lista = null;
        try {
			DomicilioDao dao = new DomicilioDao();
            conn = conexion.conectar();
            lista = dao.loadAll(conn);
			if(lista != null && lista.Count > 0)
			    result = lista.ToArray();
        } catch (Exception e) {
            result=null;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return result;
    }
    
	/**
     * Consulta todos los registros de la tabla pero con Paginacion
     * @param Domicilio obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Domicilio[] listarDomicilio(int pagina, int numRegPagina) {
        Domicilio[] result=null;
		List<Domicilio> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				DomicilioDao dao = new DomicilioDao();
				conn = conexion.conectar();
				if(limInf<=dao.countAll(conn))
					{
					lista = dao.loadAll(conn,limInf,limSup);
					if(lista != null && lista.Count > 0)
					    result = lista.ToArray();
					}
			} catch (Exception e) {
				result=null;
			} finally {
				if(conn!=null && conn.State == System.Data.ConnectionState.Open)
				conn.Close();
			}
		}
        return result;
    }
	
	public int contarBusquedaDomicilio(Domicilio obj) {
		int cantidad=-1;
        try {
			DomicilioDao dao = new DomicilioDao();
            conn = conexion.conectar();
            cantidad = dao.countSearchMatching(conn, obj);
        } catch (Exception e) {
            cantidad=-1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return cantidad;
    }
	
    /**
     * Elimina un registro de la tabla
     * @param Domicilio obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public bool eliminarDomicilio(Domicilio obj) {
        bool resultado;
        resultado = false;
        try {
			DomicilioDao dao = new DomicilioDao();
            conn = conexion.conectar();
            dao.delete(conn, obj);
            resultado = true;
        } catch (Exception e) {
            
            resultado = false;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return resultado;
    }

}

}

