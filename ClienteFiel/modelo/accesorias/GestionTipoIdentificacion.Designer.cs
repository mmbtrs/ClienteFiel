namespace ClienteFiel.modelo.accesorias
{
    partial class gestionTipoIdentificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestionTipoIdentificacion));
            this.ctrBuscar1 = new Controles.ctrBuscar();
            this.grdTipoIdentificacion = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TIPO_IDENTIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_DE_IDENTIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoIdentificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(729, 70);
            // 
            // picLogoVentana
            // 
            this.picLogoVentana.Image = global::ClienteFiel.Properties.Resources.identificacion;
            this.picLogoVentana.Location = new System.Drawing.Point(8, -1);
            this.picLogoVentana.Size = new System.Drawing.Size(77, 72);
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.Location = new System.Drawing.Point(84, 35);
            this.lblTituloVentana.Size = new System.Drawing.Size(266, 29);
            this.lblTituloVentana.Text = "Tipo de Identificación";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(368, 97);
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
            this.ctrBuscar1.Location = new System.Drawing.Point(8, 76);
            this.ctrBuscar1.Name = "ctrBuscar1";
            this.ctrBuscar1.Size = new System.Drawing.Size(361, 58);
            this.ctrBuscar1.TabIndex = 2;
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
            this.TIPO_DE_IDENTIFICACION});
            this.grdTipoIdentificacion.Location = new System.Drawing.Point(8, 140);
            this.grdTipoIdentificacion.MultiSelect = false;
            this.grdTipoIdentificacion.Name = "grdTipoIdentificacion";
            this.grdTipoIdentificacion.ReadOnly = true;
            this.grdTipoIdentificacion.RowHeadersVisible = false;
            this.grdTipoIdentificacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTipoIdentificacion.Size = new System.Drawing.Size(714, 316);
            this.grdTipoIdentificacion.TabIndex = 12;
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
            // TIPO_DE_IDENTIFICACION
            // 
            this.TIPO_DE_IDENTIFICACION.HeaderText = "TIPO DE IDENTIFICACION";
            this.TIPO_DE_IDENTIFICACION.Name = "TIPO_DE_IDENTIFICACION";
            this.TIPO_DE_IDENTIFICACION.ReadOnly = true;
            this.TIPO_DE_IDENTIFICACION.Width = 650;
            // 
            // gestionTipoIdentificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 462);
            this.Controls.Add(this.grdTipoIdentificacion);
            this.Controls.Add(this.ctrBuscar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gestionTipoIdentificacion";
            this.Text = "Gestión Tipo Identificación";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.ctrBuscar1, 0);
            this.Controls.SetChildIndex(this.grdTipoIdentificacion, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoIdentificacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.ctrBuscar ctrBuscar1;
        private System.Windows.Forms.DataGridView grdTipoIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TIPO_IDENTIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_DE_IDENTIFICACION;
    }
}