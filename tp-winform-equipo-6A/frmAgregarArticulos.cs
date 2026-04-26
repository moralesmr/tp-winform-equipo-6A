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
    public partial class frmAgregarArticulos : Form
    {
        public frmAgregarArticulos()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarArticulo_Click(object sender, EventArgs e)
        {
            Articulo aux = new Articulo();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                aux.CodArticulo = tbCodigo.Text;
                aux.Nombre = tbNombre.Text;
                aux.Descripcion = tbDescripcion.Text;
                aux.Precio = decimal.Parse(tbPrecio.Text);
                aux.Categoria = (Categoria)cbCategoria.SelectedItem;
                aux.Marca = (Marca)cbMarca.SelectedItem;

                articuloNegocio.agregar(aux);
                MessageBox.Show("Articulo agregado correctamente");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregarArticulos_Load(object sender, EventArgs e)
        {
            //Autocompletar cbMarca y cbCategoria
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            cbMarca.DataSource = marcaNegocio.Listar();
            cbCategoria.DataSource = categoriaNegocio.listar();
        }

        private void btnCancelarArticulo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
