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

public partial class GestionTipoidentificacion {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionTipoidentificacion() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }

        /**
         * Inserta nuevo registro en la tabla
         * @param Tipoidentificacion obj
         * @return Retorna el mismo objeto pero con la llave primaria configurada
         */
        public TipoidentificacionResponse crearTipoidentificacion(Tipoidentificacion obj)
        {
            List<Tipoidentificacion> lista = null;
            Tipoidentificacion obj_new = new Tipoidentificacion();
            TipoidentificacionResponse objResponse = new TipoidentificacionResponse();
            try
            {
                objResponse = new TipoidentificacionResponse();
                TipoidentificacionDao dao = new TipoidentificacionDao();
                conn = conexion.conectar();
                dao.create(conn, obj);
                //verificar existencia
                obj_new.NOM_TIPO_IDENTIFICACION = obj.NOM_TIPO_IDENTIFICACION;
                lista = dao.searchMatching(conn, obj_new);
                if (lista != null && lista.Count > 0)
                {
                    obj_new = (Tipoidentificacion)lista[0];
                }
                else
                {
                    obj_new.ID_TIPO_IDENTIFICACION = -1;
                }
                objResponse.correcto = true;
                objResponse.error = "";
                objResponse.objeto = obj_new;
            }
            catch (Exception e)
            {
                obj_new.ID_TIPO_IDENTIFICACION = -1;
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
         * @param Tipoidentificacion obj
         * @return boolean indicando si se realizo o no la actualizacion
         */
        public TipoidentificacionResponse editarTipoidentificacion(Tipoidentificacion obj)
        {
            TipoidentificacionResponse objResponse = new TipoidentificacionResponse();
            try
            {
                TipoidentificacionDao dao = new TipoidentificacionDao();
                conn = conexion.conectar();
                dao.save(conn, obj);
                objResponse.correcto = true;
                objResponse.error = "";
                objResponse.objeto = obj;
            }
            catch (Exception e)
            {
                objResponse.correcto = false;
                objResponse.error = e.Message;
                objResponse.objeto = obj;
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return objResponse;
        }
    
    /**
     * Busca el primer registro que coincida con los datos enviados
     * @param Tipoidentificacion obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Tipoidentificacion buscarPrimeroTipoidentificacion(Tipoidentificacion obj) {
        List<Tipoidentificacion> lista = null;
        try {
			TipoidentificacionDao dao = new TipoidentificacionDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Tipoidentificacion)lista[0];
            }
            else {
				obj.ID_TIPO_IDENTIFICACION = -1;
            }
        } catch (Exception e) {
            
            obj.ID_TIPO_IDENTIFICACION = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Tipoidentificacion obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Tipoidentificacion[] buscarTipoidentificacion(Tipoidentificacion obj) {
        Tipoidentificacion[] result=null;
		List<Tipoidentificacion> lista = null;
        try {
			TipoidentificacionDao dao = new TipoidentificacionDao();
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
     * @param Tipoidentificacion obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Tipoidentificacion[] buscarTipoidentificacion(Tipoidentificacion obj,int pagina, int numRegPagina) {
        Tipoidentificacion[] result=null;
		List<Tipoidentificacion> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				TipoidentificacionDao dao = new TipoidentificacionDao();
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
     * @param Tipoidentificacion obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Tipoidentificacion[] listarTipoidentificacion() {
        Tipoidentificacion[] result=null;
		List<Tipoidentificacion> lista = null;
        try {
			TipoidentificacionDao dao = new TipoidentificacionDao();
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
     * @param Tipoidentificacion obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Tipoidentificacion[] listarTipoidentificacion(int pagina, int numRegPagina) {
        Tipoidentificacion[] result=null;
		List<Tipoidentificacion> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				TipoidentificacionDao dao = new TipoidentificacionDao();
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
	
	public int contarBusquedaTipoidentificacion(Tipoidentificacion obj) {
		int cantidad=-1;
        try {
			TipoidentificacionDao dao = new TipoidentificacionDao();
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
         * @param Tipoidentificacion obj
         * @return Retorna un boolean indicando si se realizo o no la operacion
         */
        public TipoidentificacionResponse eliminarTipoidentificacion(Tipoidentificacion obj)
        {
            TipoidentificacionResponse resultado = new TipoidentificacionResponse();
            try
            {
                TipoidentificacionDao dao = new TipoidentificacionDao();
                conn = conexion.conectar();
                dao.delete(conn, obj);
                resultado.correcto = true;
                resultado.error = "";
                resultado.objeto = obj;
            }
            catch (Exception e)
            {
                resultado.correcto = false;
                resultado.error = e.Message;
                resultado.objeto = obj;
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return resultado;
        }

}

}

