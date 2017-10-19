namespace Controles
{
    partial class ctrMunicipios
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panFondo = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.grdMunicipios = new System.Windows.Forms.DataGridView();
            this.NoMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_MUNICIPIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_DEPARTAMENTO_M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUNICIPIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.grdDepartamentos = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrBuscarMunicipio = new Controles.ctrBuscar();
            this.ctrBuscarDepto = new Controles.ctrBuscar();
            this.panFondo.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMunicipios)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartamentos)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panFondo
            // 
            this.panFondo.BackColor = System.Drawing.Color.Transparent;
            this.panFondo.Controls.Add(this.panel7);
            this.panFondo.Controls.Add(this.panel6);
            this.panFondo.Location = new System.Drawing.Point(0, 0);
            this.panFondo.MaximumSize = new System.Drawing.Size(810, 246);
            this.panFondo.Name = "panFondo";
            this.panFondo.Size = new System.Drawing.Size(810, 206);
            this.panFondo.TabIndex = 18;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackgroundImage = global::Controles.Properties.Resources.fondoWindow;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.ctrBuscarMunicipio);
            this.panel7.Controls.Add(this.grdMunicipios);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Location = new System.Drawing.Point(408, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(401, 204);
            this.panel7.TabIndex = 17;
            // 
            // grdMunicipios
            // 
            this.grdMunicipios.AllowUserToAddRows = false;
            this.grdMunicipios.AllowUserToDeleteRows = false;
            this.grdMunicipios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdMunicipios.BackgroundColor = System.Drawing.Color.White;
            this.grdMunicipios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMunicipios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoMunicipio,
            this.ID_MUNICIPIO,
            this.ID_DEPARTAMENTO_M,
            this.MUNICIPIO});
            this.grdMunicipios.Location = new System.Drawing.Point(7, 98);
            this.grdMunicipios.MultiSelect = false;
            this.grdMunicipios.Name = "grdMunicipios";
            this.grdMunicipios.ReadOnly = true;
            this.grdMunicipios.RowHeadersVisible = false;
            this.grdMunicipios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMunicipios.Size = new System.Drawing.Size(383, 97);
            this.grdMunicipios.TabIndex = 12;
            this.grdMunicipios.SelectionChanged += new System.EventHandler(this.grdMunicipios_SelectionChanged);
            // 
            // NoMunicipio
            // 
            this.NoMunicipio.HeaderText = "No.";
            this.NoMunicipio.Name = "NoMunicipio";
            this.NoMunicipio.ReadOnly = true;
            this.NoMunicipio.Width = 50;
            // 
            // ID_MUNICIPIO
            // 
            this.ID_MUNICIPIO.HeaderText = "ID_MUNICIPIO";
            this.ID_MUNICIPIO.Name = "ID_MUNICIPIO";
            this.ID_MUNICIPIO.ReadOnly = true;
            this.ID_MUNICIPIO.Visible = false;
            // 
            // ID_DEPARTAMENTO_M
            // 
            this.ID_DEPARTAMENTO_M.HeaderText = "ID_DEPARTAMENTO";
            this.ID_DEPARTAMENTO_M.Name = "ID_DEPARTAMENTO_M";
            this.ID_DEPARTAMENTO_M.ReadOnly = true;
            this.ID_DEPARTAMENTO_M.Visible = false;
            // 
            // MUNICIPIO
            // 
            this.MUNICIPIO.HeaderText = "MUNICIPIO";
            this.MUNICIPIO.Name = "MUNICIPIO";
            this.MUNICIPIO.ReadOnly = true;
            this.MUNICIPIO.Width = 320;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::Controles.Properties.Resources.fondoTitulo;
            this.panel9.Controls.Add(this.label3);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(399, 28);
            this.panel9.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(4, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Municipios:";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.BackgroundImage = global::Controles.Properties.Resources.fondoWindow;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.ctrBuscarDepto);
            this.panel6.Controls.Add(this.grdDepartamentos);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Location = new System.Drawing.Point(1, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(403, 204);
            this.panel6.TabIndex = 16;
            // 
            // grdDepartamentos
            // 
            this.grdDepartamentos.AllowUserToAddRows = false;
            this.grdDepartamentos.AllowUserToDeleteRows = false;
            this.grdDepartamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDepartamentos.BackgroundColor = System.Drawing.Color.White;
            this.grdDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ID_DEPARTAMENTO,
            this.DEPARTAMENTO});
            this.grdDepartamentos.Location = new System.Drawing.Point(9, 98);
            this.grdDepartamentos.MultiSelect = false;
            this.grdDepartamentos.Name = "grdDepartamentos";
            this.grdDepartamentos.ReadOnly = true;
            this.grdDepartamentos.RowHeadersVisible = false;
            this.grdDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDepartamentos.Size = new System.Drawing.Size(385, 97);
            this.grdDepartamentos.TabIndex = 12;
            this.grdDepartamentos.SelectionChanged += new System.EventHandler(this.grdDepartamentos_SelectionChanged_1);
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 50;
            // 
            // ID_DEPARTAMENTO
            // 
            this.ID_DEPARTAMENTO.HeaderText = "ID_DEPARTAMENTO";
            this.ID_DEPARTAMENTO.Name = "ID_DEPARTAMENTO";
            this.ID_DEPARTAMENTO.ReadOnly = true;
            this.ID_DEPARTAMENTO.Visible = false;
            // 
            // DEPARTAMENTO
            // 
            this.DEPARTAMENTO.HeaderText = "DEPARTAMENTO";
            this.DEPARTAMENTO.Name = "DEPARTAMENTO";
            this.DEPARTAMENTO.ReadOnly = true;
            this.DEPARTAMENTO.Width = 320;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Controles.Properties.Resources.fondoTitulo;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(401, 28);
            this.panel5.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Departamentos:";
            // 
            // ctrBuscarMunicipio
            // 
            this.ctrBuscarMunicipio.BackColor = System.Drawing.Color.Transparent;
            this.ctrBuscarMunicipio.Location = new System.Drawing.Point(8, 34);
            this.ctrBuscarMunicipio.Name = "ctrBuscarMunicipio";
            this.ctrBuscarMunicipio.Size = new System.Drawing.Size(361, 58);
            this.ctrBuscarMunicipio.TabIndex = 13;
            // 
            // ctrBuscarDepto
            // 
            this.ctrBuscarDepto.BackColor = System.Drawing.Color.Transparent;
            this.ctrBuscarDepto.Location = new System.Drawing.Point(9, 34);
            this.ctrBuscarDepto.Name = "ctrBuscarDepto";
            this.ctrBuscarDepto.Size = new System.Drawing.Size(361, 58);
            this.ctrBuscarDepto.TabIndex = 13;
            // 
            // ctrMunicipios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panFondo);
            this.Name = "ctrMunicipios";
            this.Size = new System.Drawing.Size(810, 206);
            this.panFondo.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMunicipios)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartamentos)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panFondo;
        private System.Windows.Forms.Panel panel7;
        private ctrBuscar ctrBuscarMunicipio;
        private System.Windows.Forms.DataGridView grdMunicipios;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MUNICIPIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DEPARTAMENTO_M;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUNICIPIO;
        private System.Windows.Forms.Panel panel9;
        protected System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private ctrBuscar ctrBuscarDepto;
        private System.Windows.Forms.DataGridView grdDepartamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DEPARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTAMENTO;
        private System.Windows.Forms.Panel panel5;
        protected System.Windows.Forms.Label label2;
    }
}
