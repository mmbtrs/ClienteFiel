namespace ClienteFiel.modelo.accesorias
{
    partial class setTipoRedSocial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setTipoRedSocial));
            this.txtNombreTipoRed = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.ctrLogo = new Controles.ctrImagen();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(369, 70);
            // 
            // picLogoVentana
            // 
            this.picLogoVentana.Image = global::ClienteFiel.Properties.Resources.redsocial;
            this.picLogoVentana.Location = new System.Drawing.Point(293, 6);
            this.picLogoVentana.Size = new System.Drawing.Size(70, 57);
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.AutoSize = false;
            this.lblTituloVentana.Location = new System.Drawing.Point(8, 35);
            this.lblTituloVentana.Size = new System.Drawing.Size(290, 29);
            this.lblTituloVentana.Text = "Nueva Red Social";
            this.lblTituloVentana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Location = new System.Drawing.Point(-94, 261);
            this.panel2.Size = new System.Drawing.Size(424, 37);
            this.panel2.Controls.SetChildIndex(this.btnEditar, 0);
            this.panel2.Controls.SetChildIndex(this.btnInsertar, 0);
            this.panel2.Controls.SetChildIndex(this.btnEliminar, 0);
            this.panel2.Controls.SetChildIndex(this.btnSalir, 0);
            this.panel2.Controls.SetChildIndex(this.btnGuardar, 0);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(278, 3);
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
            // txtNombreTipoRed
            // 
            this.txtNombreTipoRed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreTipoRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTipoRed.Location = new System.Drawing.Point(96, 83);
            this.txtNombreTipoRed.Name = "txtNombreTipoRed";
            this.txtNombreTipoRed.Size = new System.Drawing.Size(256, 24);
            this.txtNombreTipoRed.TabIndex = 13;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.Color.Black;
            this.lblFiltro.Location = new System.Drawing.Point(12, 89);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(84, 18);
            this.lblFiltro.TabIndex = 14;
            this.lblFiltro.Text = "Red Social:";
            // 
            // ctrLogo
            // 
            this.ctrLogo.BackColor = System.Drawing.Color.Transparent;
            this.ctrLogo.Location = new System.Drawing.Point(96, 113);
            this.ctrLogo.Name = "ctrLogo";
            this.ctrLogo.Size = new System.Drawing.Size(238, 140);
            this.ctrLogo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(50, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Logo:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Image = global::ClienteFiel.Properties.Resources.flopy24x24;
            this.btnGuardar.Location = new System.Drawing.Point(130, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(143, 31);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar Información";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // setTipoRedSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrLogo);
            this.Controls.Add(this.txtNombreTipoRed);
            this.Controls.Add(this.lblFiltro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "setTipoRedSocial";
            this.Text = "Gestión Tipo Red Social";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.lblFiltro, 0);
            this.Controls.SetChildIndex(this.txtNombreTipoRed, 0);
            this.Controls.SetChildIndex(this.ctrLogo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox txtNombreTipoRed;
        protected System.Windows.Forms.Label lblFiltro;
        private Controles.ctrImagen ctrLogo;
        private System.Windows.Forms.Button btnGuardar;
        protected System.Windows.Forms.Label label1;
    }
}