namespace ClienteFiel.modulos.accesorias
{
    partial class SetTipoProducto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombreTipoProducto = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picLogoVentana = new System.Windows.Forms.PictureBox();
            this.lblTituloVentana = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ClienteFiel.Properties.Resources.fondo1;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtNombreTipoProducto);
            this.panel1.Controls.Add(this.lblFiltro);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 196);
            this.panel1.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::ClienteFiel.Properties.Resources.exit24x24;
            this.btnSalir.Location = new System.Drawing.Point(259, 136);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(142, 32);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::ClienteFiel.Properties.Resources.flopy24x24;
            this.btnGuardar.Location = new System.Drawing.Point(111, 136);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(142, 32);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar Información";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombreTipoProducto
            // 
            this.txtNombreTipoProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTipoProducto.Location = new System.Drawing.Point(134, 93);
            this.txtNombreTipoProducto.MaxLength = 50;
            this.txtNombreTipoProducto.Name = "txtNombreTipoProducto";
            this.txtNombreTipoProducto.Size = new System.Drawing.Size(366, 24);
            this.txtNombreTipoProducto.TabIndex = 6;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(11, 96);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(126, 18);
            this.lblFiltro.TabIndex = 7;
            this.lblFiltro.Text = "Tipo de Producto:";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ClienteFiel.Properties.Resources.fondoTitulo1;
            this.panel3.Controls.Add(this.picLogoVentana);
            this.panel3.Controls.Add(this.lblTituloVentana);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(511, 82);
            this.panel3.TabIndex = 2;
            // 
            // picLogoVentana
            // 
            this.picLogoVentana.BackColor = System.Drawing.Color.Transparent;
            this.picLogoVentana.Image = global::ClienteFiel.Properties.Resources.tipo_actividad;
            this.picLogoVentana.Location = new System.Drawing.Point(7, 27);
            this.picLogoVentana.Name = "picLogoVentana";
            this.picLogoVentana.Size = new System.Drawing.Size(211, 49);
            this.picLogoVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoVentana.TabIndex = 0;
            this.picLogoVentana.TabStop = false;
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.AutoSize = true;
            this.lblTituloVentana.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVentana.ForeColor = System.Drawing.Color.White;
            this.lblTituloVentana.Location = new System.Drawing.Point(214, 45);
            this.lblTituloVentana.Name = "lblTituloVentana";
            this.lblTituloVentana.Size = new System.Drawing.Size(355, 29);
            this.lblTituloVentana.TabIndex = 1;
            this.lblTituloVentana.Text = "Gestión Tipo Redes Sociales";
            // 
            // SetTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 196);
            this.Controls.Add(this.panel1);
            this.Name = "SetTipoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetTipoProducto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        protected System.Windows.Forms.TextBox txtNombreTipoProducto;
        protected System.Windows.Forms.Label lblFiltro;
        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Label lblTituloVentana;
        protected System.Windows.Forms.PictureBox picLogoVentana;
        private System.Windows.Forms.Button btnSalir;
    }
}