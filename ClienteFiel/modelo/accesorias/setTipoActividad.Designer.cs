namespace ClienteFiel.modelo.accesorias
{
    partial class setTipoActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setTipoActividad));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtTipoActividad = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(438, 70);
            // 
            // picLogoVentana
            // 
            this.picLogoVentana.Image = global::ClienteFiel.Properties.Resources.tipoActividad;
            this.picLogoVentana.Location = new System.Drawing.Point(364, -1);
            this.picLogoVentana.Size = new System.Drawing.Size(68, 71);
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.AutoSize = false;
            this.lblTituloVentana.Location = new System.Drawing.Point(12, 35);
            this.lblTituloVentana.Size = new System.Drawing.Size(353, 29);
            this.lblTituloVentana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Location = new System.Drawing.Point(-54, 130);
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
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Image = global::ClienteFiel.Properties.Resources.flopy24x24;
            this.btnGuardar.Location = new System.Drawing.Point(129, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(143, 31);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar Información";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTipoActividad
            // 
            this.txtTipoActividad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoActividad.Location = new System.Drawing.Point(146, 85);
            this.txtTipoActividad.Name = "txtTipoActividad";
            this.txtTipoActividad.Size = new System.Drawing.Size(256, 24);
            this.txtTipoActividad.TabIndex = 17;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.Color.Black;
            this.lblFiltro.Location = new System.Drawing.Point(23, 91);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(123, 18);
            this.lblFiltro.TabIndex = 18;
            this.lblFiltro.Text = "Tipo de Actividad:";
            // 
            // setTipoActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 176);
            this.Controls.Add(this.txtTipoActividad);
            this.Controls.Add(this.lblFiltro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "setTipoActividad";
            this.Text = "Gestión Tipo de Actividad";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.lblFiltro, 0);
            this.Controls.SetChildIndex(this.txtTipoActividad, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        protected System.Windows.Forms.TextBox txtTipoActividad;
        protected System.Windows.Forms.Label lblFiltro;
    }
}