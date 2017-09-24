using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public partial class ctrImagen : UserControl
    {
        public ctrImagen()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
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
                MessageBox.Show("Se presentó el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            picLogo.Image = null;
        }

        public Image getImage()
        {
            return picLogo.Image;
        }

        public void setImage(Image img)
        {
            picLogo.Image = img;
        }
    }
}
