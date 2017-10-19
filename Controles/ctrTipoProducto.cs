using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controles.WS_ServiciosTipoproducto;
using UtilidadesServiciosWeb;

namespace Controles
{
    public partial class ctrTipoProducto : UserControl
    {
        ServiciosTipoproducto serviciosTipoproducto;

        public ctrTipoProducto()
        {
            InitializeComponent();           
        }

        public void iniciar()
        {
            inicializarServicios();
            getTiposProductos();
        }

        private void inicializarServicios()
        {
            serviciosTipoproducto = (ServiciosTipoproducto)Configurador.ConfigurarServicio(typeof(ServiciosTipoproducto));
            serviciosTipoproducto.AutenticacionValue = new Autenticacion() { usuario = "U", contrasena = "1" };
        }

        private void getTiposProductos()
        {
            try
            {
                cmbTipoProducto.Items.Clear();
                Tipoproducto[] lstTiposProductos = serviciosTipoproducto.listarTipoproducto();
                foreach (Tipoproducto item in lstTiposProductos)
                {
                    cmbTipoProducto.Items.Add(item);
                }
                if (cmbTipoProducto.Items.Count > 0)
                {
                    cmbTipoProducto.SelectedIndex = 0;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Se presentó el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Tipoproducto getTipoProducto()
        {
            if (cmbTipoProducto.Items != null && cmbTipoProducto.Items.Count > 0 && cmbTipoProducto.SelectedIndex >= 0)
                return (Tipoproducto)cmbTipoProducto.SelectedItem;
            return null;
        }

        public void setTipoProducto(long idTipoProducto)
        {
            for (int i = 0; i < cmbTipoProducto.Items.Count; i++)
            {
                if (((Tipoproducto)cmbTipoProducto.Items[i]).ID_TIPO_PRODUCTO == idTipoProducto)
                {
                    cmbTipoProducto.SelectedIndex = i;
                    break;
                }
            }
        }
    }
}
