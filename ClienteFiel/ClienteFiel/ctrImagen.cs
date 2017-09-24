using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClienteFiel.modulos.controles_usuario
{
    public partial class ctrImagen : UserControl
    {
        public ctrImagen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarLogo();
        }

        private void cargarLogo()
        {
            try
            {
                if (openLogo.ShowDialog() == DialogResult.OK)
                {
                    picLogo.ImageLocation = openLogo.FileName;
                }
                else
                    picLogo.Image = null;
            }
            catch (Exception exp)
            {
                utilidades.Mensajes.mensajeError(exp.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            picLogo.Image = null;
        }
    }
}
