using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class ViewempresaDao {


	public Viewempresa createValueObject() {
		return new Viewempresa();
	}

	public List<Viewempresa> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM VIEW_EMPRESA ORDER BY ID_EMPRESA ASC ";
		List<Viewempresa> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Viewempresa> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_EMPRESA) AS RowNumber FROM VIEW_EMPRESA) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Viewempresa> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Viewempresa valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO VIEW_EMPRESA ( ID_EMPRESA,"+
			" ID_MUNICIPIO, ID_IMAGEN, NIT,"+
			" RAZON_SOCIAL, DIRECCION_CLIENTE, TELEFONO,"+
			" SLOGAN, LATITUD, LONGITUD,"+
			" SUCURSAL, NOM_MUNICIPIO, IMAGEN"+
			")"+
			 "VALUES ( @ID_EMPRESA, @ID_MUNICIPIO, @ID_IMAGEN, @NIT, @RAZON_SOCIAL, @DIRECCION_CLIENTE, @TELEFONO, @SLOGAN, @LATITUD, @LONGITUD, @SUCURSAL, @NOM_MUNICIPIO, @IMAGEN)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_EMPRESA", valueObject.ID_EMPRESA);
				if(valueObject.ID_MUNICIPIO!=0)
					stmt.Parameters.AddWithValue("@ID_MUNICIPIO", valueObject.ID_MUNICIPIO);
				else
					stmt.Parameters.AddWithValue("@ID_MUNICIPIO", DBNull.Value);
				if(valueObject.ID_IMAGEN!=0)
					stmt.Parameters.AddWithValue("@ID_IMAGEN", valueObject.ID_IMAGEN);
				else
					stmt.Parameters.AddWithValue("@ID_IMAGEN", DBNull.Value);
				if(valueObject.NIT!=null &&valueObject.NIT.Length <= 20)
					stmt.Parameters.AddWithValue("@NIT", valueObject.NIT);
				else
					stmt.Parameters.AddWithValue("@NIT", DBNull.Value);
				if(valueObject.RAZON_SOCIAL!=null &&valueObject.RAZON_SOCIAL.Length <= 500)
					stmt.Parameters.AddWithValue("@RAZON_SOCIAL", valueObject.RAZON_SOCIAL);
				else
					stmt.Parameters.AddWithValue("@RAZON_SOCIAL", DBNull.Value);
				if(valueObject.DIRECCION_CLIENTE!=null &&valueObject.DIRECCION_CLIENTE.Length <= 300)
					stmt.Parameters.AddWithValue("@DIRECCION_CLIENTE", valueObject.DIRECCION_CLIENTE);
				else
					stmt.Parameters.AddWithValue("@DIRECCION_CLIENTE", DBNull.Value);
				if(valueObject.TELEFONO!=null &&valueObject.TELEFONO.Length <= 100)
					stmt.Parameters.AddWithValue("@TELEFONO", valueObject.TELEFONO);
				else
					stmt.Parameters.AddWithValue("@TELEFONO", DBNull.Value);
				if(valueObject.SLOGAN!=null &&valueObject.SLOGAN.Length <= 500)
					stmt.Parameters.AddWithValue("@SLOGAN", valueObject.SLOGAN);
				else
					stmt.Parameters.AddWithValue("@SLOGAN", DBNull.Value);
				if(valueObject.LATITUD!=null &&valueObject.LATITUD.Length <= 20)
					stmt.Parameters.AddWithValue("@LATITUD", valueObject.LATITUD);
				else
					stmt.Parameters.AddWithValue("@LATITUD", DBNull.Value);
				if(valueObject.LONGITUD!=null &&valueObject.LONGITUD.Length <= 20)
					stmt.Parameters.AddWithValue("@LONGITUD", valueObject.LONGITUD);
				else
					stmt.Parameters.AddWithValue("@LONGITUD", DBNull.Value);
				if(valueObject.SUCURSAL!=null &&valueObject.SUCURSAL.Length <= 100)
					stmt.Parameters.AddWithValue("@SUCURSAL", valueObject.SUCURSAL);
				else
					stmt.Parameters.AddWithValue("@SUCURSAL", DBNull.Value);
				if(valueObject.NOM_MUNICIPIO!=null &&valueObject.NOM_MUNICIPIO.Length <= 50)
					stmt.Parameters.AddWithValue("@NOM_MUNICIPIO", valueObject.NOM_MUNICIPIO);
				else
					stmt.Parameters.AddWithValue("@NOM_MUNICIPIO", DBNull.Value);
				if(valueObject.IMAGEN!=null &&valueObject.IMAGEN.Length <= 2147483647)
					stmt.Parameters.AddWithValue("@IMAGEN", valueObject.IMAGEN);
				else
					stmt.Parameters.AddWithValue("@IMAGEN", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Viewempresa valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE VIEW_EMPRESA SET  ID_MUNICIPIO = @ID_MUNICIPIO , ID_IMAGEN = @ID_IMAGEN , NIT = @NIT ,"+
			" RAZON_SOCIAL = @RAZON_SOCIAL , DIRECCION_CLIENTE = @DIRECCION_CLIENTE , TELEFONO = @TELEFONO ,"+
			" SLOGAN = @SLOGAN , LATITUD = @LATITUD , LONGITUD = @LONGITUD ,"+
			" SUCURSAL = @SUCURSAL , NOM_MUNICIPIO = @NOM_MUNICIPIO , IMAGEN = @IMAGEN "+
			" WHERE (ID_EMPRESA= @ID_EMPRESA)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.ID_MUNICIPIO!=0)
					stmt.Parameters.AddWithValue("@ID_MUNICIPIO", valueObject.ID_MUNICIPIO);
				else
					stmt.Parameters.AddWithValue("@ID_MUNICIPIO", DBNull.Value);
				if(valueObject.ID_IMAGEN!=0)
					stmt.Parameters.AddWithValue("@ID_IMAGEN", valueObject.ID_IMAGEN);
				else
					stmt.Parameters.AddWithValue("@ID_IMAGEN", DBNull.Value);
				if(valueObject.NIT!=null &&valueObject.NIT.Length <= 20)
					stmt.Parameters.AddWithValue("@NIT", valueObject.NIT);
				else
					stmt.Parameters.AddWithValue("@NIT", DBNull.Value);
				if(valueObject.RAZON_SOCIAL!=null &&valueObject.RAZON_SOCIAL.Length <= 500)
					stmt.Parameters.AddWithValue("@RAZON_SOCIAL", valueObject.RAZON_SOCIAL);
				else
					stmt.Parameters.AddWithValue("@RAZON_SOCIAL", DBNull.Value);
				if(valueObject.DIRECCION_CLIENTE!=null &&valueObject.DIRECCION_CLIENTE.Length <= 300)
					stmt.Parameters.AddWithValue("@DIRECCION_CLIENTE", valueObject.DIRECCION_CLIENTE);
				else
					stmt.Parameters.AddWithValue("@DIRECCION_CLIENTE", DBNull.Value);
				if(valueObject.TELEFONO!=null &&valueObject.TELEFONO.Length <= 100)
					stmt.Parameters.AddWithValue("@TELEFONO", valueObject.TELEFONO);
				else
					stmt.Parameters.AddWithValue("@TELEFONO", DBNull.Value);
				if(valueObject.SLOGAN!=null &&valueObject.SLOGAN.Length <= 500)
					stmt.Parameters.AddWithValue("@SLOGAN", valueObject.SLOGAN);
				else
					stmt.Parameters.AddWithValue("@SLOGAN", DBNull.Value);
				if(valueObject.LATITUD!=null &&valueObject.LATITUD.Length <= 20)
					stmt.Parameters.AddWithValue("@LATITUD", valueObject.LATITUD);
				else
					stmt.Parameters.AddWithValue("@LATITUD", DBNull.Value);
				if(valueObject.LONGITUD!=null &&valueObject.LONGITUD.Length <= 20)
					stmt.Parameters.AddWithValue("@LONGITUD", valueObject.LONGITUD);
				else
					stmt.Parameters.AddWithValue("@LONGITUD", DBNull.Value);
				if(valueObject.SUCURSAL!=null &&valueObject.SUCURSAL.Length <= 100)
					stmt.Parameters.AddWithValue("@SUCURSAL", valueObject.SUCURSAL);
				else
					stmt.Parameters.AddWithValue("@SUCURSAL", DBNull.Value);
				if(valueObject.NOM_MUNICIPIO!=null &&valueObject.NOM_MUNICIPIO.Length <= 50)
					stmt.Parameters.AddWithValue("@NOM_MUNICIPIO", valueObject.NOM_MUNICIPIO);
				else
					stmt.Parameters.AddWithValue("@NOM_MUNICIPIO", DBNull.Value);
				if(valueObject.IMAGEN!=null &&valueObject.IMAGEN.Length <= 2147483647)
					stmt.Parameters.AddWithValue("@IMAGEN", valueObject.IMAGEN);
				else
					stmt.Parameters.AddWithValue("@IMAGEN", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_EMPRESA", valueObject.ID_EMPRESA);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Viewempresa valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM VIEW_EMPRESA WHERE (ID_EMPRESA = @ID_EMPRESA )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_EMPRESA", valueObject.ID_EMPRESA);

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
		String sql = "SELECT count(*) FROM VIEW_EMPRESA";
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
	public List<Viewempresa> searchMatching(SqlConnection conn, Viewempresa valueObject) {
		List<Viewempresa> searchResults = new List<Viewempresa>();
		bool first = true;
		String sql = "SELECT * FROM VIEW_EMPRESA WHERE 1=1 ";
		if (valueObject.ID_EMPRESA != null && valueObject.ID_EMPRESA != 0) {
			if (first) { first = false; }
			sql += "AND ID_EMPRESA= " + valueObject.ID_EMPRESA + " ";
		}

		if (valueObject.ID_MUNICIPIO != null && valueObject.ID_MUNICIPIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_MUNICIPIO= " + valueObject.ID_MUNICIPIO + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NIT)) {
			if (first) { first = false; }
			sql += "AND NIT= '" + valueObject.NIT + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.RAZON_SOCIAL)) {
			if (first) { first = false; }
			sql += "AND RAZON_SOCIAL= '" + valueObject.RAZON_SOCIAL + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.DIRECCION_CLIENTE)) {
			if (first) { first = false; }
			sql += "AND DIRECCION_CLIENTE= '" + valueObject.DIRECCION_CLIENTE + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.TELEFONO)) {
			if (first) { first = false; }
			sql += "AND TELEFONO= '" + valueObject.TELEFONO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.SLOGAN)) {
			if (first) { first = false; }
			sql += "AND SLOGAN= '" + valueObject.SLOGAN + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.LATITUD)) {
			if (first) { first = false; }
			sql += "AND LATITUD= '" + valueObject.LATITUD + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.LONGITUD)) {
			if (first) { first = false; }
			sql += "AND LONGITUD= '" + valueObject.LONGITUD + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.SUCURSAL)) {
			if (first) { first = false; }
			sql += "AND SUCURSAL= '" + valueObject.SUCURSAL + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_MUNICIPIO)) {
			if (first) { first = false; }
			sql += "AND NOM_MUNICIPIO= '" + valueObject.NOM_MUNICIPIO + "' ";
		}


		sql += "ORDER BY ID_EMPRESA ASC ";

		if (first)
			searchResults = new List<Viewempresa>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Viewempresa> searchMatching(SqlConnection conn, Viewempresa valueObject, int limiteInf, int limiteSup) {
		List<Viewempresa> searchResults = new List<Viewempresa>();
		bool first = true;
		String sql = "SELECT * FROM VIEW_EMPRESA WHERE 1=1 ";
		if (valueObject.ID_EMPRESA != null && valueObject.ID_EMPRESA != 0) {
			if (first) { first = false; }
			sql += "AND ID_EMPRESA= " + valueObject.ID_EMPRESA + " ";
		}

		if (valueObject.ID_MUNICIPIO != null && valueObject.ID_MUNICIPIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_MUNICIPIO= " + valueObject.ID_MUNICIPIO + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NIT)) {
			if (first) { first = false; }
			sql += "AND NIT= '" + valueObject.NIT + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.RAZON_SOCIAL)) {
			if (first) { first = false; }
			sql += "AND RAZON_SOCIAL= '" + valueObject.RAZON_SOCIAL + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.DIRECCION_CLIENTE)) {
			if (first) { first = false; }
			sql += "AND DIRECCION_CLIENTE= '" + valueObject.DIRECCION_CLIENTE + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.TELEFONO)) {
			if (first) { first = false; }
			sql += "AND TELEFONO= '" + valueObject.TELEFONO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.SLOGAN)) {
			if (first) { first = false; }
			sql += "AND SLOGAN= '" + valueObject.SLOGAN + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.LATITUD)) {
			if (first) { first = false; }
			sql += "AND LATITUD= '" + valueObject.LATITUD + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.LONGITUD)) {
			if (first) { first = false; }
			sql += "AND LONGITUD= '" + valueObject.LONGITUD + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.SUCURSAL)) {
			if (first) { first = false; }
			sql += "AND SUCURSAL= '" + valueObject.SUCURSAL + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOM_MUNICIPIO)) {
			if (first) { first = false; }
			sql += "AND NOM_MUNICIPIO= '" + valueObject.NOM_MUNICIPIO + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Viewempresa>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Viewempresa valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM VIEW_EMPRESA WHERE 1=1 ";
		if (valueObject.ID_EMPRESA != null && valueObject.ID_EMPRESA != 0) {
			if (first) { first = false; }
			sql += "AND ID_EMPRESA= " + valueObject.ID_EMPRESA + " ";
		}

		if (valueObject.ID_MUNICIPIO != null && valueObject.ID_MUNICIPIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_MUNICIPIO= " + valueObject.ID_MUNICIPIO + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.NIT)) {
			if (first) { first = false; }
			sql += "AND NIT= '" + valueObject.NIT + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.RAZON_SOCIAL)) {
			if (first) { first = false; }
			sql += "AND RAZON_SOCIAL= '" + valueObject.RAZON_SOCIAL + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.DIRECCION_CLIENTE)) {
			if (first) { first = false; }
			sql += "AND DIRECCION_CLIENTE= '" + valueObject.DIRECCION_CLIENTE + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.TELEFONO)) {
			if (first) { first = false; }
			sql += "AND TELEFONO= '" + valueObject.TELEFONO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.SLOGAN)) {
			if (first) { first = false; }
			sql += "AND SLOGAN= '" + valueObject.SLOGAN + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.LATITUD)) {
			if (first) { first = false; }
			sql += "AND LATITUD= '" + valueObject.LATITUD + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.LONGITUD)) {
			if (first) { first = false; }
			sql += "AND LONGITUD= '" + valueObject.LONGITUD + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.SUCURSAL)) {
			if (first) { first = false; }
			sql += "AND SUCURSAL= '" + valueObject.SUCURSAL + "' ";
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


        private List<Viewempresa> listQuery(SqlCommand stmt)
        {

            List<Viewempresa> searchResults = new List<Viewempresa>();
            SqlDataReader reader = null;
            try
            {
                int intt = 0; long longg = 0; double doublee = 0; DateTime datee;
                reader = stmt.ExecuteReader();
                while (reader.Read())
                {
                    Viewempresa temp = createValueObject();

                    temp.ID_EMPRESA = reader["ID_EMPRESA"] != null && long.TryParse(reader["ID_EMPRESA"].ToString(), out longg) ? longg : 0;
                    temp.ID_MUNICIPIO = reader["ID_MUNICIPIO"] != null && long.TryParse(reader["ID_MUNICIPIO"].ToString(), out longg) ? longg : 0;
                    temp.ID_IMAGEN = reader["ID_IMAGEN"] != null && long.TryParse(reader["ID_IMAGEN"].ToString(), out longg) ? longg : 0;
                    temp.NIT = reader["NIT"] != null ? reader["NIT"].ToString() : null;
                    temp.RAZON_SOCIAL = reader["RAZON_SOCIAL"] != null ? reader["RAZON_SOCIAL"].ToString() : null;
                    temp.DIRECCION_CLIENTE = reader["DIRECCION_CLIENTE"] != null ? reader["DIRECCION_CLIENTE"].ToString() : null;
                    temp.TELEFONO = reader["TELEFONO"] != null ? reader["TELEFONO"].ToString() : null;
                    temp.SLOGAN = reader["SLOGAN"] != null ? reader["SLOGAN"].ToString() : null;
                    temp.LATITUD = reader["LATITUD"] != null ? reader["LATITUD"].ToString() : null;
                    temp.LONGITUD = reader["LONGITUD"] != null ? reader["LONGITUD"].ToString() : null;
                    temp.SUCURSAL = reader["SUCURSAL"] != null ? reader["SUCURSAL"].ToString() : null;
                    temp.NOM_MUNICIPIO = reader["NOM_MUNICIPIO"] != null ? reader["NOM_MUNICIPIO"].ToString() : null;
                    try
                    {
                        temp.IMAGEN = reader["IMAGEN"] != null ? (byte[])reader["IMAGEN"] : null;
                    }
                    catch (Exception)
                    {
                        temp.IMAGEN = null;
                    }
                    searchResults.Add(temp);
                }
            }
            finally
            {
                if (!reader.IsClosed)
                    reader.Close();
                if (stmt != null)
                    stmt.Dispose();
            }
            return searchResults;
        }


}

}
