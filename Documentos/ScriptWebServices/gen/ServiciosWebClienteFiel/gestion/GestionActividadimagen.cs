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

public partial class GestionActividadimagen {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionActividadimagen() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Actividadimagen obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public Actividadimagen crearActividadimagen(Actividadimagen obj) {
		List<Actividadimagen> lista = null;
        Actividadimagen obj_new = new Actividadimagen();
		try {
            ActividadimagenDao dao = new ActividadimagenDao();
            conn = conexion.conectar();
            int id = Funciones.obtenerId(conn, "ACTIVIDAD_IMAGEN");
            obj.ID_ACTIVIDAD = id;
            dao.create(conn, obj);
            //verificar existencia
            obj_new.ID_ACTIVIDAD = obj.ID_ACTIVIDAD;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Actividadimagen)lista[0];
            }
            else {
                obj_new.ID_ACTIVIDAD = -1;
            }
        } catch (Exception e) {
            
            obj_new.ID_ACTIVIDAD = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj_new;
    }
	
	/**
     * Edita un registro en la tabla
     * @param Actividadimagen obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public bool editarActividadimagen(Actividadimagen obj) {
        bool resultado;
        resultado = false;
        try {
			ActividadimagenDao dao = new ActividadimagenDao();
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
     * @param Actividadimagen obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Actividadimagen buscarPrimeroActividadimagen(Actividadimagen obj) {
        List<Actividadimagen> lista = null;
        try {
			ActividadimagenDao dao = new ActividadimagenDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Actividadimagen)lista[0];
            }
            else {
				obj.ID_ACTIVIDAD = -1;
            }
        } catch (Exception e) {
            
            obj.ID_ACTIVIDAD = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Actividadimagen obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Actividadimagen[] buscarActividadimagen(Actividadimagen obj) {
        Actividadimagen[] result=null;
		List<Actividadimagen> lista = null;
        try {
			ActividadimagenDao dao = new ActividadimagenDao();
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
     * @param Actividadimagen obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Actividadimagen[] buscarActividadimagen(Actividadimagen obj,int pagina, int numRegPagina) {
        Actividadimagen[] result=null;
		List<Actividadimagen> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				ActividadimagenDao dao = new ActividadimagenDao();
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
     * @param Actividadimagen obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Actividadimagen[] listarActividadimagen() {
        Actividadimagen[] result=null;
		List<Actividadimagen> lista = null;
        try {
			ActividadimagenDao dao = new ActividadimagenDao();
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
     * @param Actividadimagen obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Actividadimagen[] listarActividadimagen(int pagina, int numRegPagina) {
        Actividadimagen[] result=null;
		List<Actividadimagen> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				ActividadimagenDao dao = new ActividadimagenDao();
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
	
	public int contarBusquedaActividadimagen(Actividadimagen obj) {
		int cantidad=-1;
        try {
			ActividadimagenDao dao = new ActividadimagenDao();
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
     * @param Actividadimagen obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public bool eliminarActividadimagen(Actividadimagen obj) {
        bool resultado;
        resultado = false;
        try {
			ActividadimagenDao dao = new ActividadimagenDao();
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

