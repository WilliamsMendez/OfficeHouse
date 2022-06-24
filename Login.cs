using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OfficeHouse.clases;

namespace OfficeHouse
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_IniSec_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Empleado frm = new Menu_Empleado();
            frm.Show();
            Menu_Gerente arm = new Menu_Gerente();
            arm.Show();

        }

        private void btnprueba_Click(object sender, EventArgs e)
        {
            MySqlConnection CDB = Cconexion.conex();
            try
            {
                CDB.Open();
                MessageBox.Show("conexion exitosa");
                CDB.Close();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message + x.StackTrace);
            }

        }
    }
}
