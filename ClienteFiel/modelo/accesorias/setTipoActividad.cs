using ClienteFiel.modelo.forms_base;
using ClienteFiel.WS_ServiciosTipoactividad;
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
    public partial class setTipoActividad : frmBase
    {
        ServiciosTipoactividad serviciosTipoactividad;

        Controles.utilidades.tipoOperacion operacion;
        Tipoactividad tipoactividad;

        public setTipoActividad(Controles.utilidades.tipoOperacion tmpOperacion, Tipoactividad tmpTipoAct)
        {
            InitializeComponent();
            inicializarServicios();
            operacion = tmpOperacion;
            tipoactividad = tmpTipoAct;
            configuracionInicial();
            Controles.utilidades.fijarSize(this);
        }

        private void inicializarServicios()
        {
            try
            {
                serviciosTipoactividad = (ServiciosTipoactividad)Configurador.ConfigurarServicio(typeof(ServiciosTipoactividad));
                serviciosTipoactividad.AutenticacionValue = new Autenticacion() { usuario = "U", contrasena = "1" };
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
                    this.Text = "Crear Nuevo Tipo de Actividad";
                    lblTituloVentana.Text = "Nuevo Tipo de Actividad";
                }
                else
                {
                    this.Text = "Editar Tipo de Actividad";
                    lblTituloVentana.Text = "Edición Tipo de Actividad";
                    txtTipoActividad.Text = tipoactividad.NOM_TIPO_ACTIVIDAD;
                }
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }

        private void editar()
        {
            TipoactividadResponse objResponse;
            try
            {
                Tipoactividad obj;
                obj = new Tipoactividad();

                if (!String.IsNullOrEmpty(txtTipoActividad.Text) && !String.IsNullOrWhiteSpace(txtTipoActividad.Text))
                    obj.NOM_TIPO_ACTIVIDAD = txtTipoActividad.Text.Trim();
                obj.ID_TIPO_ACTIVIDAD = tipoactividad.ID_TIPO_ACTIVIDAD;
                objResponse = serviciosTipoactividad.editarTipoactividad(obj);
                if (objResponse != null && objResponse.correcto)
                {
                    Controles.mensajes.mensajeCorrecto("La información del Tipo de Actividad se modificó correctamente");
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
                TipoactividadResponse objResponse;
                Tipoactividad obj = new Tipoactividad();
                if (!String.IsNullOrEmpty(txtTipoActividad.Text) && !String.IsNullOrWhiteSpace(txtTipoActividad.Text))
                    obj.NOM_TIPO_ACTIVIDAD = txtTipoActividad.Text.Trim();
                objResponse = serviciosTipoactividad.crearTipoactividad(obj);
                if (objResponse != null && objResponse.correcto)
                {
                    Controles.mensajes.mensajeCorrecto("Se creo correctamente el Tipo de Actividad " + obj.NOM_TIPO_ACTIVIDAD);
                    txtTipoActividad.Clear();
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
