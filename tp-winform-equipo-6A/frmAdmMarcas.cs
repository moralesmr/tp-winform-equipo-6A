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
    

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
