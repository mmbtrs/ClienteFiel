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

public partial class GestionTop {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionTop() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Top obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public Top crearTop(Top obj) {
		List<Top> lista = null;
        Top obj_new = new Top();
		try {
            TopDao dao = new TopDao();
            conn = conexion.conectar();
            int id = Funciones.obtenerId(conn, "TOP");
            obj.ID_TOP = id;
            dao.create(conn, obj);
            //verificar existencia
            obj_new.ID_TOP = obj.ID_TOP;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Top)lista[0];
            }
            else {
                obj_new.ID_TOP = -1;
            }
        } catch (Exception e) {
            
            obj_new.ID_TOP = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj_new;
    }
	
	/**
     * Edita un registro en la tabla
     * @param Top obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public bool editarTop(Top obj) {
        bool resultado;
        resultado = false;
        try {
			TopDao dao = new TopDao();
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
     * @param Top obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Top buscarPrimeroTop(Top obj) {
        List<Top> lista = null;
        try {
			TopDao dao = new TopDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Top)lista[0];
            }
            else {
				obj.ID_TOP = -1;
            }
        } catch (Exception e) {
            
            obj.ID_TOP = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Top obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Top[] buscarTop(Top obj) {
        Top[] result=null;
		List<Top> lista = null;
        try {
			TopDao dao = new TopDao();
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
     * @param Top obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Top[] buscarTop(Top obj,int pagina, int numRegPagina) {
        Top[] result=null;
		List<Top> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				TopDao dao = new TopDao();
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
     * @param Top obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Top[] listarTop() {
        Top[] result=null;
		List<Top> lista = null;
        try {
			TopDao dao = new TopDao();
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
     * @param Top obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Top[] listarTop(int pagina, int numRegPagina) {
        Top[] result=null;
		List<Top> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				TopDao dao = new TopDao();
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
	
	public int contarBusquedaTop(Top obj) {
		int cantidad=-1;
        try {
			TopDao dao = new TopDao();
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
     * @param Top obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public bool eliminarTop(Top obj) {
        bool resultado;
        resultado = false;
        try {
			TopDao dao = new TopDao();
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

