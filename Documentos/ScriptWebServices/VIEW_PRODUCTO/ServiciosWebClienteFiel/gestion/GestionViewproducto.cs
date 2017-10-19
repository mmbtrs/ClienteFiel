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

public partial class GestionViewproducto {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionViewproducto() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Viewproducto obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public Viewproducto crearViewproducto(Viewproducto obj) {
		List<Viewproducto> lista = null;
        Viewproducto obj_new = new Viewproducto();
		try {
            ViewproductoDao dao = new ViewproductoDao();
            conn = conexion.conectar();
            int id = Funciones.obtenerId(conn, "VIEW_PRODUCTO");
            obj.ID_PRODUCTO = id;
            dao.create(conn, obj);
            //verificar existencia
            obj_new.ID_PRODUCTO = obj.ID_PRODUCTO;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Viewproducto)lista[0];
            }
            else {
                obj_new.ID_PRODUCTO = -1;
            }
        } catch (Exception e) {
            
            obj_new.ID_PRODUCTO = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj_new;
    }
	
	/**
     * Edita un registro en la tabla
     * @param Viewproducto obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public bool editarViewproducto(Viewproducto obj) {
        bool resultado;
        resultado = false;
        try {
			ViewproductoDao dao = new ViewproductoDao();
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
     * @param Viewproducto obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Viewproducto buscarPrimeroViewproducto(Viewproducto obj) {
        List<Viewproducto> lista = null;
        try {
			ViewproductoDao dao = new ViewproductoDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Viewproducto)lista[0];
            }
            else {
				obj.ID_PRODUCTO = -1;
            }
        } catch (Exception e) {
            
            obj.ID_PRODUCTO = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Viewproducto obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Viewproducto[] buscarViewproducto(Viewproducto obj) {
        Viewproducto[] result=null;
		List<Viewproducto> lista = null;
        try {
			ViewproductoDao dao = new ViewproductoDao();
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
     * @param Viewproducto obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Viewproducto[] buscarViewproducto(Viewproducto obj,int pagina, int numRegPagina) {
        Viewproducto[] result=null;
		List<Viewproducto> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				ViewproductoDao dao = new ViewproductoDao();
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
     * @param Viewproducto obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Viewproducto[] listarViewproducto() {
        Viewproducto[] result=null;
		List<Viewproducto> lista = null;
        try {
			ViewproductoDao dao = new ViewproductoDao();
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
     * @param Viewproducto obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Viewproducto[] listarViewproducto(int pagina, int numRegPagina) {
        Viewproducto[] result=null;
		List<Viewproducto> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				ViewproductoDao dao = new ViewproductoDao();
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
	
	public int contarBusquedaViewproducto(Viewproducto obj) {
		int cantidad=-1;
        try {
			ViewproductoDao dao = new ViewproductoDao();
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
     * @param Viewproducto obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public bool eliminarViewproducto(Viewproducto obj) {
        bool resultado;
        resultado = false;
        try {
			ViewproductoDao dao = new ViewproductoDao();
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

