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

public partial class GestionHistorial {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionHistorial() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Historial obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public Historial crearHistorial(Historial obj) {
		List<Historial> lista = null;
        Historial obj_new = new Historial();
		try {
            HistorialDao dao = new HistorialDao();
            conn = conexion.conectar();
            int id = Funciones.obtenerId(conn, "HISTORIAL");
            obj.ID_HISTORIAL = id;
            dao.create(conn, obj);
            //verificar existencia
            obj_new.ID_HISTORIAL = obj.ID_HISTORIAL;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Historial)lista[0];
            }
            else {
                obj_new.ID_HISTORIAL = -1;
            }
        } catch (Exception e) {
            
            obj_new.ID_HISTORIAL = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj_new;
    }
	
	/**
     * Edita un registro en la tabla
     * @param Historial obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public bool editarHistorial(Historial obj) {
        bool resultado;
        resultado = false;
        try {
			HistorialDao dao = new HistorialDao();
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
     * @param Historial obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Historial buscarPrimeroHistorial(Historial obj) {
        List<Historial> lista = null;
        try {
			HistorialDao dao = new HistorialDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Historial)lista[0];
            }
            else {
				obj.ID_HISTORIAL = -1;
            }
        } catch (Exception e) {
            
            obj.ID_HISTORIAL = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Historial obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Historial[] buscarHistorial(Historial obj) {
        Historial[] result=null;
		List<Historial> lista = null;
        try {
			HistorialDao dao = new HistorialDao();
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
     * @param Historial obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Historial[] buscarHistorial(Historial obj,int pagina, int numRegPagina) {
        Historial[] result=null;
		List<Historial> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				HistorialDao dao = new HistorialDao();
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
     * @param Historial obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Historial[] listarHistorial() {
        Historial[] result=null;
		List<Historial> lista = null;
        try {
			HistorialDao dao = new HistorialDao();
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
     * @param Historial obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Historial[] listarHistorial(int pagina, int numRegPagina) {
        Historial[] result=null;
		List<Historial> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				HistorialDao dao = new HistorialDao();
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
	
	public int contarBusquedaHistorial(Historial obj) {
		int cantidad=-1;
        try {
			HistorialDao dao = new HistorialDao();
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
     * @param Historial obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public bool eliminarHistorial(Historial obj) {
        bool resultado;
        resultado = false;
        try {
			HistorialDao dao = new HistorialDao();
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

