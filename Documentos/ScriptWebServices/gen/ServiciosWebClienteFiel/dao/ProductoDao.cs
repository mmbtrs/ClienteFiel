using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class ProductoDao {


	public Producto createValueObject() {
		return new Producto();
	}

	public List<Producto> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM PRODUCTO ORDER BY ID_PRODUCTO ASC ";
		List<Producto> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Producto> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_PRODUCTO) AS RowNumber FROM PRODUCTO) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Producto> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Producto valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO PRODUCTO ( ID_PRODUCTO,"+
			" ID_IMAGEN, ID_TIPO_PRODUCTO, ID_EMPRESA,"+
			" NOM_PRODUCTO, PRECIO, DESCRIPCION"+
			")"+
			 "VALUES ( @ID_PRODUCTO, @ID_IMAGEN, @ID_TIPO_PRODUCTO, @ID_EMPRESA, @NOM_PRODUCTO, @PRECIO, @DESCRIPCION)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_PRODUCTO", valueObject.ID_PRODUCTO);
				if(valueObject.ID_IMAGEN!=0)
					stmt.Parameters.AddWithValue("@ID_IMAGEN", valueObject.ID_IMAGEN);
				else
					stmt.Parameters.AddWithValue("@ID_IMAGEN", DBNull.Value);
				if(valueObject.ID_TIPO_PRODUCTO!=0)
					stmt.Parameters.AddWithValue("@ID_TIPO_PRODUCTO", valueObject.ID_TIPO_PRODUCTO);
				else
					stmt.Parameters.AddWithValue("@ID_TIPO_PRODUCTO", DBNull.Value);
				if(valueObject.ID_EMPRESA!=0)
					stmt.Parameters.AddWithValue("@ID_EMPRESA", valueObject.ID_EMPRESA);
				else
					stmt.Parameters.AddWithValue("@ID_EMPRESA", DBNull.Value);
				if(valueObject.NOM_PRODUCTO!=null &&valueObject.NOM_PRODUCTO.Length <= 100)
					stmt.Parameters.AddWithValue("@NOM_PRODUCTO", valueObject.NOM_PRODUCTO);
				else
					stmt.Parameters.AddWithValue("@NOM_PRODUCTO", DBNull.Value);
				if(valueObject.PRECIO!=0)
					stmt.Parameters.AddWithValue("@PRECIO", valueObject.PRECIO);
				else
					stmt.Parameters.AddWithValue("@PRECIO", DBNull.Value);
				if(valueObject.DESCRIPCION!=null &&valueObject.DESCRIPCION.Length <= 8000)
					stmt.Parameters.AddWithValue("@DESCRIPCION", valueObject.DESCRIPCION);
				else
					stmt.Parameters.AddWithValue("@DESCRIPCION", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Producto valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE PRODUCTO SET  ID_IMAGEN = @ID_IMAGEN , ID_TIPO_PRODUCTO = @ID_TIPO_PRODUCTO , ID_EMPRESA = @ID_EMPRESA ,"+
			" NOM_PRODUCTO = @NOM_PRODUCTO , PRECIO = @PRECIO , DESCRIPCION = @DESCRIPCION "+
			" WHERE (ID_PRODUCTO= @ID_PRODUCTO)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.ID_IMAGEN!=0)
					stmt.Parameters.AddWithValue("@ID_IMAGEN", valueObject.ID_IMAGEN);
				else
					stmt.Parameters.AddWithValue("@ID_IMAGEN", DBNull.Value);
				if(valueObject.ID_TIPO_PRODUCTO!=0)
					stmt.Parameters.AddWithValue("@ID_TIPO_PRODUCTO", valueObject.ID_TIPO_PRODUCTO);
				else
					stmt.Parameters.AddWithValue("@ID_TIPO_PRODUCTO", DBNull.Value);
				if(valueObject.ID_EMPRESA!=0)
					stmt.Parameters.AddWithValue("@ID_EMPRESA", valueObject.ID_EMPRESA);
				else
					stmt.Parameters.AddWithValue("@ID_EMPRESA", DBNull.Value);
				if(valueObject.NOM_PRODUCTO!=null &&valueObject.NOM_PRODUCTO.Length <= 100)
					stmt.Parameters.AddWithValue("@NOM_PRODUCTO", valueObject.NOM_PRODUCTO);
				else
					stmt.Parameters.AddWithValue("@NOM_PRODUCTO", DBNull.Value);
				if(valueObject.PRECIO!=0)
					stmt.Parameters.AddWithValue("@PRECIO", valueObject.PRECIO);
				else
					stmt.Parameters.AddWithValue("@PRECIO", DBNull.Value);
				if(valueObject.DESCRIPCION!=null &&valueObject.DESCRIPCION.Length <= 8000)
					stmt.Parameters.AddWithValue("@DESCRIPCION", valueObject.DESCRIPCION);
				else
					stmt.Parameters.AddWithValue("@DESCRIPCION", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_PRODUCTO", valueObject.ID_PRODUCTO);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Producto valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM PRODUCTO WHERE (ID_PRODUCTO = @ID_PRODUCTO )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_PRODUCTO", valueObject.ID_PRODUCTO);

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
		String sql = "SELECT count(*) FROM PRODUCTO";
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
	public List<Producto> searchMatching(SqlConnection conn, Producto valueObject) {
		List<Producto> searchResults = new List<Producto>();
		bool first = true;
		String sql = "SELECT * FROM PRODUCTO WHERE 1=1 ";
		if (valueObject.ID_PRODUCTO != null && valueObject.ID_PRODUCTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_PRODUCTO= " + valueObject.ID_PRODUCTO + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (valueObject.ID_TIPO_PRODUCTO != null && valueObject.ID_TIPO_PRODUCTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_PRODUCTO= " + valueObject.ID_TIPO_PRODUCTO + " ";
		}

		if (valueObject.ID_EMPRESA != null && valueObject.ID_EMPRESA != 0) {
			if (first) { first = false; }
			sql += "AND ID_EMPRESA= " + valueObject.ID_EMPRESA + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_PRODUCTO)) {
			if (first) { first = false; }
			sql += "AND NOM_PRODUCTO= '" + valueObject.NOM_PRODUCTO + "' ";
		}

		if (valueObject.PRECIO != null && valueObject.PRECIO != 0) {
			if (first) { first = false; }
			sql += "AND PRECIO= " + valueObject.PRECIO + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.DESCRIPCION)) {
			if (first) { first = false; }
			sql += "AND DESCRIPCION= '" + valueObject.DESCRIPCION + "' ";
		}

		sql += "ORDER BY ID_PRODUCTO ASC ";

		if (first)
			searchResults = new List<Producto>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Producto> searchMatching(SqlConnection conn, Producto valueObject, int limiteInf, int limiteSup) {
		List<Producto> searchResults = new List<Producto>();
		bool first = true;
		String sql = "SELECT * FROM PRODUCTO WHERE 1=1 ";
		if (valueObject.ID_PRODUCTO != null && valueObject.ID_PRODUCTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_PRODUCTO= " + valueObject.ID_PRODUCTO + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (valueObject.ID_TIPO_PRODUCTO != null && valueObject.ID_TIPO_PRODUCTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_PRODUCTO= " + valueObject.ID_TIPO_PRODUCTO + " ";
		}

		if (valueObject.ID_EMPRESA != null && valueObject.ID_EMPRESA != 0) {
			if (first) { first = false; }
			sql += "AND ID_EMPRESA= " + valueObject.ID_EMPRESA + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_PRODUCTO)) {
			if (first) { first = false; }
			sql += "AND NOM_PRODUCTO= '" + valueObject.NOM_PRODUCTO + "' ";
		}

		if (valueObject.PRECIO != null && valueObject.PRECIO != 0) {
			if (first) { first = false; }
			sql += "AND PRECIO= " + valueObject.PRECIO + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.DESCRIPCION)) {
			if (first) { first = false; }
			sql += "AND DESCRIPCION= '" + valueObject.DESCRIPCION + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Producto>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Producto valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM PRODUCTO WHERE 1=1 ";
		if (valueObject.ID_PRODUCTO != null && valueObject.ID_PRODUCTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_PRODUCTO= " + valueObject.ID_PRODUCTO + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (valueObject.ID_TIPO_PRODUCTO != null && valueObject.ID_TIPO_PRODUCTO != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_PRODUCTO= " + valueObject.ID_TIPO_PRODUCTO + " ";
		}

		if (valueObject.ID_EMPRESA != null && valueObject.ID_EMPRESA != 0) {
			if (first) { first = false; }
			sql += "AND ID_EMPRESA= " + valueObject.ID_EMPRESA + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_PRODUCTO)) {
			if (first) { first = false; }
			sql += "AND NOM_PRODUCTO= '" + valueObject.NOM_PRODUCTO + "' ";
		}

		if (valueObject.PRECIO != null && valueObject.PRECIO != 0) {
			if (first) { first = false; }
			sql += "AND PRECIO= " + valueObject.PRECIO + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.DESCRIPCION)) {
			if (first) { first = false; }
			sql += "AND DESCRIPCION= '" + valueObject.DESCRIPCION + "' ";
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


	private List<Producto> listQuery(SqlCommand stmt) {

		List<Producto> searchResults = new List<Producto>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Producto temp = createValueObject();

				temp.ID_PRODUCTO= reader["ID_PRODUCTO"] != null && long.TryParse(reader["ID_PRODUCTO"].ToString(),out longg) ? longg : 0;
				temp.ID_IMAGEN= reader["ID_IMAGEN"] != null && long.TryParse(reader["ID_IMAGEN"].ToString(),out longg) ? longg : 0;
				temp.ID_TIPO_PRODUCTO= reader["ID_TIPO_PRODUCTO"] != null && long.TryParse(reader["ID_TIPO_PRODUCTO"].ToString(),out longg) ? longg : 0;
				temp.ID_EMPRESA= reader["ID_EMPRESA"] != null && long.TryParse(reader["ID_EMPRESA"].ToString(),out longg) ? longg : 0;
				temp.NOM_PRODUCTO= reader["NOM_PRODUCTO"] != null ? reader["NOM_PRODUCTO"].ToString() : null;
				temp.PRECIO= reader["PRECIO"] != null && long.TryParse(reader["PRECIO"].ToString(),out longg) ? longg : 0;
				temp.DESCRIPCION= reader["DESCRIPCION"] != null ? reader["DESCRIPCION"].ToString() : null;
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
