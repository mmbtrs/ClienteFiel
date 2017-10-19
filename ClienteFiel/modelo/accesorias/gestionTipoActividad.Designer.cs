namespace ClienteFiel.modelo.accesorias
{
    partial class gestionTipoActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestionTipoActividad));
            this.ctrBuscar1 = new Controles.ctrBuscar();
            this.grdTiposActividad = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TIPO_ACTIVIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_DE_ACTIVIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTiposActividad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(717, 70);
            // 
            // picLogoVentana
            // 
            this.picLogoVentana.Image = global::ClienteFiel.Properties.Resources.tipoActividad;
            this.picLogoVentana.Location = new System.Drawing.Point(8, 0);
            this.picLogoVentana.Size = new System.Drawing.Size(68, 71);
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.Size = new System.Drawing.Size(314, 29);
            this.lblTituloVentana.Text = "Gestión Tipo de Actividad";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(354, 98);
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
            this.ctrBuscar1.TabIndex = 2;
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
            this.TIPO_DE_ACTIVIDAD});
            this.grdTiposActividad.Location = new System.Drawing.Point(8, 141);
            this.grdTiposActividad.MultiSelect = false;
            this.grdTiposActividad.Name = "grdTiposActividad";
            this.grdTiposActividad.ReadOnly = true;
            this.grdTiposActividad.RowHeadersVisible = false;
            this.grdTiposActividad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTiposActividad.Size = new System.Drawing.Size(700, 305);
            this.grdTiposActividad.TabIndex = 12;
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
            // TIPO_DE_ACTIVIDAD
            // 
            this.TIPO_DE_ACTIVIDAD.HeaderText = "TIPO DE ACTIVIDAD";
            this.TIPO_DE_ACTIVIDAD.Name = "TIPO_DE_ACTIVIDAD";
            this.TIPO_DE_ACTIVIDAD.ReadOnly = true;
            this.TIPO_DE_ACTIVIDAD.Width = 650;
            // 
            // gestionTipoActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 454);
            this.Controls.Add(this.grdTiposActividad);
            this.Controls.Add(this.ctrBuscar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gestionTipoActividad";
            this.Text = "Gestión Tipo Actividad";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.ctrBuscar1, 0);
            this.Controls.SetChildIndex(this.grdTiposActividad, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTiposActividad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.ctrBuscar ctrBuscar1;
        private System.Windows.Forms.DataGridView grdTiposActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TIPO_ACTIVIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_DE_ACTIVIDAD;
    }
}