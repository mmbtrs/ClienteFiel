namespace ClienteFiel.modelo.accesorias
{
    partial class gestionTipoRedSocial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestionTipoRedSocial));
            this.ctrBuscar1 = new Controles.ctrBuscar();
            this.grdTiposRedesSociales = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TIPO_RED_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RED_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_IMAGEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGEN = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTiposRedesSociales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(709, 70);
            // 
            // picLogoVentana
            // 
            this.picLogoVentana.Image = global::ClienteFiel.Properties.Resources.redsocial;
            this.picLogoVentana.Size = new System.Drawing.Size(70, 57);
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.Location = new System.Drawing.Point(75, 35);
            this.lblTituloVentana.Size = new System.Drawing.Size(294, 29);
            this.lblTituloVentana.Text = "Gestión Redes Sociales";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(347, 97);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // ctrBuscar1
            // 
            this.ctrBuscar1.BackColor = System.Drawing.Color.Transparent;
            this.ctrBuscar1.Location = new System.Drawing.Point(8, 77);
            this.ctrBuscar1.Name = "ctrBuscar1";
            this.ctrBuscar1.Size = new System.Drawing.Size(361, 58);
            this.ctrBuscar1.TabIndex = 1;
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
            this.RED_SOCIAL,
            this.ID_IMAGEN,
            this.IMAGEN});
            this.grdTiposRedesSociales.Location = new System.Drawing.Point(8, 141);
            this.grdTiposRedesSociales.Name = "grdTiposRedesSociales";
            this.grdTiposRedesSociales.ReadOnly = true;
            this.grdTiposRedesSociales.RowHeadersVisible = false;
            this.grdTiposRedesSociales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTiposRedesSociales.Size = new System.Drawing.Size(693, 151);
            this.grdTiposRedesSociales.TabIndex = 10;
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
            // RED_SOCIAL
            // 
            this.RED_SOCIAL.HeaderText = "RED SOCIAL";
            this.RED_SOCIAL.Name = "RED_SOCIAL";
            this.RED_SOCIAL.ReadOnly = true;
            this.RED_SOCIAL.Width = 590;
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
            // gestionTipoRedSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 299);
            this.Controls.Add(this.ctrBuscar1);
            this.Controls.Add(this.grdTiposRedesSociales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gestionTipoRedSocial";
            this.Text = "Gestión Tipo de Red Social";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.grdTiposRedesSociales, 0);
            this.Controls.SetChildIndex(this.ctrBuscar1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTiposRedesSociales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.ctrBuscar ctrBuscar1;
        private System.Windows.Forms.DataGridView grdTiposRedesSociales;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TIPO_RED_SOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RED_SOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_IMAGEN;
        private System.Windows.Forms.DataGridViewImageColumn IMAGEN;
    }
}