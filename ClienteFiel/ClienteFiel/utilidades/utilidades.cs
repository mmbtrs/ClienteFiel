using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClienteFiel.utilidades
{
    public static class utilidades
    {
        public enum tipoOperacion { Insertar, Editar };
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

        public static void setFormatGrid(DataGridView grd)
        {
            grd.RowHeadersVisible = false;
            grd.RowsDefaultCellStyle.BackColor = Color.White;
            grd.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            grd.RowsDefaultCellStyle.SelectionBackColor = Color.DarkOrange;//CornflowerBlue;
            grd.EnableHeadersVisualStyles = false;
            grd.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            grd.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            grd.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        public static Image byteToImagen(byte[] byteImage)
        {
            MemoryStream ms = new MemoryStream(byteImage);
            return Image.FromStream(ms);
        }

        public static byte[] ImageToByte(PictureBox imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        public static byte[] ImageToByte(Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        public static void fijarSize(Form ventana)
        {
            ventana.MinimumSize = ventana.Size;
            ventana.MaximumSize = ventana.Size;
        }

        public static void lanzarTapConEnter(KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{tab}");
            }
        }

        public static void esNumero(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == '\b'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void esAlfanumerico(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar) || (e.KeyChar == '\b'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void esDecimal(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == '\b') || (e.KeyChar == ',') || (e.KeyChar == '.'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        public static void esLetra(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || (e.KeyChar == '\b'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
