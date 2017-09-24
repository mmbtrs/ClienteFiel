using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class ActividadDao {


	public Actividad createValueObject() {
		return new Actividad();
	}

	public List<Actividad> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM ACTIVIDAD ORDER BY ID_ACTIVIDAD ASC ";
		List<Actividad> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Actividad> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_ACTIVIDAD) AS RowNumber FROM ACTIVIDAD) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Actividad> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Actividad valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO ACTIVIDAD ( ID_ACTIVIDAD,"+
			" ID_EMPRESA, ID_TIPO_ACTIVIDAD, NOM_ACTIVIDAD,"+
			" DESCRIPCION, FECHA_DESDE, FECHA_HASTA,"+
			" PUBLICADO)"+
			 "VALUES ( @ID_ACTIVIDAD, @ID_EMPRESA, @ID_TIPO_ACTIVIDAD, @NOM_ACTIVIDAD, @DESCRIPCION, @FECHA_DESDE, @FECHA_HASTA, @PUBLICADO)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_ACTIVIDAD", valueObject.ID_ACTIVIDAD);
				if(valueObject.ID_EMPRESA!=0)
					stmt.Parameters.AddWithValue("@ID_EMPRESA", valueObject.ID_EMPRESA);
				else
					stmt.Parameters.AddWithValue("@ID_EMPRESA", DBNull.Value);
				if(valueObject.ID_TIPO_ACTIVIDAD!=0)
					stmt.Parameters.AddWithValue("@ID_TIPO_ACTIVIDAD", valueObject.ID_TIPO_ACTIVIDAD);
				else
					stmt.Parameters.AddWithValue("@ID_TIPO_ACTIVIDAD", DBNull.Value);
				if(valueObject.NOM_ACTIVIDAD!=null &&valueObject.NOM_ACTIVIDAD.Length <= 100)
					stmt.Parameters.AddWithValue("@NOM_ACTIVIDAD", valueObject.NOM_ACTIVIDAD);
				else
					stmt.Parameters.AddWithValue("@NOM_ACTIVIDAD", DBNull.Value);
				if(valueObject.DESCRIPCION!=null &&valueObject.DESCRIPCION.Length <= 8000)
					stmt.Parameters.AddWithValue("@DESCRIPCION", valueObject.DESCRIPCION);
				else
					stmt.Parameters.AddWithValue("@DESCRIPCION", DBNull.Value);
				if(valueObject.FECHA_DESDE != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_DESDE", valueObject.FECHA_DESDE);
				else
					stmt.Parameters.AddWithValue("@FECHA_DESDE", DBNull.Value);
				if(valueObject.FECHA_HASTA != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_HASTA", valueObject.FECHA_HASTA);
				else
					stmt.Parameters.AddWithValue("@FECHA_HASTA", DBNull.Value);
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


	public void save(SqlConnection conn, Actividad valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE ACTIVIDAD SET  ID_EMPRESA = @ID_EMPRESA , ID_TIPO_ACTIVIDAD = @ID_TIPO_ACTIVIDAD , NOM_ACTIVIDAD = @NOM_ACTIVIDAD ,"+
			" DESCRIPCION = @DESCRIPCION , FECHA_DESDE = @FECHA_DESDE , FECHA_HASTA = @FECHA_HASTA ,"+
			" PUBLICADO = @PUBLICADO  WHERE (ID_ACTIVIDAD= @ID_ACTIVIDAD)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.ID_EMPRESA!=0)
					stmt.Parameters.AddWithValue("@ID_EMPRESA", valueObject.ID_EMPRESA);
				else
					stmt.Parameters.AddWithValue("@ID_EMPRESA", DBNull.Value);
				if(valueObject.ID_TIPO_ACTIVIDAD!=0)
					stmt.Parameters.AddWithValue("@ID_TIPO_ACTIVIDAD", valueObject.ID_TIPO_ACTIVIDAD);
				else
					stmt.Parameters.AddWithValue("@ID_TIPO_ACTIVIDAD", DBNull.Value);
				if(valueObject.NOM_ACTIVIDAD!=null &&valueObject.NOM_ACTIVIDAD.Length <= 100)
					stmt.Parameters.AddWithValue("@NOM_ACTIVIDAD", valueObject.NOM_ACTIVIDAD);
				else
					stmt.Parameters.AddWithValue("@NOM_ACTIVIDAD", DBNull.Value);
				if(valueObject.DESCRIPCION!=null &&valueObject.DESCRIPCION.Length <= 8000)
					stmt.Parameters.AddWithValue("@DESCRIPCION", valueObject.DESCRIPCION);
				else
					stmt.Parameters.AddWithValue("@DESCRIPCION", DBNull.Value);
				if(valueObject.FECHA_DESDE != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_DESDE", valueObject.FECHA_DESDE);
				else
					stmt.Parameters.AddWithValue("@FECHA_DESDE", DBNull.Value);
				if(valueObject.FECHA_HASTA != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_HASTA", valueObject.FECHA_HASTA);
				else
					stmt.Parameters.AddWithValue("@FECHA_HASTA", DBNull.Value);
				if(valueObject.PUBLICADO!=null &&valueObject.PUBLICADO.Length <= 1)
					stmt.Parameters.AddWithValue("@PUBLICADO", valueObject.PUBLICADO);
				else
					stmt.Parameters.AddWithValue("@PUBLICADO", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_ACTIVIDAD", valueObject.ID_ACTIVIDAD);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Actividad valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM ACTIVIDAD WHERE (ID_ACTIVIDAD = @ID_ACTIVIDAD )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_ACTIVIDAD", valueObject.ID_ACTIVIDAD);

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
		String sql = "SELECT count(*) FROM ACTIVIDAD";
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
	public List<Actividad> searchMatching(SqlConnection conn, Actividad valueObject) {
		List<Actividad> searchResults = new List<Actividad>();
		bool first = true;
		String sql = "SELECT * FROM ACTIVIDAD WHERE 1=1 ";
		if (valueObject.ID_ACTIVIDAD != null && valueObject.ID_ACTIVIDAD != 0) {
			if (first) { first = false; }
			sql += "AND ID_ACTIVIDAD= " + valueObject.ID_ACTIVIDAD + " ";
		}

		if (valueObject.ID_EMPRESA != null && valueObject.ID_EMPRESA != 0) {
			if (first) { first = false; }
			sql += "AND ID_EMPRESA= " + valueObject.ID_EMPRESA + " ";
		}

		if (valueObject.ID_TIPO_ACTIVIDAD != null && valueObject.ID_TIPO_ACTIVIDAD != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_ACTIVIDAD= " + valueObject.ID_TIPO_ACTIVIDAD + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_ACTIVIDAD)) {
			if (first) { first = false; }
			sql += "AND NOM_ACTIVIDAD= '" + valueObject.NOM_ACTIVIDAD + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.DESCRIPCION)) {
			if (first) { first = false; }
			sql += "AND DESCRIPCION= '" + valueObject.DESCRIPCION + "' ";
		}

		if (valueObject.FECHA_DESDE != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_DESDE= '" + valueObject.FECHA_DESDE.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (valueObject.FECHA_HASTA != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_HASTA= '" + valueObject.FECHA_HASTA.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.PUBLICADO)) {
			if (first) { first = false; }
			sql += "AND PUBLICADO= '" + valueObject.PUBLICADO + "' ";
		}

		sql += "ORDER BY ID_ACTIVIDAD ASC ";

		if (first)
			searchResults = new List<Actividad>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Actividad> searchMatching(SqlConnection conn, Actividad valueObject, int limiteInf, int limiteSup) {
		List<Actividad> searchResults = new List<Actividad>();
		bool first = true;
		String sql = "SELECT * FROM ACTIVIDAD WHERE 1=1 ";
		if (valueObject.ID_ACTIVIDAD != null && valueObject.ID_ACTIVIDAD != 0) {
			if (first) { first = false; }
			sql += "AND ID_ACTIVIDAD= " + valueObject.ID_ACTIVIDAD + " ";
		}

		if (valueObject.ID_EMPRESA != null && valueObject.ID_EMPRESA != 0) {
			if (first) { first = false; }
			sql += "AND ID_EMPRESA= " + valueObject.ID_EMPRESA + " ";
		}

		if (valueObject.ID_TIPO_ACTIVIDAD != null && valueObject.ID_TIPO_ACTIVIDAD != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_ACTIVIDAD= " + valueObject.ID_TIPO_ACTIVIDAD + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_ACTIVIDAD)) {
			if (first) { first = false; }
			sql += "AND NOM_ACTIVIDAD= '" + valueObject.NOM_ACTIVIDAD + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.DESCRIPCION)) {
			if (first) { first = false; }
			sql += "AND DESCRIPCION= '" + valueObject.DESCRIPCION + "' ";
		}

		if (valueObject.FECHA_DESDE != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_DESDE= '" + valueObject.FECHA_DESDE.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (valueObject.FECHA_HASTA != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_HASTA= '" + valueObject.FECHA_HASTA.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.PUBLICADO)) {
			if (first) { first = false; }
			sql += "AND PUBLICADO= '" + valueObject.PUBLICADO + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Actividad>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Actividad valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM ACTIVIDAD WHERE 1=1 ";
		if (valueObject.ID_ACTIVIDAD != null && valueObject.ID_ACTIVIDAD != 0) {
			if (first) { first = false; }
			sql += "AND ID_ACTIVIDAD= " + valueObject.ID_ACTIVIDAD + " ";
		}

		if (valueObject.ID_EMPRESA != null && valueObject.ID_EMPRESA != 0) {
			if (first) { first = false; }
			sql += "AND ID_EMPRESA= " + valueObject.ID_EMPRESA + " ";
		}

		if (valueObject.ID_TIPO_ACTIVIDAD != null && valueObject.ID_TIPO_ACTIVIDAD != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_ACTIVIDAD= " + valueObject.ID_TIPO_ACTIVIDAD + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_ACTIVIDAD)) {
			if (first) { first = false; }
			sql += "AND NOM_ACTIVIDAD= '" + valueObject.NOM_ACTIVIDAD + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.DESCRIPCION)) {
			if (first) { first = false; }
			sql += "AND DESCRIPCION= '" + valueObject.DESCRIPCION + "' ";
		}

		if (valueObject.FECHA_DESDE != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_DESDE= '" + valueObject.FECHA_DESDE.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (valueObject.FECHA_HASTA != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_HASTA= '" + valueObject.FECHA_HASTA.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
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


	private List<Actividad> listQuery(SqlCommand stmt) {

		List<Actividad> searchResults = new List<Actividad>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Actividad temp = createValueObject();

				temp.ID_ACTIVIDAD= reader["ID_ACTIVIDAD"] != null && long.TryParse(reader["ID_ACTIVIDAD"].ToString(),out longg) ? longg : 0;
				temp.ID_EMPRESA= reader["ID_EMPRESA"] != null && long.TryParse(reader["ID_EMPRESA"].ToString(),out longg) ? longg : 0;
				temp.ID_TIPO_ACTIVIDAD= reader["ID_TIPO_ACTIVIDAD"] != null && long.TryParse(reader["ID_TIPO_ACTIVIDAD"].ToString(),out longg) ? longg : 0;
				temp.NOM_ACTIVIDAD= reader["NOM_ACTIVIDAD"] != null ? reader["NOM_ACTIVIDAD"].ToString() : null;
				temp.DESCRIPCION= reader["DESCRIPCION"] != null ? reader["DESCRIPCION"].ToString() : null;
				temp.FECHA_DESDE=  reader["FECHA_DESDE"] != null && !String.IsNullOrEmpty(reader["FECHA_DESDE"].ToString()) ? (DateTime)reader["FECHA_DESDE"] : DateTime.MinValue;
				temp.FECHA_HASTA=  reader["FECHA_HASTA"] != null && !String.IsNullOrEmpty(reader["FECHA_HASTA"].ToString()) ? (DateTime)reader["FECHA_HASTA"] : DateTime.MinValue;
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
