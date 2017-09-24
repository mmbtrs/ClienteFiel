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
using static ClienteFiel.utilidades.utilidades;

namespace ClienteFiel.modulos.accesorias
{
    public partial class SetTipoIdentificacion : Form
    {
        ServiciosTipoidentificacion serviciosTipoidentificacion;
        tipoOperacion operacion;

        Tipoidentificacion tipoidentificacion;

        public SetTipoIdentificacion(tipoOperacion tmpOperacion, Tipoidentificacion tmpTipoIdent)
        {
            InitializeComponent();
            inicializarServicios();
            operacion = tmpOperacion;
            tipoidentificacion = tmpTipoIdent;
            configuracionInicial();
            fijarSize(this);
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
                utilidades.Mensajes.mensajeError(exp.Message);
            }
        }

        private void configuracionInicial()
        {
            try
            {
                if (operacion == tipoOperacion.Insertar)
                {
                    this.Text = "Crear Nuevo Tipo de Identificación";
                    lblTituloVentana.Text = "Nuevo Tipo de Identificación";
                }
                else
                {
                    this.Text = "Editar Tipo de Identificación";
                    lblTituloVentana.Text = "Edición Tipo de Identificación";
                    txtNombreTipoIdentificacion.Text = tipoidentificacion.NOM_TIPO_IDENTIFICACION;
                }
            }
            catch (Exception exp)
            {
                utilidades.Mensajes.mensajeError(exp.Message);
            }
        }

        private void editar()
        {
            TipoidentificacionResponse objResponse;
            try
            {
                Tipoidentificacion obj;
                obj = new Tipoidentificacion();
                
                if (!String.IsNullOrEmpty(txtNombreTipoIdentificacion.Text) && !String.IsNullOrWhiteSpace(txtNombreTipoIdentificacion.Text))
                    obj.NOM_TIPO_IDENTIFICACION = txtNombreTipoIdentificacion.Text;
                obj.ID_TIPO_IDENTIFICACION = tipoidentificacion.ID_TIPO_IDENTIFICACION;
                objResponse = serviciosTipoidentificacion.editarTipoidentificacion(obj);
                if (objResponse != null && objResponse.correcto)
                {
                    utilidades.Mensajes.mensajeCorrecto("La información del Tipo de Identificación se modificó correctamente");
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

        private void guardar()
        {
            try
            {
                TipoidentificacionResponse objResponse;
                Tipoidentificacion obj = new Tipoidentificacion();
                if (!String.IsNullOrEmpty(txtNombreTipoIdentificacion.Text) && !String.IsNullOrWhiteSpace(txtNombreTipoIdentificacion.Text))
                    obj.NOM_TIPO_IDENTIFICACION = txtNombreTipoIdentificacion.Text;
                objResponse = serviciosTipoidentificacion.crearTipoidentificacion(obj);
                if (objResponse != null && objResponse.correcto)
                {
                    utilidades.Mensajes.mensajeCorrecto("Se creo correctamente el Tipo de Identificación " + obj.NOM_TIPO_IDENTIFICACION);
                    txtNombreTipoIdentificacion.Clear();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
