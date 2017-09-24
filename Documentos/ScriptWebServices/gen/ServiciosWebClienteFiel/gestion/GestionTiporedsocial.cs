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

public partial class GestionTiporedsocial {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionTiporedsocial() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Tiporedsocial obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public Tiporedsocial crearTiporedsocial(Tiporedsocial obj) {
		List<Tiporedsocial> lista = null;
        Tiporedsocial obj_new = new Tiporedsocial();
		try {
            TiporedsocialDao dao = new TiporedsocialDao();
            conn = conexion.conectar();
            int id = Funciones.obtenerId(conn, "TIPO_RED_SOCIAL");
            obj.ID_TIPO_RED_SOCIAL = id;
            dao.create(conn, obj);
            //verificar existencia
            obj_new.ID_TIPO_RED_SOCIAL = obj.ID_TIPO_RED_SOCIAL;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Tiporedsocial)lista[0];
            }
            else {
                obj_new.ID_TIPO_RED_SOCIAL = -1;
            }
        } catch (Exception e) {
            
            obj_new.ID_TIPO_RED_SOCIAL = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj_new;
    }
	
	/**
     * Edita un registro en la tabla
     * @param Tiporedsocial obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public bool editarTiporedsocial(Tiporedsocial obj) {
        bool resultado;
        resultado = false;
        try {
			TiporedsocialDao dao = new TiporedsocialDao();
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
     * @param Tiporedsocial obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Tiporedsocial buscarPrimeroTiporedsocial(Tiporedsocial obj) {
        List<Tiporedsocial> lista = null;
        try {
			TiporedsocialDao dao = new TiporedsocialDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Tiporedsocial)lista[0];
            }
            else {
				obj.ID_TIPO_RED_SOCIAL = -1;
            }
        } catch (Exception e) {
            
            obj.ID_TIPO_RED_SOCIAL = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Tiporedsocial obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Tiporedsocial[] buscarTiporedsocial(Tiporedsocial obj) {
        Tiporedsocial[] result=null;
		List<Tiporedsocial> lista = null;
        try {
			TiporedsocialDao dao = new TiporedsocialDao();
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
     * @param Tiporedsocial obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Tiporedsocial[] buscarTiporedsocial(Tiporedsocial obj,int pagina, int numRegPagina) {
        Tiporedsocial[] result=null;
		List<Tiporedsocial> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				TiporedsocialDao dao = new TiporedsocialDao();
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
     * @param Tiporedsocial obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Tiporedsocial[] listarTiporedsocial() {
        Tiporedsocial[] result=null;
		List<Tiporedsocial> lista = null;
        try {
			TiporedsocialDao dao = new TiporedsocialDao();
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
     * @param Tiporedsocial obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Tiporedsocial[] listarTiporedsocial(int pagina, int numRegPagina) {
        Tiporedsocial[] result=null;
		List<Tiporedsocial> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				TiporedsocialDao dao = new TiporedsocialDao();
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
	
	public int contarBusquedaTiporedsocial(Tiporedsocial obj) {
		int cantidad=-1;
        try {
			TiporedsocialDao dao = new TiporedsocialDao();
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
     * @param Tiporedsocial obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public bool eliminarTiporedsocial(Tiporedsocial obj) {
        bool resultado;
        resultado = false;
        try {
			TiporedsocialDao dao = new TiporedsocialDao();
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

