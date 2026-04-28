namespace tp_winform_equipo_6A
{
    partial class frmAdmCategorias
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.listBoxCategoria = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(620, 334);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(115, 36);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(349, 334);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 36);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(485, 334);
            this.btnEliminarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(115, 36);
            this.btnEliminarCategoria.TabIndex = 10;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // listBoxCategoria
            // 
            this.listBoxCategoria.FormattingEnabled = true;
            this.listBoxCategoria.ItemHeight = 16;
            this.listBoxCategoria.Location = new System.Drawing.Point(49, 58);
            this.listBoxCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCategoria.Name = "listBoxCategoria";
            this.listBoxCategoria.Size = new System.Drawing.Size(686, 244);
            this.listBoxCategoria.TabIndex = 11;
            // 
            // frmAdmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 417);
            this.Controls.Add(this.listBoxCategoria);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(849, 464);
            this.MinimumSize = new System.Drawing.Size(849, 464);
            this.Name = "frmAdmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Categorias";
            this.Load += new System.EventHandler(this.frmAdmCategorias_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.ListBox listBoxCategoria;
    }
}