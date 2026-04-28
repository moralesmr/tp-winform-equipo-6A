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
        
                  dgvCategorias.DataSource = null;
                  dgvCategorias.DataSource = listaCategorias;
                  dgvCategorias.Columns["Id"].Visible = false;
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
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            Categoria categoriaSeleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar la categoria?", "Eliminando", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    categoriaSeleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                    categoriaNegocio.eliminar(categoriaSeleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
