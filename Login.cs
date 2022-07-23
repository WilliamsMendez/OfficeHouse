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

            MySqlCommand codigo = new MySqlCommand("select usuario_empleado, clave_empleado, puesto_empleado from empleado where usuario_empleado='" + txt_usuario.Text + "'and clave_empleado='" + txt_clave.Text + "' ");
            codigo.Connection = CDB;
            MySqlDataAdapter adapter = new MySqlDataAdapter(codigo);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
           


            if (dt.Rows.Count == 1)
            {
                if (dt.Rows[0][2].ToString() == "Gerente")
                {
                    MessageBox.Show("Bienvenido");
                    this.Hide();
                    Menu_Gerente frm = new Menu_Gerente();
                    frm.Show();
                    tipousuariopublico.tipousuario = dt.Rows[0][2].ToString();
                }
                else
                {
                    MessageBox.Show("Menu Empleado");
                    this.Hide();
                    Menu_Empleado frm = new Menu_Empleado();
                    frm.Show();
                    tipousuariopublico.tipousuario = dt.Rows[0][1].ToString();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                
            }
            CDB.Close();
           
           
        }

        private void btnprueba_Click(object sender, EventArgs e)
        {
            MySqlConnection CDB = Cconexion.conex();
            try
            {
                CDB.Open();
                MessageBox.Show("Conexion exitosa");
                CDB.Close();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message + x.StackTrace);
            }

        }
    }
}
