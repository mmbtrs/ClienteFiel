using ClienteFiel.WS_ServiciosTipoproducto;
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
    public partial class SetTipoProducto : Form
    {
        ServiciosTipoproducto serviciosTipoproducto;

        tipoOperacion operacion;
        Tipoproducto tipoProducto;

        public SetTipoProducto(tipoOperacion tmpOperacion, Tipoproducto tmpTipProd)
        {
            InitializeComponent();
            inicializarServicios();
            operacion = tmpOperacion;
            tipoProducto = tmpTipProd;
            configuracionInicial();
            fijarSize(this);
        }

        private void inicializarServicios()
        {
            serviciosTipoproducto = (ServiciosTipoproducto)Configurador.ConfigurarServicio(typeof(ServiciosTipoproducto));
            serviciosTipoproducto.AutenticacionValue = new Autenticacion() { usuario = "U", contrasena = "1" };
        }

        private void configuracionInicial()
        {
            try
            {
                if (operacion == tipoOperacion.Insertar)
                {
                    this.Text = "Crear Nuevo Tipo de Producto";
                    lblTituloVentana.Text = "Nuevo Tipo de Producto";
                }
                else
                {
                    this.Text = "Editar Tipo de Producto";
                    lblTituloVentana.Text = "Editar Tipo de Producto";
                    txtNombreTipoProducto.Text = tipoProducto.NOM_TIPO_PRODUCTO;
                }
            }
            catch (Exception exp)
            {
                utilidades.Mensajes.mensajeError(exp.Message);
            }
        }

        private void editar()
        {
            TipoProductoResponse objResponse;
            try
            {
                Tipoproducto obj;
                obj = new Tipoproducto();

                if (!String.IsNullOrEmpty(txtNombreTipoProducto.Text) && !String.IsNullOrWhiteSpace(txtNombreTipoProducto.Text))
                    obj.NOM_TIPO_PRODUCTO = txtNombreTipoProducto.Text;
                obj.ID_TIPO_PRODUCTO = tipoProducto.ID_TIPO_PRODUCTO;
                objResponse = serviciosTipoproducto.editarTipoproducto(obj);
                if (objResponse != null && objResponse.correcto)
                {
                    utilidades.Mensajes.mensajeCorrecto("La información del Tipo de Producto se modificó correctamente");
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
                TipoProductoResponse objResponse;
                Tipoproducto obj = new Tipoproducto();
                if (!String.IsNullOrEmpty(txtNombreTipoProducto.Text) && !String.IsNullOrWhiteSpace(txtNombreTipoProducto.Text))
                    obj.NOM_TIPO_PRODUCTO = txtNombreTipoProducto.Text;
                objResponse = serviciosTipoproducto.crearTipoproducto(obj);
                if (objResponse != null && objResponse.correcto)
                {
                    utilidades.Mensajes.mensajeCorrecto("Se creo correctamente el Tipo de Producto " + obj.NOM_TIPO_PRODUCTO);
                    txtNombreTipoProducto.Clear();
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
