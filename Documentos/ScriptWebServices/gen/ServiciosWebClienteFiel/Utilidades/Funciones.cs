using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Globalization;
using System.Net;
using System.IO;
using System.Net.Mail;
using System.Data;

namespace ServiciosWebClienteFiel
{
    public class Funciones
    {

        public static int obtenerId(SqlConnection conn, String nombretabla)
        {

            int result = 0;

            try
            {

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "spObtenerID";
                comando.Connection = conn;
                comando.CommandType = System.Data.CommandType.StoredProcedure;


                SqlParameter parametrotabla = new SqlParameter("@tabla", System.Data.SqlDbType.NChar);
                parametrotabla.Direction = System.Data.ParameterDirection.Input;
                parametrotabla.Value = nombretabla;

                SqlParameter parametrovalor = new SqlParameter("@valor", System.Data.SqlDbType.Int);
                parametrovalor.Direction = System.Data.ParameterDirection.Output;

                comando.Parameters.Add(parametrotabla);
                comando.Parameters.Add(parametrovalor);

                comando.ExecuteNonQuery();

                result = int.Parse(parametrovalor.Value.ToString());
            }
            catch
            {
                result = 0;
            }

            return result;


        }
		

    }
}
