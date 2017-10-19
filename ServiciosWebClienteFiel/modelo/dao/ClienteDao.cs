using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class ClienteDao {


	public Cliente createValueObject() {
		return new Cliente();
	}

	public List<Cliente> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM CLIENTE ORDER BY ID_CLIENTE ASC ";
		List<Cliente> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Cliente> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_CLIENTE) AS RowNumber FROM CLIENTE) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Cliente> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Cliente valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO CLIENTE ( ID_CLIENTE,"+
			" ID_EMPRESA, ID_IMAGEN, ID_TIPO_IDENTIFICACION,"+
			" ID_CODIGO_QR, IDENTIFICACION, NOMBRES,"+
			" APELLIDOS, CORREO, DIRECCION_CLIENTE,"+
			" TELEFONO, FECHA_NACIMIENTO, SEXO"+
			")"+
			 "VALUES ( @ID_CLIENTE, @ID_EMPRESA, @ID_IMAGEN, @ID_TIPO_IDENTIFICACION, @ID_CODIGO_QR, @IDENTIFICACION, @NOMBRES, @APELLIDOS, @CORREO, @DIRECCION_CLIENTE, @TELEFONO, @FECHA_NACIMIENTO, @SEXO)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_CLIENTE", valueObject.ID_CLIENTE);
				if(valueObject.ID_EMPRESA!=0)
					stmt.Parameters.AddWithValue("@ID_EMPRESA", valueObject.ID_EMPRESA);
				else
					stmt.Parameters.AddWithValue("@ID_EMPRESA", DBNull.Value);
				if(valueObject.ID_IMAGEN!=0)
					stmt.Parameters.AddWithValue("@ID_IMAGEN", valueObject.ID_IMAGEN);
				else
					stmt.Parameters.AddWithValue("@ID_IMAGEN", DBNull.Value);
				if(valueObject.ID_TIPO_IDENTIFICACION!=0)
					stmt.Parameters.AddWithValue("@ID_TIPO_IDENTIFICACION", valueObject.ID_TIPO_IDENTIFICACION);
				else
					stmt.Parameters.AddWithValue("@ID_TIPO_IDENTIFICACION", DBNull.Value);
				if(valueObject.ID_CODIGO_QR!=0)
					stmt.Parameters.AddWithValue("@ID_CODIGO_QR", valueObject.ID_CODIGO_QR);
				else
					stmt.Parameters.AddWithValue("@ID_CODIGO_QR", DBNull.Value);
				if(valueObject.IDENTIFICACION!=null &&valueObject.IDENTIFICACION.Length <= 50)
					stmt.Parameters.AddWithValue("@IDENTIFICACION", valueObject.IDENTIFICACION);
				else
					stmt.Parameters.AddWithValue("@IDENTIFICACION", DBNull.Value);
				if(valueObject.NOMBRES!=null &&valueObject.NOMBRES.Length <= 50)
					stmt.Parameters.AddWithValue("@NOMBRES", valueObject.NOMBRES);
				else
					stmt.Parameters.AddWithValue("@NOMBRES", DBNull.Value);
				if(valueObject.APELLIDOS!=null &&valueObject.APELLIDOS.Length <= 50)
					stmt.Parameters.AddWithValue("@APELLIDOS", valueObject.APELLIDOS);
				else
					stmt.Parameters.AddWithValue("@APELLIDOS", DBNull.Value);
				if(valueObject.CORREO!=null &&valueObject.CORREO.Length <= 100)
					stmt.Parameters.AddWithValue("@CORREO", valueObject.CORREO);
				else
					stmt.Parameters.AddWithValue("@CORREO", DBNull.Value);
				if(valueObject.DIRECCION_CLIENTE!=null &&valueObject.DIRECCION_CLIENTE.Length <= 300)
					stmt.Parameters.AddWithValue("@DIRECCION_CLIENTE", valueObject.DIRECCION_CLIENTE);
				else
					stmt.Parameters.AddWithValue("@DIRECCION_CLIENTE", DBNull.Value);
				if(valueObject.TELEFONO!=null &&valueObject.TELEFONO.Length <= 100)
					stmt.Parameters.AddWithValue("@TELEFONO", valueObject.TELEFONO);
				else
					stmt.Parameters.AddWithValue("@TELEFONO", DBNull.Value);
				if(valueObject.FECHA_NACIMIENTO != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_NACIMIENTO", valueObject.FECHA_NACIMIENTO);
				else
					stmt.Parameters.AddWithValue("@FECHA_NACIMIENTO", DBNull.Value);
				if(valueObject.SEXO!=null &&valueObject.SEXO.Length <= 1)
					stmt.Parameters.AddWithValue("@SEXO", valueObject.SEXO);
				else
					stmt.Parameters.AddWithValue("@SEXO", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Cliente valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE CLIENTE SET  ID_EMPRESA = @ID_EMPRESA , ID_IMAGEN = @ID_IMAGEN , ID_TIPO_IDENTIFICACION = @ID_TIPO_IDENTIFICACION ,"+
			" ID_CODIGO_QR = @ID_CODIGO_QR , IDENTIFICACION = @IDENTIFICACION , NOMBRES = @NOMBRES ,"+
			" APELLIDOS = @APELLIDOS , CORREO = @CORREO , DIRECCION_CLIENTE = @DIRECCION_CLIENTE ,"+
			" TELEFONO = @TELEFONO , FECHA_NACIMIENTO = @FECHA_NACIMIENTO , SEXO = @SEXO "+
			" WHERE (ID_CLIENTE= @ID_CLIENTE)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.ID_EMPRESA!=0)
					stmt.Parameters.AddWithValue("@ID_EMPRESA", valueObject.ID_EMPRESA);
				else
					stmt.Parameters.AddWithValue("@ID_EMPRESA", DBNull.Value);
				if(valueObject.ID_IMAGEN!=0)
					stmt.Parameters.AddWithValue("@ID_IMAGEN", valueObject.ID_IMAGEN);
				else
					stmt.Parameters.AddWithValue("@ID_IMAGEN", DBNull.Value);
				if(valueObject.ID_TIPO_IDENTIFICACION!=0)
					stmt.Parameters.AddWithValue("@ID_TIPO_IDENTIFICACION", valueObject.ID_TIPO_IDENTIFICACION);
				else
					stmt.Parameters.AddWithValue("@ID_TIPO_IDENTIFICACION", DBNull.Value);
				if(valueObject.ID_CODIGO_QR!=0)
					stmt.Parameters.AddWithValue("@ID_CODIGO_QR", valueObject.ID_CODIGO_QR);
				else
					stmt.Parameters.AddWithValue("@ID_CODIGO_QR", DBNull.Value);
				if(valueObject.IDENTIFICACION!=null &&valueObject.IDENTIFICACION.Length <= 50)
					stmt.Parameters.AddWithValue("@IDENTIFICACION", valueObject.IDENTIFICACION);
				else
					stmt.Parameters.AddWithValue("@IDENTIFICACION", DBNull.Value);
				if(valueObject.NOMBRES!=null &&valueObject.NOMBRES.Length <= 50)
					stmt.Parameters.AddWithValue("@NOMBRES", valueObject.NOMBRES);
				else
					stmt.Parameters.AddWithValue("@NOMBRES", DBNull.Value);
				if(valueObject.APELLIDOS!=null &&valueObject.APELLIDOS.Length <= 50)
					stmt.Parameters.AddWithValue("@APELLIDOS", valueObject.APELLIDOS);
				else
					stmt.Parameters.AddWithValue("@APELLIDOS", DBNull.Value);
				if(valueObject.CORREO!=null &&valueObject.CORREO.Length <= 100)
					stmt.Parameters.AddWithValue("@CORREO", valueObject.CORREO);
				else
					stmt.Parameters.AddWithValue("@CORREO", DBNull.Value);
				if(valueObject.DIRECCION_CLIENTE!=null &&valueObject.DIRECCION_CLIENTE.Length <= 300)
					stmt.Parameters.AddWithValue("@DIRECCION_CLIENTE", valueObject.DIRECCION_CLIENTE);
				else
					stmt.Parameters.AddWithValue("@DIRECCION_CLIENTE", DBNull.Value);
				if(valueObject.TELEFONO!=null &&valueObject.TELEFONO.Length <= 100)
					stmt.Parameters.AddWithValue("@TELEFONO", valueObject.TELEFONO);
				else
					stmt.Parameters.AddWithValue("@TELEFONO", DBNull.Value);
				if(valueObject.FECHA_NACIMIENTO != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_NACIMIENTO", valueObject.FECHA_NACIMIENTO);
				else
					stmt.Parameters.AddWithValue("@FECHA_NACIMIENTO", DBNull.Value);
				if(valueObject.SEXO!=null &&valueObject.SEXO.Length <= 1)
					stmt.Parameters.AddWithValue("@SEXO", valueObject.SEXO);
				else
					stmt.Parameters.AddWithValue("@SEXO", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_CLIENTE", valueObject.ID_CLIENTE);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Cliente valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM CLIENTE WHERE (ID_CLIENTE = @ID_CLIENTE )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_CLIENTE", valueObject.ID_CLIENTE);

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
		String sql = "SELECT count(*) FROM CLIENTE";
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
	public List<Cliente> searchMatching(SqlConnection conn, Cliente valueObject) {
		List<Cliente> searchResults = new List<Cliente>();
		bool first = true;
		String sql = "SELECT * FROM CLIENTE WHERE 1=1 ";
		if (valueObject.ID_CLIENTE != null && valueObject.ID_CLIENTE != 0) {
			if (first) { first = false; }
			sql += "AND ID_CLIENTE= " + valueObject.ID_CLIENTE + " ";
		}

		if (valueObject.ID_EMPRESA != null && valueObject.ID_EMPRESA != 0) {
			if (first) { first = false; }
			sql += "AND ID_EMPRESA= " + valueObject.ID_EMPRESA + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (valueObject.ID_TIPO_IDENTIFICACION != null && valueObject.ID_TIPO_IDENTIFICACION != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_IDENTIFICACION= " + valueObject.ID_TIPO_IDENTIFICACION + " ";
		}

		if (valueObject.ID_CODIGO_QR != null && valueObject.ID_CODIGO_QR != 0) {
			if (first) { first = false; }
			sql += "AND ID_CODIGO_QR= " + valueObject.ID_CODIGO_QR + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.IDENTIFICACION)) {
			if (first) { first = false; }
			sql += "AND IDENTIFICACION= '" + valueObject.IDENTIFICACION + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOMBRES)) {
			if (first) { first = false; }
			sql += "AND NOMBRES= '" + valueObject.NOMBRES + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.APELLIDOS)) {
			if (first) { first = false; }
			sql += "AND APELLIDOS= '" + valueObject.APELLIDOS + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.CORREO)) {
			if (first) { first = false; }
			sql += "AND CORREO= '" + valueObject.CORREO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.DIRECCION_CLIENTE)) {
			if (first) { first = false; }
			sql += "AND DIRECCION_CLIENTE= '" + valueObject.DIRECCION_CLIENTE + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.TELEFONO)) {
			if (first) { first = false; }
			sql += "AND TELEFONO= '" + valueObject.TELEFONO + "' ";
		}

		if (valueObject.FECHA_NACIMIENTO != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_NACIMIENTO= '" + valueObject.FECHA_NACIMIENTO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.SEXO)) {
			if (first) { first = false; }
			sql += "AND SEXO= '" + valueObject.SEXO + "' ";
		}

		sql += "ORDER BY ID_CLIENTE ASC ";

		if (first)
			searchResults = new List<Cliente>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Cliente> searchMatching(SqlConnection conn, Cliente valueObject, int limiteInf, int limiteSup) {
		List<Cliente> searchResults = new List<Cliente>();
		bool first = true;
		String sql = "SELECT * FROM CLIENTE WHERE 1=1 ";
		if (valueObject.ID_CLIENTE != null && valueObject.ID_CLIENTE != 0) {
			if (first) { first = false; }
			sql += "AND ID_CLIENTE= " + valueObject.ID_CLIENTE + " ";
		}

		if (valueObject.ID_EMPRESA != null && valueObject.ID_EMPRESA != 0) {
			if (first) { first = false; }
			sql += "AND ID_EMPRESA= " + valueObject.ID_EMPRESA + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (valueObject.ID_TIPO_IDENTIFICACION != null && valueObject.ID_TIPO_IDENTIFICACION != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_IDENTIFICACION= " + valueObject.ID_TIPO_IDENTIFICACION + " ";
		}

		if (valueObject.ID_CODIGO_QR != null && valueObject.ID_CODIGO_QR != 0) {
			if (first) { first = false; }
			sql += "AND ID_CODIGO_QR= " + valueObject.ID_CODIGO_QR + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.IDENTIFICACION)) {
			if (first) { first = false; }
			sql += "AND IDENTIFICACION= '" + valueObject.IDENTIFICACION + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOMBRES)) {
			if (first) { first = false; }
			sql += "AND NOMBRES= '" + valueObject.NOMBRES + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.APELLIDOS)) {
			if (first) { first = false; }
			sql += "AND APELLIDOS= '" + valueObject.APELLIDOS + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.CORREO)) {
			if (first) { first = false; }
			sql += "AND CORREO= '" + valueObject.CORREO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.DIRECCION_CLIENTE)) {
			if (first) { first = false; }
			sql += "AND DIRECCION_CLIENTE= '" + valueObject.DIRECCION_CLIENTE + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.TELEFONO)) {
			if (first) { first = false; }
			sql += "AND TELEFONO= '" + valueObject.TELEFONO + "' ";
		}

		if (valueObject.FECHA_NACIMIENTO != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_NACIMIENTO= '" + valueObject.FECHA_NACIMIENTO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.SEXO)) {
			if (first) { first = false; }
			sql += "AND SEXO= '" + valueObject.SEXO + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Cliente>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Cliente valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM CLIENTE WHERE 1=1 ";
		if (valueObject.ID_CLIENTE != null && valueObject.ID_CLIENTE != 0) {
			if (first) { first = false; }
			sql += "AND ID_CLIENTE= " + valueObject.ID_CLIENTE + " ";
		}

		if (valueObject.ID_EMPRESA != null && valueObject.ID_EMPRESA != 0) {
			if (first) { first = false; }
			sql += "AND ID_EMPRESA= " + valueObject.ID_EMPRESA + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (valueObject.ID_TIPO_IDENTIFICACION != null && valueObject.ID_TIPO_IDENTIFICACION != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_IDENTIFICACION= " + valueObject.ID_TIPO_IDENTIFICACION + " ";
		}

		if (valueObject.ID_CODIGO_QR != null && valueObject.ID_CODIGO_QR != 0) {
			if (first) { first = false; }
			sql += "AND ID_CODIGO_QR= " + valueObject.ID_CODIGO_QR + " ";
		}

		if (!String.IsNullOrEmpty(valueObject.IDENTIFICACION)) {
			if (first) { first = false; }
			sql += "AND IDENTIFICACION= '" + valueObject.IDENTIFICACION + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.NOMBRES)) {
			if (first) { first = false; }
			sql += "AND NOMBRES= '" + valueObject.NOMBRES + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.APELLIDOS)) {
			if (first) { first = false; }
			sql += "AND APELLIDOS= '" + valueObject.APELLIDOS + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.CORREO)) {
			if (first) { first = false; }
			sql += "AND CORREO= '" + valueObject.CORREO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.DIRECCION_CLIENTE)) {
			if (first) { first = false; }
			sql += "AND DIRECCION_CLIENTE= '" + valueObject.DIRECCION_CLIENTE + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.TELEFONO)) {
			if (first) { first = false; }
			sql += "AND TELEFONO= '" + valueObject.TELEFONO + "' ";
		}

		if (valueObject.FECHA_NACIMIENTO != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_NACIMIENTO= '" + valueObject.FECHA_NACIMIENTO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.SEXO)) {
			if (first) { first = false; }
			sql += "AND SEXO= '" + valueObject.SEXO + "' ";
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


	private List<Cliente> listQuery(SqlCommand stmt) {

		List<Cliente> searchResults = new List<Cliente>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Cliente temp = createValueObject();

				temp.ID_CLIENTE= reader["ID_CLIENTE"] != null && long.TryParse(reader["ID_CLIENTE"].ToString(),out longg) ? longg : 0;
				temp.ID_EMPRESA= reader["ID_EMPRESA"] != null && long.TryParse(reader["ID_EMPRESA"].ToString(),out longg) ? longg : 0;
				temp.ID_IMAGEN= reader["ID_IMAGEN"] != null && long.TryParse(reader["ID_IMAGEN"].ToString(),out longg) ? longg : 0;
				temp.ID_TIPO_IDENTIFICACION= reader["ID_TIPO_IDENTIFICACION"] != null && long.TryParse(reader["ID_TIPO_IDENTIFICACION"].ToString(),out longg) ? longg : 0;
				temp.ID_CODIGO_QR= reader["ID_CODIGO_QR"] != null && long.TryParse(reader["ID_CODIGO_QR"].ToString(),out longg) ? longg : 0;
				temp.IDENTIFICACION= reader["IDENTIFICACION"] != null ? reader["IDENTIFICACION"].ToString() : null;
				temp.NOMBRES= reader["NOMBRES"] != null ? reader["NOMBRES"].ToString() : null;
				temp.APELLIDOS= reader["APELLIDOS"] != null ? reader["APELLIDOS"].ToString() : null;
				temp.CORREO= reader["CORREO"] != null ? reader["CORREO"].ToString() : null;
				temp.DIRECCION_CLIENTE= reader["DIRECCION_CLIENTE"] != null ? reader["DIRECCION_CLIENTE"].ToString() : null;
				temp.TELEFONO= reader["TELEFONO"] != null ? reader["TELEFONO"].ToString() : null;
				temp.FECHA_NACIMIENTO=  reader["FECHA_NACIMIENTO"] != null && !String.IsNullOrEmpty(reader["FECHA_NACIMIENTO"].ToString()) ? (DateTime)reader["FECHA_NACIMIENTO"] : DateTime.MinValue;
				temp.SEXO= reader["SEXO"] != null ? reader["SEXO"].ToString() : null;
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
