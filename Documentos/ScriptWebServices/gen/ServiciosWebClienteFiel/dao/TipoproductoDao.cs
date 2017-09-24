using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class TipoproductoDao {


	public Tipoproducto createValueObject() {
		return new Tipoproducto();
	}

	public List<Tipoproducto> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM TIPO_PRODUCTO ORDER BY ID_TIPO_PRODUCTO ASC ";
		List<Tipoproducto> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Tipoproducto> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_TIPO_PRODUCTO) AS RowNumber FROM TIPO_PRODUCTO) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Tipoproducto> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Tipoproducto valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO TIPO_PRODUCTO ( ID_TIPO_PRODUCTO,"+
			" NOM_TIPO_PRODUCTO)"+
			 "VALUES ( @ID_TIPO_PRODUCTO, @NOM_TIPO_PRODUCTO)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_TIPO_PRODUCTO", valueObject.ID_TIPO_PRODUCTO);
				if(valueObject.NOM_TIPO_PRODUCTO!=null &&valueObject.NOM_TIPO_PRODUCTO.Length <= 100)
					stmt.Parameters.AddWithValue("@NOM_TIPO_PRODUCTO", valueObject.NOM_TIPO_PRODUCTO);
				else
					stmt.Parameters.AddWithValue("@NOM_TIPO_PRODUCTO", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Tipoproducto valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE TIPO_PRODUCTO SET  NOM_TIPO_PRODUCTO = @NOM_TIPO_PRODUCTO  WHERE (ID_TIPO_PRODUCTO= @ID_TIPO_PRODUCTO)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.NOM_TIPO_PRODUCTO!=null &&valueObject.NOM_TIPO_PRODUCTO.Length <= 100)
					stmt.Parameters.AddWithValue("@NOM_TIPO_PRODUCTO", valueObject.NOM_TIPO_PRODUCTO);
				else
					stmt.Parameters.AddWithValue("@NOM_TIPO_PRODUCTO", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_TIPO_PRODUCTO", valueObject.ID_TIPO_PRODUCTO);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Tipoproducto valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM TIPO_PRODUCTO WHERE (ID_TIPO_PRODUCTO = @ID_TIPO_PRODUCTO )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_TIPO_PRODUCTO", valueObject.ID_TIPO_PRODUCTO);

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
		String sql = "SELECT count(*) FROM TIPO_PRODUCTO";
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
	public List<Tipoproducto> searchMatching(SqlConnection conn, Tipoproducto valueObject) {
		List<Tipoproducto> searchResults = new List<Tipoproducto>();
		bool first = true;
		String sql = "SELECT * FROM TIPO_PRODUCTO WHERE 1=1 ";
		if (valueObject.ID_TIPO_PRODUCTO != null && valueObject.ID_TIPO_PRODUCTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_PRODUCTO= " + valueObject.ID_TIPO_PRODUCTO + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_TIPO_PRODUCTO)) {
			if (first) { first = false; }
			sql += "AND NOM_TIPO_PRODUCTO= '" + valueObject.NOM_TIPO_PRODUCTO + "' ";
		}

		sql += "ORDER BY ID_TIPO_PRODUCTO ASC ";

		if (first)
			searchResults = new List<Tipoproducto>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Tipoproducto> searchMatching(SqlConnection conn, Tipoproducto valueObject, int limiteInf, int limiteSup) {
		List<Tipoproducto> searchResults = new List<Tipoproducto>();
		bool first = true;
		String sql = "SELECT * FROM TIPO_PRODUCTO WHERE 1=1 ";
		if (valueObject.ID_TIPO_PRODUCTO != null && valueObject.ID_TIPO_PRODUCTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_PRODUCTO= " + valueObject.ID_TIPO_PRODUCTO + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_TIPO_PRODUCTO)) {
			if (first) { first = false; }
			sql += "AND NOM_TIPO_PRODUCTO= '" + valueObject.NOM_TIPO_PRODUCTO + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Tipoproducto>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Tipoproducto valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM TIPO_PRODUCTO WHERE 1=1 ";
		if (valueObject.ID_TIPO_PRODUCTO != null && valueObject.ID_TIPO_PRODUCTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_PRODUCTO= " + valueObject.ID_TIPO_PRODUCTO + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_TIPO_PRODUCTO)) {
			if (first) { first = false; }
			sql += "AND NOM_TIPO_PRODUCTO= '" + valueObject.NOM_TIPO_PRODUCTO + "' ";
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


	private List<Tipoproducto> listQuery(SqlCommand stmt) {

		List<Tipoproducto> searchResults = new List<Tipoproducto>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Tipoproducto temp = createValueObject();

				temp.ID_TIPO_PRODUCTO= reader["ID_TIPO_PRODUCTO"] != null && long.TryParse(reader["ID_TIPO_PRODUCTO"].ToString(),out longg) ? longg : 0;
				temp.NOM_TIPO_PRODUCTO= reader["NOM_TIPO_PRODUCTO"] != null ? reader["NOM_TIPO_PRODUCTO"].ToString() : null;
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
