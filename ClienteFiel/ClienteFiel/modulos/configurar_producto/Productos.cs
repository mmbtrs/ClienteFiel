using ClienteFiel.utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClienteFiel.modulos.configurar_producto
{
    public partial class Productos : BaseAccesorias
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            setProductos frmProductos = new setProductos();
            frmProductos.ShowDialog(this);
        }
    }
}
