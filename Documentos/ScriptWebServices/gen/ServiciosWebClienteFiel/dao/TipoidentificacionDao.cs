using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class TipoidentificacionDao {


	public Tipoidentificacion createValueObject() {
		return new Tipoidentificacion();
	}

	public List<Tipoidentificacion> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM TIPO_IDENTIFICACION ORDER BY ID_TIPO_IDENTIFICACION ASC ";
		List<Tipoidentificacion> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Tipoidentificacion> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_TIPO_IDENTIFICACION) AS RowNumber FROM TIPO_IDENTIFICACION) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Tipoidentificacion> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Tipoidentificacion valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO TIPO_IDENTIFICACION ( ID_TIPO_IDENTIFICACION,"+
			" NOM_TIPO_IDENTIFICACION)"+
			 "VALUES ( @ID_TIPO_IDENTIFICACION, @NOM_TIPO_IDENTIFICACION)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_TIPO_IDENTIFICACION", valueObject.ID_TIPO_IDENTIFICACION);
				if(valueObject.NOM_TIPO_IDENTIFICACION!=null &&valueObject.NOM_TIPO_IDENTIFICACION.Length <= 50)
					stmt.Parameters.AddWithValue("@NOM_TIPO_IDENTIFICACION", valueObject.NOM_TIPO_IDENTIFICACION);
				else
					stmt.Parameters.AddWithValue("@NOM_TIPO_IDENTIFICACION", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Tipoidentificacion valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE TIPO_IDENTIFICACION SET  NOM_TIPO_IDENTIFICACION = @NOM_TIPO_IDENTIFICACION  WHERE (ID_TIPO_IDENTIFICACION= @ID_TIPO_IDENTIFICACION)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.NOM_TIPO_IDENTIFICACION!=null &&valueObject.NOM_TIPO_IDENTIFICACION.Length <= 50)
					stmt.Parameters.AddWithValue("@NOM_TIPO_IDENTIFICACION", valueObject.NOM_TIPO_IDENTIFICACION);
				else
					stmt.Parameters.AddWithValue("@NOM_TIPO_IDENTIFICACION", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_TIPO_IDENTIFICACION", valueObject.ID_TIPO_IDENTIFICACION);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Tipoidentificacion valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM TIPO_IDENTIFICACION WHERE (ID_TIPO_IDENTIFICACION = @ID_TIPO_IDENTIFICACION )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_TIPO_IDENTIFICACION", valueObject.ID_TIPO_IDENTIFICACION);

			int rowcount = databaseUpdate(stmt);
			if (rowcount == 0) {
				throw new Exception("Object could not be deleted! (PrimaryKey not found)");
			}
			if (rowcount > 1) {
				throw new Exception("PrimaryKey Error when updating DB! (Many objects were deleted!)");
			}
		} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public int countAll(SqlConnection conn) {
		String sql = "SELECT count(*) FROM TIPO_IDENTIFICACION";
		SqlCommand stmt = null;
		SqlDataReader result = null;
		int allRows = 0;
		try {
			stmt = new SqlCommand(sql, conn);
			result = stmt.ExecuteReader();
			if (result.Read())
				allRows = int.Parse(result[0].ToString());
		} finally {
			if(!result.IsClosed)
				result.Close();
			if (stmt != null)
				stmt.Dispose();
		}
		return allRows;
	}
	public List<Tipoidentificacion> searchMatching(SqlConnection conn, Tipoidentificacion valueObject) {
		List<Tipoidentificacion> searchResults = new List<Tipoidentificacion>();
		bool first = true;
		String sql = "SELECT * FROM TIPO_IDENTIFICACION WHERE 1=1 ";
		if (valueObject.ID_TIPO_IDENTIFICACION != null && valueObject.ID_TIPO_IDENTIFICACION != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_IDENTIFICACION= " + valueObject.ID_TIPO_IDENTIFICACION + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_TIPO_IDENTIFICACION)) {
			if (first) { first = false; }
			sql += "AND NOM_TIPO_IDENTIFICACION= '" + valueObject.NOM_TIPO_IDENTIFICACION + "' ";
		}

		sql += "ORDER BY ID_TIPO_IDENTIFICACION ASC ";

		if (first)
			searchResults = new List<Tipoidentificacion>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Tipoidentificacion> searchMatching(SqlConnection conn, Tipoidentificacion valueObject, int limiteInf, int limiteSup) {
		List<Tipoidentificacion> searchResults = new List<Tipoidentificacion>();
		bool first = true;
		String sql = "SELECT * FROM TIPO_IDENTIFICACION WHERE 1=1 ";
		if (valueObject.ID_TIPO_IDENTIFICACION != null && valueObject.ID_TIPO_IDENTIFICACION != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_IDENTIFICACION= " + valueObject.ID_TIPO_IDENTIFICACION + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_TIPO_IDENTIFICACION)) {
			if (first) { first = false; }
			sql += "AND NOM_TIPO_IDENTIFICACION= '" + valueObject.NOM_TIPO_IDENTIFICACION + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Tipoidentificacion>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Tipoidentificacion valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM TIPO_IDENTIFICACION WHERE 1=1 ";
		if (valueObject.ID_TIPO_IDENTIFICACION != null && valueObject.ID_TIPO_IDENTIFICACION != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_IDENTIFICACION= " + valueObject.ID_TIPO_IDENTIFICACION + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_TIPO_IDENTIFICACION)) {
			if (first) { first = false; }
			sql += "AND NOM_TIPO_IDENTIFICACION= '" + valueObject.NOM_TIPO_IDENTIFICACION + "' ";
		}

		SqlCommand stmt = null;
		SqlDataReader result = null;
		int allRows = 0;
		try {
			stmt = new SqlCommand(sql,conn);
			result = stmt.ExecuteReader();
			if (result.Read())
				allRows = int.Parse(result[0].ToString());
		} finally {
			if (!result.IsClosed)
				result.Close();
			if (stmt != null)
				stmt.Dispose();
		}
		return allRows;
	}


	private int databaseUpdate(SqlCommand stmt) {
		int result = stmt.ExecuteNonQuery();
		return result;
	}


	private List<Tipoidentificacion> listQuery(SqlCommand stmt) {

		List<Tipoidentificacion> searchResults = new List<Tipoidentificacion>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Tipoidentificacion temp = createValueObject();

				temp.ID_TIPO_IDENTIFICACION= reader["ID_TIPO_IDENTIFICACION"] != null && long.TryParse(reader["ID_TIPO_IDENTIFICACION"].ToString(),out longg) ? longg : 0;
				temp.NOM_TIPO_IDENTIFICACION= reader["NOM_TIPO_IDENTIFICACION"] != null ? reader["NOM_TIPO_IDENTIFICACION"].ToString() : null;
				searchResults.Add(temp);
			}
		}
		finally {
			if(!reader.IsClosed)
				reader.Close();
			if (stmt != null)
				stmt.Dispose();
		}
		return searchResults;
	}


}

}
