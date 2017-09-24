using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class ImagenDao {


	public Imagen createValueObject() {
		return new Imagen();
	}

	public List<Imagen> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM IMAGEN ORDER BY ID_IMAGEN ASC ";
		List<Imagen> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Imagen> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_IMAGEN) AS RowNumber FROM IMAGEN) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Imagen> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Imagen valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO IMAGEN ( ID_IMAGEN,"+
			" RUTA, IMAGEN)"+
			 "VALUES ( @ID_IMAGEN, @RUTA, @IMAGEN)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_IMAGEN", valueObject.ID_IMAGEN);
				if(valueObject.RUTA!=null &&valueObject.RUTA.Length <= 1000)
					stmt.Parameters.AddWithValue("@RUTA", valueObject.RUTA);
				else
					stmt.Parameters.AddWithValue("@RUTA", DBNull.Value);
				if(valueObject.IMAGEN!=null &&valueObject.IMAGEN.Length <= 2147483647)
					stmt.Parameters.AddWithValue("@IMAGEN", valueObject.IMAGEN);
				else
					stmt.Parameters.AddWithValue("@IMAGEN", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Imagen valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE IMAGEN SET  RUTA = @RUTA , IMAGEN = @IMAGEN  WHERE (ID_IMAGEN= @ID_IMAGEN)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.RUTA!=null &&valueObject.RUTA.Length <= 1000)
					stmt.Parameters.AddWithValue("@RUTA", valueObject.RUTA);
				else
					stmt.Parameters.AddWithValue("@RUTA", DBNull.Value);
				if(valueObject.IMAGEN!=null &&valueObject.IMAGEN.Length <= 2147483647)
					stmt.Parameters.AddWithValue("@IMAGEN", valueObject.IMAGEN);
				else
					stmt.Parameters.AddWithValue("@IMAGEN", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_IMAGEN", valueObject.ID_IMAGEN);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Imagen valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM IMAGEN WHERE (ID_IMAGEN = @ID_IMAGEN )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_IMAGEN", valueObject.ID_IMAGEN);

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
		String sql = "SELECT count(*) FROM IMAGEN";
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
	public List<Imagen> searchMatching(SqlConnection conn, Imagen valueObject) {
		List<Imagen> searchResults = new List<Imagen>();
		bool first = true;
		String sql = "SELECT * FROM IMAGEN WHERE 1=1 ";
		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.RUTA)) {
			if (first) { first = false; }
			sql += "AND RUTA= '" + valueObject.RUTA + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.IMAGEN)) {
			if (first) { first = false; }
			sql += "AND IMAGEN= '" + valueObject.IMAGEN + "' ";
		}

		sql += "ORDER BY ID_IMAGEN ASC ";

		if (first)
			searchResults = new List<Imagen>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Imagen> searchMatching(SqlConnection conn, Imagen valueObject, int limiteInf, int limiteSup) {
		List<Imagen> searchResults = new List<Imagen>();
		bool first = true;
		String sql = "SELECT * FROM IMAGEN WHERE 1=1 ";
		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.RUTA)) {
			if (first) { first = false; }
			sql += "AND RUTA= '" + valueObject.RUTA + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.IMAGEN)) {
			if (first) { first = false; }
			sql += "AND IMAGEN= '" + valueObject.IMAGEN + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Imagen>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Imagen valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM IMAGEN WHERE 1=1 ";
		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.RUTA)) {
			if (first) { first = false; }
			sql += "AND RUTA= '" + valueObject.RUTA + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.IMAGEN)) {
			if (first) { first = false; }
			sql += "AND IMAGEN= '" + valueObject.IMAGEN + "' ";
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


	private List<Imagen> listQuery(SqlCommand stmt) {

		List<Imagen> searchResults = new List<Imagen>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Imagen temp = createValueObject();

				temp.ID_IMAGEN= reader["ID_IMAGEN"] != null && long.TryParse(reader["ID_IMAGEN"].ToString(),out longg) ? longg : 0;
				temp.RUTA= reader["RUTA"] != null ? reader["RUTA"].ToString() : null;
				temp.IMAGEN= reader["IMAGEN"] != null ? reader["IMAGEN"].ToString() : null;
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
