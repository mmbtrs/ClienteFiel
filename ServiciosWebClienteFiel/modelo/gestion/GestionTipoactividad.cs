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

public partial class GestionTipoactividad {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionTipoactividad() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }

        /**
         * Inserta nuevo registro en la tabla
         * @param Tipoactividad obj
         * @return Retorna el mismo objeto pero con la llave primaria configurada
         */
        public TipoactividadResponse crearTipoactividad(Tipoactividad obj)
        {
            List<Tipoactividad> lista = null;
            Tipoactividad obj_new = new Tipoactividad();
            TipoactividadResponse objResponse;

            try
            {
                TipoactividadDao dao = new TipoactividadDao();
                conn = conexion.conectar();
                dao.create(conn, obj);
                //verificar existencia
                obj_new.NOM_TIPO_ACTIVIDAD = obj.NOM_TIPO_ACTIVIDAD;
                lista = dao.searchMatching(conn, obj_new);
                if (lista != null && lista.Count > 0)
                {
                    obj_new = (Tipoactividad)lista[0];
                }
                else
                {
                    obj_new.ID_TIPO_ACTIVIDAD = -1;
                }
                objResponse = new TipoactividadResponse();
                objResponse.correcto = true;
                objResponse.error = "";
                objResponse.objeto = obj_new;                
            }
            catch (Exception e)
            {
                obj_new.ID_TIPO_ACTIVIDAD = -1;
                objResponse = new TipoactividadResponse();
                objResponse.correcto = false;
                objResponse.error = e.Message;
                objResponse.objeto = obj_new;
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return objResponse;
        }
	
	/**
     * Edita un registro en la tabla
     * @param Tipoactividad obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public TipoactividadResponse editarTipoactividad(Tipoactividad obj) {
            TipoactividadResponse resultado = new TipoactividadResponse();
        try {
			TipoactividadDao dao = new TipoactividadDao();
            conn = conexion.conectar();
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
     * @param Tipoactividad obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Tipoactividad buscarPrimeroTipoactividad(Tipoactividad obj) {
        List<Tipoactividad> lista = null;
        try {
			TipoactividadDao dao = new TipoactividadDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Tipoactividad)lista[0];
            }
            else {
				obj.ID_TIPO_ACTIVIDAD = -1;
            }
        } catch (Exception e) {
            
            obj.ID_TIPO_ACTIVIDAD = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Tipoactividad obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Tipoactividad[] buscarTipoactividad(Tipoactividad obj) {
        Tipoactividad[] result=null;
		List<Tipoactividad> lista = null;
        try {
			TipoactividadDao dao = new TipoactividadDao();
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
     * @param Tipoactividad obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Tipoactividad[] buscarTipoactividad(Tipoactividad obj,int pagina, int numRegPagina) {
        Tipoactividad[] result=null;
		List<Tipoactividad> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				TipoactividadDao dao = new TipoactividadDao();
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
     * @param Tipoactividad obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Tipoactividad[] listarTipoactividad() {
        Tipoactividad[] result=null;
		List<Tipoactividad> lista = null;
        try {
			TipoactividadDao dao = new TipoactividadDao();
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
     * @param Tipoactividad obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Tipoactividad[] listarTipoactividad(int pagina, int numRegPagina) {
        Tipoactividad[] result=null;
		List<Tipoactividad> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				TipoactividadDao dao = new TipoactividadDao();
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
	
	public int contarBusquedaTipoactividad(Tipoactividad obj) {
		int cantidad=-1;
        try {
			TipoactividadDao dao = new TipoactividadDao();
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
     * @param Tipoactividad obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public TipoactividadResponse eliminarTipoactividad(Tipoactividad obj) {
            TipoactividadResponse resultado = new TipoactividadResponse();
        try {
			TipoactividadDao dao = new TipoactividadDao();
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

