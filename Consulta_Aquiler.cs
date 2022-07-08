using MySql.Data.MySqlClient;
using OfficeHouse.clases;
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

        MySqlConnection CDB = Cconexion.conex();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Consulta_Aquiler_Load(object sender, EventArgs e)
        {

            string consulta = "select * from libro";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, CDB);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgv_consultaA.DataSource = dt;
        }

        

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            CDB.Open();
            if (radioButton1.Checked == true)
            {
                string consulta = "select * from libro where id_libro= " + Buscar.Text + "";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, CDB);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgv_consultaA.DataSource = dt;
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
                dgv_consultaA.DataSource = dt;
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
                dgv_consultaA.DataSource = dt;
                MySqlCommand comando = new MySqlCommand(consulta, CDB);
                MySqlDataReader lector;
                lector = comando.ExecuteReader();
            }
            CDB.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_consultaA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnatras_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuAlquiler frm = new MenuAlquiler();
            frm.Show();
        }
    }
}
