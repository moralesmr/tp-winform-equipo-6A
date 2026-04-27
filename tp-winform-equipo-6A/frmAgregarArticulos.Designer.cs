namespace tp_winform_equipo_6A
{
    partial class frmAgregarArticulos
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
            this.btnCancelarArticulo = new System.Windows.Forms.Button();
            this.btnGuardarArticulo = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarArticulo
            // 
            this.btnCancelarArticulo.Location = new System.Drawing.Point(256, 336);
            this.btnCancelarArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelarArticulo.Name = "btnCancelarArticulo";
            this.btnCancelarArticulo.Size = new System.Drawing.Size(86, 29);
            this.btnCancelarArticulo.TabIndex = 31;
            this.btnCancelarArticulo.Text = "Cancelar";
            this.btnCancelarArticulo.UseVisualStyleBackColor = true;
            this.btnCancelarArticulo.Click += new System.EventHandler(this.btnCancelarArticulo_Click);
            // 
            // btnGuardarArticulo
            // 
            this.btnGuardarArticulo.Location = new System.Drawing.Point(166, 336);
            this.btnGuardarArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardarArticulo.Name = "btnGuardarArticulo";
            this.btnGuardarArticulo.Size = new System.Drawing.Size(86, 29);
            this.btnGuardarArticulo.TabIndex = 30;
            this.btnGuardarArticulo.Text = "Guardar";
            this.btnGuardarArticulo.UseVisualStyleBackColor = true;
            this.btnGuardarArticulo.Click += new System.EventHandler(this.btnGuardarArticulo_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUrl.Location = new System.Drawing.Point(141, 234);
            this.tbUrl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(192, 20);
            this.tbUrl.TabIndex = 29;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(141, 206);
            this.tbPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(77, 20);
            this.tbPrecio.TabIndex = 28;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(141, 119);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(192, 20);
            this.tbDescripcion.TabIndex = 27;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(141, 97);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(192, 20);
            this.tbNombre.TabIndex = 26;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(141, 63);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(192, 20);
            this.tbCodigo.TabIndex = 25;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(141, 153);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(140, 21);
            this.cbCategoria.TabIndex = 24;
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(141, 177);
            this.cbMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(140, 21);
            this.cbMarca.TabIndex = 23;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(48, 239);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(70, 13);
            this.lblUrl.TabIndex = 22;
            this.lblUrl.Text = "URL Imagen:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(48, 206);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 21;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(48, 180);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(40, 13);
            this.lblCategoria.TabIndex = 20;
            this.lblCategoria.Text = "Marca:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(48, 153);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(55, 13);
            this.lblMarca.TabIndex = 19;
            this.lblMarca.Text = "Categoria:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(48, 124);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(48, 97);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(48, 68);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "Codigo:";
            // 
            // frmAgregarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.btnCancelarArticulo);
            this.Controls.Add(this.btnGuardarArticulo);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmAgregarArticulos";
            this.Text = "Agregar Articulos";
            this.Load += new System.EventHandler(this.frmAgregarArticulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarArticulo;
        private System.Windows.Forms.Button btnGuardarArticulo;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
    }
}