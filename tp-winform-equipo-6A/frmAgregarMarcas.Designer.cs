namespace tp_winform_equipo_6A
{
    partial class frmAgregarMarcas
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarMarca = new System.Windows.Forms.Button();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(327, 265);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 36);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarMarca
            // 
            this.btnGuardarMarca.Location = new System.Drawing.Point(193, 265);
            this.btnGuardarMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarMarca.Name = "btnGuardarMarca";
            this.btnGuardarMarca.Size = new System.Drawing.Size(115, 36);
            this.btnGuardarMarca.TabIndex = 29;
            this.btnGuardarMarca.Text = "Guardar";
            this.btnGuardarMarca.UseVisualStyleBackColor = true;
            this.btnGuardarMarca.Click += new System.EventHandler(this.btnGuardarMarca_Click);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(193, 62);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(255, 22);
            this.tbDescripcion.TabIndex = 27;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(45, 65);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(100, 16);
            this.lblDescripcion.TabIndex = 28;
            this.lblDescripcion.Text = "Nombre Marca:";
            // 
            // frmAgregarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 339);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarMarca);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(532, 386);
            this.MinimumSize = new System.Drawing.Size(532, 386);
            this.Name = "frmAgregarMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarMarcas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarMarca;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
    }
}