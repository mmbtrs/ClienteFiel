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

public partial class GestionDepartamento {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionDepartamento() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Departamento obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public Departamento crearDepartamento(Departamento obj) {
		List<Departamento> lista = null;
        Departamento obj_new = new Departamento();
		try {
            DepartamentoDao dao = new DepartamentoDao();
            conn = conexion.conectar();
            int id = Funciones.obtenerId(conn, "DEPARTAMENTO");
            obj.ID_DEPARTAMENTO = id;
            dao.create(conn, obj);
            //verificar existencia
            obj_new.ID_DEPARTAMENTO = obj.ID_DEPARTAMENTO;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Departamento)lista[0];
            }
            else {
                obj_new.ID_DEPARTAMENTO = -1;
            }
        } catch (Exception e) {
            
            obj_new.ID_DEPARTAMENTO = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj_new;
    }
	
	/**
     * Edita un registro en la tabla
     * @param Departamento obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public bool editarDepartamento(Departamento obj) {
        bool resultado;
        resultado = false;
        try {
			DepartamentoDao dao = new DepartamentoDao();
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
     * @param Departamento obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Departamento buscarPrimeroDepartamento(Departamento obj) {
        List<Departamento> lista = null;
        try {
			DepartamentoDao dao = new DepartamentoDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Departamento)lista[0];
            }
            else {
				obj.ID_DEPARTAMENTO = -1;
            }
        } catch (Exception e) {
            
            obj.ID_DEPARTAMENTO = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Departamento obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Departamento[] buscarDepartamento(Departamento obj) {
        Departamento[] result=null;
		List<Departamento> lista = null;
        try {
			DepartamentoDao dao = new DepartamentoDao();
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
     * @param Departamento obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Departamento[] buscarDepartamento(Departamento obj,int pagina, int numRegPagina) {
        Departamento[] result=null;
		List<Departamento> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				DepartamentoDao dao = new DepartamentoDao();
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
     * @param Departamento obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Departamento[] listarDepartamento() {
        Departamento[] result=null;
		List<Departamento> lista = null;
        try {
			DepartamentoDao dao = new DepartamentoDao();
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
     * @param Departamento obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Departamento[] listarDepartamento(int pagina, int numRegPagina) {
        Departamento[] result=null;
		List<Departamento> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				DepartamentoDao dao = new DepartamentoDao();
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
	
	public int contarBusquedaDepartamento(Departamento obj) {
		int cantidad=-1;
        try {
			DepartamentoDao dao = new DepartamentoDao();
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
     * @param Departamento obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public bool eliminarDepartamento(Departamento obj) {
        bool resultado;
        resultado = false;
        try {
			DepartamentoDao dao = new DepartamentoDao();
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

