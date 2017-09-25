using ClienteFiel.WS_ServiciosProducto;
using System;
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

        public setProductos()
        {
            InitializeComponent();
            inicializarServicios();
            Controles.utilidades.fijarSize(this);
        }

        private void inicializarServicios()
        {
            serviciosProducto = (ServiciosProducto)Configurador.ConfigurarServicio(typeof(ServiciosProducto));
            serviciosProducto.AutenticacionValue = new Autenticacion() { usuario = "U", contrasena = "1" };
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarProducto();
        }

        private void guardarProducto()
        {
            try
            {

            }
            catch (Exception exp)
            {
                utilidades.Mensajes.mensajeError(exp.Message);
            }
        }
    }
}
