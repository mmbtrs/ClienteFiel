using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClienteFiel.utilidades
{
    public partial class VentanaImagen : Form
    {
        public VentanaImagen(Image tmpImagen)
        {
            InitializeComponent();
            picImagen.Image = tmpImagen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
