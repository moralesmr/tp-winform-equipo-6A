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
        Articulo articulo = null;
        public frmAgregarArticulos()
        {
            InitializeComponent();
        }

        public frmAgregarArticulos(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.CodArticulo = tbCodigo.Text;
                articulo.Nombre = tbNombre.Text;
                articulo.Descripcion = tbDescripcion.Text;
                articulo.Precio = decimal.Parse(tbPrecio.Text);
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                //aux.UrlImagen = tbUrlImagen.Text; 

                if (articulo.Id != 0)
                {
                    articuloNegocio.modificar(articulo);
                    MessageBox.Show("Articulo modificado correctamente");
                }
                else
                {
                    articuloNegocio.agregar(articulo);
                    MessageBox.Show("Articulo agregado correctamente");
                }

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregarArticulos_Load(object sender, EventArgs e)
        {
            Estilos.BotonAzul(btnGuardarArticulo);
            //Autocompletar cbMarca y cbCategoria
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            cbMarca.DataSource = marcaNegocio.Listar();
            cbMarca.ValueMember = "Id";
            cbMarca.DisplayMember = "Descripcion";
            cbCategoria.DataSource = categoriaNegocio.listar();
            cbCategoria.ValueMember = "Id";
            cbCategoria.DisplayMember = "Descripcion";

            if (articulo != null)
            {
                tbCodigo.Text = articulo.CodArticulo;
                tbNombre.Text = articulo.Nombre;
                tbDescripcion.Text = articulo.Descripcion;
                tbPrecio.Text = articulo.Precio.ToString();
                cbCategoria.SelectedValue = articulo.Categoria.Id;
                cbMarca.SelectedValue = articulo.Marca.Id;
                tbUrl.Text = articulo.Imagenes[0].ImagenUrl;
            }
        }

        private void btnCancelarArticulo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
