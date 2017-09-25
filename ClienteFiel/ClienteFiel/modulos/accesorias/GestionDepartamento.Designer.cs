namespace ClienteFiel.modulos.accesorias
{
    partial class GestionDepartamento
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
            this.grdDepartamentos = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdDepartamentos);
            this.panel1.Size = new System.Drawing.Size(782, 492);
            this.panel1.Controls.SetChildIndex(this.panel3, 0);
            this.panel1.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.Controls.SetChildIndex(this.lblFiltro, 0);
            this.panel1.Controls.SetChildIndex(this.picBuscar, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.txtFiltro, 0);
            this.panel1.Controls.SetChildIndex(this.cmbColumna, 0);
            this.panel1.Controls.SetChildIndex(this.grdDepartamentos, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(456, 112);
            this.panel2.Size = new System.Drawing.Size(360, 53);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(780, 82);
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.Location = new System.Drawing.Point(426, 46);
            this.lblTituloVentana.Size = new System.Drawing.Size(274, 29);
            this.lblTituloVentana.Text = "Gestión Departamento";
            // 
            // picLogoVentana
            // 
            this.picLogoVentana.Image = global::ClienteFiel.Properties.Resources.mapa_politico_colombia;
            this.picLogoVentana.Location = new System.Drawing.Point(703, 10);
            this.picLogoVentana.Size = new System.Drawing.Size(65, 67);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Location = new System.Drawing.Point(23, 134);
            // 
            // txtFiltro
            // 
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro.Location = new System.Drawing.Point(80, 131);
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // picBuscar
            // 
            this.picBuscar.Location = new System.Drawing.Point(339, 127);
            // 
            // cmbColumna
            // 
            this.cmbColumna.Items.AddRange(new object[] {
            "DEPARTAMENTO"});
            this.cmbColumna.Location = new System.Drawing.Point(80, 100);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 103);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(38, 19);
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(119, 19);
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(200, 19);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(281, 19);
            // 
            // grdDepartamentos
            // 
            this.grdDepartamentos.AllowUserToAddRows = false;
            this.grdDepartamentos.AllowUserToDeleteRows = false;
            this.grdDepartamentos.BackgroundColor = System.Drawing.Color.White;
            this.grdDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ID_DEPARTAMENTO,
            this.NOM_DEPARTAMENTO});
            this.grdDepartamentos.Location = new System.Drawing.Point(12, 171);
            this.grdDepartamentos.Name = "grdDepartamentos";
            this.grdDepartamentos.ReadOnly = true;
            this.grdDepartamentos.RowHeadersVisible = false;
            this.grdDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDepartamentos.Size = new System.Drawing.Size(757, 308);
            this.grdDepartamentos.TabIndex = 11;
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // ID_DEPARTAMENTO
            // 
            this.ID_DEPARTAMENTO.HeaderText = "ID_DEPARTAMENTO";
            this.ID_DEPARTAMENTO.Name = "ID_DEPARTAMENTO";
            this.ID_DEPARTAMENTO.ReadOnly = true;
            this.ID_DEPARTAMENTO.Visible = false;
            // 
            // NOM_DEPARTAMENTO
            // 
            this.NOM_DEPARTAMENTO.HeaderText = "DEPARTAMENTO";
            this.NOM_DEPARTAMENTO.Name = "NOM_DEPARTAMENTO";
            this.NOM_DEPARTAMENTO.ReadOnly = true;
            this.NOM_DEPARTAMENTO.Width = 650;
            // 
            // GestionDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 492);
            this.Name = "GestionDepartamento";
            this.Text = "Gestión Departamento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDepartamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DEPARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_DEPARTAMENTO;
    }
}