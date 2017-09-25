using ClienteFiel.WS_ServiciosDepartamento;
using ClienteFiel.WS_ServiciosMunicipio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilidadesServiciosWeb;

namespace ClienteFiel.modulos.accesorias
{
    public partial class setMunicipio : Form
    {
        ServiciosMunicipio serviciosMunicipio;
        Controles.utilidades.tipoOperacion operacion;
        Municipio municipio;
        Departamento departamento;

        public setMunicipio(Controles.utilidades.tipoOperacion tmpOperacion, Municipio tmpMunicipio, Departamento tmpDpto)
        {
            InitializeComponent();
            inicializarServicios();
            municipio = tmpMunicipio;
            operacion = tmpOperacion;
            departamento = tmpDpto;
            configuracionInicial();
            Controles.utilidades.fijarSize(this);
        }

        private void configuracionInicial()
        {
            try
            {
                if (operacion == Controles.utilidades.tipoOperacion.Insertar)
                {
                    this.Text = "Crear Nuevo Municipio";
                    lblTituloVentana.Text = "Nuevo Municipio";
                }
                else
                {
                    this.Text = "Editar Municipio";
                    lblTituloVentana.Text = "Edición Municipio";
                    txtMunicipio.Text = municipio.NOM_MUNICIPIO;
                }
                lblDepartamento.Text = departamento.NOM_DEPARTAMENTO;
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
                serviciosMunicipio = (ServiciosMunicipio)Configurador.ConfigurarServicio(typeof(ServiciosMunicipio));
                serviciosMunicipio.AutenticacionValue = new WS_ServiciosMunicipio.Autenticacion() { usuario = "U", contrasena = "1" };
            }
            catch (Exception exp)
            {
                utilidades.Mensajes.mensajeError(exp.Message);
            }
        }

        private void editar()
        {
            MunicipioResponse objResponse;
            try
            {
                Municipio obj;
                obj = new Municipio();

                if (!String.IsNullOrEmpty(txtMunicipio.Text) && !String.IsNullOrWhiteSpace(txtMunicipio.Text))
                    obj.NOM_MUNICIPIO = txtMunicipio.Text;
                obj.ID_DEPARTAMENTO = departamento.ID_DEPARTAMENTO;
                obj.ID_MUNICIPIO = municipio.ID_MUNICIPIO;
                objResponse = serviciosMunicipio.editarMunicipio(obj);
                if (objResponse != null && objResponse.correcto)
                {
                    utilidades.Mensajes.mensajeCorrecto("La información del Municipio se modificó correctamente");
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
                MunicipioResponse objResponse;
                Municipio obj = new Municipio();
                if (!String.IsNullOrEmpty(txtMunicipio.Text) && !String.IsNullOrWhiteSpace(txtMunicipio.Text))
                    obj.NOM_MUNICIPIO = txtMunicipio.Text;
                obj.ID_DEPARTAMENTO = departamento.ID_DEPARTAMENTO;
                objResponse = serviciosMunicipio.crearMunicipio(obj);
                if (objResponse != null && objResponse.correcto)
                {
                    utilidades.Mensajes.mensajeCorrecto("Se creo correctamente el Municipio " + obj.NOM_MUNICIPIO + " en el Departamento " + departamento.NOM_DEPARTAMENTO);
                    txtMunicipio.Clear();
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
            if (operacion == Controles.utilidades.tipoOperacion.Insertar)
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
