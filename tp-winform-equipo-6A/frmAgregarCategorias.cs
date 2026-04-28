using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_winform_equipo_6A
{
    public partial class frmAgregarCategorias : Form
    {
        public frmAgregarCategorias()
        {
            InitializeComponent();
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            Categoria aux = new Categoria();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                aux.Descripcion = tbDescripcion.Text;
                categoriaNegocio.agregar(aux);
                MessageBox.Show("Articulo agregado correctamente");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
