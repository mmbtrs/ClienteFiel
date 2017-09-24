namespace ClienteFiel.modulos.errores
{
    partial class GestionErrores
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
            this.grdErrores = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_ERROR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ERROR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MENSAJE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdErrores);
            this.panel1.Size = new System.Drawing.Size(1163, 482);
            this.panel1.Controls.SetChildIndex(this.panel3, 0);
            this.panel1.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.Controls.SetChildIndex(this.lblFiltro, 0);
            this.panel1.Controls.SetChildIndex(this.picBuscar, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.txtFiltro, 0);
            this.panel1.Controls.SetChildIndex(this.cmbColumna, 0);
            this.panel1.Controls.SetChildIndex(this.grdErrores, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(804, 113);
            this.panel2.Size = new System.Drawing.Size(346, 53);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1161, 104);
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.Location = new System.Drawing.Point(280, 48);
            this.lblTituloVentana.Size = new System.Drawing.Size(241, 42);
            this.lblTituloVentana.Text = "Gestión de Errores";
            // 
            // picLogoVentana
            // 
            this.picLogoVentana.Image = global::ClienteFiel.Properties.Resources.error404;
            this.picLogoVentana.Location = new System.Drawing.Point(134, 10);
            this.picLogoVentana.Size = new System.Drawing.Size(140, 87);
            // 
            // txtFiltro
            // 
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // cmbColumna
            // 
            this.cmbColumna.Items.AddRange(new object[] {
            "ERROR",
            "MENSAJE",
            "SOLUCION"});
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(7, 18);
            this.btnInsertar.Size = new System.Drawing.Size(107, 31);
            this.btnInsertar.Text = "Insertar Error";
            this.btnInsertar.Visible = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(120, 18);
            this.btnEditar.Size = new System.Drawing.Size(106, 31);
            this.btnEditar.Text = "Editar Error";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(232, 19);
            this.btnEliminar.Size = new System.Drawing.Size(111, 31);
            this.btnEliminar.Text = "Eliminar Error";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // grdErrores
            // 
            this.grdErrores.AllowUserToAddRows = false;
            this.grdErrores.AllowUserToDeleteRows = false;
            this.grdErrores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdErrores.BackgroundColor = System.Drawing.Color.White;
            this.grdErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdErrores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ID_ERROR,
            this.ERROR,
            this.MENSAJE,
            this.SOLUCION});
            this.grdErrores.Location = new System.Drawing.Point(12, 171);
            this.grdErrores.Name = "grdErrores";
            this.grdErrores.ReadOnly = true;
            this.grdErrores.RowHeadersVisible = false;
            this.grdErrores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdErrores.Size = new System.Drawing.Size(1138, 298);
            this.grdErrores.TabIndex = 11;
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 70;
            // 
            // ID_ERROR
            // 
            this.ID_ERROR.HeaderText = "ID_ERROR";
            this.ID_ERROR.Name = "ID_ERROR";
            this.ID_ERROR.ReadOnly = true;
            this.ID_ERROR.Visible = false;
            // 
            // ERROR
            // 
            this.ERROR.HeaderText = "ERROR";
            this.ERROR.Name = "ERROR";
            this.ERROR.ReadOnly = true;
            this.ERROR.Width = 350;
            // 
            // MENSAJE
            // 
            this.MENSAJE.HeaderText = "MENSAJE";
            this.MENSAJE.Name = "MENSAJE";
            this.MENSAJE.ReadOnly = true;
            this.MENSAJE.Width = 350;
            // 
            // SOLUCION
            // 
            this.SOLUCION.HeaderText = "SOLUCION";
            this.SOLUCION.Name = "SOLUCION";
            this.SOLUCION.ReadOnly = true;
            this.SOLUCION.Width = 350;
            // 
            // GestionErrores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 482);
            this.Name = "GestionErrores";
            this.Text = "Gestión de Errores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdErrores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdErrores;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ERROR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ERROR;
        private System.Windows.Forms.DataGridViewTextBoxColumn MENSAJE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUCION;
    }
}