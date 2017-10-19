using ClienteFiel.modelo.forms_base;
using ClienteFiel.WS_ServiciosImagen;
using ClienteFiel.WS_ServiciosViewproducto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilidadesServiciosWeb;

namespace ClienteFiel.modelo.productos
{
    public partial class setProductos : frmBase
    {
        ServiciosViewproducto serviciosViewproducto;
        ServiciosImagen serviciosImagen;
        Controles.utilidades.tipoOperacion operacion;
        Viewproducto producto;

        public setProductos(Controles.utilidades.tipoOperacion tmpTipoOperacion, long idProducto)
        {
            InitializeComponent();
            inicializarServicios();
            operacion = tmpTipoOperacion;
            if (idProducto > 0)
            {
                producto = new Viewproducto();
                producto.ID_PRODUCTO = idProducto;
            }
            ctrEmpresas1.iniciar();
            ctrTipoProducto1.iniciar();
            ctrTipoProducto1.setTipoProducto(1);
            configuracionInicial();
            Controles.utilidades.fijarSize(this);
        }

        private void inicializarServicios()
        {
            try
            {
                serviciosViewproducto = (ServiciosViewproducto)Configurador.ConfigurarServicio(typeof(ServiciosViewproducto));
                serviciosViewproducto.AutenticacionValue = new WS_ServiciosViewproducto.Autenticacion() { usuario = "U", contrasena = "1" };
                serviciosImagen = (ServiciosImagen)Configurador.ConfigurarServicio(typeof(ServiciosImagen));
                serviciosImagen.AutenticacionValue = new WS_ServiciosImagen.Autenticacion() { usuario = "U", contrasena = "1" };
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
                    lblTituloVentana.Text = "Nuevo Producto";
                }
                else
                {
                    if (producto != null && producto.ID_PRODUCTO > 0)
                    {
                        producto = serviciosViewproducto.buscarPrimeroViewproducto(producto);
                        lblTituloVentana.Text = "Editar Producto";
                        if (producto != null && producto.ID_PRODUCTO > 0)
                        {
                            ctrEmpresas1.setEmpresasSeleccionadas(new string[] { producto.ID_EMPRESA.ToString() });
                            txtProducto.Text = producto.NOM_PRODUCTO;
                            ctrTipoProducto1.setTipoProducto(producto.ID_TIPO_PRODUCTO);
                            txtPrecio.Text = producto.PRECIO.ToString();
                            txtDescripcion.Text = producto.DESCRIPCION;
                            ctrImagen1.setImage(Controles.utilidades.byteToImagen(producto.IMAGEN));
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                Controles.mensajes.mensajeError(exp.Message);
            }
        }
    }
}
