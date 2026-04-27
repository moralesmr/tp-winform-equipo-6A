
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
        private int indiceImagen = 0;
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

            indiceImagen = 0;
            cargarImagen();


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

        private void cargarImagen()
        {
            if (articulo.Imagenes != null && articulo.Imagenes.Count > 0)
            {
                try
                {
                    pbImagen.Load(articulo.Imagenes[indiceImagen].ImagenUrl);
                }
                catch
                {
                    pbImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRcCBHgbS23kyBw2r8Pquu19UtKZnrZmFUx1g&s");
                }
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (articulo.Imagenes != null && indiceImagen > 0)
            {
                indiceImagen--;
                cargarImagen();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (articulo.Imagenes != null && indiceImagen < articulo.Imagenes.Count - 1)
            {
                indiceImagen++;
                cargarImagen();
            }
        }
    }
}
