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
    public partial class Consulta_Aquiler : Form
    {
        public Consulta_Aquiler()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Consulta_Aquiler_Load(object sender, EventArgs e)
        {

        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAlquiler frm = new MenuAlquiler();
            frm.Show();
        }
    }
}
