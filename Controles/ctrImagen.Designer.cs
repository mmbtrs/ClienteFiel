namespace Controles
{
    partial class ctrImagen
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
            this.openLogo = new System.Windows.Forms.OpenFileDialog();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // openLogo
            // 
            this.openLogo.Filter = "Archivos de Imagen|*.png;*.bmp;*.jpg";
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Image = global::Controles.Properties.Resources.removeImage26x26;
            this.btnRemoveImage.Location = new System.Drawing.Point(146, 103);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(91, 36);
            this.btnRemoveImage.TabIndex = 18;
            this.btnRemoveImage.Text = "Quitar imagen ...";
            this.btnRemoveImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveImage.UseVisualStyleBackColor = true;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Image = global::Controles.Properties.Resources.loadImage26x26;
            this.btnLoadImage.Location = new System.Drawing.Point(146, 61);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(91, 36);
            this.btnLoadImage.TabIndex = 17;
            this.btnLoadImage.Text = "Selecionar imagen ...";
            this.btnLoadImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(1, 1);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(139, 138);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 16;
            this.picLogo.TabStop = false;
            this.picLogo.DragDrop += new System.Windows.Forms.DragEventHandler(this.picLogo_DragDrop);
            this.picLogo.DragEnter += new System.Windows.Forms.DragEventHandler(this.picLogo_DragEnter);
            // 
            // ctrImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.picLogo);
            this.Name = "ctrImagen";
            this.Size = new System.Drawing.Size(238, 140);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openLogo;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.PictureBox picLogo;
    }
}
