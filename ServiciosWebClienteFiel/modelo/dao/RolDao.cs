using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class RolDao {


	public Rol createValueObject() {
		return new Rol();
	}

	public List<Rol> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM ROL ORDER BY ID_ROL ASC ";
		List<Rol> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Rol> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_ROL) AS RowNumber FROM ROL) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Rol> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Rol valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO ROL ( ID_ROL,"+
			" NOM_ROL)"+
			 "VALUES ( @ID_ROL, @NOM_ROL)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_ROL", valueObject.ID_ROL);
				if(valueObject.NOM_ROL!=null &&valueObject.NOM_ROL.Length <= 50)
					stmt.Parameters.AddWithValue("@NOM_ROL", valueObject.NOM_ROL);
				else
					stmt.Parameters.AddWithValue("@NOM_ROL", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Rol valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE ROL SET  NOM_ROL = @NOM_ROL  WHERE (ID_ROL= @ID_ROL)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.NOM_ROL!=null &&valueObject.NOM_ROL.Length <= 50)
					stmt.Parameters.AddWithValue("@NOM_ROL", valueObject.NOM_ROL);
				else
					stmt.Parameters.AddWithValue("@NOM_ROL", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_ROL", valueObject.ID_ROL);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Rol valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM ROL WHERE (ID_ROL = @ID_ROL )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_ROL", valueObject.ID_ROL);

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
		String sql = "SELECT count(*) FROM ROL";
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
	public List<Rol> searchMatching(SqlConnection conn, Rol valueObject) {
		List<Rol> searchResults = new List<Rol>();
		bool first = true;
		String sql = "SELECT * FROM ROL WHERE 1=1 ";
		if (valueObject.ID_ROL != null && valueObject.ID_ROL != 0) {
			if (first) { first = false; }
			sql += "AND ID_ROL= " + valueObject.ID_ROL + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_ROL)) {
			if (first) { first = false; }
			sql += "AND NOM_ROL= '" + valueObject.NOM_ROL + "' ";
		}

		sql += "ORDER BY ID_ROL ASC ";

		if (first)
			searchResults = new List<Rol>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Rol> searchMatching(SqlConnection conn, Rol valueObject, int limiteInf, int limiteSup) {
		List<Rol> searchResults = new List<Rol>();
		bool first = true;
		String sql = "SELECT * FROM ROL WHERE 1=1 ";
		if (valueObject.ID_ROL != null && valueObject.ID_ROL != 0) {
			if (first) { first = false; }
			sql += "AND ID_ROL= " + valueObject.ID_ROL + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_ROL)) {
			if (first) { first = false; }
			sql += "AND NOM_ROL= '" + valueObject.NOM_ROL + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Rol>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Rol valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM ROL WHERE 1=1 ";
		if (valueObject.ID_ROL != null && valueObject.ID_ROL != 0) {
			if (first) { first = false; }
			sql += "AND ID_ROL= " + valueObject.ID_ROL + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_ROL)) {
			if (first) { first = false; }
			sql += "AND NOM_ROL= '" + valueObject.NOM_ROL + "' ";
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


	private List<Rol> listQuery(SqlCommand stmt) {

		List<Rol> searchResults = new List<Rol>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Rol temp = createValueObject();

				temp.ID_ROL= reader["ID_ROL"] != null && long.TryParse(reader["ID_ROL"].ToString(),out longg) ? longg : 0;
				temp.NOM_ROL= reader["NOM_ROL"] != null ? reader["NOM_ROL"].ToString() : null;
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
