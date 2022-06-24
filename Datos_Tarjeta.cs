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
    public partial class Datos_Tarjeta : Form
    {
        public Datos_Tarjeta()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pagos frm = new Pagos();
            frm.Show();
        }
    }
}
