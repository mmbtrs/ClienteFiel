using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class TipoactividadDao {


	public Tipoactividad createValueObject() {
		return new Tipoactividad();
	}

	public List<Tipoactividad> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM TIPO_ACTIVIDAD ORDER BY ID_TIPO_ACTIVIDAD ASC ";
		List<Tipoactividad> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Tipoactividad> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_TIPO_ACTIVIDAD) AS RowNumber FROM TIPO_ACTIVIDAD) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Tipoactividad> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Tipoactividad valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO TIPO_ACTIVIDAD ( "+
			" NOM_TIPO_ACTIVIDAD)"+
			 "VALUES ( @NOM_TIPO_ACTIVIDAD)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.NOM_TIPO_ACTIVIDAD!=null &&valueObject.NOM_TIPO_ACTIVIDAD.Length <= 100)
					stmt.Parameters.AddWithValue("@NOM_TIPO_ACTIVIDAD", valueObject.NOM_TIPO_ACTIVIDAD);
				else
					stmt.Parameters.AddWithValue("@NOM_TIPO_ACTIVIDAD", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Tipoactividad valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE TIPO_ACTIVIDAD SET  NOM_TIPO_ACTIVIDAD = @NOM_TIPO_ACTIVIDAD  WHERE (ID_TIPO_ACTIVIDAD= @ID_TIPO_ACTIVIDAD)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.NOM_TIPO_ACTIVIDAD!=null &&valueObject.NOM_TIPO_ACTIVIDAD.Length <= 100)
					stmt.Parameters.AddWithValue("@NOM_TIPO_ACTIVIDAD", valueObject.NOM_TIPO_ACTIVIDAD);
				else
					stmt.Parameters.AddWithValue("@NOM_TIPO_ACTIVIDAD", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_TIPO_ACTIVIDAD", valueObject.ID_TIPO_ACTIVIDAD);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Tipoactividad valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM TIPO_ACTIVIDAD WHERE (ID_TIPO_ACTIVIDAD = @ID_TIPO_ACTIVIDAD )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_TIPO_ACTIVIDAD", valueObject.ID_TIPO_ACTIVIDAD);

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
		String sql = "SELECT count(*) FROM TIPO_ACTIVIDAD";
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
	public List<Tipoactividad> searchMatching(SqlConnection conn, Tipoactividad valueObject) {
		List<Tipoactividad> searchResults = new List<Tipoactividad>();
		bool first = true;
		String sql = "SELECT * FROM TIPO_ACTIVIDAD WHERE 1=1 ";
		if (valueObject.ID_TIPO_ACTIVIDAD != null && valueObject.ID_TIPO_ACTIVIDAD != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_ACTIVIDAD= " + valueObject.ID_TIPO_ACTIVIDAD + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_TIPO_ACTIVIDAD)) {
			if (first) { first = false; }
			sql += "AND NOM_TIPO_ACTIVIDAD= '" + valueObject.NOM_TIPO_ACTIVIDAD + "' ";
		}

		sql += "ORDER BY ID_TIPO_ACTIVIDAD ASC ";

		if (first)
			searchResults = new List<Tipoactividad>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Tipoactividad> searchMatching(SqlConnection conn, Tipoactividad valueObject, int limiteInf, int limiteSup) {
		List<Tipoactividad> searchResults = new List<Tipoactividad>();
		bool first = true;
		String sql = "SELECT * FROM TIPO_ACTIVIDAD WHERE 1=1 ";
		if (valueObject.ID_TIPO_ACTIVIDAD != null && valueObject.ID_TIPO_ACTIVIDAD != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_ACTIVIDAD= " + valueObject.ID_TIPO_ACTIVIDAD + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_TIPO_ACTIVIDAD)) {
			if (first) { first = false; }
			sql += "AND NOM_TIPO_ACTIVIDAD= '" + valueObject.NOM_TIPO_ACTIVIDAD + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Tipoactividad>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Tipoactividad valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM TIPO_ACTIVIDAD WHERE 1=1 ";
		if (valueObject.ID_TIPO_ACTIVIDAD != null && valueObject.ID_TIPO_ACTIVIDAD != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_ACTIVIDAD= " + valueObject.ID_TIPO_ACTIVIDAD + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_TIPO_ACTIVIDAD)) {
			if (first) { first = false; }
			sql += "AND NOM_TIPO_ACTIVIDAD= '" + valueObject.NOM_TIPO_ACTIVIDAD + "' ";
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


	private List<Tipoactividad> listQuery(SqlCommand stmt) {

		List<Tipoactividad> searchResults = new List<Tipoactividad>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Tipoactividad temp = createValueObject();

				temp.ID_TIPO_ACTIVIDAD= reader["ID_TIPO_ACTIVIDAD"] != null && long.TryParse(reader["ID_TIPO_ACTIVIDAD"].ToString(),out longg) ? longg : 0;
				temp.NOM_TIPO_ACTIVIDAD= reader["NOM_TIPO_ACTIVIDAD"] != null ? reader["NOM_TIPO_ACTIVIDAD"].ToString() : null;
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
