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
    public partial class Consulta_Libro : Form
    {
        public Consulta_Libro()
        {
            InitializeComponent();
        }
        MySqlConnection CDB = Cconexion.conex();
      
        private void Consulta_Libro_Load(object sender, EventArgs e)
        {
            string consulta = "select * from libro";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, CDB);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgv_consultalibro.DataSource = dt;
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            CDB.Open(); 
            if (radioButton1.Checked == true)
            {
                string consulta = "select * from libro where id_libro= " + Buscar.Text + "";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, CDB);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgv_consultalibro.DataSource = dt;
                MySqlCommand comando = new MySqlCommand(consulta, CDB);
                MySqlDataReader lector;
                lector = comando.ExecuteReader();
            }
            else
                if (radioButton2.Checked == true)
            {
                string consulta = "select * from libro where titulo_libro= '" + Buscar.Text + "'";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, CDB);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgv_consultalibro.DataSource = dt;
                MySqlCommand comando = new MySqlCommand(consulta, CDB);
                MySqlDataReader lector;
                lector = comando.ExecuteReader();
            }
            else
                 if (radioButton3.Checked == true)
            {
                string consulta = "select * from libro where autor_libro= '" + Buscar.Text + "'";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, CDB);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgv_consultalibro.DataSource = dt;
                MySqlCommand comando = new MySqlCommand(consulta, CDB);
                MySqlDataReader lector;
                lector = comando.ExecuteReader();
            }
            CDB.Close();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Registro frm = new Menu_Registro();
            frm.Show();
        }
    }
}
