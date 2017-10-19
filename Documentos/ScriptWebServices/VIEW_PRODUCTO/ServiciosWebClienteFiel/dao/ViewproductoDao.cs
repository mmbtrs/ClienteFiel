using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class ViewproductoDao {


	public Viewproducto createValueObject() {
		return new Viewproducto();
	}

	public List<Viewproducto> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM VIEW_PRODUCTO ORDER BY ID_PRODUCTO ASC ";
		List<Viewproducto> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Viewproducto> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_PRODUCTO) AS RowNumber FROM VIEW_PRODUCTO) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Viewproducto> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Viewproducto valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO VIEW_PRODUCTO ( ID_PRODUCTO,"+
			" ID_IMAGEN, ID_TIPO_PRODUCTO, ID_EMPRESA,"+
			" NOM_PRODUCTO, PRECIO, DESCRIPCION,"+
			" IMAGEN, NOM_TIPO_PRODUCTO, NIT,"+
			" RAZON_SOCIAL, SUCURSAL)"+
			 "VALUES ( @ID_PRODUCTO, @ID_IMAGEN, @ID_TIPO_PRODUCTO, @ID_EMPRESA, @NOM_PRODUCTO, @PRECIO, @DESCRIPCION, @IMAGEN, @NOM_TIPO_PRODUCTO, @NIT, @RAZON_SOCIAL, @SUCURSAL)";
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
				if(valueObject.IMAGEN!=null &&valueObject.IMAGEN.Length <= 2147483647)
					stmt.Parameters.AddWithValue("@IMAGEN", valueObject.IMAGEN);
				else
					stmt.Parameters.AddWithValue("@IMAGEN", DBNull.Value);
				if(valueObject.NOM_TIPO_PRODUCTO!=null &&valueObject.NOM_TIPO_PRODUCTO.Length <= 100)
					stmt.Parameters.AddWithValue("@NOM_TIPO_PRODUCTO", valueObject.NOM_TIPO_PRODUCTO);
				else
					stmt.Parameters.AddWithValue("@NOM_TIPO_PRODUCTO", DBNull.Value);
				if(valueObject.NIT!=null &&valueObject.NIT.Length <= 20)
					stmt.Parameters.AddWithValue("@NIT", valueObject.NIT);
				else
					stmt.Parameters.AddWithValue("@NIT", DBNull.Value);
				if(valueObject.RAZON_SOCIAL!=null &&valueObject.RAZON_SOCIAL.Length <= 500)
					stmt.Parameters.AddWithValue("@RAZON_SOCIAL", valueObject.RAZON_SOCIAL);
				else
					stmt.Parameters.AddWithValue("@RAZON_SOCIAL", DBNull.Value);
				if(valueObject.SUCURSAL!=null &&valueObject.SUCURSAL.Length <= 100)
					stmt.Parameters.AddWithValue("@SUCURSAL", valueObject.SUCURSAL);
				else
					stmt.Parameters.AddWithValue("@SUCURSAL", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Viewproducto valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE VIEW_PRODUCTO SET  ID_IMAGEN = @ID_IMAGEN , ID_TIPO_PRODUCTO = @ID_TIPO_PRODUCTO , ID_EMPRESA = @ID_EMPRESA ,"+
			" NOM_PRODUCTO = @NOM_PRODUCTO , PRECIO = @PRECIO , DESCRIPCION = @DESCRIPCION ,"+
			" IMAGEN = @IMAGEN , NOM_TIPO_PRODUCTO = @NOM_TIPO_PRODUCTO , NIT = @NIT ,"+
			" RAZON_SOCIAL = @RAZON_SOCIAL , SUCURSAL = @SUCURSAL  WHERE (ID_PRODUCTO= @ID_PRODUCTO)";
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
				if(valueObject.IMAGEN!=null &&valueObject.IMAGEN.Length <= 2147483647)
					stmt.Parameters.AddWithValue("@IMAGEN", valueObject.IMAGEN);
				else
					stmt.Parameters.AddWithValue("@IMAGEN", DBNull.Value);
				if(valueObject.NOM_TIPO_PRODUCTO!=null &&valueObject.NOM_TIPO_PRODUCTO.Length <= 100)
					stmt.Parameters.AddWithValue("@NOM_TIPO_PRODUCTO", valueObject.NOM_TIPO_PRODUCTO);
				else
					stmt.Parameters.AddWithValue("@NOM_TIPO_PRODUCTO", DBNull.Value);
				if(valueObject.NIT!=null &&valueObject.NIT.Length <= 20)
					stmt.Parameters.AddWithValue("@NIT", valueObject.NIT);
				else
					stmt.Parameters.AddWithValue("@NIT", DBNull.Value);
				if(valueObject.RAZON_SOCIAL!=null &&valueObject.RAZON_SOCIAL.Length <= 500)
					stmt.Parameters.AddWithValue("@RAZON_SOCIAL", valueObject.RAZON_SOCIAL);
				else
					stmt.Parameters.AddWithValue("@RAZON_SOCIAL", DBNull.Value);
				if(valueObject.SUCURSAL!=null &&valueObject.SUCURSAL.Length <= 100)
					stmt.Parameters.AddWithValue("@SUCURSAL", valueObject.SUCURSAL);
				else
					stmt.Parameters.AddWithValue("@SUCURSAL", DBNull.Value);
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


	public void delete(SqlConnection conn, Viewproducto valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM VIEW_PRODUCTO WHERE (ID_PRODUCTO = @ID_PRODUCTO )";
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
		String sql = "SELECT count(*) FROM VIEW_PRODUCTO";
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
	public List<Viewproducto> searchMatching(SqlConnection conn, Viewproducto valueObject) {
		List<Viewproducto> searchResults = new List<Viewproducto>();
		bool first = true;
		String sql = "SELECT * FROM VIEW_PRODUCTO WHERE 1=1 ";
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

		if (!String.IsNullOrEmpty(valueObject.IMAGEN)) {
			if (first) { first = false; }
			sql += "AND IMAGEN= '" + valueObject.IMAGEN + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_TIPO_PRODUCTO)) {
			if (first) { first = false; }
			sql += "AND NOM_TIPO_PRODUCTO= '" + valueObject.NOM_TIPO_PRODUCTO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.NIT)) {
			if (first) { first = false; }
			sql += "AND NIT= '" + valueObject.NIT + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.RAZON_SOCIAL)) {
			if (first) { first = false; }
			sql += "AND RAZON_SOCIAL= '" + valueObject.RAZON_SOCIAL + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.SUCURSAL)) {
			if (first) { first = false; }
			sql += "AND SUCURSAL= '" + valueObject.SUCURSAL + "' ";
		}

		sql += "ORDER BY ID_PRODUCTO ASC ";

		if (first)
			searchResults = new List<Viewproducto>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Viewproducto> searchMatching(SqlConnection conn, Viewproducto valueObject, int limiteInf, int limiteSup) {
		List<Viewproducto> searchResults = new List<Viewproducto>();
		bool first = true;
		String sql = "SELECT * FROM VIEW_PRODUCTO WHERE 1=1 ";
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

		if (!String.IsNullOrEmpty(valueObject.IMAGEN)) {
			if (first) { first = false; }
			sql += "AND IMAGEN= '" + valueObject.IMAGEN + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_TIPO_PRODUCTO)) {
			if (first) { first = false; }
			sql += "AND NOM_TIPO_PRODUCTO= '" + valueObject.NOM_TIPO_PRODUCTO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.NIT)) {
			if (first) { first = false; }
			sql += "AND NIT= '" + valueObject.NIT + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.RAZON_SOCIAL)) {
			if (first) { first = false; }
			sql += "AND RAZON_SOCIAL= '" + valueObject.RAZON_SOCIAL + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.SUCURSAL)) {
			if (first) { first = false; }
			sql += "AND SUCURSAL= '" + valueObject.SUCURSAL + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Viewproducto>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Viewproducto valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM VIEW_PRODUCTO WHERE 1=1 ";
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

		if (!String.IsNullOrEmpty(valueObject.IMAGEN)) {
			if (first) { first = false; }
			sql += "AND IMAGEN= '" + valueObject.IMAGEN + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_TIPO_PRODUCTO)) {
			if (first) { first = false; }
			sql += "AND NOM_TIPO_PRODUCTO= '" + valueObject.NOM_TIPO_PRODUCTO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.NIT)) {
			if (first) { first = false; }
			sql += "AND NIT= '" + valueObject.NIT + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.RAZON_SOCIAL)) {
			if (first) { first = false; }
			sql += "AND RAZON_SOCIAL= '" + valueObject.RAZON_SOCIAL + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.SUCURSAL)) {
			if (first) { first = false; }
			sql += "AND SUCURSAL= '" + valueObject.SUCURSAL + "' ";
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


	private List<Viewproducto> listQuery(SqlCommand stmt) {

		List<Viewproducto> searchResults = new List<Viewproducto>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Viewproducto temp = createValueObject();

				temp.ID_PRODUCTO= reader["ID_PRODUCTO"] != null && long.TryParse(reader["ID_PRODUCTO"].ToString(),out longg) ? longg : 0;
				temp.ID_IMAGEN= reader["ID_IMAGEN"] != null && long.TryParse(reader["ID_IMAGEN"].ToString(),out longg) ? longg : 0;
				temp.ID_TIPO_PRODUCTO= reader["ID_TIPO_PRODUCTO"] != null && long.TryParse(reader["ID_TIPO_PRODUCTO"].ToString(),out longg) ? longg : 0;
				temp.ID_EMPRESA= reader["ID_EMPRESA"] != null && long.TryParse(reader["ID_EMPRESA"].ToString(),out longg) ? longg : 0;
				temp.NOM_PRODUCTO= reader["NOM_PRODUCTO"] != null ? reader["NOM_PRODUCTO"].ToString() : null;
				temp.PRECIO= reader["PRECIO"] != null && long.TryParse(reader["PRECIO"].ToString(),out longg) ? longg : 0;
				temp.DESCRIPCION= reader["DESCRIPCION"] != null ? reader["DESCRIPCION"].ToString() : null;
				temp.IMAGEN= reader["IMAGEN"] != null ? reader["IMAGEN"].ToString() : null;
				temp.NOM_TIPO_PRODUCTO= reader["NOM_TIPO_PRODUCTO"] != null ? reader["NOM_TIPO_PRODUCTO"].ToString() : null;
				temp.NIT= reader["NIT"] != null ? reader["NIT"].ToString() : null;
				temp.RAZON_SOCIAL= reader["RAZON_SOCIAL"] != null ? reader["RAZON_SOCIAL"].ToString() : null;
				temp.SUCURSAL= reader["SUCURSAL"] != null ? reader["SUCURSAL"].ToString() : null;
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
