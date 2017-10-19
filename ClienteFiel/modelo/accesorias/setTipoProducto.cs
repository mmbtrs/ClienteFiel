using ClienteFiel.modelo.forms_base;
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

namespace ClienteFiel.modelo.accesorias
{
    public partial class setTipoProducto : frmBase
    {
        ServiciosTipoproducto serviciosTipoproducto;

        Controles.utilidades.tipoOperacion operacion;
        Tipoproducto tipoProducto;

        public setTipoProducto(Controles.utilidades.tipoOperacion tmpOperacion, Tipoproducto tmpTipProd)
        {
            InitializeComponent();
            inicializarServicios();
            operacion = tmpOperacion;
            tipoProducto = tmpTipProd;
            configuracionInicial();
            Controles.utilidades.fijarSize(this);
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
                if (operacion == Controles.utilidades.tipoOperacion.Insertar)
                {
                    this.Text = "Crear Nuevo Tipo de Producto";
                    lblTituloVentana.Text = "Nuevo Tipo de Producto";
                }
                else
                {
                    this.Text = "Editar Tipo de Producto";
                    lblTituloVentana.Text = "Editar Tipo de Producto";
                    txtTipoProducto.Text = tipoProducto.NOM_TIPO_PRODUCTO;
                }
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }

        private void editar()
        {
            TipoProductoResponse objResponse;
            try
            {
                Tipoproducto obj;
                obj = new Tipoproducto();

                if (!String.IsNullOrEmpty(txtTipoProducto.Text) && !String.IsNullOrWhiteSpace(txtTipoProducto.Text))
                    obj.NOM_TIPO_PRODUCTO = txtTipoProducto.Text.Trim();
                obj.ID_TIPO_PRODUCTO = tipoProducto.ID_TIPO_PRODUCTO;
                objResponse = serviciosTipoproducto.editarTipoproducto(obj);
                if (objResponse != null && objResponse.correcto)
                {
                    Controles.mensajes.mensajeCorrecto("La información del Tipo de Producto se modificó correctamente");
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
                TipoProductoResponse objResponse;
                Tipoproducto obj = new Tipoproducto();
                if (!String.IsNullOrEmpty(txtTipoProducto.Text) && !String.IsNullOrWhiteSpace(txtTipoProducto.Text))
                    obj.NOM_TIPO_PRODUCTO = txtTipoProducto.Text.Trim();
                objResponse = serviciosTipoproducto.crearTipoproducto(obj);
                if (objResponse != null && objResponse.correcto)
                {
                    Controles.mensajes.mensajeCorrecto("Se creo correctamente el Tipo de Producto " + obj.NOM_TIPO_PRODUCTO);
                    txtTipoProducto.Clear();
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
