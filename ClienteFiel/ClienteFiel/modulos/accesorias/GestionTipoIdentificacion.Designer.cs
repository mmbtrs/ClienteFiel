namespace ClienteFiel.modulos.accesorias
{
    partial class GestionTipoIdentificacion
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
            this.grdTipoIdentificacion = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TIPO_IDENTIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_TIPO_IDENTIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoIdentificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdTipoIdentificacion);
            this.panel1.Size = new System.Drawing.Size(739, 492);
            this.panel1.Controls.SetChildIndex(this.panel3, 0);
            this.panel1.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.Controls.SetChildIndex(this.lblFiltro, 0);
            this.panel1.Controls.SetChildIndex(this.picBuscar, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.txtFiltro, 0);
            this.panel1.Controls.SetChildIndex(this.cmbColumna, 0);
            this.panel1.Controls.SetChildIndex(this.grdTipoIdentificacion, 0);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(392, 101);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(737, 82);
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.Location = new System.Drawing.Point(288, 44);
            this.lblTituloVentana.Size = new System.Drawing.Size(363, 29);
            this.lblTituloVentana.Text = "Gestión Tipo de Identificación";
            // 
            // picLogoVentana
            // 
            this.picLogoVentana.Image = global::ClienteFiel.Properties.Resources.name_tag_identification_card;
            this.picLogoVentana.Location = new System.Drawing.Point(643, 10);
            this.picLogoVentana.Size = new System.Drawing.Size(96, 74);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Location = new System.Drawing.Point(23, 129);
            // 
            // txtFiltro
            // 
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro.Location = new System.Drawing.Point(89, 126);
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // picBuscar
            // 
            this.picBuscar.Location = new System.Drawing.Point(348, 122);
            // 
            // cmbColumna
            // 
            this.cmbColumna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColumna.Items.AddRange(new object[] {
            "TIPO DE IDENTIFICACION"});
            this.cmbColumna.Location = new System.Drawing.Point(89, 95);
            this.cmbColumna.Size = new System.Drawing.Size(186, 23);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 98);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(13, 19);
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(94, 19);
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(175, 19);
            this.btnEliminar.Size = new System.Drawing.Size(75, 32);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(256, 19);
            // 
            // grdTipoIdentificacion
            // 
            this.grdTipoIdentificacion.AllowUserToAddRows = false;
            this.grdTipoIdentificacion.AllowUserToDeleteRows = false;
            this.grdTipoIdentificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTipoIdentificacion.BackgroundColor = System.Drawing.Color.White;
            this.grdTipoIdentificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTipoIdentificacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ID_TIPO_IDENTIFICACION,
            this.NOM_TIPO_IDENTIFICACION});
            this.grdTipoIdentificacion.Location = new System.Drawing.Point(12, 164);
            this.grdTipoIdentificacion.MultiSelect = false;
            this.grdTipoIdentificacion.Name = "grdTipoIdentificacion";
            this.grdTipoIdentificacion.ReadOnly = true;
            this.grdTipoIdentificacion.RowHeadersVisible = false;
            this.grdTipoIdentificacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTipoIdentificacion.Size = new System.Drawing.Size(714, 316);
            this.grdTipoIdentificacion.TabIndex = 11;
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 40;
            // 
            // ID_TIPO_IDENTIFICACION
            // 
            this.ID_TIPO_IDENTIFICACION.HeaderText = "ID_TIPO_IDENTIFICACION";
            this.ID_TIPO_IDENTIFICACION.Name = "ID_TIPO_IDENTIFICACION";
            this.ID_TIPO_IDENTIFICACION.ReadOnly = true;
            this.ID_TIPO_IDENTIFICACION.Visible = false;
            // 
            // NOM_TIPO_IDENTIFICACION
            // 
            this.NOM_TIPO_IDENTIFICACION.HeaderText = "TIPO DE IDENTIFICACION";
            this.NOM_TIPO_IDENTIFICACION.Name = "NOM_TIPO_IDENTIFICACION";
            this.NOM_TIPO_IDENTIFICACION.ReadOnly = true;
            this.NOM_TIPO_IDENTIFICACION.Width = 650;
            // 
            // GestionTipoIdentificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 492);
            this.Name = "GestionTipoIdentificacion";
            this.Text = "Gestión Tipo de Identificación";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoIdentificacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTipoIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TIPO_IDENTIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_TIPO_IDENTIFICACION;
    }
}