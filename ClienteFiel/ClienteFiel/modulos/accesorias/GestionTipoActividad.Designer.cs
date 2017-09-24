namespace ClienteFiel.modulos.accesorias
{
    partial class GestionTipoActividad
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
            this.grdTiposActividad = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TIPO_ACTIVIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_TIPO_ACTIVIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTiposActividad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdTiposActividad);
            this.panel1.Size = new System.Drawing.Size(729, 492);
            this.panel1.Controls.SetChildIndex(this.panel3, 0);
            this.panel1.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.Controls.SetChildIndex(this.lblFiltro, 0);
            this.panel1.Controls.SetChildIndex(this.picBuscar, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.txtFiltro, 0);
            this.panel1.Controls.SetChildIndex(this.cmbColumna, 0);
            this.panel1.Controls.SetChildIndex(this.grdTiposActividad, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(386, 100);
            this.panel2.Size = new System.Drawing.Size(330, 53);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(727, 82);
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.Location = new System.Drawing.Point(135, 48);
            this.lblTituloVentana.Size = new System.Drawing.Size(277, 29);
            this.lblTituloVentana.Text = "Gestión Tipo Actividad";
            // 
            // picLogoVentana
            // 
            this.picLogoVentana.Image = global::ClienteFiel.Properties.Resources.tipo_actividad;
            this.picLogoVentana.Location = new System.Drawing.Point(418, 20);
            this.picLogoVentana.Size = new System.Drawing.Size(282, 57);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Location = new System.Drawing.Point(23, 131);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(89, 128);
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // picBuscar
            // 
            this.picBuscar.Location = new System.Drawing.Point(348, 124);
            // 
            // cmbColumna
            // 
            this.cmbColumna.Items.AddRange(new object[] {
            "TIPO DE ACTIVIDAD"});
            this.cmbColumna.Location = new System.Drawing.Point(89, 97);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 100);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(7, 19);
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(88, 19);
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(169, 19);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(250, 19);
            // 
            // grdTiposActividad
            // 
            this.grdTiposActividad.AllowUserToAddRows = false;
            this.grdTiposActividad.AllowUserToDeleteRows = false;
            this.grdTiposActividad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTiposActividad.BackgroundColor = System.Drawing.Color.White;
            this.grdTiposActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTiposActividad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ID_TIPO_ACTIVIDAD,
            this.NOM_TIPO_ACTIVIDAD});
            this.grdTiposActividad.Location = new System.Drawing.Point(11, 164);
            this.grdTiposActividad.MultiSelect = false;
            this.grdTiposActividad.Name = "grdTiposActividad";
            this.grdTiposActividad.ReadOnly = true;
            this.grdTiposActividad.RowHeadersVisible = false;
            this.grdTiposActividad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTiposActividad.Size = new System.Drawing.Size(705, 315);
            this.grdTiposActividad.TabIndex = 11;
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 30;
            // 
            // ID_TIPO_ACTIVIDAD
            // 
            this.ID_TIPO_ACTIVIDAD.HeaderText = "ID_TIPO_ACTIVIDAD";
            this.ID_TIPO_ACTIVIDAD.Name = "ID_TIPO_ACTIVIDAD";
            this.ID_TIPO_ACTIVIDAD.ReadOnly = true;
            this.ID_TIPO_ACTIVIDAD.Visible = false;
            // 
            // NOM_TIPO_ACTIVIDAD
            // 
            this.NOM_TIPO_ACTIVIDAD.HeaderText = "TIPO DE ACTIVIDAD";
            this.NOM_TIPO_ACTIVIDAD.Name = "NOM_TIPO_ACTIVIDAD";
            this.NOM_TIPO_ACTIVIDAD.ReadOnly = true;
            this.NOM_TIPO_ACTIVIDAD.Width = 650;
            // 
            // GestionTipoActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 492);
            this.Name = "GestionTipoActividad";
            this.Text = "Gestión Tipo Actividad";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTiposActividad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTiposActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TIPO_ACTIVIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_TIPO_ACTIVIDAD;
    }
}