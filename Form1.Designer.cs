namespace pryEtapa4Ahumada
{
    partial class frmEtapa4
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.pctImagen = new System.Windows.Forms.PictureBox();
            this.lblListar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(80, 91);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(132, 58);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(80, 295);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(132, 58);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // pctImagen
            // 
            this.pctImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctImagen.Location = new System.Drawing.Point(292, 12);
            this.pctImagen.Name = "pctImagen";
            this.pctImagen.Size = new System.Drawing.Size(295, 227);
            this.pctImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctImagen.TabIndex = 2;
            this.pctImagen.TabStop = false;
            // 
            // lblListar
            // 
            this.lblListar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListar.Location = new System.Drawing.Point(288, 295);
            this.lblListar.Name = "lblListar";
            this.lblListar.Size = new System.Drawing.Size(299, 58);
            this.lblListar.TabIndex = 3;
            // 
            // frmEtapa4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 394);
            this.Controls.Add(this.lblListar);
            this.Controls.Add(this.pctImagen);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnGenerar);
            this.Name = "frmEtapa4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etapa 4 - CREAR OBJETOS EN LISTA";
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.PictureBox pctImagen;
        private System.Windows.Forms.Label lblListar;
    }
}

