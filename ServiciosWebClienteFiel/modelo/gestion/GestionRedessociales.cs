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

public partial class GestionRedessociales {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionRedessociales() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Redessociales obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public Redessociales crearRedessociales(Redessociales obj) {
		List<Redessociales> lista = null;
        Redessociales obj_new = new Redessociales();
		try {
            RedessocialesDao dao = new RedessocialesDao();
            conn = conexion.conectar();
            int id = Funciones.obtenerId(conn, "REDES_SOCIALES");
            obj.ID_REDES_SOCIALES = id;
            dao.create(conn, obj);
            //verificar existencia
            obj_new.ID_REDES_SOCIALES = obj.ID_REDES_SOCIALES;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Redessociales)lista[0];
            }
            else {
                obj_new.ID_REDES_SOCIALES = -1;
            }
        } catch (Exception e) {
            
            obj_new.ID_REDES_SOCIALES = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj_new;
    }
	
	/**
     * Edita un registro en la tabla
     * @param Redessociales obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public bool editarRedessociales(Redessociales obj) {
        bool resultado;
        resultado = false;
        try {
			RedessocialesDao dao = new RedessocialesDao();
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
     * @param Redessociales obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Redessociales buscarPrimeroRedessociales(Redessociales obj) {
        List<Redessociales> lista = null;
        try {
			RedessocialesDao dao = new RedessocialesDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Redessociales)lista[0];
            }
            else {
				obj.ID_REDES_SOCIALES = -1;
            }
        } catch (Exception e) {
            
            obj.ID_REDES_SOCIALES = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Redessociales obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Redessociales[] buscarRedessociales(Redessociales obj) {
        Redessociales[] result=null;
		List<Redessociales> lista = null;
        try {
			RedessocialesDao dao = new RedessocialesDao();
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
     * @param Redessociales obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Redessociales[] buscarRedessociales(Redessociales obj,int pagina, int numRegPagina) {
        Redessociales[] result=null;
		List<Redessociales> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				RedessocialesDao dao = new RedessocialesDao();
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
     * @param Redessociales obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Redessociales[] listarRedessociales() {
        Redessociales[] result=null;
		List<Redessociales> lista = null;
        try {
			RedessocialesDao dao = new RedessocialesDao();
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
     * @param Redessociales obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Redessociales[] listarRedessociales(int pagina, int numRegPagina) {
        Redessociales[] result=null;
		List<Redessociales> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				RedessocialesDao dao = new RedessocialesDao();
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
	
	public int contarBusquedaRedessociales(Redessociales obj) {
		int cantidad=-1;
        try {
			RedessocialesDao dao = new RedessocialesDao();
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
     * @param Redessociales obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public bool eliminarRedessociales(Redessociales obj) {
        bool resultado;
        resultado = false;
        try {
			RedessocialesDao dao = new RedessocialesDao();
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

