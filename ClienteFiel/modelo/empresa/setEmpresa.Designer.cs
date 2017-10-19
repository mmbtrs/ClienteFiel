namespace ClienteFiel.modelo.empresa
{
    partial class setEmpresa
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
            this.txtNit = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.radOtra = new System.Windows.Forms.RadioButton();
            this.radPrincipal = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSlogan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.ctrLogo = new Controles.ctrImagen();
            this.ctrMunicipio = new Controles.ctrMunicipios();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(836, 70);
            // 
            // picLogoVentana
            // 
            this.picLogoVentana.Image = global::ClienteFiel.Properties.Resources.empresaa;
            this.picLogoVentana.Location = new System.Drawing.Point(774, 7);
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.AutoSize = false;
            this.lblTituloVentana.Size = new System.Drawing.Size(699, 29);
            this.lblTituloVentana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Location = new System.Drawing.Point(146, 510);
            this.panel2.Size = new System.Drawing.Size(423, 37);
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
            // txtNit
            // 
            this.txtNit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNit.Location = new System.Drawing.Point(117, 78);
            this.txtNit.MaxLength = 20;
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(180, 24);
            this.txtNit.TabIndex = 19;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(10, 111);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(101, 18);
            this.lblFiltro.TabIndex = 21;
            this.lblFiltro.Text = "Razón Social:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(117, 108);
            this.txtRazonSocial.MaxLength = 500;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(462, 24);
            this.txtRazonSocial.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(303, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Completo sin guines ni comas";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.ctrLogo);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(13, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 151);
            this.panel3.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Logo:";
            // 
            // txtSucursal
            // 
            this.txtSucursal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSucursal.Enabled = false;
            this.txtSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSucursal.Location = new System.Drawing.Point(429, 476);
            this.txtSucursal.MaxLength = 100;
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(205, 24);
            this.txtSucursal.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(369, 479);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 18);
            this.label10.TabIndex = 42;
            this.label10.Text = "¿Cual?:";
            // 
            // radOtra
            // 
            this.radOtra.AutoSize = true;
            this.radOtra.BackColor = System.Drawing.Color.Transparent;
            this.radOtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.radOtra.Location = new System.Drawing.Point(534, 454);
            this.radOtra.Name = "radOtra";
            this.radOtra.Size = new System.Drawing.Size(55, 22);
            this.radOtra.TabIndex = 36;
            this.radOtra.Text = "Otra";
            this.radOtra.UseVisualStyleBackColor = false;
            this.radOtra.CheckedChanged += new System.EventHandler(this.radOtra_CheckedChanged);
            // 
            // radPrincipal
            // 
            this.radPrincipal.AutoSize = true;
            this.radPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.radPrincipal.Checked = true;
            this.radPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.radPrincipal.Location = new System.Drawing.Point(433, 454);
            this.radPrincipal.Name = "radPrincipal";
            this.radPrincipal.Size = new System.Drawing.Size(82, 22);
            this.radPrincipal.TabIndex = 35;
            this.radPrincipal.TabStop = true;
            this.radPrincipal.Text = "Principal";
            this.radPrincipal.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(357, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 18);
            this.label9.TabIndex = 41;
            this.label9.Text = "Sucursal:";
            // 
            // txtSlogan
            // 
            this.txtSlogan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSlogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlogan.Location = new System.Drawing.Point(429, 414);
            this.txtSlogan.MaxLength = 500;
            this.txtSlogan.Name = "txtSlogan";
            this.txtSlogan.Size = new System.Drawing.Size(374, 24);
            this.txtSlogan.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(369, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 40;
            this.label8.Text = "Slogan:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(352, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 38;
            this.label6.Text = "Dirección:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(429, 384);
            this.txtTelefono.MaxLength = 100;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(205, 24);
            this.txtTelefono.TabIndex = 33;
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(429, 354);
            this.txtDireccion.MaxLength = 300;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(302, 24);
            this.txtDireccion.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(357, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "Teléfono:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Image = global::ClienteFiel.Properties.Resources.flopy24x24;
            this.btnGuardar.Location = new System.Drawing.Point(129, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(143, 31);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar Información";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ctrLogo
            // 
            this.ctrLogo.BackColor = System.Drawing.Color.Transparent;
            this.ctrLogo.Location = new System.Drawing.Point(56, 9);
            this.ctrLogo.Name = "ctrLogo";
            this.ctrLogo.Size = new System.Drawing.Size(238, 140);
            this.ctrLogo.TabIndex = 25;
            // 
            // ctrMunicipio
            // 
            this.ctrMunicipio.BackColor = System.Drawing.Color.Transparent;
            this.ctrMunicipio.Location = new System.Drawing.Point(14, 138);
            this.ctrMunicipio.Name = "ctrMunicipio";
            this.ctrMunicipio.Size = new System.Drawing.Size(810, 205);
            this.ctrMunicipio.TabIndex = 24;
            // 
            // setEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 555);
            this.Controls.Add(this.txtSucursal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radOtra);
            this.Controls.Add(this.radPrincipal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSlogan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ctrMunicipio);
            this.Controls.Add(this.txtNit);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "setEmpresa";
            this.Text = "Gestión Empresa";
            this.Load += new System.EventHandler(this.setEmpresa_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtRazonSocial, 0);
            this.Controls.SetChildIndex(this.lblFiltro, 0);
            this.Controls.SetChildIndex(this.txtNit, 0);
            this.Controls.SetChildIndex(this.ctrMunicipio, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtDireccion, 0);
            this.Controls.SetChildIndex(this.txtTelefono, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtSlogan, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.radPrincipal, 0);
            this.Controls.SetChildIndex(this.radOtra, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtSucursal, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox txtNit;
        protected System.Windows.Forms.Label lblFiltro;
        protected System.Windows.Forms.TextBox txtRazonSocial;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        private Controles.ctrMunicipios ctrMunicipio;
        private Controles.ctrImagen ctrLogo;
        private System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox txtSucursal;
        protected System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radOtra;
        private System.Windows.Forms.RadioButton radPrincipal;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.TextBox txtSlogan;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.TextBox txtTelefono;
        protected System.Windows.Forms.TextBox txtDireccion;
        protected System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardar;
    }
}