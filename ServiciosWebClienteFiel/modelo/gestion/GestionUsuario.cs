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

public partial class GestionUsuario {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionUsuario() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Usuario obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public Usuario crearUsuario(Usuario obj) {
		List<Usuario> lista = null;
        Usuario obj_new = new Usuario();
		try {
            UsuarioDao dao = new UsuarioDao();
            conn = conexion.conectar();
            int id = Funciones.obtenerId(conn, "USUARIO");
            obj.ID_USUARIO = id;
            dao.create(conn, obj);
            //verificar existencia
            obj_new.ID_USUARIO = obj.ID_USUARIO;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Usuario)lista[0];
            }
            else {
                obj_new.ID_USUARIO = -1;
            }
        } catch (Exception e) {
            
            obj_new.ID_USUARIO = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj_new;
    }
	
	/**
     * Edita un registro en la tabla
     * @param Usuario obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public bool editarUsuario(Usuario obj) {
        bool resultado;
        resultado = false;
        try {
			UsuarioDao dao = new UsuarioDao();
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
     * @param Usuario obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Usuario buscarPrimeroUsuario(Usuario obj) {
        List<Usuario> lista = null;
        try {
			UsuarioDao dao = new UsuarioDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Usuario)lista[0];
            }
            else {
				obj.ID_USUARIO = -1;
            }
        } catch (Exception e) {
            
            obj.ID_USUARIO = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Usuario obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Usuario[] buscarUsuario(Usuario obj) {
        Usuario[] result=null;
		List<Usuario> lista = null;
        try {
			UsuarioDao dao = new UsuarioDao();
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
     * @param Usuario obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Usuario[] buscarUsuario(Usuario obj,int pagina, int numRegPagina) {
        Usuario[] result=null;
		List<Usuario> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				UsuarioDao dao = new UsuarioDao();
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
     * @param Usuario obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Usuario[] listarUsuario() {
        Usuario[] result=null;
		List<Usuario> lista = null;
        try {
			UsuarioDao dao = new UsuarioDao();
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
     * @param Usuario obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Usuario[] listarUsuario(int pagina, int numRegPagina) {
        Usuario[] result=null;
		List<Usuario> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				UsuarioDao dao = new UsuarioDao();
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
	
	public int contarBusquedaUsuario(Usuario obj) {
		int cantidad=-1;
        try {
			UsuarioDao dao = new UsuarioDao();
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
     * @param Usuario obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public bool eliminarUsuario(Usuario obj) {
        bool resultado;
        resultado = false;
        try {
			UsuarioDao dao = new UsuarioDao();
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

