namespace ClienteFiel.modelo.accesorias
{
    partial class setTipoIdentificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setTipoIdentificacion));
            this.txtTipoIdentificacion = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(469, 70);
            // 
            // picLogoVentana
            // 
            this.picLogoVentana.Image = global::ClienteFiel.Properties.Resources.identificacion;
            this.picLogoVentana.Location = new System.Drawing.Point(385, -1);
            this.picLogoVentana.Size = new System.Drawing.Size(77, 72);
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.AutoSize = false;
            this.lblTituloVentana.Location = new System.Drawing.Point(65, 35);
            this.lblTituloVentana.Size = new System.Drawing.Size(320, 29);
            this.lblTituloVentana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Location = new System.Drawing.Point(-42, 127);
            this.panel2.Size = new System.Drawing.Size(422, 37);
            this.panel2.Controls.SetChildIndex(this.btnEditar, 0);
            this.panel2.Controls.SetChildIndex(this.btnInsertar, 0);
            this.panel2.Controls.SetChildIndex(this.btnEliminar, 0);
            this.panel2.Controls.SetChildIndex(this.btnSalir, 0);
            this.panel2.Controls.SetChildIndex(this.btnGuardar, 0);
            // 
            // btnSalir
            // 
            this.btnSalir.Size = new System.Drawing.Size(143, 31);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Visible = false;
            // 
            // txtTipoIdentificacion
            // 
            this.txtTipoIdentificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoIdentificacion.Location = new System.Drawing.Point(179, 87);
            this.txtTipoIdentificacion.Name = "txtTipoIdentificacion";
            this.txtTipoIdentificacion.Size = new System.Drawing.Size(256, 24);
            this.txtTipoIdentificacion.TabIndex = 15;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.Color.Black;
            this.lblFiltro.Location = new System.Drawing.Point(28, 93);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(150, 18);
            this.lblFiltro.TabIndex = 16;
            this.lblFiltro.Text = "Tipo de Identificación:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Image = global::ClienteFiel.Properties.Resources.flopy24x24;
            this.btnGuardar.Location = new System.Drawing.Point(129, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(143, 31);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar Información";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // setTipoIdentificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 174);
            this.Controls.Add(this.txtTipoIdentificacion);
            this.Controls.Add(this.lblFiltro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "setTipoIdentificacion";
            this.Text = "Gestión Tipo Identificación";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.lblFiltro, 0);
            this.Controls.SetChildIndex(this.txtTipoIdentificacion, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox txtTipoIdentificacion;
        protected System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnGuardar;
    }
}