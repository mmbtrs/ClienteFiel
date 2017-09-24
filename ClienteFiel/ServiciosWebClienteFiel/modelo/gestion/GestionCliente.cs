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

public partial class GestionCliente {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionCliente() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Cliente obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public Cliente crearCliente(Cliente obj) {
		List<Cliente> lista = null;
        Cliente obj_new = new Cliente();
		try {
            ClienteDao dao = new ClienteDao();
            conn = conexion.conectar();
            int id = Funciones.obtenerId(conn, "CLIENTE");
            obj.ID_CLIENTE = id;
            dao.create(conn, obj);
            //verificar existencia
            obj_new.ID_CLIENTE = obj.ID_CLIENTE;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Cliente)lista[0];
            }
            else {
                obj_new.ID_CLIENTE = -1;
            }
        } catch (Exception e) {
            
            obj_new.ID_CLIENTE = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj_new;
    }
	
	/**
     * Edita un registro en la tabla
     * @param Cliente obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public bool editarCliente(Cliente obj) {
        bool resultado;
        resultado = false;
        try {
			ClienteDao dao = new ClienteDao();
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
     * @param Cliente obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Cliente buscarPrimeroCliente(Cliente obj) {
        List<Cliente> lista = null;
        try {
			ClienteDao dao = new ClienteDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Cliente)lista[0];
            }
            else {
				obj.ID_CLIENTE = -1;
            }
        } catch (Exception e) {
            
            obj.ID_CLIENTE = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Cliente obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Cliente[] buscarCliente(Cliente obj) {
        Cliente[] result=null;
		List<Cliente> lista = null;
        try {
			ClienteDao dao = new ClienteDao();
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
     * @param Cliente obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Cliente[] buscarCliente(Cliente obj,int pagina, int numRegPagina) {
        Cliente[] result=null;
		List<Cliente> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				ClienteDao dao = new ClienteDao();
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
     * @param Cliente obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Cliente[] listarCliente() {
        Cliente[] result=null;
		List<Cliente> lista = null;
        try {
			ClienteDao dao = new ClienteDao();
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
     * @param Cliente obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Cliente[] listarCliente(int pagina, int numRegPagina) {
        Cliente[] result=null;
		List<Cliente> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				ClienteDao dao = new ClienteDao();
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
	
	public int contarBusquedaCliente(Cliente obj) {
		int cantidad=-1;
        try {
			ClienteDao dao = new ClienteDao();
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
     * @param Cliente obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public bool eliminarCliente(Cliente obj) {
        bool resultado;
        resultado = false;
        try {
			ClienteDao dao = new ClienteDao();
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

