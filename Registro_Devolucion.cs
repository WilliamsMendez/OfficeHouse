using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeHouse
{
    public partial class Registro_Devolucion : Form
    {
        public Registro_Devolucion()
        {
            InitializeComponent();
        }

        private void Registro_Devolucion_Load(object sender, EventArgs e)
        {

        }

        private void cb_puesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDevolucion frm = new MenuDevolucion();
            frm.Show();
        }
    }
}
