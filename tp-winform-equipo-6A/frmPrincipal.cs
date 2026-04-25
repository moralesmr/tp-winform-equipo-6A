using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;

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
            //Conexion BBDD
            ArticuloNegocio articuloNegocio = new negocio.ArticuloNegocio();
            dgvArticulos.DataSource = articuloNegocio.listarArticulos();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAgregarArticulos ventanaAgregarArticulo = new frmAgregarArticulos();
            ventanaAgregarArticulo.ShowDialog();
        }
    }
}
