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
            picLogo.AllowDrop = true;
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

        private void picLogo_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void picLogo_DragDrop(object sender, DragEventArgs e)
        {
            String[] files = (String[])e.Data.GetData(DataFormats.FileDrop, false);

            if (files != null && files.Length > 1)
            {
                foreach (var file in files)
                {
                    MessageBox.Show(file);
                    try
                    {
                        picLogo.Image = Image.FromFile(file);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("El archivo " + file + " no es un archivo de imagen valido", "Archivo no valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                try
                {
                    picLogo.Image = Image.FromFile(files[0]);
                }
                catch (Exception)
                {
                    MessageBox.Show("El archivo " + files[0] + " no es un archivo de imagen valido", "Archivo no valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }
    }
}
