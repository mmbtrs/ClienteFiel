using ClienteFiel.modulos.errores;
using ClienteFiel.WS_ServiciosError;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilidadesServiciosWeb;

namespace ClienteFiel.utilidades
{
    public static class Mensajes
    {
        static bool registrarErrores = false;
        static ServiciosError serviciosError;

        public static void errorWebServices(String error)
        {
            //serviciosError = (ServiciosError)Configurador.ConfigurarServicio(typeof(ServiciosError));
            //serviciosError.AutenticacionValue = new Autenticacion() { usuario = "U", contrasena = "1" };
            //Error tmpError = new Error();
            ////error = error.Replace(char.Parse("'"), '_');
            //tmpError.ERROR = error;
            //tmpError = serviciosError.buscarPrimeroError(tmpError);
            //if (tmpError != null && tmpError.ID_ERROR > 0)
            //    MessageBox.Show(tmpError.MENSAJE_PARA_USUARIO + " " + tmpError.POSIBLE_SOLUCION, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //else
            //{
            //    getRegistrarErrores();
            //    if (registrarErrores)
            //    {
            //        if (MessageBox.Show(error + ". ¿Desea registrar el error?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            //        {
            //            tmpError = new Error();
            //            tmpError.ERROR = error;
            //            setErrores setE = new setErrores(tipoOperacion.Insertar, tmpError);
            //            setE.ShowDialog();
            //        }
            //    }
            //    else
            //        MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            if (error.Contains("No se puede insertar una clave duplicada en el objeto"))
            {
                String[] tmp1 = error.Split('(');
                String[] tmp2 = tmp1[1].Split(')');
                MessageBox.Show("Ya existe un registro con el valor " + tmp2[0], "Valor duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (error.Contains("No se puede insertar el valor NULL en la columna"))
                {
                    MessageBox.Show("Existen campos requeridos, que estan vacios, por favor llenelos", "Valor requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (error.Contains("Instrucción DELETE en conflicto con la restricción REFERENCE"))
                    {
                        MessageBox.Show("Eliminación fallida, el elemento no se puede eliminar ya que está referenciado por un registro de otra tabla", "Valor referenciado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Error desconocido: " + error, "Error Desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public static void mensajeError(String error)
        {
            MessageBox.Show("Se presentó el siguiente error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void mensajeCorrecto(String mensaje)
        {
            MessageBox.Show(mensaje, "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void getRegistrarErrores()
        {
            try
            {
                String path = Directory.GetCurrentDirectory();
                StreamReader file = new StreamReader(path + "\\configure.ini");
                String line;
                while ((line = file.ReadLine()) != null)
                {
                    if (!line[0].Equals(";"))
                    {
                        String[] CampoValor = line.Split('=');
                        if (CampoValor[0].Trim().ToUpper().Equals("REGISTRARERRORES"))
                            bool.TryParse(CampoValor[1], out registrarErrores);
                    }
                }
                file.Close();
            }
            catch (Exception exp)
            {
                mensajeError(exp.Message);
            }
        }
    }
}
