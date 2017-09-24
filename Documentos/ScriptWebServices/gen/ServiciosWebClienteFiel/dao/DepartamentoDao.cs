using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class DepartamentoDao {


	public Departamento createValueObject() {
		return new Departamento();
	}

	public List<Departamento> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM DEPARTAMENTO ORDER BY ID_DEPARTAMENTO ASC ";
		List<Departamento> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Departamento> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_DEPARTAMENTO) AS RowNumber FROM DEPARTAMENTO) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Departamento> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Departamento valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO DEPARTAMENTO ( ID_DEPARTAMENTO,"+
			" NOM_DEPARTAMENTO)"+
			 "VALUES ( @ID_DEPARTAMENTO, @NOM_DEPARTAMENTO)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_DEPARTAMENTO", valueObject.ID_DEPARTAMENTO);
				if(valueObject.NOM_DEPARTAMENTO!=null &&valueObject.NOM_DEPARTAMENTO.Length <= 50)
					stmt.Parameters.AddWithValue("@NOM_DEPARTAMENTO", valueObject.NOM_DEPARTAMENTO);
				else
					stmt.Parameters.AddWithValue("@NOM_DEPARTAMENTO", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Departamento valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE DEPARTAMENTO SET  NOM_DEPARTAMENTO = @NOM_DEPARTAMENTO  WHERE (ID_DEPARTAMENTO= @ID_DEPARTAMENTO)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.NOM_DEPARTAMENTO!=null &&valueObject.NOM_DEPARTAMENTO.Length <= 50)
					stmt.Parameters.AddWithValue("@NOM_DEPARTAMENTO", valueObject.NOM_DEPARTAMENTO);
				else
					stmt.Parameters.AddWithValue("@NOM_DEPARTAMENTO", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_DEPARTAMENTO", valueObject.ID_DEPARTAMENTO);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Departamento valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM DEPARTAMENTO WHERE (ID_DEPARTAMENTO = @ID_DEPARTAMENTO )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_DEPARTAMENTO", valueObject.ID_DEPARTAMENTO);

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
		String sql = "SELECT count(*) FROM DEPARTAMENTO";
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
	public List<Departamento> searchMatching(SqlConnection conn, Departamento valueObject) {
		List<Departamento> searchResults = new List<Departamento>();
		bool first = true;
		String sql = "SELECT * FROM DEPARTAMENTO WHERE 1=1 ";
		if (valueObject.ID_DEPARTAMENTO != null && valueObject.ID_DEPARTAMENTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_DEPARTAMENTO= " + valueObject.ID_DEPARTAMENTO + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_DEPARTAMENTO)) {
			if (first) { first = false; }
			sql += "AND NOM_DEPARTAMENTO= '" + valueObject.NOM_DEPARTAMENTO + "' ";
		}

		sql += "ORDER BY ID_DEPARTAMENTO ASC ";

		if (first)
			searchResults = new List<Departamento>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Departamento> searchMatching(SqlConnection conn, Departamento valueObject, int limiteInf, int limiteSup) {
		List<Departamento> searchResults = new List<Departamento>();
		bool first = true;
		String sql = "SELECT * FROM DEPARTAMENTO WHERE 1=1 ";
		if (valueObject.ID_DEPARTAMENTO != null && valueObject.ID_DEPARTAMENTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_DEPARTAMENTO= " + valueObject.ID_DEPARTAMENTO + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_DEPARTAMENTO)) {
			if (first) { first = false; }
			sql += "AND NOM_DEPARTAMENTO= '" + valueObject.NOM_DEPARTAMENTO + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Departamento>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Departamento valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM DEPARTAMENTO WHERE 1=1 ";
		if (valueObject.ID_DEPARTAMENTO != null && valueObject.ID_DEPARTAMENTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_DEPARTAMENTO= " + valueObject.ID_DEPARTAMENTO + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_DEPARTAMENTO)) {
			if (first) { first = false; }
			sql += "AND NOM_DEPARTAMENTO= '" + valueObject.NOM_DEPARTAMENTO + "' ";
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


	private List<Departamento> listQuery(SqlCommand stmt) {

		List<Departamento> searchResults = new List<Departamento>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Departamento temp = createValueObject();

				temp.ID_DEPARTAMENTO= reader["ID_DEPARTAMENTO"] != null && long.TryParse(reader["ID_DEPARTAMENTO"].ToString(),out longg) ? longg : 0;
				temp.NOM_DEPARTAMENTO= reader["NOM_DEPARTAMENTO"] != null ? reader["NOM_DEPARTAMENTO"].ToString() : null;
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
