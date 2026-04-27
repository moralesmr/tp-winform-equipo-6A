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
            //Se aplican estilos a los botones
            Estilos.BotonAzul(btnAgregarArticulo);
            Estilos.BotonAzul(btnModificarArticulo);
            Estilos.BotonAzul(btnEliminarArticulo);
            Estilos.BotonAzul(btnDetalleArticulo);
            Estilos.BotonAzul(btnBuscador);

            cbBuscador.Items.Add("Nombre");
            cbBuscador.Items.Add("Marca");
            cbBuscador.Items.Add("Categoria");
            cbBuscador.Items.Add("Codigo");
            cbBuscador.Items.Add("Precio");
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
            try
            {
                dgvArticulos.DataSource = articuloNegocio.listarArticulos();
                dgvArticulos.Columns["Id"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.ToString());
            }
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado;
            articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAgregarArticulos modificar = new frmAgregarArticulos(articuloSeleccionado);
            modificar.ShowDialog();
            cargarArticulos();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            Articulo articuloSeleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el articulo?", "Eliminando", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    articuloNegocio.eliminar(articuloSeleccionado.Id);
                    cargarArticulos();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }










































        private void btnBuscador_Click(object sender, EventArgs e)
        {
            if (cbBuscador.SelectedItem == null)
            {
                MessageBox.Show("seleccione un campo");
                return;
            }

            string campo = cbBuscador.SelectedItem.ToString();
            string filtro = tbBuscador.Text;

            ArticuloNegocio negocio = new ArticuloNegocio();
        
            try
            {
                dgvArticulos.DataSource = negocio.filtrar(campo, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDetalleArticulo_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado =
                    (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                frmDetalleArticulos detalle =
                    new frmDetalleArticulos(seleccionado);

                detalle.ShowDialog();
            }
           
           
        
        }

        private void cbBuscador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            frmAdmMarcas ventanaMarcas = new frmAdmMarcas();
            ventanaMarcas.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmAdmCategorias ventanaCategorias = new frmAdmCategorias();
            ventanaCategorias.ShowDialog();
        }
    }
    
}
