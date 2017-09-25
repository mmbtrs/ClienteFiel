namespace ClienteFiel.modulos.configurar_producto
{
    partial class setProductos
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.picLogoVentana = new System.Windows.Forms.PictureBox();
            this.lblTituloVentana = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrEmpresas = new Controles.ctrEmpresas();
            this.ctrTipoProducto = new Controles.ctrTipoProducto();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctrImagen = new Controles.ctrImagen();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ClienteFiel.Properties.Resources.fondoTitulo1;
            this.panel3.Controls.Add(this.picLogoVentana);
            this.panel3.Controls.Add(this.lblTituloVentana);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(959, 82);
            this.panel3.TabIndex = 3;
            // 
            // picLogoVentana
            // 
            this.picLogoVentana.BackColor = System.Drawing.Color.Transparent;
            this.picLogoVentana.Image = global::ClienteFiel.Properties.Resources.productos;
            this.picLogoVentana.Location = new System.Drawing.Point(7, 12);
            this.picLogoVentana.Name = "picLogoVentana";
            this.picLogoVentana.Size = new System.Drawing.Size(110, 64);
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
            this.lblTituloVentana.Location = new System.Drawing.Point(123, 47);
            this.lblTituloVentana.Name = "lblTituloVentana";
            this.lblTituloVentana.Size = new System.Drawing.Size(231, 29);
            this.lblTituloVentana.TabIndex = 1;
            this.lblTituloVentana.Text = "Agregar Productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Empresas";
            // 
            // ctrEmpresas
            // 
            this.ctrEmpresas.BackColor = System.Drawing.Color.Transparent;
            this.ctrEmpresas.Location = new System.Drawing.Point(32, 115);
            this.ctrEmpresas.Name = "ctrEmpresas";
            this.ctrEmpresas.Size = new System.Drawing.Size(899, 150);
            this.ctrEmpresas.TabIndex = 5;
            // 
            // ctrTipoProducto
            // 
            this.ctrTipoProducto.BackColor = System.Drawing.Color.Transparent;
            this.ctrTipoProducto.Location = new System.Drawing.Point(10, 307);
            this.ctrTipoProducto.Name = "ctrTipoProducto";
            this.ctrTipoProducto.Size = new System.Drawing.Size(376, 30);
            this.ctrTipoProducto.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Producto:";
            // 
            // txtProducto
            // 
            this.txtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(119, 277);
            this.txtProducto.MaxLength = 100;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(247, 24);
            this.txtProducto.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(119, 343);
            this.txtPrecio.MaxLength = 100;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(125, 24);
            this.txtPrecio.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Precio($):";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(119, 373);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(339, 54);
            this.txtDescripcion.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descripción:";
            // 
            // ctrImagen
            // 
            this.ctrImagen.BackColor = System.Drawing.Color.Transparent;
            this.ctrImagen.Location = new System.Drawing.Point(561, 280);
            this.ctrImagen.Name = "ctrImagen";
            this.ctrImagen.Size = new System.Drawing.Size(238, 140);
            this.ctrImagen.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(504, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Imagen:";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::ClienteFiel.Properties.Resources.exit24x24;
            this.btnSalir.Location = new System.Drawing.Point(482, 437);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(142, 32);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::ClienteFiel.Properties.Resources.flopy24x24;
            this.btnGuardar.Location = new System.Drawing.Point(334, 437);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(142, 32);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar Información";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // setProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClienteFiel.Properties.Resources.fondoVentana;
            this.ClientSize = new System.Drawing.Size(959, 478);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.ctrImagen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrTipoProducto);
            this.Controls.Add(this.ctrEmpresas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Name = "setProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.PictureBox picLogoVentana;
        protected System.Windows.Forms.Label lblTituloVentana;
        private System.Windows.Forms.Label label1;
        private Controles.ctrEmpresas ctrEmpresas;
        private Controles.ctrTipoProducto ctrTipoProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private Controles.ctrImagen ctrImagen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
    }
}