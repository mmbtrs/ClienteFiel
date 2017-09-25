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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(942, 393);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(780, 112);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(940, 104);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClienteFiel.Properties.Resources.fondoVentana;
            this.ClientSize = new System.Drawing.Size(942, 393);
            this.Name = "Productos";
            this.Text = "Productos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        //private ClienteFiel.modulos.controles_usuario.ctrImagen ctrImagen1;

        #endregion

        //private ClienteFiel..modulos.controles_usuario.ctrImagen ctrImagen1;
    }
}