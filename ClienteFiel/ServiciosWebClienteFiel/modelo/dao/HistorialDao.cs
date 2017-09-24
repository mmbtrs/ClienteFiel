using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class HistorialDao {


	public Historial createValueObject() {
		return new Historial();
	}

	public List<Historial> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM HISTORIAL ORDER BY ID_HISTORIAL ASC ";
		List<Historial> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Historial> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_HISTORIAL) AS RowNumber FROM HISTORIAL) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Historial> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Historial valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO HISTORIAL ( ID_HISTORIAL,"+
			" ID_CLIENTE, ID_IMAGEN, ID_HISTORIAL_DESCUENTO,"+
			" ID_USUARIO, FECHA, HORA,"+
			" NUM_FACTURA_VISITA, VALOR_FACTURA, ORIGEN,"+
			" ESTADO)"+
			 "VALUES ( @ID_HISTORIAL, @ID_CLIENTE, @ID_IMAGEN, @ID_HISTORIAL_DESCUENTO, @ID_USUARIO, @FECHA, @HORA, @NUM_FACTURA_VISITA, @VALOR_FACTURA, @ORIGEN, @ESTADO)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_HISTORIAL", valueObject.ID_HISTORIAL);
				if(valueObject.ID_CLIENTE!=0)
					stmt.Parameters.AddWithValue("@ID_CLIENTE", valueObject.ID_CLIENTE);
				else
					stmt.Parameters.AddWithValue("@ID_CLIENTE", DBNull.Value);
				if(valueObject.ID_IMAGEN!=0)
					stmt.Parameters.AddWithValue("@ID_IMAGEN", valueObject.ID_IMAGEN);
				else
					stmt.Parameters.AddWithValue("@ID_IMAGEN", DBNull.Value);
				if(valueObject.ID_HISTORIAL_DESCUENTO!=0)
					stmt.Parameters.AddWithValue("@ID_HISTORIAL_DESCUENTO", valueObject.ID_HISTORIAL_DESCUENTO);
				else
					stmt.Parameters.AddWithValue("@ID_HISTORIAL_DESCUENTO", DBNull.Value);
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
				if(valueObject.NUM_FACTURA_VISITA!=null &&valueObject.NUM_FACTURA_VISITA.Length <= 100)
					stmt.Parameters.AddWithValue("@NUM_FACTURA_VISITA", valueObject.NUM_FACTURA_VISITA);
				else
					stmt.Parameters.AddWithValue("@NUM_FACTURA_VISITA", DBNull.Value);
				if(valueObject.VALOR_FACTURA!=0)
					stmt.Parameters.AddWithValue("@VALOR_FACTURA", valueObject.VALOR_FACTURA);
				else
					stmt.Parameters.AddWithValue("@VALOR_FACTURA", DBNull.Value);
				if(valueObject.ORIGEN!=null &&valueObject.ORIGEN.Length <= 1)
					stmt.Parameters.AddWithValue("@ORIGEN", valueObject.ORIGEN);
				else
					stmt.Parameters.AddWithValue("@ORIGEN", DBNull.Value);
				if(valueObject.ESTADO!=null &&valueObject.ESTADO.Length <= 1)
					stmt.Parameters.AddWithValue("@ESTADO", valueObject.ESTADO);
				else
					stmt.Parameters.AddWithValue("@ESTADO", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Historial valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE HISTORIAL SET  ID_CLIENTE = @ID_CLIENTE , ID_IMAGEN = @ID_IMAGEN , ID_HISTORIAL_DESCUENTO = @ID_HISTORIAL_DESCUENTO ,"+
			" ID_USUARIO = @ID_USUARIO , FECHA = @FECHA , HORA = @HORA ,"+
			" NUM_FACTURA_VISITA = @NUM_FACTURA_VISITA , VALOR_FACTURA = @VALOR_FACTURA , ORIGEN = @ORIGEN ,"+
			" ESTADO = @ESTADO  WHERE (ID_HISTORIAL= @ID_HISTORIAL)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.ID_CLIENTE!=0)
					stmt.Parameters.AddWithValue("@ID_CLIENTE", valueObject.ID_CLIENTE);
				else
					stmt.Parameters.AddWithValue("@ID_CLIENTE", DBNull.Value);
				if(valueObject.ID_IMAGEN!=0)
					stmt.Parameters.AddWithValue("@ID_IMAGEN", valueObject.ID_IMAGEN);
				else
					stmt.Parameters.AddWithValue("@ID_IMAGEN", DBNull.Value);
				if(valueObject.ID_HISTORIAL_DESCUENTO!=0)
					stmt.Parameters.AddWithValue("@ID_HISTORIAL_DESCUENTO", valueObject.ID_HISTORIAL_DESCUENTO);
				else
					stmt.Parameters.AddWithValue("@ID_HISTORIAL_DESCUENTO", DBNull.Value);
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
				if(valueObject.NUM_FACTURA_VISITA!=null &&valueObject.NUM_FACTURA_VISITA.Length <= 100)
					stmt.Parameters.AddWithValue("@NUM_FACTURA_VISITA", valueObject.NUM_FACTURA_VISITA);
				else
					stmt.Parameters.AddWithValue("@NUM_FACTURA_VISITA", DBNull.Value);
				if(valueObject.VALOR_FACTURA!=0)
					stmt.Parameters.AddWithValue("@VALOR_FACTURA", valueObject.VALOR_FACTURA);
				else
					stmt.Parameters.AddWithValue("@VALOR_FACTURA", DBNull.Value);
				if(valueObject.ORIGEN!=null &&valueObject.ORIGEN.Length <= 1)
					stmt.Parameters.AddWithValue("@ORIGEN", valueObject.ORIGEN);
				else
					stmt.Parameters.AddWithValue("@ORIGEN", DBNull.Value);
				if(valueObject.ESTADO!=null &&valueObject.ESTADO.Length <= 1)
					stmt.Parameters.AddWithValue("@ESTADO", valueObject.ESTADO);
				else
					stmt.Parameters.AddWithValue("@ESTADO", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_HISTORIAL", valueObject.ID_HISTORIAL);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Historial valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM HISTORIAL WHERE (ID_HISTORIAL = @ID_HISTORIAL )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_HISTORIAL", valueObject.ID_HISTORIAL);

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
		String sql = "SELECT count(*) FROM HISTORIAL";
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
	public List<Historial> searchMatching(SqlConnection conn, Historial valueObject) {
		List<Historial> searchResults = new List<Historial>();
		bool first = true;
		String sql = "SELECT * FROM HISTORIAL WHERE 1=1 ";
		if (valueObject.ID_HISTORIAL != null && valueObject.ID_HISTORIAL != 0) {
			if (first) { first = false; }
			sql += "AND ID_HISTORIAL= " + valueObject.ID_HISTORIAL + " ";
		}

		if (valueObject.ID_CLIENTE != null && valueObject.ID_CLIENTE != 0) {
			if (first) { first = false; }
			sql += "AND ID_CLIENTE= " + valueObject.ID_CLIENTE + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (valueObject.ID_HISTORIAL_DESCUENTO != null && valueObject.ID_HISTORIAL_DESCUENTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_HISTORIAL_DESCUENTO= " + valueObject.ID_HISTORIAL_DESCUENTO + " ";
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

		if (!String.IsNullOrEmpty(valueObject.NUM_FACTURA_VISITA)) {
			if (first) { first = false; }
			sql += "AND NUM_FACTURA_VISITA= '" + valueObject.NUM_FACTURA_VISITA + "' ";
		}

		if (valueObject.VALOR_FACTURA != null && valueObject.VALOR_FACTURA != 0) {
			if (first) { first = false; }
			sql += "AND VALOR_FACTURA= " + valueObject.VALOR_FACTURA + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.ORIGEN)) {
			if (first) { first = false; }
			sql += "AND ORIGEN= '" + valueObject.ORIGEN + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.ESTADO)) {
			if (first) { first = false; }
			sql += "AND ESTADO= '" + valueObject.ESTADO + "' ";
		}

		sql += "ORDER BY ID_HISTORIAL ASC ";

		if (first)
			searchResults = new List<Historial>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Historial> searchMatching(SqlConnection conn, Historial valueObject, int limiteInf, int limiteSup) {
		List<Historial> searchResults = new List<Historial>();
		bool first = true;
		String sql = "SELECT * FROM HISTORIAL WHERE 1=1 ";
		if (valueObject.ID_HISTORIAL != null && valueObject.ID_HISTORIAL != 0) {
			if (first) { first = false; }
			sql += "AND ID_HISTORIAL= " + valueObject.ID_HISTORIAL + " ";
		}

		if (valueObject.ID_CLIENTE != null && valueObject.ID_CLIENTE != 0) {
			if (first) { first = false; }
			sql += "AND ID_CLIENTE= " + valueObject.ID_CLIENTE + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (valueObject.ID_HISTORIAL_DESCUENTO != null && valueObject.ID_HISTORIAL_DESCUENTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_HISTORIAL_DESCUENTO= " + valueObject.ID_HISTORIAL_DESCUENTO + " ";
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

		if (!String.IsNullOrEmpty(valueObject.NUM_FACTURA_VISITA)) {
			if (first) { first = false; }
			sql += "AND NUM_FACTURA_VISITA= '" + valueObject.NUM_FACTURA_VISITA + "' ";
		}

		if (valueObject.VALOR_FACTURA != null && valueObject.VALOR_FACTURA != 0) {
			if (first) { first = false; }
			sql += "AND VALOR_FACTURA= " + valueObject.VALOR_FACTURA + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.ORIGEN)) {
			if (first) { first = false; }
			sql += "AND ORIGEN= '" + valueObject.ORIGEN + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.ESTADO)) {
			if (first) { first = false; }
			sql += "AND ESTADO= '" + valueObject.ESTADO + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Historial>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Historial valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM HISTORIAL WHERE 1=1 ";
		if (valueObject.ID_HISTORIAL != null && valueObject.ID_HISTORIAL != 0) {
			if (first) { first = false; }
			sql += "AND ID_HISTORIAL= " + valueObject.ID_HISTORIAL + " ";
		}

		if (valueObject.ID_CLIENTE != null && valueObject.ID_CLIENTE != 0) {
			if (first) { first = false; }
			sql += "AND ID_CLIENTE= " + valueObject.ID_CLIENTE + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (valueObject.ID_HISTORIAL_DESCUENTO != null && valueObject.ID_HISTORIAL_DESCUENTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_HISTORIAL_DESCUENTO= " + valueObject.ID_HISTORIAL_DESCUENTO + " ";
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

		if (!String.IsNullOrEmpty(valueObject.NUM_FACTURA_VISITA)) {
			if (first) { first = false; }
			sql += "AND NUM_FACTURA_VISITA= '" + valueObject.NUM_FACTURA_VISITA + "' ";
		}

		if (valueObject.VALOR_FACTURA != null && valueObject.VALOR_FACTURA != 0) {
			if (first) { first = false; }
			sql += "AND VALOR_FACTURA= " + valueObject.VALOR_FACTURA + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.ORIGEN)) {
			if (first) { first = false; }
			sql += "AND ORIGEN= '" + valueObject.ORIGEN + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.ESTADO)) {
			if (first) { first = false; }
			sql += "AND ESTADO= '" + valueObject.ESTADO + "' ";
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


	private List<Historial> listQuery(SqlCommand stmt) {

		List<Historial> searchResults = new List<Historial>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Historial temp = createValueObject();

				temp.ID_HISTORIAL= reader["ID_HISTORIAL"] != null && long.TryParse(reader["ID_HISTORIAL"].ToString(),out longg) ? longg : 0;
				temp.ID_CLIENTE= reader["ID_CLIENTE"] != null && long.TryParse(reader["ID_CLIENTE"].ToString(),out longg) ? longg : 0;
				temp.ID_IMAGEN= reader["ID_IMAGEN"] != null && long.TryParse(reader["ID_IMAGEN"].ToString(),out longg) ? longg : 0;
				temp.ID_HISTORIAL_DESCUENTO= reader["ID_HISTORIAL_DESCUENTO"] != null && long.TryParse(reader["ID_HISTORIAL_DESCUENTO"].ToString(),out longg) ? longg : 0;
				temp.ID_USUARIO= reader["ID_USUARIO"] != null && long.TryParse(reader["ID_USUARIO"].ToString(),out longg) ? longg : 0;
				temp.FECHA=  reader["FECHA"] != null && !String.IsNullOrEmpty(reader["FECHA"].ToString()) ? (DateTime)reader["FECHA"] : DateTime.MinValue;
				temp.HORA=  reader["HORA"] != null && !String.IsNullOrEmpty(reader["HORA"].ToString()) ? (DateTime)reader["HORA"] : DateTime.MinValue;
				temp.NUM_FACTURA_VISITA= reader["NUM_FACTURA_VISITA"] != null ? reader["NUM_FACTURA_VISITA"].ToString() : null;
				temp.VALOR_FACTURA= reader["VALOR_FACTURA"] != null && long.TryParse(reader["VALOR_FACTURA"].ToString(),out longg) ? longg : 0;
				temp.ORIGEN= reader["ORIGEN"] != null ? reader["ORIGEN"].ToString() : null;
				temp.ESTADO= reader["ESTADO"] != null ? reader["ESTADO"].ToString() : null;
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
