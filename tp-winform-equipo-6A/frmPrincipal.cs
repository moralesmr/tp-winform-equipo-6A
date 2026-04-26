using dominio;
using negocio;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargarArticulos();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAgregarArticulos ventanaAgregarArticulo = new frmAgregarArticulos();
            ventanaAgregarArticulo.ShowDialog();
            cargarArticulos();

        }

        public void cargarArticulos()
        {
            //Conexion BBDD
            ArticuloNegocio articuloNegocio = new negocio.ArticuloNegocio();
            dgvArticulos.DataSource = articuloNegocio.listarArticulos();
            dgvArticulos.Columns["Id"].Visible = false;
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado;
            articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAgregarArticulos modificar = new frmAgregarArticulos(articuloSeleccionado);
            modificar.ShowDialog();
            cargarArticulos();
        }
    }
    
}
