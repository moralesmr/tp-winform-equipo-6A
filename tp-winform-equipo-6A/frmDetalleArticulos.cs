
﻿using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_winform_equipo_6A
{
    public partial class frmDetalleArticulos : Form
    {

        private Articulo articulo;

        public frmDetalleArticulos(Articulo articuloSeleccionado)
        {
            InitializeComponent();

            articulo = articuloSeleccionado;

            cargarDetalle();
        }

        private void cargarDetalle()
        {
            txtNombre.Text = articulo.Nombre;
            txtCategoria.Text = articulo.Categoria.Descripcion;
            txtCodigo.Text = articulo.CodArticulo;
            txtMarca.Text = articulo.Marca.Descripcion;
            txtPrecio.Text = articulo.Precio.ToString();    
            txtDescripcion.Text = articulo.Descripcion;
            if (articulo.Imagenes != null && articulo.Imagenes.Count > 0)
            {
                pictureBox1.Load(articulo.Imagenes[0].ImagenUrl);
                MessageBox.Show("Imagen cargada correctamente");
            }
            
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        public frmDetalleArticulos()
        {
            InitializeComponent();
        }

        private void frmDetalleArticulos_Load(object sender, EventArgs e)
        {
            Estilos.BotonAzul(btnVolver);
        }
    }
}
