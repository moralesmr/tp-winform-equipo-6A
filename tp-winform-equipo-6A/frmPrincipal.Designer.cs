namespace tp_winform_equipo_6A
{
    partial class frmPrincipal
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnDetalleArticulo = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.cbBuscador = new System.Windows.Forms.ComboBox();
            this.tbBuscador = new System.Windows.Forms.TextBox();
            this.btnBuscador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(36, 154);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(891, 245);
            this.dgvArticulos.TabIndex = 15;
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(36, 446);
            this.btnAgregarArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(115, 36);
            this.btnAgregarArticulo.TabIndex = 16;
            this.btnAgregarArticulo.Text = "Agregar";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Location = new System.Drawing.Point(171, 446);
            this.btnModificarArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(115, 36);
            this.btnModificarArticulo.TabIndex = 17;
            this.btnModificarArticulo.Text = "Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(308, 446);
            this.btnEliminarArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(115, 36);
            this.btnEliminarArticulo.TabIndex = 18;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnDetalleArticulo
            // 
            this.btnDetalleArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalleArticulo.Location = new System.Drawing.Point(444, 446);
            this.btnDetalleArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetalleArticulo.Name = "btnDetalleArticulo";
            this.btnDetalleArticulo.Size = new System.Drawing.Size(115, 36);
            this.btnDetalleArticulo.TabIndex = 19;
            this.btnDetalleArticulo.Text = "Ver Detalle";
            this.btnDetalleArticulo.UseVisualStyleBackColor = true;
            this.btnDetalleArticulo.Click += new System.EventHandler(this.btnDetalleArticulo_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(675, 446);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 36);
            this.button5.TabIndex = 20;
            this.button5.Text = "Marcas";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(811, 446);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 36);
            this.button6.TabIndex = 21;
            this.button6.Text = "Categorias";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Location = new System.Drawing.Point(33, 117);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(72, 16);
            this.lblBuscador.TabIndex = 22;
            this.lblBuscador.Text = "Buscar por";
            // 
            // cbBuscador
            // 
            this.cbBuscador.FormattingEnabled = true;
            this.cbBuscador.Location = new System.Drawing.Point(123, 114);
            this.cbBuscador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBuscador.Name = "cbBuscador";
            this.cbBuscador.Size = new System.Drawing.Size(283, 24);
            this.cbBuscador.TabIndex = 23;
            // 
            // tbBuscador
            // 
            this.tbBuscador.Location = new System.Drawing.Point(433, 117);
            this.tbBuscador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBuscador.Name = "tbBuscador";
            this.tbBuscador.Size = new System.Drawing.Size(375, 22);
            this.tbBuscador.TabIndex = 24;
            this.tbBuscador.Text = "Ingrese texto...";
            // 
            // btnBuscador
            // 
            this.btnBuscador.Location = new System.Drawing.Point(824, 111);
            this.btnBuscador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscador.Name = "btnBuscador";
            this.btnBuscador.Size = new System.Drawing.Size(101, 34);
            this.btnBuscador.TabIndex = 25;
            this.btnBuscador.Text = "Buscar";
            this.btnBuscador.UseVisualStyleBackColor = true;
            this.btnBuscador.Click += new System.EventHandler(this.btnBuscador_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBuscador);
            this.Controls.Add(this.tbBuscador);
            this.Controls.Add(this.cbBuscador);
            this.Controls.Add(this.lblBuscador);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnDetalleArticulo);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.Text = "Catálogo de Artículos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnDetalleArticulo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.ComboBox cbBuscador;
        private System.Windows.Forms.TextBox tbBuscador;
        private System.Windows.Forms.Button btnBuscador;
    }
}
