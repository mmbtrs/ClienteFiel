namespace ClienteFiel.modelo.accesorias
{
    partial class gestionTipoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestionTipoProducto));
            this.ctrBuscar1 = new Controles.ctrBuscar();
            this.grdTipoProducto = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TIPO_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_DE_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(720, 70);
            // 
            // picLogoVentana
            // 
            this.picLogoVentana.Image = global::ClienteFiel.Properties.Resources.TipoProducto;
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.Size = new System.Drawing.Size(313, 29);
            this.lblTituloVentana.Text = "Gestión Tipo de Producto";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(358, 98);
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
            this.TIPO_DE_PRODUCTO});
            this.grdTipoProducto.Location = new System.Drawing.Point(8, 141);
            this.grdTipoProducto.Name = "grdTipoProducto";
            this.grdTipoProducto.ReadOnly = true;
            this.grdTipoProducto.RowHeadersVisible = false;
            this.grdTipoProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTipoProducto.Size = new System.Drawing.Size(704, 262);
            this.grdTipoProducto.TabIndex = 12;
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
            // TIPO_DE_PRODUCTO
            // 
            this.TIPO_DE_PRODUCTO.HeaderText = "TIPO DE PRODUCTO";
            this.TIPO_DE_PRODUCTO.Name = "TIPO_DE_PRODUCTO";
            this.TIPO_DE_PRODUCTO.ReadOnly = true;
            this.TIPO_DE_PRODUCTO.Width = 620;
            // 
            // gestionTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 412);
            this.Controls.Add(this.grdTipoProducto);
            this.Controls.Add(this.ctrBuscar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gestionTipoProducto";
            this.Text = "Gestión Tipo de Producto";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.ctrBuscar1, 0);
            this.Controls.SetChildIndex(this.grdTipoProducto, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVentana)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.ctrBuscar ctrBuscar1;
        private System.Windows.Forms.DataGridView grdTipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TIPO_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_DE_PRODUCTO;
    }
}