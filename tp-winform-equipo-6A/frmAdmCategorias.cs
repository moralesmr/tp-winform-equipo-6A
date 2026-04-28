using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace tp_winform_equipo_6A
{
    public partial class frmAdmCategorias : Form
    {

        private List<Categoria> listaCategorias;
        public frmAdmCategorias()
        {
            InitializeComponent();
        }

        private void frmAdmCategorias_Load(object sender, EventArgs e)
        {
            cargar();
        }

          private void cargar()
          {
            try
            {
                CategoriaNegocio negocio = new CategoriaNegocio();
                listaCategorias = negocio.listar();

                listBoxCategoria.DataSource = null;
                listBoxCategoria.DataSource = listaCategorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error en la carga: " + ex.Message);
            }
          }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarCategorias ventanaAgregarCategorias = new frmAgregarCategorias();
            ventanaAgregarCategorias.ShowDialog();
            cargar();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionada;

            try
            {

                if (listBoxCategoria.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione una marca de la lista para eliminar.");
                    return;
                }

                DialogResult respuesta = MessageBox.Show("¿De verdad desea eliminar esta cateogoria?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionada = (Categoria)listBoxCategoria.SelectedItem;
                    negocio.eliminar(seleccionada.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la categoria. Es posible que esté vinculada a un artículo existente. \nDetalle: " + ex.Message, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
