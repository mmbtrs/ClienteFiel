using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class DomicilioDao {


	public Domicilio createValueObject() {
		return new Domicilio();
	}

	public List<Domicilio> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM DOMICILIO ORDER BY ID_DOMICILIO ASC ";
		List<Domicilio> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Domicilio> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_DOMICILIO) AS RowNumber FROM DOMICILIO) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Domicilio> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Domicilio valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO DOMICILIO ( ID_DOMICILIO,"+
			" ID_CLIENTE, ID_USUARIO, FECHA_DOMICILIO,"+
			" HORA_DOMICILIO, FECHA_VERIFICACION, HORA_VERIFICACION,"+
			" DIRECCION, TELEFONO, BARRIO,"+
			" ESTADO, OBSERVACIONES, TOTAL"+
			")"+
			 "VALUES ( @ID_DOMICILIO, @ID_CLIENTE, @ID_USUARIO, @FECHA_DOMICILIO, @HORA_DOMICILIO, @FECHA_VERIFICACION, @HORA_VERIFICACION, @DIRECCION, @TELEFONO, @BARRIO, @ESTADO, @OBSERVACIONES, @TOTAL)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_DOMICILIO", valueObject.ID_DOMICILIO);
				if(valueObject.ID_CLIENTE!=0)
					stmt.Parameters.AddWithValue("@ID_CLIENTE", valueObject.ID_CLIENTE);
				else
					stmt.Parameters.AddWithValue("@ID_CLIENTE", DBNull.Value);
				if(valueObject.ID_USUARIO!=0)
					stmt.Parameters.AddWithValue("@ID_USUARIO", valueObject.ID_USUARIO);
				else
					stmt.Parameters.AddWithValue("@ID_USUARIO", DBNull.Value);
				if(valueObject.FECHA_DOMICILIO != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_DOMICILIO", valueObject.FECHA_DOMICILIO);
				else
					stmt.Parameters.AddWithValue("@FECHA_DOMICILIO", DBNull.Value);
				if(valueObject.HORA_DOMICILIO != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@HORA_DOMICILIO", valueObject.HORA_DOMICILIO);
				else
					stmt.Parameters.AddWithValue("@HORA_DOMICILIO", DBNull.Value);
				if(valueObject.FECHA_VERIFICACION != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_VERIFICACION", valueObject.FECHA_VERIFICACION);
				else
					stmt.Parameters.AddWithValue("@FECHA_VERIFICACION", DBNull.Value);
				if(valueObject.HORA_VERIFICACION != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@HORA_VERIFICACION", valueObject.HORA_VERIFICACION);
				else
					stmt.Parameters.AddWithValue("@HORA_VERIFICACION", DBNull.Value);
				if(valueObject.DIRECCION!=null &&valueObject.DIRECCION.Length <= 300)
					stmt.Parameters.AddWithValue("@DIRECCION", valueObject.DIRECCION);
				else
					stmt.Parameters.AddWithValue("@DIRECCION", DBNull.Value);
				if(valueObject.TELEFONO!=null &&valueObject.TELEFONO.Length <= 100)
					stmt.Parameters.AddWithValue("@TELEFONO", valueObject.TELEFONO);
				else
					stmt.Parameters.AddWithValue("@TELEFONO", DBNull.Value);
				if(valueObject.BARRIO!=null &&valueObject.BARRIO.Length <= 300)
					stmt.Parameters.AddWithValue("@BARRIO", valueObject.BARRIO);
				else
					stmt.Parameters.AddWithValue("@BARRIO", DBNull.Value);
				if(valueObject.ESTADO!=null &&valueObject.ESTADO.Length <= 1)
					stmt.Parameters.AddWithValue("@ESTADO", valueObject.ESTADO);
				else
					stmt.Parameters.AddWithValue("@ESTADO", DBNull.Value);
				if(valueObject.OBSERVACIONES!=null &&valueObject.OBSERVACIONES.Length <= 8000)
					stmt.Parameters.AddWithValue("@OBSERVACIONES", valueObject.OBSERVACIONES);
				else
					stmt.Parameters.AddWithValue("@OBSERVACIONES", DBNull.Value);
				if(valueObject.TOTAL!=0)
					stmt.Parameters.AddWithValue("@TOTAL", valueObject.TOTAL);
				else
					stmt.Parameters.AddWithValue("@TOTAL", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Domicilio valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE DOMICILIO SET  ID_CLIENTE = @ID_CLIENTE , ID_USUARIO = @ID_USUARIO , FECHA_DOMICILIO = @FECHA_DOMICILIO ,"+
			" HORA_DOMICILIO = @HORA_DOMICILIO , FECHA_VERIFICACION = @FECHA_VERIFICACION , HORA_VERIFICACION = @HORA_VERIFICACION ,"+
			" DIRECCION = @DIRECCION , TELEFONO = @TELEFONO , BARRIO = @BARRIO ,"+
			" ESTADO = @ESTADO , OBSERVACIONES = @OBSERVACIONES , TOTAL = @TOTAL "+
			" WHERE (ID_DOMICILIO= @ID_DOMICILIO)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.ID_CLIENTE!=0)
					stmt.Parameters.AddWithValue("@ID_CLIENTE", valueObject.ID_CLIENTE);
				else
					stmt.Parameters.AddWithValue("@ID_CLIENTE", DBNull.Value);
				if(valueObject.ID_USUARIO!=0)
					stmt.Parameters.AddWithValue("@ID_USUARIO", valueObject.ID_USUARIO);
				else
					stmt.Parameters.AddWithValue("@ID_USUARIO", DBNull.Value);
				if(valueObject.FECHA_DOMICILIO != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_DOMICILIO", valueObject.FECHA_DOMICILIO);
				else
					stmt.Parameters.AddWithValue("@FECHA_DOMICILIO", DBNull.Value);
				if(valueObject.HORA_DOMICILIO != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@HORA_DOMICILIO", valueObject.HORA_DOMICILIO);
				else
					stmt.Parameters.AddWithValue("@HORA_DOMICILIO", DBNull.Value);
				if(valueObject.FECHA_VERIFICACION != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_VERIFICACION", valueObject.FECHA_VERIFICACION);
				else
					stmt.Parameters.AddWithValue("@FECHA_VERIFICACION", DBNull.Value);
				if(valueObject.HORA_VERIFICACION != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@HORA_VERIFICACION", valueObject.HORA_VERIFICACION);
				else
					stmt.Parameters.AddWithValue("@HORA_VERIFICACION", DBNull.Value);
				if(valueObject.DIRECCION!=null &&valueObject.DIRECCION.Length <= 300)
					stmt.Parameters.AddWithValue("@DIRECCION", valueObject.DIRECCION);
				else
					stmt.Parameters.AddWithValue("@DIRECCION", DBNull.Value);
				if(valueObject.TELEFONO!=null &&valueObject.TELEFONO.Length <= 100)
					stmt.Parameters.AddWithValue("@TELEFONO", valueObject.TELEFONO);
				else
					stmt.Parameters.AddWithValue("@TELEFONO", DBNull.Value);
				if(valueObject.BARRIO!=null &&valueObject.BARRIO.Length <= 300)
					stmt.Parameters.AddWithValue("@BARRIO", valueObject.BARRIO);
				else
					stmt.Parameters.AddWithValue("@BARRIO", DBNull.Value);
				if(valueObject.ESTADO!=null &&valueObject.ESTADO.Length <= 1)
					stmt.Parameters.AddWithValue("@ESTADO", valueObject.ESTADO);
				else
					stmt.Parameters.AddWithValue("@ESTADO", DBNull.Value);
				if(valueObject.OBSERVACIONES!=null &&valueObject.OBSERVACIONES.Length <= 8000)
					stmt.Parameters.AddWithValue("@OBSERVACIONES", valueObject.OBSERVACIONES);
				else
					stmt.Parameters.AddWithValue("@OBSERVACIONES", DBNull.Value);
				if(valueObject.TOTAL!=0)
					stmt.Parameters.AddWithValue("@TOTAL", valueObject.TOTAL);
				else
					stmt.Parameters.AddWithValue("@TOTAL", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_DOMICILIO", valueObject.ID_DOMICILIO);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Domicilio valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM DOMICILIO WHERE (ID_DOMICILIO = @ID_DOMICILIO )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_DOMICILIO", valueObject.ID_DOMICILIO);

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
		String sql = "SELECT count(*) FROM DOMICILIO";
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
	public List<Domicilio> searchMatching(SqlConnection conn, Domicilio valueObject) {
		List<Domicilio> searchResults = new List<Domicilio>();
		bool first = true;
		String sql = "SELECT * FROM DOMICILIO WHERE 1=1 ";
		if (valueObject.ID_DOMICILIO != null && valueObject.ID_DOMICILIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_DOMICILIO= " + valueObject.ID_DOMICILIO + " ";
		}

		if (valueObject.ID_CLIENTE != null && valueObject.ID_CLIENTE != 0) {
			if (first) { first = false; }
			sql += "AND ID_CLIENTE= " + valueObject.ID_CLIENTE + " ";
		}

		if (valueObject.ID_USUARIO != null && valueObject.ID_USUARIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_USUARIO= " + valueObject.ID_USUARIO + " ";
		}

		if (valueObject.FECHA_DOMICILIO != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_DOMICILIO= '" + valueObject.FECHA_DOMICILIO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (valueObject.HORA_DOMICILIO != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND HORA_DOMICILIO= '" + valueObject.HORA_DOMICILIO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (valueObject.FECHA_VERIFICACION != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_VERIFICACION= '" + valueObject.FECHA_VERIFICACION.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (valueObject.HORA_VERIFICACION != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND HORA_VERIFICACION= '" + valueObject.HORA_VERIFICACION.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.DIRECCION)) {
			if (first) { first = false; }
			sql += "AND DIRECCION= '" + valueObject.DIRECCION + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.TELEFONO)) {
			if (first) { first = false; }
			sql += "AND TELEFONO= '" + valueObject.TELEFONO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.BARRIO)) {
			if (first) { first = false; }
			sql += "AND BARRIO= '" + valueObject.BARRIO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.ESTADO)) {
			if (first) { first = false; }
			sql += "AND ESTADO= '" + valueObject.ESTADO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.OBSERVACIONES)) {
			if (first) { first = false; }
			sql += "AND OBSERVACIONES= '" + valueObject.OBSERVACIONES + "' ";
		}

		if (valueObject.TOTAL != null && valueObject.TOTAL != 0) {
			if (first) { first = false; }
			sql += "AND TOTAL= " + valueObject.TOTAL + " ";
		}

		sql += "ORDER BY ID_DOMICILIO ASC ";

		if (first)
			searchResults = new List<Domicilio>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Domicilio> searchMatching(SqlConnection conn, Domicilio valueObject, int limiteInf, int limiteSup) {
		List<Domicilio> searchResults = new List<Domicilio>();
		bool first = true;
		String sql = "SELECT * FROM DOMICILIO WHERE 1=1 ";
		if (valueObject.ID_DOMICILIO != null && valueObject.ID_DOMICILIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_DOMICILIO= " + valueObject.ID_DOMICILIO + " ";
		}

		if (valueObject.ID_CLIENTE != null && valueObject.ID_CLIENTE != 0) {
			if (first) { first = false; }
			sql += "AND ID_CLIENTE= " + valueObject.ID_CLIENTE + " ";
		}

		if (valueObject.ID_USUARIO != null && valueObject.ID_USUARIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_USUARIO= " + valueObject.ID_USUARIO + " ";
		}

		if (valueObject.FECHA_DOMICILIO != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_DOMICILIO= '" + valueObject.FECHA_DOMICILIO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (valueObject.HORA_DOMICILIO != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND HORA_DOMICILIO= '" + valueObject.HORA_DOMICILIO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (valueObject.FECHA_VERIFICACION != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_VERIFICACION= '" + valueObject.FECHA_VERIFICACION.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (valueObject.HORA_VERIFICACION != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND HORA_VERIFICACION= '" + valueObject.HORA_VERIFICACION.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.DIRECCION)) {
			if (first) { first = false; }
			sql += "AND DIRECCION= '" + valueObject.DIRECCION + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.TELEFONO)) {
			if (first) { first = false; }
			sql += "AND TELEFONO= '" + valueObject.TELEFONO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.BARRIO)) {
			if (first) { first = false; }
			sql += "AND BARRIO= '" + valueObject.BARRIO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.ESTADO)) {
			if (first) { first = false; }
			sql += "AND ESTADO= '" + valueObject.ESTADO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.OBSERVACIONES)) {
			if (first) { first = false; }
			sql += "AND OBSERVACIONES= '" + valueObject.OBSERVACIONES + "' ";
		}

		if (valueObject.TOTAL != null && valueObject.TOTAL != 0) {
			if (first) { first = false; }
			sql += "AND TOTAL= " + valueObject.TOTAL + " ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Domicilio>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Domicilio valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM DOMICILIO WHERE 1=1 ";
		if (valueObject.ID_DOMICILIO != null && valueObject.ID_DOMICILIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_DOMICILIO= " + valueObject.ID_DOMICILIO + " ";
		}

		if (valueObject.ID_CLIENTE != null && valueObject.ID_CLIENTE != 0) {
			if (first) { first = false; }
			sql += "AND ID_CLIENTE= " + valueObject.ID_CLIENTE + " ";
		}

		if (valueObject.ID_USUARIO != null && valueObject.ID_USUARIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_USUARIO= " + valueObject.ID_USUARIO + " ";
		}

		if (valueObject.FECHA_DOMICILIO != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_DOMICILIO= '" + valueObject.FECHA_DOMICILIO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (valueObject.HORA_DOMICILIO != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND HORA_DOMICILIO= '" + valueObject.HORA_DOMICILIO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (valueObject.FECHA_VERIFICACION != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_VERIFICACION= '" + valueObject.FECHA_VERIFICACION.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (valueObject.HORA_VERIFICACION != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND HORA_VERIFICACION= '" + valueObject.HORA_VERIFICACION.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.DIRECCION)) {
			if (first) { first = false; }
			sql += "AND DIRECCION= '" + valueObject.DIRECCION + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.TELEFONO)) {
			if (first) { first = false; }
			sql += "AND TELEFONO= '" + valueObject.TELEFONO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.BARRIO)) {
			if (first) { first = false; }
			sql += "AND BARRIO= '" + valueObject.BARRIO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.ESTADO)) {
			if (first) { first = false; }
			sql += "AND ESTADO= '" + valueObject.ESTADO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.OBSERVACIONES)) {
			if (first) { first = false; }
			sql += "AND OBSERVACIONES= '" + valueObject.OBSERVACIONES + "' ";
		}

		if (valueObject.TOTAL != null && valueObject.TOTAL != 0) {
			if (first) { first = false; }
			sql += "AND TOTAL= " + valueObject.TOTAL + " ";
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


	private List<Domicilio> listQuery(SqlCommand stmt) {

		List<Domicilio> searchResults = new List<Domicilio>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Domicilio temp = createValueObject();

				temp.ID_DOMICILIO= reader["ID_DOMICILIO"] != null && long.TryParse(reader["ID_DOMICILIO"].ToString(),out longg) ? longg : 0;
				temp.ID_CLIENTE= reader["ID_CLIENTE"] != null && long.TryParse(reader["ID_CLIENTE"].ToString(),out longg) ? longg : 0;
				temp.ID_USUARIO= reader["ID_USUARIO"] != null && long.TryParse(reader["ID_USUARIO"].ToString(),out longg) ? longg : 0;
				temp.FECHA_DOMICILIO=  reader["FECHA_DOMICILIO"] != null && !String.IsNullOrEmpty(reader["FECHA_DOMICILIO"].ToString()) ? (DateTime)reader["FECHA_DOMICILIO"] : DateTime.MinValue;
				temp.HORA_DOMICILIO=  reader["HORA_DOMICILIO"] != null && !String.IsNullOrEmpty(reader["HORA_DOMICILIO"].ToString()) ? (DateTime)reader["HORA_DOMICILIO"] : DateTime.MinValue;
				temp.FECHA_VERIFICACION=  reader["FECHA_VERIFICACION"] != null && !String.IsNullOrEmpty(reader["FECHA_VERIFICACION"].ToString()) ? (DateTime)reader["FECHA_VERIFICACION"] : DateTime.MinValue;
				temp.HORA_VERIFICACION=  reader["HORA_VERIFICACION"] != null && !String.IsNullOrEmpty(reader["HORA_VERIFICACION"].ToString()) ? (DateTime)reader["HORA_VERIFICACION"] : DateTime.MinValue;
				temp.DIRECCION= reader["DIRECCION"] != null ? reader["DIRECCION"].ToString() : null;
				temp.TELEFONO= reader["TELEFONO"] != null ? reader["TELEFONO"].ToString() : null;
				temp.BARRIO= reader["BARRIO"] != null ? reader["BARRIO"].ToString() : null;
				temp.ESTADO= reader["ESTADO"] != null ? reader["ESTADO"].ToString() : null;
				temp.OBSERVACIONES= reader["OBSERVACIONES"] != null ? reader["OBSERVACIONES"].ToString() : null;
				temp.TOTAL= reader["TOTAL"] != null && long.TryParse(reader["TOTAL"].ToString(),out longg) ? longg : 0;
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
