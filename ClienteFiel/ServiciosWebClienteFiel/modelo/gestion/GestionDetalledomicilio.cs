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

public partial class GestionDetalledomicilio {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionDetalledomicilio() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Detalledomicilio obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public Detalledomicilio crearDetalledomicilio(Detalledomicilio obj) {
		List<Detalledomicilio> lista = null;
        Detalledomicilio obj_new = new Detalledomicilio();
		try {
            DetalledomicilioDao dao = new DetalledomicilioDao();
            conn = conexion.conectar();
            int id = Funciones.obtenerId(conn, "DETALLE_DOMICILIO");
            obj.ID_DETALLE_DOMICILIO = id;
            dao.create(conn, obj);
            //verificar existencia
            obj_new.ID_DETALLE_DOMICILIO = obj.ID_DETALLE_DOMICILIO;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Detalledomicilio)lista[0];
            }
            else {
                obj_new.ID_DETALLE_DOMICILIO = -1;
            }
        } catch (Exception e) {
            
            obj_new.ID_DETALLE_DOMICILIO = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj_new;
    }
	
	/**
     * Edita un registro en la tabla
     * @param Detalledomicilio obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public bool editarDetalledomicilio(Detalledomicilio obj) {
        bool resultado;
        resultado = false;
        try {
			DetalledomicilioDao dao = new DetalledomicilioDao();
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
     * @param Detalledomicilio obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Detalledomicilio buscarPrimeroDetalledomicilio(Detalledomicilio obj) {
        List<Detalledomicilio> lista = null;
        try {
			DetalledomicilioDao dao = new DetalledomicilioDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Detalledomicilio)lista[0];
            }
            else {
				obj.ID_DETALLE_DOMICILIO = -1;
            }
        } catch (Exception e) {
            
            obj.ID_DETALLE_DOMICILIO = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Detalledomicilio obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Detalledomicilio[] buscarDetalledomicilio(Detalledomicilio obj) {
        Detalledomicilio[] result=null;
		List<Detalledomicilio> lista = null;
        try {
			DetalledomicilioDao dao = new DetalledomicilioDao();
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
     * @param Detalledomicilio obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Detalledomicilio[] buscarDetalledomicilio(Detalledomicilio obj,int pagina, int numRegPagina) {
        Detalledomicilio[] result=null;
		List<Detalledomicilio> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				DetalledomicilioDao dao = new DetalledomicilioDao();
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
     * @param Detalledomicilio obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Detalledomicilio[] listarDetalledomicilio() {
        Detalledomicilio[] result=null;
		List<Detalledomicilio> lista = null;
        try {
			DetalledomicilioDao dao = new DetalledomicilioDao();
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
     * @param Detalledomicilio obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Detalledomicilio[] listarDetalledomicilio(int pagina, int numRegPagina) {
        Detalledomicilio[] result=null;
		List<Detalledomicilio> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				DetalledomicilioDao dao = new DetalledomicilioDao();
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
	
	public int contarBusquedaDetalledomicilio(Detalledomicilio obj) {
		int cantidad=-1;
        try {
			DetalledomicilioDao dao = new DetalledomicilioDao();
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
     * @param Detalledomicilio obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public bool eliminarDetalledomicilio(Detalledomicilio obj) {
        bool resultado;
        resultado = false;
        try {
			DetalledomicilioDao dao = new DetalledomicilioDao();
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

