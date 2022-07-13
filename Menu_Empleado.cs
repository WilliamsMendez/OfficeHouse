using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeHouse.clases;

namespace OfficeHouse
{
    public partial class Menu_Empleado : Form
    {
        public Menu_Empleado()
        {
            InitializeComponent();
        }

        private void btnalquiler_Click(object sender, EventArgs e)
        {
            pantallaav.av = 1;
            this.Hide();
            Membresia_cliente frm = new Membresia_cliente();
            frm.Show();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Registro frm = new Menu_Registro();
            frm.Show();
            
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();
            
        }
    }
}
