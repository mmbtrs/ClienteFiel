using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class CodigoqrDao {


	public Codigoqr createValueObject() {
		return new Codigoqr();
	}

	public List<Codigoqr> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM CODIGO_QR ORDER BY ID_CODIGO_QR ASC ";
		List<Codigoqr> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Codigoqr> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_CODIGO_QR) AS RowNumber FROM CODIGO_QR) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Codigoqr> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Codigoqr valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO CODIGO_QR ( ID_CODIGO_QR,"+
			" QR)"+
			 "VALUES ( @ID_CODIGO_QR, @QR)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_CODIGO_QR", valueObject.ID_CODIGO_QR);
				if(valueObject.QR!=null &&valueObject.QR.Length <= 2147483647)
					stmt.Parameters.AddWithValue("@QR", valueObject.QR);
				else
					stmt.Parameters.AddWithValue("@QR", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Codigoqr valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE CODIGO_QR SET  QR = @QR  WHERE (ID_CODIGO_QR= @ID_CODIGO_QR)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.QR!=null &&valueObject.QR.Length <= 2147483647)
					stmt.Parameters.AddWithValue("@QR", valueObject.QR);
				else
					stmt.Parameters.AddWithValue("@QR", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_CODIGO_QR", valueObject.ID_CODIGO_QR);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Codigoqr valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM CODIGO_QR WHERE (ID_CODIGO_QR = @ID_CODIGO_QR )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_CODIGO_QR", valueObject.ID_CODIGO_QR);

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
		String sql = "SELECT count(*) FROM CODIGO_QR";
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
	public List<Codigoqr> searchMatching(SqlConnection conn, Codigoqr valueObject) {
		List<Codigoqr> searchResults = new List<Codigoqr>();
		bool first = true;
		String sql = "SELECT * FROM CODIGO_QR WHERE 1=1 ";
		if (valueObject.ID_CODIGO_QR != null && valueObject.ID_CODIGO_QR != 0) {
			if (first) { first = false; }
			sql += "AND ID_CODIGO_QR= " + valueObject.ID_CODIGO_QR + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.QR)) {
			if (first) { first = false; }
			sql += "AND QR= '" + valueObject.QR + "' ";
		}

		sql += "ORDER BY ID_CODIGO_QR ASC ";

		if (first)
			searchResults = new List<Codigoqr>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Codigoqr> searchMatching(SqlConnection conn, Codigoqr valueObject, int limiteInf, int limiteSup) {
		List<Codigoqr> searchResults = new List<Codigoqr>();
		bool first = true;
		String sql = "SELECT * FROM CODIGO_QR WHERE 1=1 ";
		if (valueObject.ID_CODIGO_QR != null && valueObject.ID_CODIGO_QR != 0) {
			if (first) { first = false; }
			sql += "AND ID_CODIGO_QR= " + valueObject.ID_CODIGO_QR + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.QR)) {
			if (first) { first = false; }
			sql += "AND QR= '" + valueObject.QR + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Codigoqr>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Codigoqr valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM CODIGO_QR WHERE 1=1 ";
		if (valueObject.ID_CODIGO_QR != null && valueObject.ID_CODIGO_QR != 0) {
			if (first) { first = false; }
			sql += "AND ID_CODIGO_QR= " + valueObject.ID_CODIGO_QR + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.QR)) {
			if (first) { first = false; }
			sql += "AND QR= '" + valueObject.QR + "' ";
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


	private List<Codigoqr> listQuery(SqlCommand stmt) {

		List<Codigoqr> searchResults = new List<Codigoqr>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Codigoqr temp = createValueObject();

				temp.ID_CODIGO_QR= reader["ID_CODIGO_QR"] != null && long.TryParse(reader["ID_CODIGO_QR"].ToString(),out longg) ? longg : 0;
				temp.QR= reader["QR"] != null ? reader["QR"].ToString() : null;
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
