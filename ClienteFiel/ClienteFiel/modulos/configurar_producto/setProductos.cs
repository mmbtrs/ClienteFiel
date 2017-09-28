using ClienteFiel.WS_ServiciosImagen;
using ClienteFiel.WS_ServiciosProducto;
using ClienteFiel.WS_ServiciosTipoproducto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilidadesServiciosWeb;

namespace ClienteFiel.modulos.configurar_producto
{
    public partial class setProductos : Form
    {
        ServiciosProducto serviciosProducto;
        ServiciosImagen serviciosImagen;

        public setProductos()
        {
            InitializeComponent();
            inicializarServicios();
            Controles.utilidades.fijarSize(this);
        }

        private void inicializarServicios()
        {
            serviciosProducto = (ServiciosProducto)Configurador.ConfigurarServicio(typeof(ServiciosProducto));
            serviciosProducto.AutenticacionValue = new WS_ServiciosProducto.Autenticacion() { usuario = "U", contrasena = "1" };
            serviciosImagen = (ServiciosImagen)Configurador.ConfigurarServicio(typeof(ServiciosImagen));
            serviciosImagen.AutenticacionValue = new WS_ServiciosImagen.Autenticacion() { usuario = "U", contrasena = "1" };

            ctrEmpresas.iniciar();
            ctrTipoProducto.iniciar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           guardar();
        }

        private void guardar()
        {
            try
            {
                ArrayList lstEmpresas = ctrEmpresas.getEmpresasSeleccionadas();
                if (lstEmpresas != null && lstEmpresas.Count > 0)
                {
                    for (int i = 0; i < lstEmpresas.Count; i++)
                    {
                        guardarProducto(long.Parse(lstEmpresas[i].ToString()));
                    }
                    utilidades.Mensajes.mensajeCorrecto("Proceso de guardado del producto terminado correctamente");
                }
                else
                    MessageBox.Show("Debe seleccionar al menos una empresa de la lista", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exp)
            {
                utilidades.Mensajes.mensajeError(exp.Message);
            }
        }

        private bool guardarProducto(long idEmpresa)
        {
            try
            {
                Imagen tmpImg = gurdarImagen();
                if (tmpImg != null && tmpImg.ID_IMAGEN > 0)
                {
                    Producto producto = new Producto();
                    producto.ID_EMPRESA = idEmpresa;
                    producto.ID_IMAGEN = tmpImg.ID_IMAGEN;
                    producto.ID_TIPO_PRODUCTO = ctrTipoProducto.getTipoProducto().ID_TIPO_PRODUCTO;
                    producto.NOM_PRODUCTO = txtProducto.Text;
                    long tmpValor = 0;
                    long.TryParse(txtPrecio.Text, out tmpValor);
                    producto.PRECIO = tmpValor;
                    producto.DESCRIPCION = txtDescripcion.Text;
                    ProductoResponse prodResponse = serviciosProducto.crearProducto(producto);
                    if (prodResponse != null && prodResponse.correcto)
                        return true;
                    else
                    {
                        utilidades.Mensajes.errorWebServices(prodResponse.error);
                        return false;
                    }
                }
            }
            catch (Exception exp)
            {
                utilidades.Mensajes.mensajeError(exp.Message);
                return false;
            }
            return false;
        }

        private Imagen gurdarImagen()
        {
            try
            {
                if (ctrImagen.getImage() != null)
                {
                    Imagen img = new Imagen();
                    img.IMAGEN = Controles.utilidades.ImageToByte(ctrImagen.getImage());
                    ImagenResponse imgResponse = serviciosImagen.crearImagen(img);
                    if (imgResponse != null && imgResponse.correcto)
                    {
                        return imgResponse.objeto;
                    }
                    else
                    {
                        utilidades.Mensajes.errorWebServices(imgResponse.error);
                        return null;
                    }
                }
            }
            catch (Exception exp)
            {
                utilidades.Mensajes.mensajeError(exp.Message);
                return null;
            }
            return null;
        }
    }
}
