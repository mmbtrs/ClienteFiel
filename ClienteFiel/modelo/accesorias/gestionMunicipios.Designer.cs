namespace ClienteFiel.modelo.accesorias
{
    partial class gestionMunicipios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestionMunicipios));
            this.panel6 = new System.Windows.Forms.Panel();
            this.ctrBuscarDepto = new Controles.ctrBuscar();
            this.grdDepartamentos = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEliminarD = new System.Windows.Forms.Button();
            this.btnInsertarD = new System.Windows.Forms.Button();
            this.btnEditarD = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ctrBuscarMunicipio = new Controles.ctrBuscar();
            this.grdMunicipios = new System.Windows.Forms.DataGridView();
            this.NoMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_MUNICIPIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_DEPARTAMENTO_M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUNICIPIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnEliminarM = new System.Windows.Forms.Button();
            this.btnInsertarM = new System.Windows.Forms.Button();
            this.btnEditarM = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartamentos)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMunicipios)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(827, 70);
            // 
            // picLogoVentana
            // 
            this.picLogoVentana.Image = global::ClienteFiel.Properties.Resources.municipio;
            this.picLogoVentana.Location = new System.Drawing.Point(9, 7);
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.Location = new System.Drawing.Point(60, 35);
            this.lblTituloVentana.Size = new System.Drawing.Size(273, 29);
            this.lblTituloVentana.Text = "Gestión de Municipios";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(65, 443);
            this.panel2.Size = new System.Drawing.Size(422, 37);
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
            // panel6
            // 
            this.panel6.BackgroundImage = global::ClienteFiel.Properties.Resources.fondoWindow;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.ctrBuscarDepto);
            this.panel6.Controls.Add(this.grdDepartamentos);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Location = new System.Drawing.Point(8, 79);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(403, 358);
            this.panel6.TabIndex = 13;
            // 
            // ctrBuscarDepto
            // 
            this.ctrBuscarDepto.BackColor = System.Drawing.Color.Transparent;
            this.ctrBuscarDepto.Location = new System.Drawing.Point(9, 34);
            this.ctrBuscarDepto.Name = "ctrBuscarDepto";
            this.ctrBuscarDepto.Size = new System.Drawing.Size(361, 58);
            this.ctrBuscarDepto.TabIndex = 13;
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
            this.DEPARTAMENTO});
            this.grdDepartamentos.Location = new System.Drawing.Point(8, 151);
            this.grdDepartamentos.Name = "grdDepartamentos";
            this.grdDepartamentos.ReadOnly = true;
            this.grdDepartamentos.RowHeadersVisible = false;
            this.grdDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDepartamentos.Size = new System.Drawing.Size(385, 197);
            this.grdDepartamentos.TabIndex = 12;
            this.grdDepartamentos.SelectionChanged += new System.EventHandler(this.grdDepartamentos_SelectionChanged);
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
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnEliminarD);
            this.panel3.Controls.Add(this.btnInsertarD);
            this.panel3.Controls.Add(this.btnEditarD);
            this.panel3.Location = new System.Drawing.Point(27, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 53);
            this.panel3.TabIndex = 5;
            // 
            // btnEliminarD
            // 
            this.btnEliminarD.Image = global::ClienteFiel.Properties.Resources.del24x24;
            this.btnEliminarD.Location = new System.Drawing.Point(233, 3);
            this.btnEliminarD.Name = "btnEliminarD";
            this.btnEliminarD.Size = new System.Drawing.Size(107, 47);
            this.btnEliminarD.TabIndex = 13;
            this.btnEliminarD.Text = "Eliminar Departamento";
            this.btnEliminarD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarD.UseVisualStyleBackColor = true;
            this.btnEliminarD.Click += new System.EventHandler(this.btnEliminarD_Click);
            // 
            // btnInsertarD
            // 
            this.btnInsertarD.Image = global::ClienteFiel.Properties.Resources.insertHoja24x24;
            this.btnInsertarD.Location = new System.Drawing.Point(3, 3);
            this.btnInsertarD.Name = "btnInsertarD";
            this.btnInsertarD.Size = new System.Drawing.Size(107, 47);
            this.btnInsertarD.TabIndex = 11;
            this.btnInsertarD.Text = "Insertar Departamento";
            this.btnInsertarD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertarD.UseVisualStyleBackColor = true;
            this.btnInsertarD.Click += new System.EventHandler(this.btnInsertarD_Click);
            // 
            // btnEditarD
            // 
            this.btnEditarD.Image = global::ClienteFiel.Properties.Resources.edit24x24;
            this.btnEditarD.Location = new System.Drawing.Point(116, 3);
            this.btnEditarD.Name = "btnEditarD";
            this.btnEditarD.Size = new System.Drawing.Size(111, 47);
            this.btnEditarD.TabIndex = 12;
            this.btnEditarD.Text = "Editar Departamento";
            this.btnEditarD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarD.UseVisualStyleBackColor = true;
            this.btnEditarD.Click += new System.EventHandler(this.btnEditarD_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::ClienteFiel.Properties.Resources.fondoTitulo;
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
            // panel7
            // 
            this.panel7.BackgroundImage = global::ClienteFiel.Properties.Resources.fondoWindow;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.ctrBuscarMunicipio);
            this.panel7.Controls.Add(this.grdMunicipios);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Location = new System.Drawing.Point(417, 79);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(403, 358);
            this.panel7.TabIndex = 14;
            // 
            // ctrBuscarMunicipio
            // 
            this.ctrBuscarMunicipio.BackColor = System.Drawing.Color.Transparent;
            this.ctrBuscarMunicipio.Location = new System.Drawing.Point(8, 34);
            this.ctrBuscarMunicipio.Name = "ctrBuscarMunicipio";
            this.ctrBuscarMunicipio.Size = new System.Drawing.Size(361, 58);
            this.ctrBuscarMunicipio.TabIndex = 13;
            // 
            // grdMunicipios
            // 
            this.grdMunicipios.AllowUserToAddRows = false;
            this.grdMunicipios.AllowUserToDeleteRows = false;
            this.grdMunicipios.BackgroundColor = System.Drawing.Color.White;
            this.grdMunicipios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMunicipios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoMunicipio,
            this.ID_MUNICIPIO,
            this.ID_DEPARTAMENTO_M,
            this.MUNICIPIO});
            this.grdMunicipios.Location = new System.Drawing.Point(8, 151);
            this.grdMunicipios.Name = "grdMunicipios";
            this.grdMunicipios.ReadOnly = true;
            this.grdMunicipios.RowHeadersVisible = false;
            this.grdMunicipios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMunicipios.Size = new System.Drawing.Size(385, 197);
            this.grdMunicipios.TabIndex = 12;
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
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.btnEliminarM);
            this.panel8.Controls.Add(this.btnInsertarM);
            this.panel8.Controls.Add(this.btnEditarM);
            this.panel8.Location = new System.Drawing.Point(27, 95);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(343, 53);
            this.panel8.TabIndex = 5;
            // 
            // btnEliminarM
            // 
            this.btnEliminarM.Image = global::ClienteFiel.Properties.Resources.del24x24;
            this.btnEliminarM.Location = new System.Drawing.Point(233, 3);
            this.btnEliminarM.Name = "btnEliminarM";
            this.btnEliminarM.Size = new System.Drawing.Size(107, 47);
            this.btnEliminarM.TabIndex = 13;
            this.btnEliminarM.Text = "Eliminar Municipio";
            this.btnEliminarM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarM.UseVisualStyleBackColor = true;
            this.btnEliminarM.Click += new System.EventHandler(this.btnEliminarM_Click);
            // 
            // btnInsertarM
            // 
            this.btnInsertarM.Image = global::ClienteFiel.Properties.Resources.insertHoja24x24;
            this.btnInsertarM.Location = new System.Drawing.Point(3, 3);
            this.btnInsertarM.Name = "btnInsertarM";
            this.btnInsertarM.Size = new System.Drawing.Size(107, 47);
            this.btnInsertarM.TabIndex = 11;
            this.btnInsertarM.Text = "Insertar Municipio";
            this.btnInsertarM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertarM.UseVisualStyleBackColor = true;
            this.btnInsertarM.Click += new System.EventHandler(this.btnInsertarM_Click);
            // 
            // btnEditarM
            // 
            this.btnEditarM.Image = global::ClienteFiel.Properties.Resources.edit24x24;
            this.btnEditarM.Location = new System.Drawing.Point(116, 3);
            this.btnEditarM.Name = "btnEditarM";
            this.btnEditarM.Size = new System.Drawing.Size(111, 47);
            this.btnEditarM.TabIndex = 12;
            this.btnEditarM.Text = "Editar Municipio";
            this.btnEditarM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarM.UseVisualStyleBackColor = true;
            this.btnEditarM.Click += new System.EventHandler(this.btnEditarM_Click);
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::ClienteFiel.Properties.Resources.fondoTitulo;
            this.panel9.Controls.Add(this.label3);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(401, 28);
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
            // gestionMunicipios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 484);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gestionMunicipios";
            this.Text = "Gestión Municipios";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.Controls.SetChildIndex(this.panel7, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartamentos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMunicipios)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private Controles.ctrBuscar ctrBuscarDepto;
        private System.Windows.Forms.DataGridView grdDepartamentos;
        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Button btnEliminarD;
        protected System.Windows.Forms.Button btnInsertarD;
        protected System.Windows.Forms.Button btnEditarD;
        private System.Windows.Forms.Panel panel5;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private Controles.ctrBuscar ctrBuscarMunicipio;
        private System.Windows.Forms.DataGridView grdMunicipios;
        protected System.Windows.Forms.Panel panel8;
        protected System.Windows.Forms.Button btnEliminarM;
        protected System.Windows.Forms.Button btnInsertarM;
        protected System.Windows.Forms.Button btnEditarM;
        private System.Windows.Forms.Panel panel9;
        protected System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DEPARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MUNICIPIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DEPARTAMENTO_M;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUNICIPIO;
    }
}