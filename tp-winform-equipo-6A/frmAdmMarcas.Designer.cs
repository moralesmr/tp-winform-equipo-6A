namespace tp_winform_equipo_6A
{
    partial class frmAdmMarcas
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
            this.listBoxMarca = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMarca
            // 
            this.listBoxMarca.FormattingEnabled = true;
            this.listBoxMarca.ItemHeight = 16;
            this.listBoxMarca.Location = new System.Drawing.Point(48, 41);
            this.listBoxMarca.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMarca.Name = "listBoxMarca";
            this.listBoxMarca.Size = new System.Drawing.Size(686, 244);
            this.listBoxMarca.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(484, 329);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 36);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(348, 329);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 36);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(619, 329);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(115, 36);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // frmAdmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 417);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.listBoxMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(849, 464);
            this.MinimumSize = new System.Drawing.Size(849, 464);
            this.Name = "frmAdmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Marcas";
            this.Load += new System.EventHandler(this.frmAdmMarcas_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxMarca;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCerrar;
    }
}