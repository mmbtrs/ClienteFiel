namespace ClienteFiel.modulos.accesorias
{
    partial class GestionMunicipio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.grdMunicipios = new System.Windows.Forms.DataGridView();
            this.NoMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_MUNICIPIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_DEPARTAMENTO_M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_MUNICIPIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnEliminarM = new System.Windows.Forms.Button();
            this.btnInsertarM = new System.Windows.Forms.Button();
            this.btnEditarM = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbColumnaMunicipio = new System.Windows.Forms.ComboBox();
            this.txtFiltroMunicipio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.grdDepartamentos = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminarD = new System.Windows.Forms.Button();
            this.btnInsertarD = new System.Windows.Forms.Button();
            this.btnEditarD = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbColumnaDepto = new System.Windows.Forms.ComboBox();
            this.txtFiltroDpto = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTituloVentana = new System.Windows.Forms.Label();
            this.picLogoVentana = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMunicipios)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartamentos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ClienteFiel.Properties.Resources.fondo1;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 519);
            this.panel1.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::ClienteFiel.Properties.Resources.exit24x24;
            this.btnSalir.Location = new System.Drawing.Point(350, 482);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(142, 32);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::ClienteFiel.Properties.Resources.fondo1;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.grdMunicipios);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.cmbColumnaMunicipio);
            this.panel7.Controls.Add(this.txtFiltroMunicipio);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Location = new System.Drawing.Point(428, 121);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(403, 358);
            this.panel7.TabIndex = 13;
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
            this.NOM_MUNICIPIO});
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
            // NOM_MUNICIPIO
            // 
            this.NOM_MUNICIPIO.HeaderText = "MUNICIPIO";
            this.NOM_MUNICIPIO.Name = "NOM_MUNICIPIO";
            this.NOM_MUNICIPIO.ReadOnly = true;
            this.NOM_MUNICIPIO.Width = 320;
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
            this.panel9.BackgroundImage = global::ClienteFiel.Properties.Resources.fondo2;
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
            // cmbColumnaMunicipio
            // 
            this.cmbColumnaMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColumnaMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColumnaMunicipio.FormattingEnabled = true;
            this.cmbColumnaMunicipio.Items.AddRange(new object[] {
            "MUNICIPIO"});
            this.cmbColumnaMunicipio.Location = new System.Drawing.Point(85, 35);
            this.cmbColumnaMunicipio.Name = "cmbColumnaMunicipio";
            this.cmbColumnaMunicipio.Size = new System.Drawing.Size(186, 26);
            this.cmbColumnaMunicipio.TabIndex = 10;
            // 
            // txtFiltroMunicipio
            // 
            this.txtFiltroMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltroMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroMunicipio.Location = new System.Drawing.Point(85, 66);
            this.txtFiltroMunicipio.Name = "txtFiltroMunicipio";
            this.txtFiltroMunicipio.Size = new System.Drawing.Size(256, 24);
            this.txtFiltroMunicipio.TabIndex = 6;
            this.txtFiltroMunicipio.TextChanged += new System.EventHandler(this.txtFiltroMunicipio_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Buscar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Columna:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ClienteFiel.Properties.Resources.buscar2;
            this.pictureBox1.Location = new System.Drawing.Point(344, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::ClienteFiel.Properties.Resources.fondo1;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.grdDepartamentos);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.cmbColumnaDepto);
            this.panel6.Controls.Add(this.txtFiltroDpto);
            this.panel6.Controls.Add(this.lblFiltro);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.picBuscar);
            this.panel6.Location = new System.Drawing.Point(11, 121);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(403, 358);
            this.panel6.TabIndex = 12;
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
            // NOM_DEPARTAMENTO
            // 
            this.NOM_DEPARTAMENTO.HeaderText = "DEPARTAMENTO";
            this.NOM_DEPARTAMENTO.Name = "NOM_DEPARTAMENTO";
            this.NOM_DEPARTAMENTO.ReadOnly = true;
            this.NOM_DEPARTAMENTO.Width = 320;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnEliminarD);
            this.panel2.Controls.Add(this.btnInsertarD);
            this.panel2.Controls.Add(this.btnEditarD);
            this.panel2.Location = new System.Drawing.Point(27, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 53);
            this.panel2.TabIndex = 5;
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
            this.panel5.BackgroundImage = global::ClienteFiel.Properties.Resources.fondo2;
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
            // cmbColumnaDepto
            // 
            this.cmbColumnaDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColumnaDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColumnaDepto.FormattingEnabled = true;
            this.cmbColumnaDepto.Items.AddRange(new object[] {
            "DEPARTAMENTO"});
            this.cmbColumnaDepto.Location = new System.Drawing.Point(85, 35);
            this.cmbColumnaDepto.Name = "cmbColumnaDepto";
            this.cmbColumnaDepto.Size = new System.Drawing.Size(186, 26);
            this.cmbColumnaDepto.TabIndex = 10;
            // 
            // txtFiltroDpto
            // 
            this.txtFiltroDpto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltroDpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroDpto.Location = new System.Drawing.Point(85, 66);
            this.txtFiltroDpto.Name = "txtFiltroDpto";
            this.txtFiltroDpto.Size = new System.Drawing.Size(256, 24);
            this.txtFiltroDpto.TabIndex = 6;
            this.txtFiltroDpto.TextChanged += new System.EventHandler(this.txtFiltroDpto_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(19, 69);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(59, 18);
            this.lblFiltro.TabIndex = 7;
            this.lblFiltro.Text = "Buscar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Columna:";
            // 
            // picBuscar
            // 
            this.picBuscar.BackColor = System.Drawing.Color.Transparent;
            this.picBuscar.Image = global::ClienteFiel.Properties.Resources.buscar2;
            this.picBuscar.Location = new System.Drawing.Point(344, 62);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(26, 27);
            this.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBuscar.TabIndex = 8;
            this.picBuscar.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ClienteFiel.Properties.Resources.fondoTitulo1;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblTituloVentana);
            this.panel3.Controls.Add(this.picLogoVentana);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(841, 82);
            this.panel3.TabIndex = 2;
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.AutoSize = true;
            this.lblTituloVentana.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVentana.ForeColor = System.Drawing.Color.White;
            this.lblTituloVentana.Location = new System.Drawing.Point(533, 48);
            this.lblTituloVentana.Name = "lblTituloVentana";
            this.lblTituloVentana.Size = new System.Drawing.Size(223, 29);
            this.lblTituloVentana.TabIndex = 1;
            this.lblTituloVentana.Text = "Gestión Municipio";
            // 
            // picLogoVentana
            // 
            this.picLogoVentana.BackColor = System.Drawing.Color.Transparent;
            this.picLogoVentana.Image = global::ClienteFiel.Properties.Resources.mapa_cauca;
            this.picLogoVentana.Location = new System.Drawing.Point(751, 3);
            this.picLogoVentana.Name = "picLogoVentana";
            this.picLogoVentana.Size = new System.Drawing.Size(85, 74);
            this.picLogoVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoVentana.TabIndex = 0;
            this.picLogoVentana.TabStop = false;
            // 
            // GestionMunicipio
            // 
            this.ClientSize = new System.Drawing.Size(843, 519);
            this.Controls.Add(this.panel1);
            this.Name = "GestionMunicipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Municipio";
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMunicipios)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartamentos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        protected System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        protected System.Windows.Forms.ComboBox cmbColumnaDepto;
        protected System.Windows.Forms.TextBox txtFiltroDpto;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.PictureBox picBuscar;
        protected System.Windows.Forms.Label lblFiltro;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Button btnEliminarD;
        protected System.Windows.Forms.Button btnInsertarD;
        protected System.Windows.Forms.Button btnEditarD;
        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Label lblTituloVentana;
        protected System.Windows.Forms.PictureBox picLogoVentana;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView grdMunicipios;
        protected System.Windows.Forms.Panel panel8;
        protected System.Windows.Forms.Button btnEliminarM;
        protected System.Windows.Forms.Button btnInsertarM;
        protected System.Windows.Forms.Button btnEditarM;
        private System.Windows.Forms.Panel panel9;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.ComboBox cmbColumnaMunicipio;
        protected System.Windows.Forms.TextBox txtFiltroMunicipio;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView grdDepartamentos;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DEPARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_DEPARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MUNICIPIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DEPARTAMENTO_M;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_MUNICIPIO;
        private System.Windows.Forms.Button btnSalir;
    }
}