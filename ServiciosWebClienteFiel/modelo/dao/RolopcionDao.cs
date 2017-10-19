using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class RolopcionDao {


	public Rolopcion createValueObject() {
		return new Rolopcion();
	}

	public List<Rolopcion> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM ROL_OPCION ORDER BY ID_ROL_OPCION ASC ";
		List<Rolopcion> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Rolopcion> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_ROL_OPCION) AS RowNumber FROM ROL_OPCION) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Rolopcion> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Rolopcion valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO ROL_OPCION ( ID_ROL_OPCION,"+
			" ID_ROL, OPCION)"+
			 "VALUES ( @ID_ROL_OPCION, @ID_ROL, @OPCION)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_ROL_OPCION", valueObject.ID_ROL_OPCION);
				if(valueObject.ID_ROL!=0)
					stmt.Parameters.AddWithValue("@ID_ROL", valueObject.ID_ROL);
				else
					stmt.Parameters.AddWithValue("@ID_ROL", DBNull.Value);
				if(valueObject.OPCION!=null &&valueObject.OPCION.Length <= 50)
					stmt.Parameters.AddWithValue("@OPCION", valueObject.OPCION);
				else
					stmt.Parameters.AddWithValue("@OPCION", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Rolopcion valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE ROL_OPCION SET  ID_ROL = @ID_ROL , OPCION = @OPCION  WHERE (ID_ROL_OPCION= @ID_ROL_OPCION)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.ID_ROL!=0)
					stmt.Parameters.AddWithValue("@ID_ROL", valueObject.ID_ROL);
				else
					stmt.Parameters.AddWithValue("@ID_ROL", DBNull.Value);
				if(valueObject.OPCION!=null &&valueObject.OPCION.Length <= 50)
					stmt.Parameters.AddWithValue("@OPCION", valueObject.OPCION);
				else
					stmt.Parameters.AddWithValue("@OPCION", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_ROL_OPCION", valueObject.ID_ROL_OPCION);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Rolopcion valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM ROL_OPCION WHERE (ID_ROL_OPCION = @ID_ROL_OPCION )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_ROL_OPCION", valueObject.ID_ROL_OPCION);

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
		String sql = "SELECT count(*) FROM ROL_OPCION";
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
	public List<Rolopcion> searchMatching(SqlConnection conn, Rolopcion valueObject) {
		List<Rolopcion> searchResults = new List<Rolopcion>();
		bool first = true;
		String sql = "SELECT * FROM ROL_OPCION WHERE 1=1 ";
		if (valueObject.ID_ROL_OPCION != null && valueObject.ID_ROL_OPCION != 0) {
			if (first) { first = false; }
			sql += "AND ID_ROL_OPCION= " + valueObject.ID_ROL_OPCION + " ";
		}

		if (valueObject.ID_ROL != null && valueObject.ID_ROL != 0) {
			if (first) { first = false; }
			sql += "AND ID_ROL= " + valueObject.ID_ROL + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.OPCION)) {
			if (first) { first = false; }
			sql += "AND OPCION= '" + valueObject.OPCION + "' ";
		}

		sql += "ORDER BY ID_ROL_OPCION ASC ";

		if (first)
			searchResults = new List<Rolopcion>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Rolopcion> searchMatching(SqlConnection conn, Rolopcion valueObject, int limiteInf, int limiteSup) {
		List<Rolopcion> searchResults = new List<Rolopcion>();
		bool first = true;
		String sql = "SELECT * FROM ROL_OPCION WHERE 1=1 ";
		if (valueObject.ID_ROL_OPCION != null && valueObject.ID_ROL_OPCION != 0) {
			if (first) { first = false; }
			sql += "AND ID_ROL_OPCION= " + valueObject.ID_ROL_OPCION + " ";
		}

		if (valueObject.ID_ROL != null && valueObject.ID_ROL != 0) {
			if (first) { first = false; }
			sql += "AND ID_ROL= " + valueObject.ID_ROL + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.OPCION)) {
			if (first) { first = false; }
			sql += "AND OPCION= '" + valueObject.OPCION + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Rolopcion>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Rolopcion valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM ROL_OPCION WHERE 1=1 ";
		if (valueObject.ID_ROL_OPCION != null && valueObject.ID_ROL_OPCION != 0) {
			if (first) { first = false; }
			sql += "AND ID_ROL_OPCION= " + valueObject.ID_ROL_OPCION + " ";
		}

		if (valueObject.ID_ROL != null && valueObject.ID_ROL != 0) {
			if (first) { first = false; }
			sql += "AND ID_ROL= " + valueObject.ID_ROL + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.OPCION)) {
			if (first) { first = false; }
			sql += "AND OPCION= '" + valueObject.OPCION + "' ";
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


	private List<Rolopcion> listQuery(SqlCommand stmt) {

		List<Rolopcion> searchResults = new List<Rolopcion>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Rolopcion temp = createValueObject();

				temp.ID_ROL_OPCION= reader["ID_ROL_OPCION"] != null && long.TryParse(reader["ID_ROL_OPCION"].ToString(),out longg) ? longg : 0;
				temp.ID_ROL= reader["ID_ROL"] != null && long.TryParse(reader["ID_ROL"].ToString(),out longg) ? longg : 0;
				temp.OPCION= reader["OPCION"] != null ? reader["OPCION"].ToString() : null;
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
