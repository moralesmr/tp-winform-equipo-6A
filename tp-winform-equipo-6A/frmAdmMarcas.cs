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
    public partial class frmAdmMarcas : Form

    {
        private List<Marca> listaMarcas;
        public frmAdmMarcas()
        {
            InitializeComponent();
        }

        private void frmAdmMarcas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            try
            {
                MarcaNegocio negocio = new MarcaNegocio();
                listaMarcas = negocio.Listar();

                listBoxMarca.DataSource = null;
                listBoxMarca.DataSource = listaMarcas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error en la carga: " + ex.Message);
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            frmAgregarMarcas ventanaAgregarMarcas = new frmAgregarMarcas();
            ventanaAgregarMarcas.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionada;

            try
            {

                if (listBoxMarca.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione una marca de la lista para eliminar.");
                    return;
                }

                DialogResult respuesta = MessageBox.Show("¿De verdad desea eliminar esta marca?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionada = (Marca)listBoxMarca.SelectedItem;
                    negocio.Eliminar(seleccionada.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la marca. Es posible que esté vinculada a un artículo existente. \nDetalle: " + ex.Message, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
