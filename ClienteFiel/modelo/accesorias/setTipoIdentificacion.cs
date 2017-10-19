using ClienteFiel.modelo.forms_base;
using ClienteFiel.WS_ServiciosTipoidentificacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilidadesServiciosWeb;

namespace ClienteFiel.modelo.accesorias
{
    public partial class setTipoIdentificacion : frmBase
    {
        ServiciosTipoidentificacion serviciosTipoidentificacion;
        Controles.utilidades.tipoOperacion operacion;

        Tipoidentificacion tipoidentificacion;

        public setTipoIdentificacion(Controles.utilidades.tipoOperacion tmpOperacion, Tipoidentificacion tmpTipoIdent)
        {
            InitializeComponent();
            inicializarServicios();
            operacion = tmpOperacion;
            tipoidentificacion = tmpTipoIdent;
            configuracionInicial();
            Controles.utilidades.fijarSize(this);
        }

        private void inicializarServicios()
        {
            try
            {
                serviciosTipoidentificacion = (ServiciosTipoidentificacion)Configurador.ConfigurarServicio(typeof(ServiciosTipoidentificacion));
                serviciosTipoidentificacion.AutenticacionValue = new WS_ServiciosTipoidentificacion.Autenticacion() { usuario = "U", contrasena = "1" };
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }

        private void configuracionInicial()
        {
            try
            {
                if (operacion == Controles.utilidades.tipoOperacion.Insertar)
                {
                    this.Text = "Crear Nuevo Tipo de Identificación";
                    lblTituloVentana.Text = "Nuevo Tipo de Identificación";
                }
                else
                {
                    this.Text = "Editar Tipo de Identificación";
                    lblTituloVentana.Text = "Edición Tipo de Identificación";
                    txtTipoIdentificacion.Text = tipoidentificacion.NOM_TIPO_IDENTIFICACION;
                }
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }

        private void editar()
        {
            TipoidentificacionResponse objResponse;
            try
            {
                Tipoidentificacion obj;
                obj = new Tipoidentificacion();

                if (!String.IsNullOrEmpty(txtTipoIdentificacion.Text) && !String.IsNullOrWhiteSpace(txtTipoIdentificacion.Text))
                    obj.NOM_TIPO_IDENTIFICACION = txtTipoIdentificacion.Text.Trim();
                obj.ID_TIPO_IDENTIFICACION = tipoidentificacion.ID_TIPO_IDENTIFICACION;
                objResponse = serviciosTipoidentificacion.editarTipoidentificacion(obj);
                if (objResponse != null && objResponse.correcto)
                {
                    Controles.mensajes.mensajeCorrecto("La información del Tipo de Identificación se modificó correctamente");
                    this.Close();
                }
                else
                {
                    if (objResponse != null)
                    {
                        Controles.mensajes.errorWebServices(objResponse.error);
                    }
                }
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }

        private void guardar()
        {
            try
            {
                TipoidentificacionResponse objResponse;
                Tipoidentificacion obj = new Tipoidentificacion();
                if (!String.IsNullOrEmpty(txtTipoIdentificacion.Text) && !String.IsNullOrWhiteSpace(txtTipoIdentificacion.Text))
                    obj.NOM_TIPO_IDENTIFICACION = txtTipoIdentificacion.Text.Trim();
                objResponse = serviciosTipoidentificacion.crearTipoidentificacion(obj);
                if (objResponse != null && objResponse.correcto)
                {
                    Controles.mensajes.mensajeCorrecto("Se creo correctamente el Tipo de Identificación " + obj.NOM_TIPO_IDENTIFICACION);
                    txtTipoIdentificacion.Clear();
                }
                else
                {
                    if (objResponse != null)
                    {
                        Controles.mensajes.errorWebServices(objResponse.error);
                    }
                }
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (operacion == Controles.utilidades.tipoOperacion.Insertar)
                guardar();
            else
                editar();
        }
    }
}
