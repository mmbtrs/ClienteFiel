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

public partial class GestionCodigoqr {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionCodigoqr() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Codigoqr obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public Codigoqr crearCodigoqr(Codigoqr obj) {
		List<Codigoqr> lista = null;
        Codigoqr obj_new = new Codigoqr();
		try {
            CodigoqrDao dao = new CodigoqrDao();
            conn = conexion.conectar();
            int id = Funciones.obtenerId(conn, "CODIGO_QR");
            obj.ID_CODIGO_QR = id;
            dao.create(conn, obj);
            //verificar existencia
            obj_new.ID_CODIGO_QR = obj.ID_CODIGO_QR;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Codigoqr)lista[0];
            }
            else {
                obj_new.ID_CODIGO_QR = -1;
            }
        } catch (Exception e) {
            
            obj_new.ID_CODIGO_QR = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj_new;
    }
	
	/**
     * Edita un registro en la tabla
     * @param Codigoqr obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public bool editarCodigoqr(Codigoqr obj) {
        bool resultado;
        resultado = false;
        try {
			CodigoqrDao dao = new CodigoqrDao();
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
     * @param Codigoqr obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Codigoqr buscarPrimeroCodigoqr(Codigoqr obj) {
        List<Codigoqr> lista = null;
        try {
			CodigoqrDao dao = new CodigoqrDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Codigoqr)lista[0];
            }
            else {
				obj.ID_CODIGO_QR = -1;
            }
        } catch (Exception e) {
            
            obj.ID_CODIGO_QR = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Codigoqr obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Codigoqr[] buscarCodigoqr(Codigoqr obj) {
        Codigoqr[] result=null;
		List<Codigoqr> lista = null;
        try {
			CodigoqrDao dao = new CodigoqrDao();
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
     * @param Codigoqr obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Codigoqr[] buscarCodigoqr(Codigoqr obj,int pagina, int numRegPagina) {
        Codigoqr[] result=null;
		List<Codigoqr> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				CodigoqrDao dao = new CodigoqrDao();
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
     * @param Codigoqr obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Codigoqr[] listarCodigoqr() {
        Codigoqr[] result=null;
		List<Codigoqr> lista = null;
        try {
			CodigoqrDao dao = new CodigoqrDao();
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
     * @param Codigoqr obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Codigoqr[] listarCodigoqr(int pagina, int numRegPagina) {
        Codigoqr[] result=null;
		List<Codigoqr> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				CodigoqrDao dao = new CodigoqrDao();
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
	
	public int contarBusquedaCodigoqr(Codigoqr obj) {
		int cantidad=-1;
        try {
			CodigoqrDao dao = new CodigoqrDao();
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
     * @param Codigoqr obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public bool eliminarCodigoqr(Codigoqr obj) {
        bool resultado;
        resultado = false;
        try {
			CodigoqrDao dao = new CodigoqrDao();
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

