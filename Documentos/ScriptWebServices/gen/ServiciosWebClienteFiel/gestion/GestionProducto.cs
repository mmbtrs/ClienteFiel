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

public partial class GestionProducto {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionProducto() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Producto obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public Producto crearProducto(Producto obj) {
		List<Producto> lista = null;
        Producto obj_new = new Producto();
		try {
            ProductoDao dao = new ProductoDao();
            conn = conexion.conectar();
            int id = Funciones.obtenerId(conn, "PRODUCTO");
            obj.ID_PRODUCTO = id;
            dao.create(conn, obj);
            //verificar existencia
            obj_new.ID_PRODUCTO = obj.ID_PRODUCTO;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Producto)lista[0];
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
     * @param Producto obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public bool editarProducto(Producto obj) {
        bool resultado;
        resultado = false;
        try {
			ProductoDao dao = new ProductoDao();
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
     * @param Producto obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Producto buscarPrimeroProducto(Producto obj) {
        List<Producto> lista = null;
        try {
			ProductoDao dao = new ProductoDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Producto)lista[0];
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
     * @param Producto obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Producto[] buscarProducto(Producto obj) {
        Producto[] result=null;
		List<Producto> lista = null;
        try {
			ProductoDao dao = new ProductoDao();
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
     * @param Producto obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Producto[] buscarProducto(Producto obj,int pagina, int numRegPagina) {
        Producto[] result=null;
		List<Producto> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				ProductoDao dao = new ProductoDao();
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
     * @param Producto obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Producto[] listarProducto() {
        Producto[] result=null;
		List<Producto> lista = null;
        try {
			ProductoDao dao = new ProductoDao();
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
     * @param Producto obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Producto[] listarProducto(int pagina, int numRegPagina) {
        Producto[] result=null;
		List<Producto> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				ProductoDao dao = new ProductoDao();
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
	
	public int contarBusquedaProducto(Producto obj) {
		int cantidad=-1;
        try {
			ProductoDao dao = new ProductoDao();
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
     * @param Producto obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public bool eliminarProducto(Producto obj) {
        bool resultado;
        resultado = false;
        try {
			ProductoDao dao = new ProductoDao();
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

