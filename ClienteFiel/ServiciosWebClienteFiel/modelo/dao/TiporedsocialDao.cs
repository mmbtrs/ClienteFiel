using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class TiporedsocialDao {


	public Tiporedsocial createValueObject() {
		return new Tiporedsocial();
	}

	public List<Tiporedsocial> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM TIPO_RED_SOCIAL ORDER BY ID_TIPO_RED_SOCIAL ASC ";
		List<Tiporedsocial> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Tiporedsocial> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_TIPO_RED_SOCIAL) AS RowNumber FROM TIPO_RED_SOCIAL) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Tiporedsocial> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Tiporedsocial valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO TIPO_RED_SOCIAL ( "+
			" ID_IMAGEN, NOM_TIPO_RED_SOCIAL)"+
			 "VALUES ( @ID_IMAGEN, @NOM_TIPO_RED_SOCIAL)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.ID_IMAGEN!=0)
					stmt.Parameters.AddWithValue("@ID_IMAGEN", valueObject.ID_IMAGEN);
				else
					stmt.Parameters.AddWithValue("@ID_IMAGEN", DBNull.Value);
				if(valueObject.NOM_TIPO_RED_SOCIAL!=null &&valueObject.NOM_TIPO_RED_SOCIAL.Length <= 100)
					stmt.Parameters.AddWithValue("@NOM_TIPO_RED_SOCIAL", valueObject.NOM_TIPO_RED_SOCIAL);
				else
					stmt.Parameters.AddWithValue("@NOM_TIPO_RED_SOCIAL", DBNull.Value);
				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Tiporedsocial valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE TIPO_RED_SOCIAL SET  ID_IMAGEN = @ID_IMAGEN , NOM_TIPO_RED_SOCIAL = @NOM_TIPO_RED_SOCIAL  WHERE (ID_TIPO_RED_SOCIAL= @ID_TIPO_RED_SOCIAL)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.ID_IMAGEN!=0)
					stmt.Parameters.AddWithValue("@ID_IMAGEN", valueObject.ID_IMAGEN);
				else
					stmt.Parameters.AddWithValue("@ID_IMAGEN", DBNull.Value);
				if(valueObject.NOM_TIPO_RED_SOCIAL!=null &&valueObject.NOM_TIPO_RED_SOCIAL.Length <= 100)
					stmt.Parameters.AddWithValue("@NOM_TIPO_RED_SOCIAL", valueObject.NOM_TIPO_RED_SOCIAL);
				else
					stmt.Parameters.AddWithValue("@NOM_TIPO_RED_SOCIAL", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_TIPO_RED_SOCIAL", valueObject.ID_TIPO_RED_SOCIAL);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Tiporedsocial valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM TIPO_RED_SOCIAL WHERE (ID_TIPO_RED_SOCIAL = @ID_TIPO_RED_SOCIAL )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_TIPO_RED_SOCIAL", valueObject.ID_TIPO_RED_SOCIAL);

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
		String sql = "SELECT count(*) FROM TIPO_RED_SOCIAL";
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
	public List<Tiporedsocial> searchMatching(SqlConnection conn, Tiporedsocial valueObject) {
		List<Tiporedsocial> searchResults = new List<Tiporedsocial>();
		bool first = true;
		String sql = "SELECT * FROM TIPO_RED_SOCIAL WHERE 1=1 ";
		if (valueObject.ID_TIPO_RED_SOCIAL != null && valueObject.ID_TIPO_RED_SOCIAL != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_RED_SOCIAL= " + valueObject.ID_TIPO_RED_SOCIAL + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_TIPO_RED_SOCIAL)) {
			if (first) { first = false; }
			sql += "AND NOM_TIPO_RED_SOCIAL= '" + valueObject.NOM_TIPO_RED_SOCIAL + "' ";
		}

		sql += "ORDER BY ID_TIPO_RED_SOCIAL ASC ";

		if (first)
			searchResults = new List<Tiporedsocial>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Tiporedsocial> searchMatching(SqlConnection conn, Tiporedsocial valueObject, int limiteInf, int limiteSup) {
		List<Tiporedsocial> searchResults = new List<Tiporedsocial>();
		bool first = true;
		String sql = "SELECT * FROM TIPO_RED_SOCIAL WHERE 1=1 ";
		if (valueObject.ID_TIPO_RED_SOCIAL != null && valueObject.ID_TIPO_RED_SOCIAL != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_RED_SOCIAL= " + valueObject.ID_TIPO_RED_SOCIAL + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_TIPO_RED_SOCIAL)) {
			if (first) { first = false; }
			sql += "AND NOM_TIPO_RED_SOCIAL= '" + valueObject.NOM_TIPO_RED_SOCIAL + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Tiporedsocial>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Tiporedsocial valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM TIPO_RED_SOCIAL WHERE 1=1 ";
		if (valueObject.ID_TIPO_RED_SOCIAL != null && valueObject.ID_TIPO_RED_SOCIAL != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_RED_SOCIAL= " + valueObject.ID_TIPO_RED_SOCIAL + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_TIPO_RED_SOCIAL)) {
			if (first) { first = false; }
			sql += "AND NOM_TIPO_RED_SOCIAL= '" + valueObject.NOM_TIPO_RED_SOCIAL + "' ";
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


	private List<Tiporedsocial> listQuery(SqlCommand stmt) {

		List<Tiporedsocial> searchResults = new List<Tiporedsocial>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Tiporedsocial temp = createValueObject();

				temp.ID_TIPO_RED_SOCIAL= reader["ID_TIPO_RED_SOCIAL"] != null && long.TryParse(reader["ID_TIPO_RED_SOCIAL"].ToString(),out longg) ? longg : 0;
				temp.ID_IMAGEN= reader["ID_IMAGEN"] != null && long.TryParse(reader["ID_IMAGEN"].ToString(),out longg) ? longg : 0;
				temp.NOM_TIPO_RED_SOCIAL= reader["NOM_TIPO_RED_SOCIAL"] != null ? reader["NOM_TIPO_RED_SOCIAL"].ToString() : null;
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
