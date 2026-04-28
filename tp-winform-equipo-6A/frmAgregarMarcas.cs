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
    public partial class frmAgregarMarcas : Form
    {
        public frmAgregarMarcas()
        {
            InitializeComponent();
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            Marca aux = new Marca();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                aux.Descripcion = tbDescripcion.Text;
                marcaNegocio.Agregar(aux);
                MessageBox.Show("Marca agregada correctamente");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
