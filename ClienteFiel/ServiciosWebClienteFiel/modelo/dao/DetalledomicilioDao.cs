using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class DetalledomicilioDao {


	public Detalledomicilio createValueObject() {
		return new Detalledomicilio();
	}

	public List<Detalledomicilio> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM DETALLE_DOMICILIO ORDER BY ID_DETALLE_DOMICILIO ASC ";
		List<Detalledomicilio> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Detalledomicilio> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_DETALLE_DOMICILIO) AS RowNumber FROM DETALLE_DOMICILIO) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Detalledomicilio> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Detalledomicilio valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO DETALLE_DOMICILIO ( ID_DETALLE_DOMICILIO,"+
			" ID_DOMICILIO, ID_PRODUCTO, OBSERVACION,"+
			" CANTIDAD, SUBTOTAL)"+
			 "VALUES ( @ID_DETALLE_DOMICILIO, @ID_DOMICILIO, @ID_PRODUCTO, @OBSERVACION, @CANTIDAD, @SUBTOTAL)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_DETALLE_DOMICILIO", valueObject.ID_DETALLE_DOMICILIO);
				if(valueObject.ID_DOMICILIO!=0)
					stmt.Parameters.AddWithValue("@ID_DOMICILIO", valueObject.ID_DOMICILIO);
				else
					stmt.Parameters.AddWithValue("@ID_DOMICILIO", DBNull.Value);
				if(valueObject.ID_PRODUCTO!=0)
					stmt.Parameters.AddWithValue("@ID_PRODUCTO", valueObject.ID_PRODUCTO);
				else
					stmt.Parameters.AddWithValue("@ID_PRODUCTO", DBNull.Value);
				if(valueObject.OBSERVACION!=null &&valueObject.OBSERVACION.Length <= 8000)
					stmt.Parameters.AddWithValue("@OBSERVACION", valueObject.OBSERVACION);
				else
					stmt.Parameters.AddWithValue("@OBSERVACION", DBNull.Value);
				if(valueObject.CANTIDAD!=0)
					stmt.Parameters.AddWithValue("@CANTIDAD", valueObject.CANTIDAD);
				else
					stmt.Parameters.AddWithValue("@CANTIDAD", DBNull.Value);
				if(valueObject.SUBTOTAL!=0)
					stmt.Parameters.AddWithValue("@SUBTOTAL", valueObject.SUBTOTAL);
				else
					stmt.Parameters.AddWithValue("@SUBTOTAL", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Detalledomicilio valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE DETALLE_DOMICILIO SET  ID_DOMICILIO = @ID_DOMICILIO , ID_PRODUCTO = @ID_PRODUCTO , OBSERVACION = @OBSERVACION ,"+
			" CANTIDAD = @CANTIDAD , SUBTOTAL = @SUBTOTAL  WHERE (ID_DETALLE_DOMICILIO= @ID_DETALLE_DOMICILIO)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.ID_DOMICILIO!=0)
					stmt.Parameters.AddWithValue("@ID_DOMICILIO", valueObject.ID_DOMICILIO);
				else
					stmt.Parameters.AddWithValue("@ID_DOMICILIO", DBNull.Value);
				if(valueObject.ID_PRODUCTO!=0)
					stmt.Parameters.AddWithValue("@ID_PRODUCTO", valueObject.ID_PRODUCTO);
				else
					stmt.Parameters.AddWithValue("@ID_PRODUCTO", DBNull.Value);
				if(valueObject.OBSERVACION!=null &&valueObject.OBSERVACION.Length <= 8000)
					stmt.Parameters.AddWithValue("@OBSERVACION", valueObject.OBSERVACION);
				else
					stmt.Parameters.AddWithValue("@OBSERVACION", DBNull.Value);
				if(valueObject.CANTIDAD!=0)
					stmt.Parameters.AddWithValue("@CANTIDAD", valueObject.CANTIDAD);
				else
					stmt.Parameters.AddWithValue("@CANTIDAD", DBNull.Value);
				if(valueObject.SUBTOTAL!=0)
					stmt.Parameters.AddWithValue("@SUBTOTAL", valueObject.SUBTOTAL);
				else
					stmt.Parameters.AddWithValue("@SUBTOTAL", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_DETALLE_DOMICILIO", valueObject.ID_DETALLE_DOMICILIO);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Detalledomicilio valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM DETALLE_DOMICILIO WHERE (ID_DETALLE_DOMICILIO = @ID_DETALLE_DOMICILIO )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_DETALLE_DOMICILIO", valueObject.ID_DETALLE_DOMICILIO);

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
		String sql = "SELECT count(*) FROM DETALLE_DOMICILIO";
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
	public List<Detalledomicilio> searchMatching(SqlConnection conn, Detalledomicilio valueObject) {
		List<Detalledomicilio> searchResults = new List<Detalledomicilio>();
		bool first = true;
		String sql = "SELECT * FROM DETALLE_DOMICILIO WHERE 1=1 ";
		if (valueObject.ID_DETALLE_DOMICILIO != null && valueObject.ID_DETALLE_DOMICILIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_DETALLE_DOMICILIO= " + valueObject.ID_DETALLE_DOMICILIO + " ";
		}

		if (valueObject.ID_DOMICILIO != null && valueObject.ID_DOMICILIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_DOMICILIO= " + valueObject.ID_DOMICILIO + " ";
		}

		if (valueObject.ID_PRODUCTO != null && valueObject.ID_PRODUCTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_PRODUCTO= " + valueObject.ID_PRODUCTO + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.OBSERVACION)) {
			if (first) { first = false; }
			sql += "AND OBSERVACION= '" + valueObject.OBSERVACION + "' ";
		}

		if (valueObject.CANTIDAD != null && valueObject.CANTIDAD != 0) {
			if (first) { first = false; }
			sql += "AND CANTIDAD= " + valueObject.CANTIDAD + " ";
		}

		if (valueObject.SUBTOTAL != null && valueObject.SUBTOTAL != 0) {
			if (first) { first = false; }
			sql += "AND SUBTOTAL= " + valueObject.SUBTOTAL + " ";
		}

		sql += "ORDER BY ID_DETALLE_DOMICILIO ASC ";

		if (first)
			searchResults = new List<Detalledomicilio>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Detalledomicilio> searchMatching(SqlConnection conn, Detalledomicilio valueObject, int limiteInf, int limiteSup) {
		List<Detalledomicilio> searchResults = new List<Detalledomicilio>();
		bool first = true;
		String sql = "SELECT * FROM DETALLE_DOMICILIO WHERE 1=1 ";
		if (valueObject.ID_DETALLE_DOMICILIO != null && valueObject.ID_DETALLE_DOMICILIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_DETALLE_DOMICILIO= " + valueObject.ID_DETALLE_DOMICILIO + " ";
		}

		if (valueObject.ID_DOMICILIO != null && valueObject.ID_DOMICILIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_DOMICILIO= " + valueObject.ID_DOMICILIO + " ";
		}

		if (valueObject.ID_PRODUCTO != null && valueObject.ID_PRODUCTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_PRODUCTO= " + valueObject.ID_PRODUCTO + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.OBSERVACION)) {
			if (first) { first = false; }
			sql += "AND OBSERVACION= '" + valueObject.OBSERVACION + "' ";
		}

		if (valueObject.CANTIDAD != null && valueObject.CANTIDAD != 0) {
			if (first) { first = false; }
			sql += "AND CANTIDAD= " + valueObject.CANTIDAD + " ";
		}

		if (valueObject.SUBTOTAL != null && valueObject.SUBTOTAL != 0) {
			if (first) { first = false; }
			sql += "AND SUBTOTAL= " + valueObject.SUBTOTAL + " ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Detalledomicilio>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Detalledomicilio valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM DETALLE_DOMICILIO WHERE 1=1 ";
		if (valueObject.ID_DETALLE_DOMICILIO != null && valueObject.ID_DETALLE_DOMICILIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_DETALLE_DOMICILIO= " + valueObject.ID_DETALLE_DOMICILIO + " ";
		}

		if (valueObject.ID_DOMICILIO != null && valueObject.ID_DOMICILIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_DOMICILIO= " + valueObject.ID_DOMICILIO + " ";
		}

		if (valueObject.ID_PRODUCTO != null && valueObject.ID_PRODUCTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_PRODUCTO= " + valueObject.ID_PRODUCTO + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.OBSERVACION)) {
			if (first) { first = false; }
			sql += "AND OBSERVACION= '" + valueObject.OBSERVACION + "' ";
		}

		if (valueObject.CANTIDAD != null && valueObject.CANTIDAD != 0) {
			if (first) { first = false; }
			sql += "AND CANTIDAD= " + valueObject.CANTIDAD + " ";
		}

		if (valueObject.SUBTOTAL != null && valueObject.SUBTOTAL != 0) {
			if (first) { first = false; }
			sql += "AND SUBTOTAL= " + valueObject.SUBTOTAL + " ";
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


	private List<Detalledomicilio> listQuery(SqlCommand stmt) {

		List<Detalledomicilio> searchResults = new List<Detalledomicilio>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Detalledomicilio temp = createValueObject();

				temp.ID_DETALLE_DOMICILIO= reader["ID_DETALLE_DOMICILIO"] != null && long.TryParse(reader["ID_DETALLE_DOMICILIO"].ToString(),out longg) ? longg : 0;
				temp.ID_DOMICILIO= reader["ID_DOMICILIO"] != null && long.TryParse(reader["ID_DOMICILIO"].ToString(),out longg) ? longg : 0;
				temp.ID_PRODUCTO= reader["ID_PRODUCTO"] != null && long.TryParse(reader["ID_PRODUCTO"].ToString(),out longg) ? longg : 0;
				temp.OBSERVACION= reader["OBSERVACION"] != null ? reader["OBSERVACION"].ToString() : null;
				temp.CANTIDAD= reader["CANTIDAD"] != null && long.TryParse(reader["CANTIDAD"].ToString(),out longg) ? longg : 0;
				temp.SUBTOTAL= reader["SUBTOTAL"] != null && long.TryParse(reader["SUBTOTAL"].ToString(),out longg) ? longg : 0;
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
