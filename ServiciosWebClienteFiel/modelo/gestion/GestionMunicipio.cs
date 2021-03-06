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

public partial class GestionMunicipio {
    
	ConectarBD conexion;
	SqlConnection conn;	
	
    public GestionMunicipio() {
    
        crearObjetos();
    }
    
    private void crearObjetos(){
       conexion = ConectarBD.obtenerInstancia();
    }
	
	/**
     * Inserta nuevo registro en la tabla
     * @param Municipio obj
     * @return Retorna el mismo objeto pero con la llave primaria configurada
     */
	public MunicipioResponse crearMunicipio(Municipio obj) {
		List<Municipio> lista = null;
        Municipio obj_new = new Municipio();
            MunicipioResponse response = new MunicipioResponse();

        try {
            MunicipioDao dao = new MunicipioDao();
            conn = conexion.conectar();
            dao.create(conn, obj);
            //verificar existencia
            obj_new.NOM_MUNICIPIO = obj.NOM_MUNICIPIO;
                obj_new.ID_DEPARTAMENTO = obj.ID_DEPARTAMENTO;
            lista = dao.searchMatching(conn, obj_new);
            if (lista != null && lista.Count > 0) {
                obj_new = (Municipio)lista[0];
            }
            else {
                obj_new.ID_MUNICIPIO = -1;
            }
                response.correcto = true;
                response.error = "";
                response.objeto = obj_new;
        } catch (Exception e) {
            
            obj_new.ID_MUNICIPIO = -1;
                response.correcto = false;
                response.error = e.Message;
                response.objeto = obj_new;
            } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return response;
    }
	
	/**
     * Edita un registro en la tabla
     * @param Municipio obj
     * @return boolean indicando si se realizo o no la actualizacion
     */
    public MunicipioResponse editarMunicipio(Municipio obj) {
            MunicipioResponse resultado = new MunicipioResponse();
        try {
			MunicipioDao dao = new MunicipioDao();
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
     * @param Municipio obj
     * @return Retorna el mismo objeto pero con los datos consultados
     */
    public Municipio buscarPrimeroMunicipio(Municipio obj) {
        List<Municipio> lista = null;
        try {
			MunicipioDao dao = new MunicipioDao();
            conn = conexion.conectar();
            lista = dao.searchMatching(conn, obj);
            if (lista != null && lista.Count > 0) {
                obj = (Municipio)lista[0];
            }
            else {
				obj.ID_MUNICIPIO = -1;
            }
        } catch (Exception e) {
            
            obj.ID_MUNICIPIO = -1;
        } finally {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open)
			conn.Close();
        }
        return obj;
    }
    
    /**
     * Busca los registros que coincidan con los datos enviados
     * @param Municipio obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Municipio[] buscarMunicipio(Municipio obj) {
        Municipio[] result=null;
		List<Municipio> lista = null;
        try {
			MunicipioDao dao = new MunicipioDao();
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
     * @param Municipio obj
     * @return Retorna la lista de los registros que coinciden
     */
    public Municipio[] buscarMunicipio(Municipio obj,int pagina, int numRegPagina) {
        Municipio[] result=null;
		List<Municipio> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				MunicipioDao dao = new MunicipioDao();
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
     * @param Municipio obj
     * @return Retorna la lista de los registros en la tabla
     */
    public Municipio[] listarMunicipio() {
        Municipio[] result=null;
		List<Municipio> lista = null;
        try {
			MunicipioDao dao = new MunicipioDao();
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
     * @param Municipio obj
     * @return Retorna la lista de los registros en la tabla con paginacion
     */
	
	public Municipio[] listarMunicipio(int pagina, int numRegPagina) {
        Municipio[] result=null;
		List<Municipio> lista = null;
		if(pagina>0 && numRegPagina>0)
		{
			pagina--;
			int limInf =0;
			int limSup =0;
			limInf = pagina*numRegPagina+1;
			limSup = (pagina+1)*numRegPagina;
			try {
				MunicipioDao dao = new MunicipioDao();
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
	
	public int contarBusquedaMunicipio(Municipio obj) {
		int cantidad=-1;
        try {
			MunicipioDao dao = new MunicipioDao();
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
     * @param Municipio obj
     * @return Retorna un boolean indicando si se realizo o no la operacion
     */
    public MunicipioResponse eliminarMunicipio(Municipio obj) {
            MunicipioResponse resultado = new MunicipioResponse();
        try {
			MunicipioDao dao = new MunicipioDao();
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

