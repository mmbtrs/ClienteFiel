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

public partial class GestionTipoproducto {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionTipoproducto() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Tipoproducto obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public Tipoproducto crearTipoproducto(Tipoproducto obj) {
		List<Tipoproducto> lista = null;
        Tipoproducto obj_new = new Tipoproducto();
		try {
            TipoproductoDao dao = new TipoproductoDao();
            conn = conexion.conectar();
            int id = Funciones.obtenerId(conn, "TIPO_PRODUCTO");
            obj.ID_TIPO_PRODUCTO = id;
            dao.create(conn, obj);
            //verificar existencia
            obj_new.ID_TIPO_PRODUCTO = obj.ID_TIPO_PRODUCTO;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Tipoproducto)lista[0];
            }
            else {
                obj_new.ID_TIPO_PRODUCTO = -1;
            }
        } catch (Exception e) {
            
            obj_new.ID_TIPO_PRODUCTO = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj_new;
    }
	
	/**
     * Edita un registro en la tabla
     * @param Tipoproducto obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public bool editarTipoproducto(Tipoproducto obj) {
        bool resultado;
        resultado = false;
        try {
			TipoproductoDao dao = new TipoproductoDao();
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
     * @param Tipoproducto obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Tipoproducto buscarPrimeroTipoproducto(Tipoproducto obj) {
        List<Tipoproducto> lista = null;
        try {
			TipoproductoDao dao = new TipoproductoDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Tipoproducto)lista[0];
            }
            else {
				obj.ID_TIPO_PRODUCTO = -1;
            }
        } catch (Exception e) {
            
            obj.ID_TIPO_PRODUCTO = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Tipoproducto obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Tipoproducto[] buscarTipoproducto(Tipoproducto obj) {
        Tipoproducto[] result=null;
		List<Tipoproducto> lista = null;
        try {
			TipoproductoDao dao = new TipoproductoDao();
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
     * @param Tipoproducto obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Tipoproducto[] buscarTipoproducto(Tipoproducto obj,int pagina, int numRegPagina) {
        Tipoproducto[] result=null;
		List<Tipoproducto> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				TipoproductoDao dao = new TipoproductoDao();
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
     * @param Tipoproducto obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Tipoproducto[] listarTipoproducto() {
        Tipoproducto[] result=null;
		List<Tipoproducto> lista = null;
        try {
			TipoproductoDao dao = new TipoproductoDao();
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
     * @param Tipoproducto obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Tipoproducto[] listarTipoproducto(int pagina, int numRegPagina) {
        Tipoproducto[] result=null;
		List<Tipoproducto> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				TipoproductoDao dao = new TipoproductoDao();
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
	
	public int contarBusquedaTipoproducto(Tipoproducto obj) {
		int cantidad=-1;
        try {
			TipoproductoDao dao = new TipoproductoDao();
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
     * @param Tipoproducto obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public bool eliminarTipoproducto(Tipoproducto obj) {
        bool resultado;
        resultado = false;
        try {
			TipoproductoDao dao = new TipoproductoDao();
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

