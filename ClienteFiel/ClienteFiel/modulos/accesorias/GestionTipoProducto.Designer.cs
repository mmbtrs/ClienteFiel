namespace ClienteFiel.modulos.accesorias
{
    partial class GestionTipoProducto
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
            this.grdTipoProducto = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TIPO_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_TIPO_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdTipoProducto);
            this.panel1.Size = new System.Drawing.Size(729, 492);
            this.panel1.Controls.SetChildIndex(this.panel3, 0);
            this.panel1.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.Controls.SetChildIndex(this.lblFiltro, 0);
            this.panel1.Controls.SetChildIndex(this.picBuscar, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.txtFiltro, 0);
            this.panel1.Controls.SetChildIndex(this.cmbColumna, 0);
            this.panel1.Controls.SetChildIndex(this.grdTipoProducto, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(383, 95);
            this.panel2.Size = new System.Drawing.Size(333, 53);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(727, 82);
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.Location = new System.Drawing.Point(267, 48);
            this.lblTituloVentana.Size = new System.Drawing.Size(326, 29);
            this.lblTituloVentana.Text = "Gestión Tipo de Productos";
            // 
            // picLogoVentana
            // 
            this.picLogoVentana.Image = global::ClienteFiel.Properties.Resources.tipos_de_productos;
            this.picLogoVentana.Location = new System.Drawing.Point(590, 6);
            this.picLogoVentana.Size = new System.Drawing.Size(125, 71);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Location = new System.Drawing.Point(23, 128);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(89, 125);
            // 
            // picBuscar
            // 
            this.picBuscar.Location = new System.Drawing.Point(348, 121);
            // 
            // cmbColumna
            // 
            this.cmbColumna.Items.AddRange(new object[] {
            "TIPO DE PRODUCTO"});
            this.cmbColumna.Location = new System.Drawing.Point(89, 94);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 97);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(18, 19);
            this.btnInsertar.Size = new System.Drawing.Size(74, 31);
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(98, 19);
            this.btnEditar.Size = new System.Drawing.Size(74, 31);
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(178, 19);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(256, 19);
            this.btnSalir.Size = new System.Drawing.Size(74, 31);
            // 
            // grdTipoProducto
            // 
            this.grdTipoProducto.AllowUserToAddRows = false;
            this.grdTipoProducto.AllowUserToDeleteRows = false;
            this.grdTipoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTipoProducto.BackgroundColor = System.Drawing.Color.White;
            this.grdTipoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTipoProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ID_TIPO_PRODUCTO,
            this.NOM_TIPO_PRODUCTO});
            this.grdTipoProducto.Location = new System.Drawing.Point(12, 163);
            this.grdTipoProducto.Name = "grdTipoProducto";
            this.grdTipoProducto.ReadOnly = true;
            this.grdTipoProducto.RowHeadersVisible = false;
            this.grdTipoProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTipoProducto.Size = new System.Drawing.Size(704, 316);
            this.grdTipoProducto.TabIndex = 11;
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 50;
            // 
            // ID_TIPO_PRODUCTO
            // 
            this.ID_TIPO_PRODUCTO.HeaderText = "ID_TIPO_PRODUCTO";
            this.ID_TIPO_PRODUCTO.Name = "ID_TIPO_PRODUCTO";
            this.ID_TIPO_PRODUCTO.ReadOnly = true;
            this.ID_TIPO_PRODUCTO.Visible = false;
            // 
            // NOM_TIPO_PRODUCTO
            // 
            this.NOM_TIPO_PRODUCTO.HeaderText = "TIPO DE PRODUCTO";
            this.NOM_TIPO_PRODUCTO.Name = "NOM_TIPO_PRODUCTO";
            this.NOM_TIPO_PRODUCTO.ReadOnly = true;
            this.NOM_TIPO_PRODUCTO.Width = 620;
            // 
            // GestionTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 492);
            this.Name = "GestionTipoProducto";
            this.Text = "GestionTipoProducto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TIPO_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_TIPO_PRODUCTO;
    }
}