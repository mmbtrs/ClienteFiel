using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;

using ServiciosWebClienteFiel.objetos;

namespace ServiciosWebClienteFiel.dao{

partial class UsuarioDao {


	public Usuario createValueObject() {
		return new Usuario();
	}

	public List<Usuario> loadAll(SqlConnection conn) {
		String sql = "SELECT * FROM USUARIO ORDER BY ID_USUARIO ASC ";
		List<Usuario> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public List<Usuario> loadAll(SqlConnection conn, int limiteInf, int limiteSup) {
		String sql = "SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY ID_USUARIO) AS RowNumber FROM USUARIO) AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;
		List<Usuario> searchResults = listQuery(new SqlCommand(sql, conn));
		return searchResults;
	}


	public void create(SqlConnection conn, Usuario valueObject) {
		String sql = "";
		SqlCommand stmt = null;
		try {
			sql = "INSERT INTO USUARIO ( ID_USUARIO,"+
			" ID_TIPO_IDENTIFICACION, ID_EMPRESA, ID_IMAGEN,"+
			" ID_ROL, IDENTIFICACION, NOMBRES,"+
			" APELLIDOS, CORREO, DIRECCION,"+
			" TELEFONO, LOGIN, PASSWORD,"+
			" FECHA_NACIMIENTO, SEXO, ESTADO,"+
			" FECHA_INGRESO, FECHA_RETIRO)"+
			 "VALUES ( @ID_USUARIO, @ID_TIPO_IDENTIFICACION, @ID_EMPRESA, @ID_IMAGEN, @ID_ROL, @IDENTIFICACION, @NOMBRES, @APELLIDOS, @CORREO, @DIRECCION, @TELEFONO, @LOGIN, @PASSWORD, @FECHA_NACIMIENTO, @SEXO, @ESTADO, @FECHA_INGRESO, @FECHA_RETIRO)";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_USUARIO", valueObject.ID_USUARIO);
				if(valueObject.ID_TIPO_IDENTIFICACION!=0)
					stmt.Parameters.AddWithValue("@ID_TIPO_IDENTIFICACION", valueObject.ID_TIPO_IDENTIFICACION);
				else
					stmt.Parameters.AddWithValue("@ID_TIPO_IDENTIFICACION", DBNull.Value);
				if(valueObject.ID_EMPRESA!=0)
					stmt.Parameters.AddWithValue("@ID_EMPRESA", valueObject.ID_EMPRESA);
				else
					stmt.Parameters.AddWithValue("@ID_EMPRESA", DBNull.Value);
				if(valueObject.ID_IMAGEN!=0)
					stmt.Parameters.AddWithValue("@ID_IMAGEN", valueObject.ID_IMAGEN);
				else
					stmt.Parameters.AddWithValue("@ID_IMAGEN", DBNull.Value);
				if(valueObject.ID_ROL!=0)
					stmt.Parameters.AddWithValue("@ID_ROL", valueObject.ID_ROL);
				else
					stmt.Parameters.AddWithValue("@ID_ROL", DBNull.Value);
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
				if(valueObject.DIRECCION!=null &&valueObject.DIRECCION.Length <= 300)
					stmt.Parameters.AddWithValue("@DIRECCION", valueObject.DIRECCION);
				else
					stmt.Parameters.AddWithValue("@DIRECCION", DBNull.Value);
				if(valueObject.TELEFONO!=null &&valueObject.TELEFONO.Length <= 100)
					stmt.Parameters.AddWithValue("@TELEFONO", valueObject.TELEFONO);
				else
					stmt.Parameters.AddWithValue("@TELEFONO", DBNull.Value);
				if(valueObject.LOGIN!=null &&valueObject.LOGIN.Length <= 500)
					stmt.Parameters.AddWithValue("@LOGIN", valueObject.LOGIN);
				else
					stmt.Parameters.AddWithValue("@LOGIN", DBNull.Value);
				if(valueObject.PASSWORD!=null &&valueObject.PASSWORD.Length <= 100)
					stmt.Parameters.AddWithValue("@PASSWORD", valueObject.PASSWORD);
				else
					stmt.Parameters.AddWithValue("@PASSWORD", DBNull.Value);
				if(valueObject.FECHA_NACIMIENTO != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_NACIMIENTO", valueObject.FECHA_NACIMIENTO);
				else
					stmt.Parameters.AddWithValue("@FECHA_NACIMIENTO", DBNull.Value);
				if(valueObject.SEXO!=null &&valueObject.SEXO.Length <= 1)
					stmt.Parameters.AddWithValue("@SEXO", valueObject.SEXO);
				else
					stmt.Parameters.AddWithValue("@SEXO", DBNull.Value);
				if(valueObject.ESTADO!=null &&valueObject.ESTADO.Length <= 1)
					stmt.Parameters.AddWithValue("@ESTADO", valueObject.ESTADO);
				else
					stmt.Parameters.AddWithValue("@ESTADO", DBNull.Value);
				if(valueObject.FECHA_INGRESO != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_INGRESO", valueObject.FECHA_INGRESO);
				else
					stmt.Parameters.AddWithValue("@FECHA_INGRESO", DBNull.Value);
				if(valueObject.FECHA_RETIRO != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_RETIRO", valueObject.FECHA_RETIRO);
				else
					stmt.Parameters.AddWithValue("@FECHA_RETIRO", DBNull.Value);



				databaseUpdate(stmt);
			} finally {
				if (stmt != null)
					stmt.Dispose();
			}
	}


	public void save(SqlConnection conn, Usuario valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "UPDATE USUARIO SET  ID_TIPO_IDENTIFICACION = @ID_TIPO_IDENTIFICACION , ID_EMPRESA = @ID_EMPRESA , ID_IMAGEN = @ID_IMAGEN ,"+
			" ID_ROL = @ID_ROL , IDENTIFICACION = @IDENTIFICACION , NOMBRES = @NOMBRES ,"+
			" APELLIDOS = @APELLIDOS , CORREO = @CORREO , DIRECCION = @DIRECCION ,"+
			" TELEFONO = @TELEFONO , LOGIN = @LOGIN , PASSWORD = @PASSWORD ,"+
			" FECHA_NACIMIENTO = @FECHA_NACIMIENTO , SEXO = @SEXO , ESTADO = @ESTADO ,"+
			" FECHA_INGRESO = @FECHA_INGRESO , FECHA_RETIRO = @FECHA_RETIRO  WHERE (ID_USUARIO= @ID_USUARIO)";
			stmt = new SqlCommand(sql, conn);
				if(valueObject.ID_TIPO_IDENTIFICACION!=0)
					stmt.Parameters.AddWithValue("@ID_TIPO_IDENTIFICACION", valueObject.ID_TIPO_IDENTIFICACION);
				else
					stmt.Parameters.AddWithValue("@ID_TIPO_IDENTIFICACION", DBNull.Value);
				if(valueObject.ID_EMPRESA!=0)
					stmt.Parameters.AddWithValue("@ID_EMPRESA", valueObject.ID_EMPRESA);
				else
					stmt.Parameters.AddWithValue("@ID_EMPRESA", DBNull.Value);
				if(valueObject.ID_IMAGEN!=0)
					stmt.Parameters.AddWithValue("@ID_IMAGEN", valueObject.ID_IMAGEN);
				else
					stmt.Parameters.AddWithValue("@ID_IMAGEN", DBNull.Value);
				if(valueObject.ID_ROL!=0)
					stmt.Parameters.AddWithValue("@ID_ROL", valueObject.ID_ROL);
				else
					stmt.Parameters.AddWithValue("@ID_ROL", DBNull.Value);
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
				if(valueObject.DIRECCION!=null &&valueObject.DIRECCION.Length <= 300)
					stmt.Parameters.AddWithValue("@DIRECCION", valueObject.DIRECCION);
				else
					stmt.Parameters.AddWithValue("@DIRECCION", DBNull.Value);
				if(valueObject.TELEFONO!=null &&valueObject.TELEFONO.Length <= 100)
					stmt.Parameters.AddWithValue("@TELEFONO", valueObject.TELEFONO);
				else
					stmt.Parameters.AddWithValue("@TELEFONO", DBNull.Value);
				if(valueObject.LOGIN!=null &&valueObject.LOGIN.Length <= 500)
					stmt.Parameters.AddWithValue("@LOGIN", valueObject.LOGIN);
				else
					stmt.Parameters.AddWithValue("@LOGIN", DBNull.Value);
				if(valueObject.PASSWORD!=null &&valueObject.PASSWORD.Length <= 100)
					stmt.Parameters.AddWithValue("@PASSWORD", valueObject.PASSWORD);
				else
					stmt.Parameters.AddWithValue("@PASSWORD", DBNull.Value);
				if(valueObject.FECHA_NACIMIENTO != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_NACIMIENTO", valueObject.FECHA_NACIMIENTO);
				else
					stmt.Parameters.AddWithValue("@FECHA_NACIMIENTO", DBNull.Value);
				if(valueObject.SEXO!=null &&valueObject.SEXO.Length <= 1)
					stmt.Parameters.AddWithValue("@SEXO", valueObject.SEXO);
				else
					stmt.Parameters.AddWithValue("@SEXO", DBNull.Value);
				if(valueObject.ESTADO!=null &&valueObject.ESTADO.Length <= 1)
					stmt.Parameters.AddWithValue("@ESTADO", valueObject.ESTADO);
				else
					stmt.Parameters.AddWithValue("@ESTADO", DBNull.Value);
				if(valueObject.FECHA_INGRESO != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_INGRESO", valueObject.FECHA_INGRESO);
				else
					stmt.Parameters.AddWithValue("@FECHA_INGRESO", DBNull.Value);
				if(valueObject.FECHA_RETIRO != DateTime.MinValue)
					stmt.Parameters.AddWithValue("@FECHA_RETIRO", valueObject.FECHA_RETIRO);
				else
					stmt.Parameters.AddWithValue("@FECHA_RETIRO", DBNull.Value);
				stmt.Parameters.AddWithValue("@ID_USUARIO", valueObject.ID_USUARIO);

				int rowcount = databaseUpdate(stmt);
				if (rowcount == 0) {
					throw new Exception("Object could not be saved! (PrimaryKey not found)");
				}
			} finally {
				if (stmt != null)
					stmt.Dispose();
		}
	}


	public void delete(SqlConnection conn, Usuario valueObject) {
		SqlCommand stmt = null;
		String sql = "";
		try {
			sql = "DELETE FROM USUARIO WHERE (ID_USUARIO = @ID_USUARIO )";
			stmt = new SqlCommand(sql, conn);
			stmt.Parameters.AddWithValue("@ID_USUARIO", valueObject.ID_USUARIO);

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
		String sql = "SELECT count(*) FROM USUARIO";
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
	public List<Usuario> searchMatching(SqlConnection conn, Usuario valueObject) {
		List<Usuario> searchResults = new List<Usuario>();
		bool first = true;
		String sql = "SELECT * FROM USUARIO WHERE 1=1 ";
		if (valueObject.ID_USUARIO != null && valueObject.ID_USUARIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_USUARIO= " + valueObject.ID_USUARIO + " ";
		}

		if (valueObject.ID_TIPO_IDENTIFICACION != null && valueObject.ID_TIPO_IDENTIFICACION != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_IDENTIFICACION= " + valueObject.ID_TIPO_IDENTIFICACION + " ";
		}

		if (valueObject.ID_EMPRESA != null && valueObject.ID_EMPRESA != 0) {
			if (first) { first = false; }
			sql += "AND ID_EMPRESA= " + valueObject.ID_EMPRESA + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (valueObject.ID_ROL != null && valueObject.ID_ROL != 0) {
			if (first) { first = false; }
			sql += "AND ID_ROL= " + valueObject.ID_ROL + " ";
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

		if (!String.IsNullOrEmpty(valueObject.DIRECCION)) {
			if (first) { first = false; }
			sql += "AND DIRECCION= '" + valueObject.DIRECCION + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.TELEFONO)) {
			if (first) { first = false; }
			sql += "AND TELEFONO= '" + valueObject.TELEFONO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.LOGIN)) {
			if (first) { first = false; }
			sql += "AND LOGIN= '" + valueObject.LOGIN + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.PASSWORD)) {
			if (first) { first = false; }
			sql += "AND PASSWORD= '" + valueObject.PASSWORD + "' ";
		}

		if (valueObject.FECHA_NACIMIENTO != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_NACIMIENTO= '" + valueObject.FECHA_NACIMIENTO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.SEXO)) {
			if (first) { first = false; }
			sql += "AND SEXO= '" + valueObject.SEXO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.ESTADO)) {
			if (first) { first = false; }
			sql += "AND ESTADO= '" + valueObject.ESTADO + "' ";
		}

		if (valueObject.FECHA_INGRESO != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_INGRESO= '" + valueObject.FECHA_INGRESO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (valueObject.FECHA_RETIRO != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_RETIRO= '" + valueObject.FECHA_RETIRO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		sql += "ORDER BY ID_USUARIO ASC ";

		if (first)
			searchResults = new List<Usuario>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public List<Usuario> searchMatching(SqlConnection conn, Usuario valueObject, int limiteInf, int limiteSup) {
		List<Usuario> searchResults = new List<Usuario>();
		bool first = true;
		String sql = "SELECT * FROM USUARIO WHERE 1=1 ";
		if (valueObject.ID_USUARIO != null && valueObject.ID_USUARIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_USUARIO= " + valueObject.ID_USUARIO + " ";
		}

		if (valueObject.ID_TIPO_IDENTIFICACION != null && valueObject.ID_TIPO_IDENTIFICACION != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_IDENTIFICACION= " + valueObject.ID_TIPO_IDENTIFICACION + " ";
		}

		if (valueObject.ID_EMPRESA != null && valueObject.ID_EMPRESA != 0) {
			if (first) { first = false; }
			sql += "AND ID_EMPRESA= " + valueObject.ID_EMPRESA + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (valueObject.ID_ROL != null && valueObject.ID_ROL != 0) {
			if (first) { first = false; }
			sql += "AND ID_ROL= " + valueObject.ID_ROL + " ";
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

		if (!String.IsNullOrEmpty(valueObject.DIRECCION)) {
			if (first) { first = false; }
			sql += "AND DIRECCION= '" + valueObject.DIRECCION + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.TELEFONO)) {
			if (first) { first = false; }
			sql += "AND TELEFONO= '" + valueObject.TELEFONO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.LOGIN)) {
			if (first) { first = false; }
			sql += "AND LOGIN= '" + valueObject.LOGIN + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.PASSWORD)) {
			if (first) { first = false; }
			sql += "AND PASSWORD= '" + valueObject.PASSWORD + "' ";
		}

		if (valueObject.FECHA_NACIMIENTO != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_NACIMIENTO= '" + valueObject.FECHA_NACIMIENTO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.SEXO)) {
			if (first) { first = false; }
			sql += "AND SEXO= '" + valueObject.SEXO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.ESTADO)) {
			if (first) { first = false; }
			sql += "AND ESTADO= '" + valueObject.ESTADO + "' ";
		}

		if (valueObject.FECHA_INGRESO != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_INGRESO= '" + valueObject.FECHA_INGRESO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (valueObject.FECHA_RETIRO != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_RETIRO= '" + valueObject.FECHA_RETIRO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		sql += ") AS CONSULTA WHERE RowNumber >="+ limiteInf +" AND RowNumber <="+ limiteSup;

		if (first)
			searchResults = new List<Usuario>();
		else
			searchResults = listQuery(new SqlCommand(sql,conn));

		return searchResults;
	}


	public int countSearchMatching(SqlConnection conn, Usuario valueObject) {
		bool first = true;
		String sql = "SELECT COUNT(*) FROM USUARIO WHERE 1=1 ";
		if (valueObject.ID_USUARIO != null && valueObject.ID_USUARIO != 0) {
			if (first) { first = false; }
			sql += "AND ID_USUARIO= " + valueObject.ID_USUARIO + " ";
		}

		if (valueObject.ID_TIPO_IDENTIFICACION != null && valueObject.ID_TIPO_IDENTIFICACION != 0) {
			if (first) { first = false; }
			sql += "AND ID_TIPO_IDENTIFICACION= " + valueObject.ID_TIPO_IDENTIFICACION + " ";
		}

		if (valueObject.ID_EMPRESA != null && valueObject.ID_EMPRESA != 0) {
			if (first) { first = false; }
			sql += "AND ID_EMPRESA= " + valueObject.ID_EMPRESA + " ";
		}

		if (valueObject.ID_IMAGEN != null && valueObject.ID_IMAGEN != 0) {
			if (first) { first = false; }
			sql += "AND ID_IMAGEN= " + valueObject.ID_IMAGEN + " ";
		}

		if (valueObject.ID_ROL != null && valueObject.ID_ROL != 0) {
			if (first) { first = false; }
			sql += "AND ID_ROL= " + valueObject.ID_ROL + " ";
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

		if (!String.IsNullOrEmpty(valueObject.DIRECCION)) {
			if (first) { first = false; }
			sql += "AND DIRECCION= '" + valueObject.DIRECCION + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.TELEFONO)) {
			if (first) { first = false; }
			sql += "AND TELEFONO= '" + valueObject.TELEFONO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.LOGIN)) {
			if (first) { first = false; }
			sql += "AND LOGIN= '" + valueObject.LOGIN + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.PASSWORD)) {
			if (first) { first = false; }
			sql += "AND PASSWORD= '" + valueObject.PASSWORD + "' ";
		}

		if (valueObject.FECHA_NACIMIENTO != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_NACIMIENTO= '" + valueObject.FECHA_NACIMIENTO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.SEXO)) {
			if (first) { first = false; }
			sql += "AND SEXO= '" + valueObject.SEXO + "' ";
		}

		if (!String.IsNullOrEmpty(valueObject.ESTADO)) {
			if (first) { first = false; }
			sql += "AND ESTADO= '" + valueObject.ESTADO + "' ";
		}

		if (valueObject.FECHA_INGRESO != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_INGRESO= '" + valueObject.FECHA_INGRESO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
		}

		if (valueObject.FECHA_RETIRO != DateTime.MinValue) {
			if (first) { first = false; }
			sql += "AND FECHA_RETIRO= '" + valueObject.FECHA_RETIRO.ToString("dd/MM/yyyy HH:mm:ss") + "' ";
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


	private List<Usuario> listQuery(SqlCommand stmt) {

		List<Usuario> searchResults = new List<Usuario>();
		SqlDataReader reader = null;
		try {
		int intt = 0; long longg = 0; double doublee = 0;DateTime datee;
			reader = stmt.ExecuteReader();
			while (reader.Read()) {
				Usuario temp = createValueObject();

				temp.ID_USUARIO= reader["ID_USUARIO"] != null && long.TryParse(reader["ID_USUARIO"].ToString(),out longg) ? longg : 0;
				temp.ID_TIPO_IDENTIFICACION= reader["ID_TIPO_IDENTIFICACION"] != null && long.TryParse(reader["ID_TIPO_IDENTIFICACION"].ToString(),out longg) ? longg : 0;
				temp.ID_EMPRESA= reader["ID_EMPRESA"] != null && long.TryParse(reader["ID_EMPRESA"].ToString(),out longg) ? longg : 0;
				temp.ID_IMAGEN= reader["ID_IMAGEN"] != null && long.TryParse(reader["ID_IMAGEN"].ToString(),out longg) ? longg : 0;
				temp.ID_ROL= reader["ID_ROL"] != null && long.TryParse(reader["ID_ROL"].ToString(),out longg) ? longg : 0;
				temp.IDENTIFICACION= reader["IDENTIFICACION"] != null ? reader["IDENTIFICACION"].ToString() : null;
				temp.NOMBRES= reader["NOMBRES"] != null ? reader["NOMBRES"].ToString() : null;
				temp.APELLIDOS= reader["APELLIDOS"] != null ? reader["APELLIDOS"].ToString() : null;
				temp.CORREO= reader["CORREO"] != null ? reader["CORREO"].ToString() : null;
				temp.DIRECCION= reader["DIRECCION"] != null ? reader["DIRECCION"].ToString() : null;
				temp.TELEFONO= reader["TELEFONO"] != null ? reader["TELEFONO"].ToString() : null;
				temp.LOGIN= reader["LOGIN"] != null ? reader["LOGIN"].ToString() : null;
				temp.PASSWORD= reader["PASSWORD"] != null ? reader["PASSWORD"].ToString() : null;
				temp.FECHA_NACIMIENTO=  reader["FECHA_NACIMIENTO"] != null && !String.IsNullOrEmpty(reader["FECHA_NACIMIENTO"].ToString()) ? (DateTime)reader["FECHA_NACIMIENTO"] : DateTime.MinValue;
				temp.SEXO= reader["SEXO"] != null ? reader["SEXO"].ToString() : null;
				temp.ESTADO= reader["ESTADO"] != null ? reader["ESTADO"].ToString() : null;
				temp.FECHA_INGRESO=  reader["FECHA_INGRESO"] != null && !String.IsNullOrEmpty(reader["FECHA_INGRESO"].ToString()) ? (DateTime)reader["FECHA_INGRESO"] : DateTime.MinValue;
				temp.FECHA_RETIRO=  reader["FECHA_RETIRO"] != null && !String.IsNullOrEmpty(reader["FECHA_RETIRO"].ToString()) ? (DateTime)reader["FECHA_RETIRO"] : DateTime.MinValue;
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
