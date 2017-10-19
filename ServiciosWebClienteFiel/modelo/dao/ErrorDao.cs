using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class ErrorDao {


	public Error createValueObject() {
		return new Error();
	}

	public List<Error> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM ERROR ORDER BY ID_ERROR ASC ";
		List<Error> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Error> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_ERROR) AS RowNumber FROM ERROR) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Error> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Error valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO ERROR ( "+
			" ERROR, MENSAJE_PARA_USUARIO,"+
			" POSIBLE_SOLUCION, CAMPO_DE_BUSQUEDA)"+
             "VALUES ( @ERROR, @MENSAJE_PARA_USUARIO, @POSIBLE_SOLUCION, @CAMPO_DE_BUSQUEDA)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.ERROR!=null &&valueObject.ERROR.Length <= 8000)
					stmt.Parameters.AddWithValue("@ERROR", valueObject.ERROR);
				else
					stmt.Parameters.AddWithValue("@ERROR", DBNull.Value);
				if(valueObject.MENSAJE_PARA_USUARIO!=null &&valueObject.MENSAJE_PARA_USUARIO.Length <= 8000)
					stmt.Parameters.AddWithValue("@MENSAJE_PARA_USUARIO", valueObject.MENSAJE_PARA_USUARIO);
				else
					stmt.Parameters.AddWithValue("@MENSAJE_PARA_USUARIO", DBNull.Value);
				if(valueObject.POSIBLE_SOLUCION!=null &&valueObject.POSIBLE_SOLUCION.Length <= 8000)
					stmt.Parameters.AddWithValue("@POSIBLE_SOLUCION", valueObject.POSIBLE_SOLUCION);
				else
					stmt.Parameters.AddWithValue("@POSIBLE_SOLUCION", DBNull.Value);
                if (valueObject.CAMPO_DE_BUSQUEDA != null && valueObject.CAMPO_DE_BUSQUEDA.Length <= 149)
                    stmt.Parameters.AddWithValue("@CAMPO_DE_BUSQUEDA", valueObject.CAMPO_DE_BUSQUEDA);
                else
                    stmt.Parameters.AddWithValue("@CAMPO_DE_BUSQUEDA", DBNull.Value);



                databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Error valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE ERROR SET  ERROR = @ERROR , MENSAJE_PARA_USUARIO = @MENSAJE_PARA_USUARIO ,"+
            " POSIBLE_SOLUCION = @POSIBLE_SOLUCION, CAMPO_DE_BUSQUEDA = @CAMPO_DE_BUSQUEDA  WHERE (ID_ERROR= @ID_ERROR)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.ERROR!=null &&valueObject.ERROR.Length <= 8000)
					stmt.Parameters.AddWithValue("@ERROR", valueObject.ERROR);
				else
					stmt.Parameters.AddWithValue("@ERROR", DBNull.Value);
				if(valueObject.MENSAJE_PARA_USUARIO!=null &&valueObject.MENSAJE_PARA_USUARIO.Length <= 8000)
					stmt.Parameters.AddWithValue("@MENSAJE_PARA_USUARIO", valueObject.MENSAJE_PARA_USUARIO);
				else
					stmt.Parameters.AddWithValue("@MENSAJE_PARA_USUARIO", DBNull.Value);
				if(valueObject.POSIBLE_SOLUCION!=null &&valueObject.POSIBLE_SOLUCION.Length <= 8000)
					stmt.Parameters.AddWithValue("@POSIBLE_SOLUCION", valueObject.POSIBLE_SOLUCION);
				else
					stmt.Parameters.AddWithValue("@POSIBLE_SOLUCION", DBNull.Value);
                if (valueObject.CAMPO_DE_BUSQUEDA != null && valueObject.CAMPO_DE_BUSQUEDA.Length <= 8000)
                    stmt.Parameters.AddWithValue("@CAMPO_DE_BUSQUEDA", valueObject.CAMPO_DE_BUSQUEDA);
                else
                    stmt.Parameters.AddWithValue("@CAMPO_DE_BUSQUEDA", DBNull.Value);
                stmt.Parameters.AddWithValue("@ID_ERROR", valueObject.ID_ERROR);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Error valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM ERROR WHERE (ID_ERROR = @ID_ERROR )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_ERROR", valueObject.ID_ERROR);

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
		String sql = "SELECT count(*) FROM ERROR";
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
	public List<Error> searchMatching(SqlConnection conn, Error valueObject) {
		List<Error> searchResults = new List<Error>();
		bool first = true;
		String sql = "SELECT * FROM ERROR WHERE 1=1 ";
		if (valueObject.ID_ERROR != null && valueObject.ID_ERROR != 0) {
			if (first) { first = false; }
			sql += "AND ID_ERROR= " + valueObject.ID_ERROR + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.ERROR)) {
			if (first) { first = false; }
			sql += "AND ERROR= '" + valueObject.ERROR + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.MENSAJE_PARA_USUARIO)) {
			if (first) { first = false; }
			sql += "AND MENSAJE_PARA_USUARIO= '" + valueObject.MENSAJE_PARA_USUARIO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.POSIBLE_SOLUCION)) {
			if (first) { first = false; }
			sql += "AND POSIBLE_SOLUCION= '" + valueObject.POSIBLE_SOLUCION + "' ";
		}

            if (!String.IsNullOrEmpty(valueObject.CAMPO_DE_BUSQUEDA))
            {
                if (first) { first = false; }
                sql += "AND CAMPO_DE_BUSQUEDA= '" + valueObject.CAMPO_DE_BUSQUEDA + "' ";
            }

            sql += "ORDER BY ID_ERROR ASC ";

		if (first)
			searchResults = new List<Error>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Error> searchMatching(SqlConnection conn, Error valueObject, int limiteInf, int limiteSup) {
		List<Error> searchResults = new List<Error>();
		bool first = true;
		String sql = "SELECT * FROM ERROR WHERE 1=1 ";
		if (valueObject.ID_ERROR != null && valueObject.ID_ERROR != 0) {
			if (first) { first = false; }
			sql += "AND ID_ERROR= " + valueObject.ID_ERROR + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.ERROR)) {
			if (first) { first = false; }
			sql += "AND ERROR= '" + valueObject.ERROR + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.MENSAJE_PARA_USUARIO)) {
			if (first) { first = false; }
			sql += "AND MENSAJE_PARA_USUARIO= '" + valueObject.MENSAJE_PARA_USUARIO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.POSIBLE_SOLUCION)) {
			if (first) { first = false; }
			sql += "AND POSIBLE_SOLUCION= '" + valueObject.POSIBLE_SOLUCION + "' ";
		}

            if (!String.IsNullOrEmpty(valueObject.CAMPO_DE_BUSQUEDA))
            {
                if (first) { first = false; }
                sql += "AND CAMPO_DE_BUSQUEDA= '" + valueObject.CAMPO_DE_BUSQUEDA + "' ";
            }

            sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Error>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Error valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM ERROR WHERE 1=1 ";
		if (valueObject.ID_ERROR != null && valueObject.ID_ERROR != 0) {
			if (first) { first = false; }
			sql += "AND ID_ERROR= " + valueObject.ID_ERROR + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.ERROR)) {
			if (first) { first = false; }
			sql += "AND ERROR= '" + valueObject.ERROR + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.MENSAJE_PARA_USUARIO)) {
			if (first) { first = false; }
			sql += "AND MENSAJE_PARA_USUARIO= '" + valueObject.MENSAJE_PARA_USUARIO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.POSIBLE_SOLUCION)) {
			if (first) { first = false; }
			sql += "AND POSIBLE_SOLUCION= '" + valueObject.POSIBLE_SOLUCION + "' ";
		}

            if (!String.IsNullOrEmpty(valueObject.CAMPO_DE_BUSQUEDA))
            {
                if (first) { first = false; }
                sql += "AND CAMPO_DE_BUSQUEDA= '" + valueObject.CAMPO_DE_BUSQUEDA + "' ";
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


	private List<Error> listQuery(SqlCommand stmt) {

		List<Error> searchResults = new List<Error>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Error temp = createValueObject();

				temp.ID_ERROR= reader["ID_ERROR"] != null && long.TryParse(reader["ID_ERROR"].ToString(),out longg) ? longg : 0;
				temp.ERROR= reader["ERROR"] != null ? reader["ERROR"].ToString() : null;
				temp.MENSAJE_PARA_USUARIO= reader["MENSAJE_PARA_USUARIO"] != null ? reader["MENSAJE_PARA_USUARIO"].ToString() : null;
				temp.POSIBLE_SOLUCION= reader["POSIBLE_SOLUCION"] != null ? reader["POSIBLE_SOLUCION"].ToString() : null;
                    temp.CAMPO_DE_BUSQUEDA = reader["CAMPO_DE_BUSQUEDA"] != null ? reader["CAMPO_DE_BUSQUEDA"].ToString() : null;
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
