using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class DescuentoDao {


	public Descuento createValueObject() {
		return new Descuento();
	}

	public List<Descuento> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM DESCUENTO ORDER BY ID_DESCUENTO ASC ";
		List<Descuento> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Descuento> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_DESCUENTO) AS RowNumber FROM DESCUENTO) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Descuento> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Descuento valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO DESCUENTO ( ID_DESCUENTO,"+
			" ID_EMPRESA, NOM_DESCUENTO, DESCRIPCION,"+
			" FECHA_DESDE, FECHA_FIN, FORMULA,"+
			" PUBLICADO)"+
			 "VALUES ( @ID_DESCUENTO, @ID_EMPRESA, @NOM_DESCUENTO, @DESCRIPCION, @FECHA_DESDE, @FECHA_FIN, @FORMULA, @PUBLICADO)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_DESCUENTO", valueObject.ID_DESCUENTO);
				if(valueObject.ID_EMPRESA!=0)
					stmt.Parameters.AddWithValue("@ID_EMPRESA", valueObject.ID_EMPRESA);
				else
					stmt.Parameters.AddWithValue("@ID_EMPRESA", DBNull.Value);
				if(valueObject.NOM_DESCUENTO!=null &&valueObject.NOM_DESCUENTO.Length <= 100)
					stmt.Parameters.AddWithValue("@NOM_DESCUENTO", valueObject.NOM_DESCUENTO);
				else
					stmt.Parameters.AddWithValue("@NOM_DESCUENTO", DBNull.Value);
				if(valueObject.DESCRIPCION!=null &&valueObject.DESCRIPCION.Length <= 8000)
					stmt.Parameters.AddWithValue("@DESCRIPCION", valueObject.DESCRIPCION);
				else
					stmt.Parameters.AddWithValue("@DESCRIPCION", DBNull.Value);
				if(valueObject.FECHA_DESDE != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_DESDE", valueObject.FECHA_DESDE);
				else
					stmt.Parameters.AddWithValue("@FECHA_DESDE", DBNull.Value);
				if(valueObject.FECHA_FIN != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_FIN", valueObject.FECHA_FIN);
				else
					stmt.Parameters.AddWithValue("@FECHA_FIN", DBNull.Value);
				if(valueObject.FORMULA!=null &&valueObject.FORMULA.Length <= 8000)
					stmt.Parameters.AddWithValue("@FORMULA", valueObject.FORMULA);
				else
					stmt.Parameters.AddWithValue("@FORMULA", DBNull.Value);
				if(valueObject.PUBLICADO!=null &&valueObject.PUBLICADO.Length <= 1)
					stmt.Parameters.AddWithValue("@PUBLICADO", valueObject.PUBLICADO);
				else
					stmt.Parameters.AddWithValue("@PUBLICADO", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Descuento valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE DESCUENTO SET  ID_EMPRESA = @ID_EMPRESA , NOM_DESCUENTO = @NOM_DESCUENTO , DESCRIPCION = @DESCRIPCION ,"+
			" FECHA_DESDE = @FECHA_DESDE , FECHA_FIN = @FECHA_FIN , FORMULA = @FORMULA ,"+
			" PUBLICADO = @PUBLICADO  WHERE (ID_DESCUENTO= @ID_DESCUENTO)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.ID_EMPRESA!=0)
					stmt.Parameters.AddWithValue("@ID_EMPRESA", valueObject.ID_EMPRESA);
				else
					stmt.Parameters.AddWithValue("@ID_EMPRESA", DBNull.Value);
				if(valueObject.NOM_DESCUENTO!=null &&valueObject.NOM_DESCUENTO.Length <= 100)
					stmt.Parameters.AddWithValue("@NOM_DESCUENTO", valueObject.NOM_DESCUENTO);
				else
					stmt.Parameters.AddWithValue("@NOM_DESCUENTO", DBNull.Value);
				if(valueObject.DESCRIPCION!=null &&valueObject.DESCRIPCION.Length <= 8000)
					stmt.Parameters.AddWithValue("@DESCRIPCION", valueObject.DESCRIPCION);
				else
					stmt.Parameters.AddWithValue("@DESCRIPCION", DBNull.Value);
				if(valueObject.FECHA_DESDE != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_DESDE", valueObject.FECHA_DESDE);
				else
					stmt.Parameters.AddWithValue("@FECHA_DESDE", DBNull.Value);
				if(valueObject.FECHA_FIN != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_FIN", valueObject.FECHA_FIN);
				else
					stmt.Parameters.AddWithValue("@FECHA_FIN", DBNull.Value);
				if(valueObject.FORMULA!=null &&valueObject.FORMULA.Length <= 8000)
					stmt.Parameters.AddWithValue("@FORMULA", valueObject.FORMULA);
				else
					stmt.Parameters.AddWithValue("@FORMULA", DBNull.Value);
				if(valueObject.PUBLICADO!=null &&valueObject.PUBLICADO.Length <= 1)
					stmt.Parameters.AddWithValue("@PUBLICADO", valueObject.PUBLICADO);
				else
					stmt.Parameters.AddWithValue("@PUBLICADO", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_DESCUENTO", valueObject.ID_DESCUENTO);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Descuento valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM DESCUENTO WHERE (ID_DESCUENTO = @ID_DESCUENTO )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_DESCUENTO", valueObject.ID_DESCUENTO);

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
		String sql = "SELECT count(*) FROM DESCUENTO";
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
	public List<Descuento> searchMatching(SqlConnection conn, Descuento valueObject) {
		List<Descuento> searchResults = new List<Descuento>();
		bool first = true;
		String sql = "SELECT * FROM DESCUENTO WHERE 1=1 ";
		if (valueObject.ID_DESCUENTO != null && valueObject.ID_DESCUENTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_DESCUENTO= " + valueObject.ID_DESCUENTO + " ";
		}

		if (valueObject.ID_EMPRESA != null && valueObject.ID_EMPRESA != 0) {
			if (first) { first = false; }
			sql += "AND ID_EMPRESA= " + valueObject.ID_EMPRESA + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_DESCUENTO)) {
			if (first) { first = false; }
			sql += "AND NOM_DESCUENTO= '" + valueObject.NOM_DESCUENTO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.DESCRIPCION)) {
			if (first) { first = false; }
			sql += "AND DESCRIPCION= '" + valueObject.DESCRIPCION + "' ";
		}

		if (valueObject.FECHA_DESDE != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_DESDE= '" + valueObject.FECHA_DESDE.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (valueObject.FECHA_FIN != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_FIN= '" + valueObject.FECHA_FIN.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.FORMULA)) {
			if (first) { first = false; }
			sql += "AND FORMULA= '" + valueObject.FORMULA + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.PUBLICADO)) {
			if (first) { first = false; }
			sql += "AND PUBLICADO= '" + valueObject.PUBLICADO + "' ";
		}

		sql += "ORDER BY ID_DESCUENTO ASC ";

		if (first)
			searchResults = new List<Descuento>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Descuento> searchMatching(SqlConnection conn, Descuento valueObject, int limiteInf, int limiteSup) {
		List<Descuento> searchResults = new List<Descuento>();
		bool first = true;
		String sql = "SELECT * FROM DESCUENTO WHERE 1=1 ";
		if (valueObject.ID_DESCUENTO != null && valueObject.ID_DESCUENTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_DESCUENTO= " + valueObject.ID_DESCUENTO + " ";
		}

		if (valueObject.ID_EMPRESA != null && valueObject.ID_EMPRESA != 0) {
			if (first) { first = false; }
			sql += "AND ID_EMPRESA= " + valueObject.ID_EMPRESA + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_DESCUENTO)) {
			if (first) { first = false; }
			sql += "AND NOM_DESCUENTO= '" + valueObject.NOM_DESCUENTO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.DESCRIPCION)) {
			if (first) { first = false; }
			sql += "AND DESCRIPCION= '" + valueObject.DESCRIPCION + "' ";
		}

		if (valueObject.FECHA_DESDE != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_DESDE= '" + valueObject.FECHA_DESDE.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (valueObject.FECHA_FIN != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_FIN= '" + valueObject.FECHA_FIN.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.FORMULA)) {
			if (first) { first = false; }
			sql += "AND FORMULA= '" + valueObject.FORMULA + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.PUBLICADO)) {
			if (first) { first = false; }
			sql += "AND PUBLICADO= '" + valueObject.PUBLICADO + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Descuento>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Descuento valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM DESCUENTO WHERE 1=1 ";
		if (valueObject.ID_DESCUENTO != null && valueObject.ID_DESCUENTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_DESCUENTO= " + valueObject.ID_DESCUENTO + " ";
		}

		if (valueObject.ID_EMPRESA != null && valueObject.ID_EMPRESA != 0) {
			if (first) { first = false; }
			sql += "AND ID_EMPRESA= " + valueObject.ID_EMPRESA + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_DESCUENTO)) {
			if (first) { first = false; }
			sql += "AND NOM_DESCUENTO= '" + valueObject.NOM_DESCUENTO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.DESCRIPCION)) {
			if (first) { first = false; }
			sql += "AND DESCRIPCION= '" + valueObject.DESCRIPCION + "' ";
		}

		if (valueObject.FECHA_DESDE != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_DESDE= '" + valueObject.FECHA_DESDE.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (valueObject.FECHA_FIN != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_FIN= '" + valueObject.FECHA_FIN.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.FORMULA)) {
			if (first) { first = false; }
			sql += "AND FORMULA= '" + valueObject.FORMULA + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.PUBLICADO)) {
			if (first) { first = false; }
			sql += "AND PUBLICADO= '" + valueObject.PUBLICADO + "' ";
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


	private List<Descuento> listQuery(SqlCommand stmt) {

		List<Descuento> searchResults = new List<Descuento>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Descuento temp = createValueObject();

				temp.ID_DESCUENTO= reader["ID_DESCUENTO"] != null && long.TryParse(reader["ID_DESCUENTO"].ToString(),out longg) ? longg : 0;
				temp.ID_EMPRESA= reader["ID_EMPRESA"] != null && long.TryParse(reader["ID_EMPRESA"].ToString(),out longg) ? longg : 0;
				temp.NOM_DESCUENTO= reader["NOM_DESCUENTO"] != null ? reader["NOM_DESCUENTO"].ToString() : null;
				temp.DESCRIPCION= reader["DESCRIPCION"] != null ? reader["DESCRIPCION"].ToString() : null;
				temp.FECHA_DESDE=  reader["FECHA_DESDE"] != null && !String.IsNullOrEmpty(reader["FECHA_DESDE"].ToString()) ? (DateTime)reader["FECHA_DESDE"] : DateTime.MinValue;
				temp.FECHA_FIN=  reader["FECHA_FIN"] != null && !String.IsNullOrEmpty(reader["FECHA_FIN"].ToString()) ? (DateTime)reader["FECHA_FIN"] : DateTime.MinValue;
				temp.FORMULA= reader["FORMULA"] != null ? reader["FORMULA"].ToString() : null;
				temp.PUBLICADO= reader["PUBLICADO"] != null ? reader["PUBLICADO"].ToString() : null;
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
