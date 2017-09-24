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
using static ClienteFiel.utilidades.utilidades;

namespace ClienteFiel.modulos.accesorias
{
    public partial class SetTipoActividad : Form
    {
        ServiciosTipoactividad serviciosTipoactividad;

        tipoOperacion operacion;
        Tipoactividad tipoactividad;

        public SetTipoActividad(tipoOperacion tmpOperacion, Tipoactividad tmpTipoAct)
        {
            InitializeComponent();
            inicializarServicios();
            operacion = tmpOperacion;
            tipoactividad = tmpTipoAct;
            configuracionInicial();
            fijarSize(this);
        }

        private void inicializarServicios()
        {
            try
            {
                serviciosTipoactividad = (ServiciosTipoactividad)Configurador.ConfigurarServicio(typeof(ServiciosTipoactividad));
                serviciosTipoactividad.AutenticacionValue = new WS_ServiciosTipoactividad.Autenticacion() { usuario = "U", contrasena = "1" };
            }
            catch (Exception exp)
            {
                utilidades.Mensajes.mensajeError(exp.Message);
            }
        }

        private void configuracionInicial()
        {
            try
            {
                if (operacion == tipoOperacion.Insertar)
                {
                    this.Text = "Crear Nuevo Tipo de Actividad";
                    lblTituloVentana.Text = "Nuevo Tipo de Actividad";
                }
                else
                {
                    this.Text = "Editar Tipo de Actividad";
                    lblTituloVentana.Text = "Edición Tipo de Actividad";
                    txtNombreTipoActividad.Text = tipoactividad.NOM_TIPO_ACTIVIDAD;
                }
            }
            catch (Exception exp)
            {
                utilidades.Mensajes.mensajeError(exp.Message);
            }
        }

        private void editar()
        {
            TipoactividadResponse objResponse;
            try
            {
                Tipoactividad obj;
                obj = new Tipoactividad();

                if (!String.IsNullOrEmpty(txtNombreTipoActividad.Text) && !String.IsNullOrWhiteSpace(txtNombreTipoActividad.Text))
                    obj.NOM_TIPO_ACTIVIDAD = txtNombreTipoActividad.Text;
                obj.ID_TIPO_ACTIVIDAD = tipoactividad.ID_TIPO_ACTIVIDAD;
                objResponse = serviciosTipoactividad.editarTipoactividad(obj);
                if (objResponse != null && objResponse.correcto)
                {
                    utilidades.Mensajes.mensajeCorrecto("La información del Tipo de Actividad se modificó correctamente");
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
                TipoactividadResponse objResponse;
                Tipoactividad obj = new Tipoactividad();
                if (!String.IsNullOrEmpty(txtNombreTipoActividad.Text) && !String.IsNullOrWhiteSpace(txtNombreTipoActividad.Text))
                    obj.NOM_TIPO_ACTIVIDAD = txtNombreTipoActividad.Text;
                objResponse = serviciosTipoactividad.crearTipoactividad(obj);
                if (objResponse != null && objResponse.correcto)
                {
                    utilidades.Mensajes.mensajeCorrecto("Se creo correctamente el Tipo de Actividad " + obj.NOM_TIPO_ACTIVIDAD);
                    txtNombreTipoActividad.Clear();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
