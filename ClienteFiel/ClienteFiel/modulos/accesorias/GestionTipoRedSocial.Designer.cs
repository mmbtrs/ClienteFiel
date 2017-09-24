namespace ClienteFiel.modulos.accesorias
{
    partial class GestionTipoRedSocial
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
            this.grdTiposRedesSociales = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TIPO_RED_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_TIPO_RED_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_IMAGEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGEN = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTiposRedesSociales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ClienteFiel.Properties.Resources.fondoVentana;
            this.panel1.Controls.Add(this.grdTiposRedesSociales);
            this.panel1.Size = new System.Drawing.Size(718, 415);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.cmbColumna, 0);
            this.panel1.Controls.SetChildIndex(this.panel3, 0);
            this.panel1.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.Controls.SetChildIndex(this.lblFiltro, 0);
            this.panel1.Controls.SetChildIndex(this.picBuscar, 0);
            this.panel1.Controls.SetChildIndex(this.grdTiposRedesSociales, 0);
            this.panel1.Controls.SetChildIndex(this.txtFiltro, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(360, 102);
            this.panel2.Size = new System.Drawing.Size(345, 59);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panel3.Size = new System.Drawing.Size(716, 82);
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.Location = new System.Drawing.Point(353, 50);
            this.lblTituloVentana.Size = new System.Drawing.Size(294, 29);
            this.lblTituloVentana.Text = "Gestión Redes Sociales";
            // 
            // picLogoVentana
            // 
            this.picLogoVentana.Image = global::ClienteFiel.Properties.Resources.red_social2;
            this.picLogoVentana.Location = new System.Drawing.Point(641, 19);
            this.picLogoVentana.Size = new System.Drawing.Size(64, 59);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFiltro.Location = new System.Drawing.Point(24, 130);
            this.lblFiltro.Size = new System.Drawing.Size(56, 17);
            // 
            // txtFiltro
            // 
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro.Location = new System.Drawing.Point(78, 127);
            this.txtFiltro.MaxLength = 100;
            this.txtFiltro.Size = new System.Drawing.Size(235, 24);
            this.txtFiltro.TabIndex = 2;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // picBuscar
            // 
            this.picBuscar.Location = new System.Drawing.Point(316, 124);
            // 
            // cmbColumna
            // 
            this.cmbColumna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColumna.Items.AddRange(new object[] {
            "RED SOCIAL"});
            this.cmbColumna.Location = new System.Drawing.Point(80, 97);
            this.cmbColumna.Size = new System.Drawing.Size(233, 23);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Size = new System.Drawing.Size(67, 17);
            // 
            // btnInsertar
            // 
            this.btnInsertar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInsertar.Location = new System.Drawing.Point(24, 19);
            this.btnInsertar.Size = new System.Drawing.Size(75, 32);
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(105, 20);
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(186, 20);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(267, 20);
            // 
            // grdTiposRedesSociales
            // 
            this.grdTiposRedesSociales.AllowUserToAddRows = false;
            this.grdTiposRedesSociales.AllowUserToDeleteRows = false;
            this.grdTiposRedesSociales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTiposRedesSociales.BackgroundColor = System.Drawing.Color.White;
            this.grdTiposRedesSociales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTiposRedesSociales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ID_TIPO_RED_SOCIAL,
            this.NOM_TIPO_RED_SOCIAL,
            this.ID_IMAGEN,
            this.IMAGEN});
            this.grdTiposRedesSociales.Location = new System.Drawing.Point(12, 167);
            this.grdTiposRedesSociales.Name = "grdTiposRedesSociales";
            this.grdTiposRedesSociales.ReadOnly = true;
            this.grdTiposRedesSociales.RowHeadersVisible = false;
            this.grdTiposRedesSociales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTiposRedesSociales.Size = new System.Drawing.Size(693, 234);
            this.grdTiposRedesSociales.TabIndex = 9;
            this.grdTiposRedesSociales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTiposRedesSociales_CellClick);
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 30;
            // 
            // ID_TIPO_RED_SOCIAL
            // 
            this.ID_TIPO_RED_SOCIAL.HeaderText = "ID";
            this.ID_TIPO_RED_SOCIAL.Name = "ID_TIPO_RED_SOCIAL";
            this.ID_TIPO_RED_SOCIAL.ReadOnly = true;
            this.ID_TIPO_RED_SOCIAL.Visible = false;
            // 
            // NOM_TIPO_RED_SOCIAL
            // 
            this.NOM_TIPO_RED_SOCIAL.HeaderText = "RED SOCIAL";
            this.NOM_TIPO_RED_SOCIAL.Name = "NOM_TIPO_RED_SOCIAL";
            this.NOM_TIPO_RED_SOCIAL.ReadOnly = true;
            this.NOM_TIPO_RED_SOCIAL.Width = 590;
            // 
            // ID_IMAGEN
            // 
            this.ID_IMAGEN.HeaderText = "IDIMAGEN";
            this.ID_IMAGEN.Name = "ID_IMAGEN";
            this.ID_IMAGEN.ReadOnly = true;
            this.ID_IMAGEN.Visible = false;
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
            // GestionTipoRedSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 415);
            this.Name = "GestionTipoRedSocial";
            this.Text = "Gestión Redes Sociales";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTiposRedesSociales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTiposRedesSociales;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TIPO_RED_SOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_TIPO_RED_SOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_IMAGEN;
        private System.Windows.Forms.DataGridViewImageColumn IMAGEN;
    }
}