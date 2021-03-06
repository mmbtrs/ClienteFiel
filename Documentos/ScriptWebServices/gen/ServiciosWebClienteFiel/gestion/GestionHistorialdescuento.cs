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

public partial class GestionHistorialdescuento {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionHistorialdescuento() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Historialdescuento obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public Historialdescuento crearHistorialdescuento(Historialdescuento obj) {
		List<Historialdescuento> lista = null;
        Historialdescuento obj_new = new Historialdescuento();
		try {
            HistorialdescuentoDao dao = new HistorialdescuentoDao();
            conn = conexion.conectar();
            int id = Funciones.obtenerId(conn, "HISTORIAL_DESCUENTO");
            obj.ID_HISTORIAL_DESCUENTO = id;
            dao.create(conn, obj);
            //verificar existencia
            obj_new.ID_HISTORIAL_DESCUENTO = obj.ID_HISTORIAL_DESCUENTO;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Historialdescuento)lista[0];
            }
            else {
                obj_new.ID_HISTORIAL_DESCUENTO = -1;
            }
        } catch (Exception e) {
            
            obj_new.ID_HISTORIAL_DESCUENTO = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj_new;
    }
	
	/**
     * Edita un registro en la tabla
     * @param Historialdescuento obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public bool editarHistorialdescuento(Historialdescuento obj) {
        bool resultado;
        resultado = false;
        try {
			HistorialdescuentoDao dao = new HistorialdescuentoDao();
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
     * @param Historialdescuento obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Historialdescuento buscarPrimeroHistorialdescuento(Historialdescuento obj) {
        List<Historialdescuento> lista = null;
        try {
			HistorialdescuentoDao dao = new HistorialdescuentoDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Historialdescuento)lista[0];
            }
            else {
				obj.ID_HISTORIAL_DESCUENTO = -1;
            }
        } catch (Exception e) {
            
            obj.ID_HISTORIAL_DESCUENTO = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Historialdescuento obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Historialdescuento[] buscarHistorialdescuento(Historialdescuento obj) {
        Historialdescuento[] result=null;
		List<Historialdescuento> lista = null;
        try {
			HistorialdescuentoDao dao = new HistorialdescuentoDao();
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
     * @param Historialdescuento obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Historialdescuento[] buscarHistorialdescuento(Historialdescuento obj,int pagina, int numRegPagina) {
        Historialdescuento[] result=null;
		List<Historialdescuento> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				HistorialdescuentoDao dao = new HistorialdescuentoDao();
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
     * @param Historialdescuento obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Historialdescuento[] listarHistorialdescuento() {
        Historialdescuento[] result=null;
		List<Historialdescuento> lista = null;
        try {
			HistorialdescuentoDao dao = new HistorialdescuentoDao();
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
     * @param Historialdescuento obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Historialdescuento[] listarHistorialdescuento(int pagina, int numRegPagina) {
        Historialdescuento[] result=null;
		List<Historialdescuento> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				HistorialdescuentoDao dao = new HistorialdescuentoDao();
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
	
	public int contarBusquedaHistorialdescuento(Historialdescuento obj) {
		int cantidad=-1;
        try {
			HistorialdescuentoDao dao = new HistorialdescuentoDao();
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
     * @param Historialdescuento obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public bool eliminarHistorialdescuento(Historialdescuento obj) {
        bool resultado;
        resultado = false;
        try {
			HistorialdescuentoDao dao = new HistorialdescuentoDao();
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

