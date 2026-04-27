using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace tp_winform_equipo_6A
{
    public static class Estilos
    {
        public static void BotonAzul(Button btn)
        {
            btn.BackColor = Color.FromArgb(0, 123, 255);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI Semibold", 9F);
        }

        public static void lblDiseño(Label lbl)
        {
            lbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            lbl.ForeColor = Color.FromArgb(60, 60, 60);
            lbl.AutoSize = true;
        }

        public static void cbDiseño(ComboBox cb)
        {
            cb.FlatStyle = FlatStyle.Flat;
            cb.Font = new Font("Segoe UI", 10F);
            cb.BackColor = Color.White;
            cb.ForeColor = Color.Black;
        }

    }
}
