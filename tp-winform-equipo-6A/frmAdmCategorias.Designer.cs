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
            this.listBoxCat = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(558, 404);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // listBoxCat
            // 
            this.listBoxCat.FormattingEnabled = true;
            this.listBoxCat.Location = new System.Drawing.Point(52, 30);
            this.listBoxCat.Name = "listBoxCat";
            this.listBoxCat.Size = new System.Drawing.Size(430, 342);
            this.listBoxCat.TabIndex = 1;
            // 
            // frmAdmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxCat);
            this.Controls.Add(this.btnCerrar);
            this.Name = "frmAdmCategorias";
            this.Text = "Administrar Categorias";
            this.Load += new System.EventHandler(this.frmAdmCategorias_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ListBox listBoxCat;
    }
}