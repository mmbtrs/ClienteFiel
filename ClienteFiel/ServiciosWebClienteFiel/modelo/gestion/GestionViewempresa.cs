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

public partial class GestionViewempresa {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionViewempresa() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Viewempresa obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public Viewempresa crearViewempresa(Viewempresa obj) {
		List<Viewempresa> lista = null;
        Viewempresa obj_new = new Viewempresa();
		try {
            ViewempresaDao dao = new ViewempresaDao();
            conn = conexion.conectar();
            int id = Funciones.obtenerId(conn, "VIEW_EMPRESA");
            obj.ID_EMPRESA = id;
            dao.create(conn, obj);
            //verificar existencia
            obj_new.ID_EMPRESA = obj.ID_EMPRESA;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Viewempresa)lista[0];
            }
            else {
                obj_new.ID_EMPRESA = -1;
            }
        } catch (Exception e) {
            
            obj_new.ID_EMPRESA = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj_new;
    }
	
	/**
     * Edita un registro en la tabla
     * @param Viewempresa obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public bool editarViewempresa(Viewempresa obj) {
        bool resultado;
        resultado = false;
        try {
			ViewempresaDao dao = new ViewempresaDao();
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
     * @param Viewempresa obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Viewempresa buscarPrimeroViewempresa(Viewempresa obj) {
        List<Viewempresa> lista = null;
        try {
			ViewempresaDao dao = new ViewempresaDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Viewempresa)lista[0];
            }
            else {
				obj.ID_EMPRESA = -1;
            }
        } catch (Exception e) {
            
            obj.ID_EMPRESA = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Viewempresa obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Viewempresa[] buscarViewempresa(Viewempresa obj) {
        Viewempresa[] result=null;
		List<Viewempresa> lista = null;
        try {
			ViewempresaDao dao = new ViewempresaDao();
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
     * @param Viewempresa obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Viewempresa[] buscarViewempresa(Viewempresa obj,int pagina, int numRegPagina) {
        Viewempresa[] result=null;
		List<Viewempresa> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				ViewempresaDao dao = new ViewempresaDao();
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
     * @param Viewempresa obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Viewempresa[] listarViewempresa() {
        Viewempresa[] result=null;
		List<Viewempresa> lista = null;
        try {
			ViewempresaDao dao = new ViewempresaDao();
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
     * @param Viewempresa obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Viewempresa[] listarViewempresa(int pagina, int numRegPagina) {
        Viewempresa[] result=null;
		List<Viewempresa> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				ViewempresaDao dao = new ViewempresaDao();
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
	
	public int contarBusquedaViewempresa(Viewempresa obj) {
		int cantidad=-1;
        try {
			ViewempresaDao dao = new ViewempresaDao();
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
     * @param Viewempresa obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public bool eliminarViewempresa(Viewempresa obj) {
        bool resultado;
        resultado = false;
        try {
			ViewempresaDao dao = new ViewempresaDao();
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

