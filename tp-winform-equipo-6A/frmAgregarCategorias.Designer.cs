namespace tp_winform_equipo_6A
{
    partial class frmAgregarCategorias
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
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(202, 63);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(255, 22);
            this.tbDescripcion.TabIndex = 21;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(54, 66);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(121, 16);
            this.lblDescripcion.TabIndex = 24;
            this.lblDescripcion.Text = "Nombre Categoria:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(336, 266);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 36);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCategoria
            // 
            this.btnGuardarCategoria.Location = new System.Drawing.Point(202, 266);
            this.btnGuardarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarCategoria.Name = "btnGuardarCategoria";
            this.btnGuardarCategoria.Size = new System.Drawing.Size(115, 36);
            this.btnGuardarCategoria.TabIndex = 25;
            this.btnGuardarCategoria.Text = "Guardar";
            this.btnGuardarCategoria.UseVisualStyleBackColor = true;
            this.btnGuardarCategoria.Click += new System.EventHandler(this.btnGuardarCategoria_Click);
            // 
            // frmAgregarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 339);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarCategoria);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(532, 386);
            this.MinimumSize = new System.Drawing.Size(532, 386);
            this.Name = "frmAgregarCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarCategorias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarCategoria;
    }
}