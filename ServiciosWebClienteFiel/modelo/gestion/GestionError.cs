using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;

using AccesoDatos;

using ServiciosWebClienteFiel.dao;
using ServiciosWebClienteFiel.objetos;
using ServiciosWebClienteFiel.ObjectsResponse;

namespace ServiciosWebClienteFiel.gestion {

public partial class GestionError {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionError() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Error obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public ErrorResponse crearError(Error obj) {
		List<Error> lista = null;
            ErrorResponse objResponse = new ErrorResponse();
        Error obj_new = new Error();
		try {
            ErrorDao dao = new ErrorDao();
            conn = conexion.conectar();
                obj.ERROR = obj.ERROR.Replace(char.Parse("'"), '_');
                try
                {
                    obj.CAMPO_DE_BUSQUEDA = obj.ERROR.Substring(0, 149);
                }
                catch (Exception exp)
                {
                    obj.CAMPO_DE_BUSQUEDA = obj.ERROR.Substring(0, 80);
                }
                
            dao.create(conn, obj);
            //verificar existencia
            obj_new.ERROR = obj.ERROR;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Error)lista[0];
            }
            else {
                obj_new.ID_ERROR = -1;
            }
                objResponse.correcto = true;
                objResponse.error = "";
                objResponse.objeto = obj_new;
        } catch (Exception e) {
            
            obj_new.ID_ERROR = -1;
                objResponse.correcto = false;
                objResponse.error = e.Message;
                objResponse.objeto = obj_new;
            } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return objResponse;
    }
	
	/**
     * Edita un registro en la tabla
     * @param Error obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public ErrorResponse editarError(Error obj) {
            ErrorResponse resultado = new ErrorResponse();
        try {
			ErrorDao dao = new ErrorDao();
            conn = conexion.conectar();
                obj.ERROR = obj.ERROR.Replace(char.Parse("'"), '_');
                try
                {
                    obj.CAMPO_DE_BUSQUEDA = obj.ERROR.Substring(0, 149);
                }
                catch (Exception exp)
                {
                    obj.CAMPO_DE_BUSQUEDA = obj.ERROR.Substring(0, 80);
                }

                dao.save(conn, obj);
            resultado.correcto = true;
                resultado.error = "";
                resultado.objeto = obj;
        } catch (Exception e) {
            
                resultado.correcto = false;
                resultado.error = e.Message;
                resultado.objeto = obj;
            } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return resultado;
    }
    
    /**
     * Busca el primer registro que coincida con los datos enviados
     * @param Error obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Error buscarPrimeroError(Error obj) {
        List<Error> lista = null;
        try {
			ErrorDao dao = new ErrorDao();
            conn = conexion.conectar();
                obj.ERROR = obj.ERROR.Replace(char.Parse("'"), '_');
                try
                {
                    obj.CAMPO_DE_BUSQUEDA = obj.ERROR.Substring(0, 149);
                }
                catch (Exception exp)
                {
                    obj.CAMPO_DE_BUSQUEDA = obj.ERROR.Substring(0, 80);
                }
                obj.ERROR = String.Empty;
                lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Error)lista[0];
            }
            else {
				obj.ID_ERROR = -1;
            }
        } catch (Exception e) {
            
            obj.ID_ERROR = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Error obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Error[] buscarError(Error obj) {
        Error[] result=null;
		List<Error> lista = null;
        try {
			ErrorDao dao = new ErrorDao();
            conn = conexion.conectar();
                obj.ERROR = obj.ERROR.Replace(char.Parse("'"), '_');
                try
                {
                    obj.CAMPO_DE_BUSQUEDA = obj.ERROR.Substring(0, 149);
                }
                catch (Exception exp)
                {
                    obj.CAMPO_DE_BUSQUEDA = obj.ERROR.Substring(0, 80);
                }
                obj.ERROR = String.Empty;
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
     * @param Error obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Error[] buscarError(Error obj,int pagina, int numRegPagina) {
        Error[] result=null;
		List<Error> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				ErrorDao dao = new ErrorDao();
				conn = conexion.conectar();
                    obj.ERROR = obj.ERROR.Replace(char.Parse("'"), '_');
                    try
                    {
                        obj.CAMPO_DE_BUSQUEDA = obj.ERROR.Substring(0, 149);
                    }
                    catch (Exception exp)
                    {
                        obj.CAMPO_DE_BUSQUEDA = obj.ERROR.Substring(0, 80);
                    }
                    obj.ERROR = String.Empty;
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
     * @param Error obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Error[] listarError() {
        Error[] result=null;
		List<Error> lista = null;
        try {
			ErrorDao dao = new ErrorDao();
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
     * @param Error obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Error[] listarError(int pagina, int numRegPagina) {
        Error[] result=null;
		List<Error> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				ErrorDao dao = new ErrorDao();
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
	
	public int contarBusquedaError(Error obj) {
		int cantidad=-1;
        try {
			ErrorDao dao = new ErrorDao();
            conn = conexion.conectar();
                obj.ERROR = obj.ERROR.Replace(char.Parse("'"), '_');
                try
                {
                    obj.CAMPO_DE_BUSQUEDA = obj.ERROR.Substring(0, 149);
                }
                catch (Exception exp)
                {
                    obj.CAMPO_DE_BUSQUEDA = obj.ERROR.Substring(0, 80);
                }
                obj.ERROR = String.Empty;
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
     * @param Error obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public ErrorResponse eliminarError(Error obj) {
            ErrorResponse resultado = new ErrorResponse();
        try {
			ErrorDao dao = new ErrorDao();
            conn = conexion.conectar();
            dao.delete(conn, obj);
            resultado.correcto = true;
                resultado.error = "";
                resultado.objeto = obj;
        } catch (Exception e) {

                resultado.correcto = false;
                resultado.error = e.Message;
                resultado.objeto = obj;
            } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return resultado;
    }

}

}

