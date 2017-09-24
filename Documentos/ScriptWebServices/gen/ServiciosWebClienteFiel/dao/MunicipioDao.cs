using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class MunicipioDao {


	public Municipio createValueObject() {
		return new Municipio();
	}

	public List<Municipio> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM MUNICIPIO ORDER BY ID_MUNICIPIO ASC ";
		List<Municipio> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Municipio> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_MUNICIPIO) AS RowNumber FROM MUNICIPIO) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Municipio> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Municipio valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO MUNICIPIO ( ID_MUNICIPIO,"+
			" ID_DEPARTAMENTO, NOM_MUNICIPIO)"+
			 "VALUES ( @ID_MUNICIPIO, @ID_DEPARTAMENTO, @NOM_MUNICIPIO)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_MUNICIPIO", valueObject.ID_MUNICIPIO);
				if(valueObject.ID_DEPARTAMENTO!=0)
					stmt.Parameters.AddWithValue("@ID_DEPARTAMENTO", valueObject.ID_DEPARTAMENTO);
				else
					stmt.Parameters.AddWithValue("@ID_DEPARTAMENTO", DBNull.Value);
				if(valueObject.NOM_MUNICIPIO!=null &&valueObject.NOM_MUNICIPIO.Length <= 50)
					stmt.Parameters.AddWithValue("@NOM_MUNICIPIO", valueObject.NOM_MUNICIPIO);
				else
					stmt.Parameters.AddWithValue("@NOM_MUNICIPIO", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Municipio valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE MUNICIPIO SET  ID_DEPARTAMENTO = @ID_DEPARTAMENTO , NOM_MUNICIPIO = @NOM_MUNICIPIO  WHERE (ID_MUNICIPIO= @ID_MUNICIPIO)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.ID_DEPARTAMENTO!=0)
					stmt.Parameters.AddWithValue("@ID_DEPARTAMENTO", valueObject.ID_DEPARTAMENTO);
				else
					stmt.Parameters.AddWithValue("@ID_DEPARTAMENTO", DBNull.Value);
				if(valueObject.NOM_MUNICIPIO!=null &&valueObject.NOM_MUNICIPIO.Length <= 50)
					stmt.Parameters.AddWithValue("@NOM_MUNICIPIO", valueObject.NOM_MUNICIPIO);
				else
					stmt.Parameters.AddWithValue("@NOM_MUNICIPIO", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_MUNICIPIO", valueObject.ID_MUNICIPIO);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Municipio valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM MUNICIPIO WHERE (ID_MUNICIPIO = @ID_MUNICIPIO )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_MUNICIPIO", valueObject.ID_MUNICIPIO);

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
		String sql = "SELECT count(*) FROM MUNICIPIO";
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
	public List<Municipio> searchMatching(SqlConnection conn, Municipio valueObject) {
		List<Municipio> searchResults = new List<Municipio>();
		bool first = true;
		String sql = "SELECT * FROM MUNICIPIO WHERE 1=1 ";
		if (valueObject.ID_MUNICIPIO != null && valueObject.ID_MUNICIPIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_MUNICIPIO= " + valueObject.ID_MUNICIPIO + " ";
		}

		if (valueObject.ID_DEPARTAMENTO != null && valueObject.ID_DEPARTAMENTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_DEPARTAMENTO= " + valueObject.ID_DEPARTAMENTO + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_MUNICIPIO)) {
			if (first) { first = false; }
			sql += "AND NOM_MUNICIPIO= '" + valueObject.NOM_MUNICIPIO + "' ";
		}

		sql += "ORDER BY ID_MUNICIPIO ASC ";

		if (first)
			searchResults = new List<Municipio>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Municipio> searchMatching(SqlConnection conn, Municipio valueObject, int limiteInf, int limiteSup) {
		List<Municipio> searchResults = new List<Municipio>();
		bool first = true;
		String sql = "SELECT * FROM MUNICIPIO WHERE 1=1 ";
		if (valueObject.ID_MUNICIPIO != null && valueObject.ID_MUNICIPIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_MUNICIPIO= " + valueObject.ID_MUNICIPIO + " ";
		}

		if (valueObject.ID_DEPARTAMENTO != null && valueObject.ID_DEPARTAMENTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_DEPARTAMENTO= " + valueObject.ID_DEPARTAMENTO + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_MUNICIPIO)) {
			if (first) { first = false; }
			sql += "AND NOM_MUNICIPIO= '" + valueObject.NOM_MUNICIPIO + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Municipio>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Municipio valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM MUNICIPIO WHERE 1=1 ";
		if (valueObject.ID_MUNICIPIO != null && valueObject.ID_MUNICIPIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_MUNICIPIO= " + valueObject.ID_MUNICIPIO + " ";
		}

		if (valueObject.ID_DEPARTAMENTO != null && valueObject.ID_DEPARTAMENTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_DEPARTAMENTO= " + valueObject.ID_DEPARTAMENTO + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_MUNICIPIO)) {
			if (first) { first = false; }
			sql += "AND NOM_MUNICIPIO= '" + valueObject.NOM_MUNICIPIO + "' ";
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


	private List<Municipio> listQuery(SqlCommand stmt) {

		List<Municipio> searchResults = new List<Municipio>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Municipio temp = createValueObject();

				temp.ID_MUNICIPIO= reader["ID_MUNICIPIO"] != null && long.TryParse(reader["ID_MUNICIPIO"].ToString(),out longg) ? longg : 0;
				temp.ID_DEPARTAMENTO= reader["ID_DEPARTAMENTO"] != null && long.TryParse(reader["ID_DEPARTAMENTO"].ToString(),out longg) ? longg : 0;
				temp.NOM_MUNICIPIO= reader["NOM_MUNICIPIO"] != null ? reader["NOM_MUNICIPIO"].ToString() : null;
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
