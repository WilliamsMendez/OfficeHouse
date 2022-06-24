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
    public partial class Menu_Gerente : Form
    {
        public Menu_Gerente()
        {
            InitializeComponent();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Registro frm = new Menu_Registro();
            frm.Show();
            
        }

        private void btnalquiler_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAlquiler frm = new MenuAlquiler();
            frm.Show();
        }

        private void btndevoluciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDevolucion frm = new MenuDevolucion();
            frm.Show();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();
        }

        private void btnusuario_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios frm = new Usuarios();
            frm.Show();
        }
    }
}
