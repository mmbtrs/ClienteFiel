using ClienteFiel.modelo.accesorias;
using ClienteFiel.modelo.empresa;
using ClienteFiel.modelo.productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClienteFiel
{
    public partial class ClienteFiel : Form
    {
        public ClienteFiel()
        {
            InitializeComponent();
        }

        private void redSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestionTipoRedSocial frmGestionTipoRedSocial = new gestionTipoRedSocial();
            frmGestionTipoRedSocial.ShowDialog(this);
        }

        private void tipoIdentificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestionTipoIdentificacion frmGestionTipoIdentificacion = new gestionTipoIdentificacion();
            frmGestionTipoIdentificacion.ShowDialog(this);
        }

        private void tipoDeActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestionTipoActividad frmGestionTipoActividad = new gestionTipoActividad();
            frmGestionTipoActividad.ShowDialog(this);
        }

        private void tipoDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestionTipoProducto frmGestionTipoProducto = new gestionTipoProducto();
            frmGestionTipoProducto.ShowDialog(this);
        }

        private void municipiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestionMunicipios frmGestionMunicipios = new gestionMunicipios();
            frmGestionMunicipios.ShowDialog(this);
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestionDepartamentos frmGestionDepartamentos = new gestionDepartamentos();
            frmGestionDepartamentos.ShowDialog(this);
        }

        private void gestiónEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestionEmpresa frmGestionEmpresa = new gestionEmpresa();
            frmGestionEmpresa.ShowDialog(this);
        }

        private void configuraciónDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestionProductos frmGestionProductos = new gestionProductos();
            frmGestionProductos.ShowDialog(this);
        }
    }
}
