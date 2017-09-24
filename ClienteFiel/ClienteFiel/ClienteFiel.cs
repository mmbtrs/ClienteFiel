using ClienteFiel.modulos.accesorias;
using ClienteFiel.modulos.configurar_producto;
using ClienteFiel.modulos.empresa;
using ClienteFiel.modulos.errores;
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

        private void tipoRedSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionTipoRedSocial gestionTipoRedSocial = new GestionTipoRedSocial();
            gestionTipoRedSocial.ShowDialog(this);
        }

        private void tipoIdentificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionTipoIdentificacion gestionTipoIdentificacion = new GestionTipoIdentificacion();
            gestionTipoIdentificacion.ShowDialog(this);
        }

        private void tipoActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionTipoActividad gestionTipoActividad = new GestionTipoActividad();
            gestionTipoActividad.ShowDialog(this);
        }

        private void gestionDeErroresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionErrores gestionErrores = new GestionErrores();
            gestionErrores.ShowDialog(this);
        }

        private void tipoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionTipoProducto gestionTipoProducto = new GestionTipoProducto();
            gestionTipoProducto.ShowDialog(this);
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionDepartamento gestionDepartamento = new GestionDepartamento();
            gestionDepartamento.ShowDialog(this);
        }

        private void municipioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionMunicipio gestionMunicipio = new GestionMunicipio();
            gestionMunicipio.ShowDialog(this);
        }

        private void datosDeLaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionEmpresa gestionEmpresa = new GestionEmpresa();
            gestionEmpresa.ShowDialog(this);
        }

        private void configuraciónDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.ShowDialog(this);
        }

        internal class modulos
        {
        }
    }
}
