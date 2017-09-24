namespace ClienteFiel.modulos.empresa
{
    partial class GestionEmpresa
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
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_EMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_MUNICIPIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_IMAGEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZON_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLOGAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LATITUD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LONGITUD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUCURSAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUNICIPIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGEN = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdDatos);
            this.panel1.Size = new System.Drawing.Size(727, 492);
            this.panel1.Controls.SetChildIndex(this.panel3, 0);
            this.panel1.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.Controls.SetChildIndex(this.lblFiltro, 0);
            this.panel1.Controls.SetChildIndex(this.picBuscar, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.txtFiltro, 0);
            this.panel1.Controls.SetChildIndex(this.cmbColumna, 0);
            this.panel1.Controls.SetChildIndex(this.grdDatos, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(380, 113);
            this.panel2.Size = new System.Drawing.Size(334, 53);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(725, 82);
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloVentana.Location = new System.Drawing.Point(402, 46);
            this.lblTituloVentana.Size = new System.Drawing.Size(227, 29);
            this.lblTituloVentana.Text = "Gestión Empresas";
            // 
            // picLogoVentana
            // 
            this.picLogoVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogoVentana.Image = global::ClienteFiel.Properties.Resources.empresaa;
            this.picLogoVentana.Location = new System.Drawing.Point(634, 8);
            this.picLogoVentana.Size = new System.Drawing.Size(77, 74);
            // 
            // cmbColumna
            // 
            this.cmbColumna.Items.AddRange(new object[] {
            "NIT",
            "RAZON SOCIAL",
            "DIRECCION",
            "TELEFONO",
            "SUCURSAL",
            "MUNICIPIO"});
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(14, 19);
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(95, 19);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(176, 19);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(255, 19);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.BackgroundColor = System.Drawing.Color.White;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ID_EMPRESA,
            this.ID_MUNICIPIO,
            this.ID_IMAGEN,
            this.NIT,
            this.RAZON_SOCIAL,
            this.DIRECCION,
            this.TELEFONO,
            this.SLOGAN,
            this.LATITUD,
            this.LONGITUD,
            this.SUCURSAL,
            this.MUNICIPIO,
            this.IMAGEN});
            this.grdDatos.Location = new System.Drawing.Point(12, 171);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(702, 308);
            this.grdDatos.TabIndex = 11;
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 50;
            // 
            // ID_EMPRESA
            // 
            this.ID_EMPRESA.HeaderText = "ID_EMPRESA";
            this.ID_EMPRESA.Name = "ID_EMPRESA";
            this.ID_EMPRESA.ReadOnly = true;
            this.ID_EMPRESA.Visible = false;
            // 
            // ID_MUNICIPIO
            // 
            this.ID_MUNICIPIO.HeaderText = "ID_MUNICIPIO";
            this.ID_MUNICIPIO.Name = "ID_MUNICIPIO";
            this.ID_MUNICIPIO.ReadOnly = true;
            this.ID_MUNICIPIO.Visible = false;
            // 
            // ID_IMAGEN
            // 
            this.ID_IMAGEN.HeaderText = "ID_IMAGEN";
            this.ID_IMAGEN.Name = "ID_IMAGEN";
            this.ID_IMAGEN.ReadOnly = true;
            this.ID_IMAGEN.Visible = false;
            // 
            // NIT
            // 
            this.NIT.HeaderText = "NIT";
            this.NIT.Name = "NIT";
            this.NIT.ReadOnly = true;
            // 
            // RAZON_SOCIAL
            // 
            this.RAZON_SOCIAL.HeaderText = "RAZON SOCIAL";
            this.RAZON_SOCIAL.Name = "RAZON_SOCIAL";
            this.RAZON_SOCIAL.ReadOnly = true;
            this.RAZON_SOCIAL.Width = 150;
            // 
            // DIRECCION
            // 
            this.DIRECCION.HeaderText = "DIRECCION";
            this.DIRECCION.Name = "DIRECCION";
            this.DIRECCION.ReadOnly = true;
            this.DIRECCION.Width = 150;
            // 
            // TELEFONO
            // 
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            // 
            // SLOGAN
            // 
            this.SLOGAN.HeaderText = "SLOGAN";
            this.SLOGAN.Name = "SLOGAN";
            this.SLOGAN.ReadOnly = true;
            this.SLOGAN.Width = 300;
            // 
            // LATITUD
            // 
            this.LATITUD.HeaderText = "LATITUD";
            this.LATITUD.Name = "LATITUD";
            this.LATITUD.ReadOnly = true;
            this.LATITUD.Width = 70;
            // 
            // LONGITUD
            // 
            this.LONGITUD.HeaderText = "LONGITUD";
            this.LONGITUD.Name = "LONGITUD";
            this.LONGITUD.ReadOnly = true;
            this.LONGITUD.Width = 70;
            // 
            // SUCURSAL
            // 
            this.SUCURSAL.HeaderText = "SUCURSAL";
            this.SUCURSAL.Name = "SUCURSAL";
            this.SUCURSAL.ReadOnly = true;
            // 
            // MUNICIPIO
            // 
            this.MUNICIPIO.HeaderText = "MUNICIPIO";
            this.MUNICIPIO.Name = "MUNICIPIO";
            this.MUNICIPIO.ReadOnly = true;
            // 
            // IMAGEN
            // 
            this.IMAGEN.HeaderText = "LOGO";
            this.IMAGEN.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.IMAGEN.Name = "IMAGEN";
            this.IMAGEN.ReadOnly = true;
            this.IMAGEN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IMAGEN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IMAGEN.Width = 50;
            // 
            // GestionEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 492);
            this.Name = "GestionEmpresa";
            this.Text = "Gestion Empresa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_EMPRESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MUNICIPIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_IMAGEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZON_SOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLOGAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LATITUD;
        private System.Windows.Forms.DataGridViewTextBoxColumn LONGITUD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUCURSAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUNICIPIO;
        private System.Windows.Forms.DataGridViewImageColumn IMAGEN;
    }
}