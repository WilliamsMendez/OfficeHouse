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
    public partial class Membresia_cliente : Form
    {
        public Membresia_cliente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_alquiler frm = new Registro_alquiler();
            frm.Show();
            Registro_Devolucion arm = new Registro_Devolucion();
            arm.Show();
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {

        }
    }
}
