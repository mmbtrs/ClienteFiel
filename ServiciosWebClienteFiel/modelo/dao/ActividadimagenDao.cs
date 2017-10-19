using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class ActividadimagenDao {


	public Actividadimagen createValueObject() {
		return new Actividadimagen();
	}

	public List<Actividadimagen> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM ACTIVIDAD_IMAGEN ORDER BY ID_ACTIVIDAD ASC ";
		List<Actividadimagen> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Actividadimagen> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_ACTIVIDAD) AS RowNumber FROM ACTIVIDAD_IMAGEN) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Actividadimagen> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Actividadimagen valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO ACTIVIDAD_IMAGEN ( ID_ACTIVIDAD,"+
			" ID_IMAGEN)"+
			 "VALUES ( @ID_ACTIVIDAD, @ID_IMAGEN)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_ACTIVIDAD", valueObject.ID_ACTIVIDAD);
				if(valueObject.ID_IMAGEN!=0)
					stmt.Parameters.AddWithValue("@ID_IMAGEN", valueObject.ID_IMAGEN);
				else
					stmt.Parameters.AddWithValue("@ID_IMAGEN", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Actividadimagen valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE ACTIVIDAD_IMAGEN SET  ID_IMAGEN = @ID_IMAGEN  WHERE (ID_ACTIVIDAD= @ID_ACTIVIDAD)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.ID_IMAGEN!=0)
					stmt.Parameters.AddWithValue("@ID_IMAGEN", valueObject.ID_IMAGEN);
				else
					stmt.Parameters.AddWithValue("@ID_IMAGEN", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_ACTIVIDAD", valueObject.ID_ACTIVIDAD);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Actividadimagen valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM ACTIVIDAD_IMAGEN WHERE (ID_ACTIVIDAD = @ID_ACTIVIDAD )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_ACTIVIDAD", valueObject.ID_ACTIVIDAD);

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
		String sql = "SELECT count(*) FROM ACTIVIDAD_IMAGEN";
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
	public List<Actividadimagen> searchMatching(SqlConnection conn, Actividadimagen valueObject) {
		List<Actividadimagen> searchResults = new List<Actividadimagen>();
		bool first = true;
		String sql = "SELECT * FROM ACTIVIDAD_IMAGEN WHERE 1=1 ";
		if (valueObject.ID_ACTIVIDAD != null && valueObject.ID_ACTIVIDAD != 0) {
			if (first) { first = false; }
			sql += "AND ID_ACTIVIDAD= " + valueObject.ID_ACTIVIDAD + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		sql += "ORDER BY ID_ACTIVIDAD ASC ";

		if (first)
			searchResults = new List<Actividadimagen>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Actividadimagen> searchMatching(SqlConnection conn, Actividadimagen valueObject, int limiteInf, int limiteSup) {
		List<Actividadimagen> searchResults = new List<Actividadimagen>();
		bool first = true;
		String sql = "SELECT * FROM ACTIVIDAD_IMAGEN WHERE 1=1 ";
		if (valueObject.ID_ACTIVIDAD != null && valueObject.ID_ACTIVIDAD != 0) {
			if (first) { first = false; }
			sql += "AND ID_ACTIVIDAD= " + valueObject.ID_ACTIVIDAD + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Actividadimagen>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Actividadimagen valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM ACTIVIDAD_IMAGEN WHERE 1=1 ";
		if (valueObject.ID_ACTIVIDAD != null && valueObject.ID_ACTIVIDAD != 0) {
			if (first) { first = false; }
			sql += "AND ID_ACTIVIDAD= " + valueObject.ID_ACTIVIDAD + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
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


	private List<Actividadimagen> listQuery(SqlCommand stmt) {

		List<Actividadimagen> searchResults = new List<Actividadimagen>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Actividadimagen temp = createValueObject();

				temp.ID_ACTIVIDAD= reader["ID_ACTIVIDAD"] != null && long.TryParse(reader["ID_ACTIVIDAD"].ToString(),out longg) ? longg : 0;
				temp.ID_IMAGEN= reader["ID_IMAGEN"] != null && long.TryParse(reader["ID_IMAGEN"].ToString(),out longg) ? longg : 0;
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
