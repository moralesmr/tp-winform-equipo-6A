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
        
                  listBoxCat.DataSource = null;
                  listBoxCat.DataSource = listaCategorias;
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
