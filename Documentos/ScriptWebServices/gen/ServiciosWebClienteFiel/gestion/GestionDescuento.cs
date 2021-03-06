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

public partial class GestionDescuento {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionDescuento() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Descuento obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public Descuento crearDescuento(Descuento obj) {
		List<Descuento> lista = null;
        Descuento obj_new = new Descuento();
		try {
            DescuentoDao dao = new DescuentoDao();
            conn = conexion.conectar();
            int id = Funciones.obtenerId(conn, "DESCUENTO");
            obj.ID_DESCUENTO = id;
            dao.create(conn, obj);
            //verificar existencia
            obj_new.ID_DESCUENTO = obj.ID_DESCUENTO;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Descuento)lista[0];
            }
            else {
                obj_new.ID_DESCUENTO = -1;
            }
        } catch (Exception e) {
            
            obj_new.ID_DESCUENTO = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj_new;
    }
	
	/**
     * Edita un registro en la tabla
     * @param Descuento obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public bool editarDescuento(Descuento obj) {
        bool resultado;
        resultado = false;
        try {
			DescuentoDao dao = new DescuentoDao();
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
     * @param Descuento obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Descuento buscarPrimeroDescuento(Descuento obj) {
        List<Descuento> lista = null;
        try {
			DescuentoDao dao = new DescuentoDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Descuento)lista[0];
            }
            else {
				obj.ID_DESCUENTO = -1;
            }
        } catch (Exception e) {
            
            obj.ID_DESCUENTO = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Descuento obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Descuento[] buscarDescuento(Descuento obj) {
        Descuento[] result=null;
		List<Descuento> lista = null;
        try {
			DescuentoDao dao = new DescuentoDao();
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
     * @param Descuento obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Descuento[] buscarDescuento(Descuento obj,int pagina, int numRegPagina) {
        Descuento[] result=null;
		List<Descuento> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				DescuentoDao dao = new DescuentoDao();
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
     * @param Descuento obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Descuento[] listarDescuento() {
        Descuento[] result=null;
		List<Descuento> lista = null;
        try {
			DescuentoDao dao = new DescuentoDao();
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
     * @param Descuento obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Descuento[] listarDescuento(int pagina, int numRegPagina) {
        Descuento[] result=null;
		List<Descuento> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				DescuentoDao dao = new DescuentoDao();
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
	
	public int contarBusquedaDescuento(Descuento obj) {
		int cantidad=-1;
        try {
			DescuentoDao dao = new DescuentoDao();
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
     * @param Descuento obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public bool eliminarDescuento(Descuento obj) {
        bool resultado;
        resultado = false;
        try {
			DescuentoDao dao = new DescuentoDao();
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

