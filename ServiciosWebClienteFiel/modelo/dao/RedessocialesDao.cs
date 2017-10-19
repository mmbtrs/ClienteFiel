using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class RedessocialesDao {


	public Redessociales createValueObject() {
		return new Redessociales();
	}

	public List<Redessociales> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM REDES_SOCIALES ORDER BY ID_REDES_SOCIALES ASC ";
		List<Redessociales> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Redessociales> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_REDES_SOCIALES) AS RowNumber FROM REDES_SOCIALES) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Redessociales> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Redessociales valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO REDES_SOCIALES ( ID_REDES_SOCIALES,"+
			" ID_TIPO_RED_SOCIAL, URL)"+
			 "VALUES ( @ID_REDES_SOCIALES, @ID_TIPO_RED_SOCIAL, @URL)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_REDES_SOCIALES", valueObject.ID_REDES_SOCIALES);
				if(valueObject.ID_TIPO_RED_SOCIAL!=0)
					stmt.Parameters.AddWithValue("@ID_TIPO_RED_SOCIAL", valueObject.ID_TIPO_RED_SOCIAL);
				else
					stmt.Parameters.AddWithValue("@ID_TIPO_RED_SOCIAL", DBNull.Value);
				if(valueObject.URL!=null &&valueObject.URL.Length <= 500)
					stmt.Parameters.AddWithValue("@URL", valueObject.URL);
				else
					stmt.Parameters.AddWithValue("@URL", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Redessociales valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE REDES_SOCIALES SET  ID_TIPO_RED_SOCIAL = @ID_TIPO_RED_SOCIAL , URL = @URL  WHERE (ID_REDES_SOCIALES= @ID_REDES_SOCIALES)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.ID_TIPO_RED_SOCIAL!=0)
					stmt.Parameters.AddWithValue("@ID_TIPO_RED_SOCIAL", valueObject.ID_TIPO_RED_SOCIAL);
				else
					stmt.Parameters.AddWithValue("@ID_TIPO_RED_SOCIAL", DBNull.Value);
				if(valueObject.URL!=null &&valueObject.URL.Length <= 500)
					stmt.Parameters.AddWithValue("@URL", valueObject.URL);
				else
					stmt.Parameters.AddWithValue("@URL", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_REDES_SOCIALES", valueObject.ID_REDES_SOCIALES);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Redessociales valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM REDES_SOCIALES WHERE (ID_REDES_SOCIALES = @ID_REDES_SOCIALES )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_REDES_SOCIALES", valueObject.ID_REDES_SOCIALES);

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
		String sql = "SELECT count(*) FROM REDES_SOCIALES";
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
	public List<Redessociales> searchMatching(SqlConnection conn, Redessociales valueObject) {
		List<Redessociales> searchResults = new List<Redessociales>();
		bool first = true;
		String sql = "SELECT * FROM REDES_SOCIALES WHERE 1=1 ";
		if (valueObject.ID_REDES_SOCIALES != null && valueObject.ID_REDES_SOCIALES != 0) {
			if (first) { first = false; }
			sql += "AND ID_REDES_SOCIALES= " + valueObject.ID_REDES_SOCIALES + " ";
		}

		if (valueObject.ID_TIPO_RED_SOCIAL != null && valueObject.ID_TIPO_RED_SOCIAL != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_RED_SOCIAL= " + valueObject.ID_TIPO_RED_SOCIAL + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.URL)) {
			if (first) { first = false; }
			sql += "AND URL= '" + valueObject.URL + "' ";
		}

		sql += "ORDER BY ID_REDES_SOCIALES ASC ";

		if (first)
			searchResults = new List<Redessociales>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Redessociales> searchMatching(SqlConnection conn, Redessociales valueObject, int limiteInf, int limiteSup) {
		List<Redessociales> searchResults = new List<Redessociales>();
		bool first = true;
		String sql = "SELECT * FROM REDES_SOCIALES WHERE 1=1 ";
		if (valueObject.ID_REDES_SOCIALES != null && valueObject.ID_REDES_SOCIALES != 0) {
			if (first) { first = false; }
			sql += "AND ID_REDES_SOCIALES= " + valueObject.ID_REDES_SOCIALES + " ";
		}

		if (valueObject.ID_TIPO_RED_SOCIAL != null && valueObject.ID_TIPO_RED_SOCIAL != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_RED_SOCIAL= " + valueObject.ID_TIPO_RED_SOCIAL + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.URL)) {
			if (first) { first = false; }
			sql += "AND URL= '" + valueObject.URL + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Redessociales>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Redessociales valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM REDES_SOCIALES WHERE 1=1 ";
		if (valueObject.ID_REDES_SOCIALES != null && valueObject.ID_REDES_SOCIALES != 0) {
			if (first) { first = false; }
			sql += "AND ID_REDES_SOCIALES= " + valueObject.ID_REDES_SOCIALES + " ";
		}

		if (valueObject.ID_TIPO_RED_SOCIAL != null && valueObject.ID_TIPO_RED_SOCIAL != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_RED_SOCIAL= " + valueObject.ID_TIPO_RED_SOCIAL + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.URL)) {
			if (first) { first = false; }
			sql += "AND URL= '" + valueObject.URL + "' ";
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


	private List<Redessociales> listQuery(SqlCommand stmt) {

		List<Redessociales> searchResults = new List<Redessociales>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Redessociales temp = createValueObject();

				temp.ID_REDES_SOCIALES= reader["ID_REDES_SOCIALES"] != null && long.TryParse(reader["ID_REDES_SOCIALES"].ToString(),out longg) ? longg : 0;
				temp.ID_TIPO_RED_SOCIAL= reader["ID_TIPO_RED_SOCIAL"] != null && long.TryParse(reader["ID_TIPO_RED_SOCIAL"].ToString(),out longg) ? longg : 0;
				temp.URL= reader["URL"] != null ? reader["URL"].ToString() : null;
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
