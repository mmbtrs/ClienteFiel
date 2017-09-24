using ClienteFiel.WS_ServiciosError;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilidadesServiciosWeb;
using static ClienteFiel.utilidades.utilidades;

namespace ClienteFiel.modulos.errores
{
    public partial class setErrores : Form
    {
        ServiciosError serviciosError;

        tipoOperacion operacion;
        Error error;

        public setErrores(tipoOperacion tmpTipoOperacion, Error tmpError)
        {
            InitializeComponent();
            inicializarServicios();
            operacion = tmpTipoOperacion;
            //tmpError.ERROR = tmpError.ERROR.Replace(char.Parse("'"), '_');//removerComilla(tmpError.ERROR);
            error = tmpError;
            configuracionInicial();
        }

        private void configuracionInicial()
        {
            try
            {
                if (operacion == tipoOperacion.Insertar)
                {
                    this.Text = "Crear Nuevo Tipo de Error";
                    lblTituloVentana.Text = "Nuevo Tipo de Error";
                    txtError.Text = error.ERROR;
                }
                else
                {
                    this.Text = "Editar Tipo de Error";
                    lblTituloVentana.Text = "Edición Tipo de Error";
                    txtError.Text = error.ERROR;
                    txtMensaje.Text = error.MENSAJE_PARA_USUARIO;
                    txtSolucion.Text = error.POSIBLE_SOLUCION;
                }
            }
            catch (Exception exp)
            {
                utilidades.Mensajes.mensajeError(exp.Message);
            }
        }
        private void inicializarServicios()
        {
            try
            {
                serviciosError = (ServiciosError)Configurador.ConfigurarServicio(typeof(ServiciosError));
                serviciosError.AutenticacionValue = new Autenticacion() { usuario = "U", contrasena = "1" };
            }
            catch (Exception exp)
            {
                utilidades.Mensajes.mensajeError(exp.Message);
            }
        }

        private void editar()
        {
            ErrorResponse objResponse;
            try
            {
                Error obj;
                obj = new Error();

                if (!String.IsNullOrEmpty(txtMensaje.Text) && !String.IsNullOrWhiteSpace(txtMensaje.Text))
                    obj.MENSAJE_PARA_USUARIO = txtMensaje.Text;
                if (!String.IsNullOrEmpty(txtSolucion.Text) && !String.IsNullOrWhiteSpace(txtSolucion.Text))
                    obj.POSIBLE_SOLUCION = txtSolucion.Text;
                obj.ERROR = error.ERROR;
                obj.ID_ERROR = error.ID_ERROR;
                objResponse = serviciosError.editarError(obj);

                if (objResponse != null && objResponse.correcto)
                {
                    utilidades.Mensajes.mensajeCorrecto("La información del Tipo de Error se modificó correctamente");
                    this.Close();
                }
                else
                {
                    if (objResponse != null)
                    {
                        utilidades.Mensajes.errorWebServices(objResponse.error);
                    }
                }
            }
            catch (Exception exp)
            {
                utilidades.Mensajes.mensajeError(exp.Message);
            }
        }

        private void guardar()
        {
            try
            {
                ErrorResponse objResponse;
                Error obj = new Error();
                if (!String.IsNullOrEmpty(txtMensaje.Text) && !String.IsNullOrWhiteSpace(txtMensaje.Text))
                    obj.MENSAJE_PARA_USUARIO = txtMensaje.Text;
                if (!String.IsNullOrEmpty(txtSolucion.Text) && !String.IsNullOrWhiteSpace(txtSolucion.Text))
                    obj.POSIBLE_SOLUCION = txtSolucion.Text;
                obj.ERROR = txtError.Text;
                objResponse = serviciosError.crearError(obj);
                if (objResponse != null && objResponse.correcto)
                {
                    utilidades.Mensajes.mensajeCorrecto("Se creo correctamente el Tipo de Error");
                    this.Close();
                }
                else
                {
                    if (objResponse != null)
                    {
                        utilidades.Mensajes.errorWebServices(objResponse.error);
                    }
                }
            }
            catch (Exception exp)
            {
                utilidades.Mensajes.mensajeError(exp.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (operacion == tipoOperacion.Insertar)
                guardar();
            else
                editar();
        }
    }
}
