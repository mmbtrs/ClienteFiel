using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class HistorialdescuentoDao {


	public Historialdescuento createValueObject() {
		return new Historialdescuento();
	}

	public List<Historialdescuento> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM HISTORIAL_DESCUENTO ORDER BY ID_HISTORIAL_DESCUENTO ASC ";
		List<Historialdescuento> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Historialdescuento> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_HISTORIAL_DESCUENTO) AS RowNumber FROM HISTORIAL_DESCUENTO) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Historialdescuento> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Historialdescuento valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO HISTORIAL_DESCUENTO ( ID_HISTORIAL_DESCUENTO,"+
			" ID_IMAGEN, ID_DESCUENTO, ID_USUARIO,"+
			" FECHA, HORA, NUM_FACTURA"+
			")"+
			 "VALUES ( @ID_HISTORIAL_DESCUENTO, @ID_IMAGEN, @ID_DESCUENTO, @ID_USUARIO, @FECHA, @HORA, @NUM_FACTURA)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_HISTORIAL_DESCUENTO", valueObject.ID_HISTORIAL_DESCUENTO);
				if(valueObject.ID_IMAGEN!=0)
					stmt.Parameters.AddWithValue("@ID_IMAGEN", valueObject.ID_IMAGEN);
				else
					stmt.Parameters.AddWithValue("@ID_IMAGEN", DBNull.Value);
				if(valueObject.ID_DESCUENTO!=0)
					stmt.Parameters.AddWithValue("@ID_DESCUENTO", valueObject.ID_DESCUENTO);
				else
					stmt.Parameters.AddWithValue("@ID_DESCUENTO", DBNull.Value);
				if(valueObject.ID_USUARIO!=0)
					stmt.Parameters.AddWithValue("@ID_USUARIO", valueObject.ID_USUARIO);
				else
					stmt.Parameters.AddWithValue("@ID_USUARIO", DBNull.Value);
				if(valueObject.FECHA != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA", valueObject.FECHA);
				else
					stmt.Parameters.AddWithValue("@FECHA", DBNull.Value);
				if(valueObject.HORA != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@HORA", valueObject.HORA);
				else
					stmt.Parameters.AddWithValue("@HORA", DBNull.Value);
				if(valueObject.NUM_FACTURA!=null &&valueObject.NUM_FACTURA.Length <= 100)
					stmt.Parameters.AddWithValue("@NUM_FACTURA", valueObject.NUM_FACTURA);
				else
					stmt.Parameters.AddWithValue("@NUM_FACTURA", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Historialdescuento valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE HISTORIAL_DESCUENTO SET  ID_IMAGEN = @ID_IMAGEN , ID_DESCUENTO = @ID_DESCUENTO , ID_USUARIO = @ID_USUARIO ,"+
			" FECHA = @FECHA , HORA = @HORA , NUM_FACTURA = @NUM_FACTURA "+
			" WHERE (ID_HISTORIAL_DESCUENTO= @ID_HISTORIAL_DESCUENTO)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.ID_IMAGEN!=0)
					stmt.Parameters.AddWithValue("@ID_IMAGEN", valueObject.ID_IMAGEN);
				else
					stmt.Parameters.AddWithValue("@ID_IMAGEN", DBNull.Value);
				if(valueObject.ID_DESCUENTO!=0)
					stmt.Parameters.AddWithValue("@ID_DESCUENTO", valueObject.ID_DESCUENTO);
				else
					stmt.Parameters.AddWithValue("@ID_DESCUENTO", DBNull.Value);
				if(valueObject.ID_USUARIO!=0)
					stmt.Parameters.AddWithValue("@ID_USUARIO", valueObject.ID_USUARIO);
				else
					stmt.Parameters.AddWithValue("@ID_USUARIO", DBNull.Value);
				if(valueObject.FECHA != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA", valueObject.FECHA);
				else
					stmt.Parameters.AddWithValue("@FECHA", DBNull.Value);
				if(valueObject.HORA != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@HORA", valueObject.HORA);
				else
					stmt.Parameters.AddWithValue("@HORA", DBNull.Value);
				if(valueObject.NUM_FACTURA!=null &&valueObject.NUM_FACTURA.Length <= 100)
					stmt.Parameters.AddWithValue("@NUM_FACTURA", valueObject.NUM_FACTURA);
				else
					stmt.Parameters.AddWithValue("@NUM_FACTURA", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_HISTORIAL_DESCUENTO", valueObject.ID_HISTORIAL_DESCUENTO);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Historialdescuento valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM HISTORIAL_DESCUENTO WHERE (ID_HISTORIAL_DESCUENTO = @ID_HISTORIAL_DESCUENTO )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_HISTORIAL_DESCUENTO", valueObject.ID_HISTORIAL_DESCUENTO);

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
		String sql = "SELECT count(*) FROM HISTORIAL_DESCUENTO";
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
	public List<Historialdescuento> searchMatching(SqlConnection conn, Historialdescuento valueObject) {
		List<Historialdescuento> searchResults = new List<Historialdescuento>();
		bool first = true;
		String sql = "SELECT * FROM HISTORIAL_DESCUENTO WHERE 1=1 ";
		if (valueObject.ID_HISTORIAL_DESCUENTO != null && valueObject.ID_HISTORIAL_DESCUENTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_HISTORIAL_DESCUENTO= " + valueObject.ID_HISTORIAL_DESCUENTO + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (valueObject.ID_DESCUENTO != null && valueObject.ID_DESCUENTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_DESCUENTO= " + valueObject.ID_DESCUENTO + " ";
		}

		if (valueObject.ID_USUARIO != null && valueObject.ID_USUARIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_USUARIO= " + valueObject.ID_USUARIO + " ";
		}

		if (valueObject.FECHA != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA= '" + valueObject.FECHA.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (valueObject.HORA != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND HORA= '" + valueObject.HORA.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.NUM_FACTURA)) {
			if (first) { first = false; }
			sql += "AND NUM_FACTURA= '" + valueObject.NUM_FACTURA + "' ";
		}

		sql += "ORDER BY ID_HISTORIAL_DESCUENTO ASC ";

		if (first)
			searchResults = new List<Historialdescuento>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Historialdescuento> searchMatching(SqlConnection conn, Historialdescuento valueObject, int limiteInf, int limiteSup) {
		List<Historialdescuento> searchResults = new List<Historialdescuento>();
		bool first = true;
		String sql = "SELECT * FROM HISTORIAL_DESCUENTO WHERE 1=1 ";
		if (valueObject.ID_HISTORIAL_DESCUENTO != null && valueObject.ID_HISTORIAL_DESCUENTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_HISTORIAL_DESCUENTO= " + valueObject.ID_HISTORIAL_DESCUENTO + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (valueObject.ID_DESCUENTO != null && valueObject.ID_DESCUENTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_DESCUENTO= " + valueObject.ID_DESCUENTO + " ";
		}

		if (valueObject.ID_USUARIO != null && valueObject.ID_USUARIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_USUARIO= " + valueObject.ID_USUARIO + " ";
		}

		if (valueObject.FECHA != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA= '" + valueObject.FECHA.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (valueObject.HORA != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND HORA= '" + valueObject.HORA.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.NUM_FACTURA)) {
			if (first) { first = false; }
			sql += "AND NUM_FACTURA= '" + valueObject.NUM_FACTURA + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Historialdescuento>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Historialdescuento valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM HISTORIAL_DESCUENTO WHERE 1=1 ";
		if (valueObject.ID_HISTORIAL_DESCUENTO != null && valueObject.ID_HISTORIAL_DESCUENTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_HISTORIAL_DESCUENTO= " + valueObject.ID_HISTORIAL_DESCUENTO + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (valueObject.ID_DESCUENTO != null && valueObject.ID_DESCUENTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_DESCUENTO= " + valueObject.ID_DESCUENTO + " ";
		}

		if (valueObject.ID_USUARIO != null && valueObject.ID_USUARIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_USUARIO= " + valueObject.ID_USUARIO + " ";
		}

		if (valueObject.FECHA != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA= '" + valueObject.FECHA.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (valueObject.HORA != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND HORA= '" + valueObject.HORA.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.NUM_FACTURA)) {
			if (first) { first = false; }
			sql += "AND NUM_FACTURA= '" + valueObject.NUM_FACTURA + "' ";
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


	private List<Historialdescuento> listQuery(SqlCommand stmt) {

		List<Historialdescuento> searchResults = new List<Historialdescuento>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Historialdescuento temp = createValueObject();

				temp.ID_HISTORIAL_DESCUENTO= reader["ID_HISTORIAL_DESCUENTO"] != null && long.TryParse(reader["ID_HISTORIAL_DESCUENTO"].ToString(),out longg) ? longg : 0;
				temp.ID_IMAGEN= reader["ID_IMAGEN"] != null && long.TryParse(reader["ID_IMAGEN"].ToString(),out longg) ? longg : 0;
				temp.ID_DESCUENTO= reader["ID_DESCUENTO"] != null && long.TryParse(reader["ID_DESCUENTO"].ToString(),out longg) ? longg : 0;
				temp.ID_USUARIO= reader["ID_USUARIO"] != null && long.TryParse(reader["ID_USUARIO"].ToString(),out longg) ? longg : 0;
				temp.FECHA=  reader["FECHA"] != null && !String.IsNullOrEmpty(reader["FECHA"].ToString()) ? (DateTime)reader["FECHA"] : DateTime.MinValue;
				temp.HORA=  reader["HORA"] != null && !String.IsNullOrEmpty(reader["HORA"].ToString()) ? (DateTime)reader["HORA"] : DateTime.MinValue;
				temp.NUM_FACTURA= reader["NUM_FACTURA"] != null ? reader["NUM_FACTURA"].ToString() : null;
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
