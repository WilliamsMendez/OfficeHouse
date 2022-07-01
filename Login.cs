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
        MySqlConnection CDB = Cconexion.conex();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_IniSec_Click(object sender, EventArgs e)
        {
            CDB.Open();
            MySqlCommand codigo = new MySqlCommand();
           
            codigo.Connection = CDB;
            codigo.CommandText = ("select *from empleado where usuario_empleado='" + txt_usuario.Text+"'and clave_empleado='" + txt_clave.Text+"' ");
            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("Bienvenido");
                this.Hide();
                Menu_Gerente frm = new Menu_Gerente();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contrase;a incorrectos");
                
            }
            CDB.Close();
            

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
