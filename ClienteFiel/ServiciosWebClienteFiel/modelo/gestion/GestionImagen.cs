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

public partial class GestionImagen {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionImagen() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }

        /**
         * Inserta nuevo registro en la tabla
         * @param Imagen obj
         * @return Retorna el mismo objeto pero con la llave primaria configurada
         */
        public ImagenResponse crearImagen(Imagen obj)
        {
            List<Imagen> lista = null;
            Imagen obj_new = new Imagen();
            ImagenResponse objResponse = new ImagenResponse();

            try
            {
                ImagenDao dao = new ImagenDao();
                conn = conexion.conectar();
                int id = Funciones.obtenerId(conn, "IMAGEN");
                obj.ID_IMAGEN = id;
                dao.create(conn, obj);
                //verificar existencia
                obj_new.ID_IMAGEN = obj.ID_IMAGEN;
                lista = dao.searchMatching(conn, obj_new);
                if (lista != null && lista.Count > 0)
                {
                    obj_new = (Imagen)lista[0];
                }
                else
                {
                    obj_new.ID_IMAGEN = -1;
                }
                objResponse.correcto = true;
                objResponse.error = "";
                objResponse.objeto = obj_new;
            }
            catch (Exception e)
            {
                obj_new.ID_IMAGEN = -1;
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
     * @param Imagen obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public ImagenResponse editarImagen(Imagen obj) {
            ImagenResponse imagenResponse;
        try {
			ImagenDao dao = new ImagenDao();
            conn = conexion.conectar();
            dao.save(conn, obj);
                imagenResponse = new ImagenResponse();
            imagenResponse.correcto = true;
        } catch (Exception e) {
                imagenResponse = new ImagenResponse();
                imagenResponse.correcto = false;
                imagenResponse.error = e.Message;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return imagenResponse;
    }
    
    /**
     * Busca el primer registro que coincida con los datos enviados
     * @param Imagen obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Imagen buscarPrimeroImagen(Imagen obj) {
        List<Imagen> lista = null;
        try {
			ImagenDao dao = new ImagenDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Imagen)lista[0];
            }
            else {
				obj.ID_IMAGEN = -1;
            }
        } catch (Exception e) {
            
            obj.ID_IMAGEN = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Imagen obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Imagen[] buscarImagen(Imagen obj) {
        Imagen[] result=null;
		List<Imagen> lista = null;
        try {
			ImagenDao dao = new ImagenDao();
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
     * @param Imagen obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Imagen[] buscarImagen(Imagen obj,int pagina, int numRegPagina) {
        Imagen[] result=null;
		List<Imagen> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				ImagenDao dao = new ImagenDao();
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
     * @param Imagen obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Imagen[] listarImagen() {
        Imagen[] result=null;
		List<Imagen> lista = null;
        try {
			ImagenDao dao = new ImagenDao();
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
     * @param Imagen obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Imagen[] listarImagen(int pagina, int numRegPagina) {
        Imagen[] result=null;
		List<Imagen> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				ImagenDao dao = new ImagenDao();
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
	
	public int contarBusquedaImagen(Imagen obj) {
		int cantidad=-1;
        try {
			ImagenDao dao = new ImagenDao();
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
         * @param Imagen obj
         * @return Retorna un boolean indicando si se realizo o no la operacion
         */
        public ImagenResponse eliminarImagen(Imagen obj)
        {
            ImagenResponse resultado = new ImagenResponse();
            try
            {
                ImagenDao dao = new ImagenDao();
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

