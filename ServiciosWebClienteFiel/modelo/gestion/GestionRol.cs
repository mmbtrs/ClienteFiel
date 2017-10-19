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

public partial class GestionRol {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionRol() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Rol obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public Rol crearRol(Rol obj) {
		List<Rol> lista = null;
        Rol obj_new = new Rol();
		try {
            RolDao dao = new RolDao();
            conn = conexion.conectar();
            int id = Funciones.obtenerId(conn, "ROL");
            obj.ID_ROL = id;
            dao.create(conn, obj);
            //verificar existencia
            obj_new.ID_ROL = obj.ID_ROL;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Rol)lista[0];
            }
            else {
                obj_new.ID_ROL = -1;
            }
        } catch (Exception e) {
            
            obj_new.ID_ROL = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj_new;
    }
	
	/**
     * Edita un registro en la tabla
     * @param Rol obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public bool editarRol(Rol obj) {
        bool resultado;
        resultado = false;
        try {
			RolDao dao = new RolDao();
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
     * @param Rol obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Rol buscarPrimeroRol(Rol obj) {
        List<Rol> lista = null;
        try {
			RolDao dao = new RolDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Rol)lista[0];
            }
            else {
				obj.ID_ROL = -1;
            }
        } catch (Exception e) {
            
            obj.ID_ROL = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Rol obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Rol[] buscarRol(Rol obj) {
        Rol[] result=null;
		List<Rol> lista = null;
        try {
			RolDao dao = new RolDao();
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
     * @param Rol obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Rol[] buscarRol(Rol obj,int pagina, int numRegPagina) {
        Rol[] result=null;
		List<Rol> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				RolDao dao = new RolDao();
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
     * @param Rol obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Rol[] listarRol() {
        Rol[] result=null;
		List<Rol> lista = null;
        try {
			RolDao dao = new RolDao();
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
     * @param Rol obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Rol[] listarRol(int pagina, int numRegPagina) {
        Rol[] result=null;
		List<Rol> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				RolDao dao = new RolDao();
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
	
	public int contarBusquedaRol(Rol obj) {
		int cantidad=-1;
        try {
			RolDao dao = new RolDao();
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
     * @param Rol obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public bool eliminarRol(Rol obj) {
        bool resultado;
        resultado = false;
        try {
			RolDao dao = new RolDao();
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

