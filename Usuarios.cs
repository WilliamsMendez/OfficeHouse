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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Gerente frm = new Menu_Gerente();
            frm.Show();
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
