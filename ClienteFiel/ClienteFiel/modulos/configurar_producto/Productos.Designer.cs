namespace ClienteFiel.modulos.configurar_producto
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrImagen1 = new Controles.ctrImagen();
            this.SuspendLayout();
            // 
            // ctrImagen1
            // 
            this.ctrImagen1.BackColor = System.Drawing.Color.Transparent;
            this.ctrImagen1.Location = new System.Drawing.Point(223, 87);
            this.ctrImagen1.Name = "ctrImagen1";
            this.ctrImagen1.Size = new System.Drawing.Size(238, 140);
            this.ctrImagen1.TabIndex = 0;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 311);
            this.Controls.Add(this.ctrImagen1);
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.ResumeLayout(false);

        }

        private Controles.ctrImagen ctrImagen1;

        //private ClienteFiel.modulos.controles_usuario.ctrImagen ctrImagen1;

        #endregion

        //private ClienteFiel..modulos.controles_usuario.ctrImagen ctrImagen1;
    }
}