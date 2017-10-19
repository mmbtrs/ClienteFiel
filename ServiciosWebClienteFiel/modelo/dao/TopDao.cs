using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class TopDao {


	public Top createValueObject() {
		return new Top();
	}

	public List<Top> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM TOP ORDER BY ID_TOP ASC ";
		List<Top> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Top> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_TOP) AS RowNumber FROM TOP) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Top> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Top valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO TOP ( ID_TOP,"+
			" ID_EMPRESA, ID_IMAGEN, NOM_TOP,"+
			" URL)"+
			 "VALUES ( @ID_TOP, @ID_EMPRESA, @ID_IMAGEN, @NOM_TOP, @URL)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_TOP", valueObject.ID_TOP);
				if(valueObject.ID_EMPRESA!=0)
					stmt.Parameters.AddWithValue("@ID_EMPRESA", valueObject.ID_EMPRESA);
				else
					stmt.Parameters.AddWithValue("@ID_EMPRESA", DBNull.Value);
				if(valueObject.ID_IMAGEN!=0)
					stmt.Parameters.AddWithValue("@ID_IMAGEN", valueObject.ID_IMAGEN);
				else
					stmt.Parameters.AddWithValue("@ID_IMAGEN", DBNull.Value);
				if(valueObject.NOM_TOP!=null &&valueObject.NOM_TOP.Length <= 100)
					stmt.Parameters.AddWithValue("@NOM_TOP", valueObject.NOM_TOP);
				else
					stmt.Parameters.AddWithValue("@NOM_TOP", DBNull.Value);
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


	public void save(SqlConnection conn, Top valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE TOP SET  ID_EMPRESA = @ID_EMPRESA , ID_IMAGEN = @ID_IMAGEN , NOM_TOP = @NOM_TOP ,"+
			" URL = @URL  WHERE (ID_TOP= @ID_TOP)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.ID_EMPRESA!=0)
					stmt.Parameters.AddWithValue("@ID_EMPRESA", valueObject.ID_EMPRESA);
				else
					stmt.Parameters.AddWithValue("@ID_EMPRESA", DBNull.Value);
				if(valueObject.ID_IMAGEN!=0)
					stmt.Parameters.AddWithValue("@ID_IMAGEN", valueObject.ID_IMAGEN);
				else
					stmt.Parameters.AddWithValue("@ID_IMAGEN", DBNull.Value);
				if(valueObject.NOM_TOP!=null &&valueObject.NOM_TOP.Length <= 100)
					stmt.Parameters.AddWithValue("@NOM_TOP", valueObject.NOM_TOP);
				else
					stmt.Parameters.AddWithValue("@NOM_TOP", DBNull.Value);
				if(valueObject.URL!=null &&valueObject.URL.Length <= 500)
					stmt.Parameters.AddWithValue("@URL", valueObject.URL);
				else
					stmt.Parameters.AddWithValue("@URL", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_TOP", valueObject.ID_TOP);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Top valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM TOP WHERE (ID_TOP = @ID_TOP )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_TOP", valueObject.ID_TOP);

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
		String sql = "SELECT count(*) FROM TOP";
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
	public List<Top> searchMatching(SqlConnection conn, Top valueObject) {
		List<Top> searchResults = new List<Top>();
		bool first = true;
		String sql = "SELECT * FROM TOP WHERE 1=1 ";
		if (valueObject.ID_TOP != null && valueObject.ID_TOP != 0) {
			if (first) { first = false; }
			sql += "AND ID_TOP= " + valueObject.ID_TOP + " ";
		}

		if (valueObject.ID_EMPRESA != null && valueObject.ID_EMPRESA != 0) {
			if (first) { first = false; }
			sql += "AND ID_EMPRESA= " + valueObject.ID_EMPRESA + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_TOP)) {
			if (first) { first = false; }
			sql += "AND NOM_TOP= '" + valueObject.NOM_TOP + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.URL)) {
			if (first) { first = false; }
			sql += "AND URL= '" + valueObject.URL + "' ";
		}

		sql += "ORDER BY ID_TOP ASC ";

		if (first)
			searchResults = new List<Top>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Top> searchMatching(SqlConnection conn, Top valueObject, int limiteInf, int limiteSup) {
		List<Top> searchResults = new List<Top>();
		bool first = true;
		String sql = "SELECT * FROM TOP WHERE 1=1 ";
		if (valueObject.ID_TOP != null && valueObject.ID_TOP != 0) {
			if (first) { first = false; }
			sql += "AND ID_TOP= " + valueObject.ID_TOP + " ";
		}

		if (valueObject.ID_EMPRESA != null && valueObject.ID_EMPRESA != 0) {
			if (first) { first = false; }
			sql += "AND ID_EMPRESA= " + valueObject.ID_EMPRESA + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_TOP)) {
			if (first) { first = false; }
			sql += "AND NOM_TOP= '" + valueObject.NOM_TOP + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.URL)) {
			if (first) { first = false; }
			sql += "AND URL= '" + valueObject.URL + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Top>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Top valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM TOP WHERE 1=1 ";
		if (valueObject.ID_TOP != null && valueObject.ID_TOP != 0) {
			if (first) { first = false; }
			sql += "AND ID_TOP= " + valueObject.ID_TOP + " ";
		}

		if (valueObject.ID_EMPRESA != null && valueObject.ID_EMPRESA != 0) {
			if (first) { first = false; }
			sql += "AND ID_EMPRESA= " + valueObject.ID_EMPRESA + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_TOP)) {
			if (first) { first = false; }
			sql += "AND NOM_TOP= '" + valueObject.NOM_TOP + "' ";
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


	private List<Top> listQuery(SqlCommand stmt) {

		List<Top> searchResults = new List<Top>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Top temp = createValueObject();

				temp.ID_TOP= reader["ID_TOP"] != null && long.TryParse(reader["ID_TOP"].ToString(),out longg) ? longg : 0;
				temp.ID_EMPRESA= reader["ID_EMPRESA"] != null && long.TryParse(reader["ID_EMPRESA"].ToString(),out longg) ? longg : 0;
				temp.ID_IMAGEN= reader["ID_IMAGEN"] != null && long.TryParse(reader["ID_IMAGEN"].ToString(),out longg) ? longg : 0;
				temp.NOM_TOP= reader["NOM_TOP"] != null ? reader["NOM_TOP"].ToString() : null;
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
