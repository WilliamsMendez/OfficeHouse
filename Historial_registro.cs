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
    public partial class Historial_registro : Form
    {
        public Historial_registro()
        {
            InitializeComponent();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Registro frm = new Menu_Registro();
            frm.Show();
        }
    }
}
