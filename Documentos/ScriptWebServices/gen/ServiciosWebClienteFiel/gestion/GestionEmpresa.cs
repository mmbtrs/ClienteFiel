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

public partial class GestionEmpresa {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionEmpresa() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Empresa obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public Empresa crearEmpresa(Empresa obj) {
		List<Empresa> lista = null;
        Empresa obj_new = new Empresa();
		try {
            EmpresaDao dao = new EmpresaDao();
            conn = conexion.conectar();
            int id = Funciones.obtenerId(conn, "EMPRESA");
            obj.ID_EMPRESA = id;
            dao.create(conn, obj);
            //verificar existencia
            obj_new.ID_EMPRESA = obj.ID_EMPRESA;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Empresa)lista[0];
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
     * @param Empresa obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public bool editarEmpresa(Empresa obj) {
        bool resultado;
        resultado = false;
        try {
			EmpresaDao dao = new EmpresaDao();
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
     * @param Empresa obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Empresa buscarPrimeroEmpresa(Empresa obj) {
        List<Empresa> lista = null;
        try {
			EmpresaDao dao = new EmpresaDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Empresa)lista[0];
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
     * @param Empresa obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Empresa[] buscarEmpresa(Empresa obj) {
        Empresa[] result=null;
		List<Empresa> lista = null;
        try {
			EmpresaDao dao = new EmpresaDao();
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
     * @param Empresa obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Empresa[] buscarEmpresa(Empresa obj,int pagina, int numRegPagina) {
        Empresa[] result=null;
		List<Empresa> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				EmpresaDao dao = new EmpresaDao();
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
     * @param Empresa obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Empresa[] listarEmpresa() {
        Empresa[] result=null;
		List<Empresa> lista = null;
        try {
			EmpresaDao dao = new EmpresaDao();
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
     * @param Empresa obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Empresa[] listarEmpresa(int pagina, int numRegPagina) {
        Empresa[] result=null;
		List<Empresa> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				EmpresaDao dao = new EmpresaDao();
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
	
	public int contarBusquedaEmpresa(Empresa obj) {
		int cantidad=-1;
        try {
			EmpresaDao dao = new EmpresaDao();
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
     * @param Empresa obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public bool eliminarEmpresa(Empresa obj) {
        bool resultado;
        resultado = false;
        try {
			EmpresaDao dao = new EmpresaDao();
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

