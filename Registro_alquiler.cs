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
    public partial class Registro_alquiler : Form
    {
        public Registro_alquiler()
        {
            InitializeComponent();
        }
        MySqlConnection CDB = Cconexion.conex();

        public void llenartabla()
        {
            string consulta = "select * from alquiler";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, CDB);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgv_alquiler.DataSource = dt;
        }
        private void Registro_alquiler_Load(object sender, EventArgs e)
        {
            string consulta = "select * from alquiler";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, CDB);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgv_alquiler.DataSource = dt;
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAlquiler frm = new MenuAlquiler();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CDB.Open();

            string consulta = "delete from alquiler where id_alquiler=" + codigo_alquiler.Text + "";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, CDB);
            MySqlCommand comando = new MySqlCommand(consulta, CDB);
            comando.ExecuteNonQuery();
            llenartabla();
            CDB.Close();
            MessageBox.Show("Datos eliminados correctamente");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dgv_libro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo_alquiler.Text = dgv_alquiler.SelectedCells[0].Value.ToString();
            cantidad_alquiler.Text = dgv_alquiler.SelectedCells[1].Value.ToString();
            fechalquiler.Text = dgv_alquiler.SelectedCells[2].Value.ToString();
            fechaaprox.Text = dgv_alquiler.SelectedCells[3].Value.ToString();
                      
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                CDB.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = CDB;
                comando.CommandText = ("Insert into alquiler(id_alquiler, cantidad, fecha_alquiler, fecha_aprox_entrega ) values('" + codigo_alquiler.Text + "', '" + float.Parse(cantidad_alquiler.Text) + "','" + fechalquiler.Value.ToString("yyyy/MM/dd") + "','" + fechaaprox.Value.ToString("yyyy/MM/dd") + "');");
                comando.ExecuteNonQuery();
                CDB.Close();
                llenartabla();
                MessageBox.Show("Datos ingresados correctamente");
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message + i.StackTrace);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CDB.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = CDB;
                comando.CommandText = ("UPDATE alquiler SET id_alquiler='" + codigo_alquiler.Text + "',cantidad='"+ float.Parse(cantidad_alquiler.Text)+ "',fecha_alquiler='" + fechalquiler.Value.ToString("yyyy/MM/dd") + "',fecha_aprox_entrega='" + fechaaprox.Value.ToString("yyyy/MM/dd") + "' WHERE id_alquiler='" + codigo_alquiler.Text + "'");
                comando.ExecuteNonQuery();
                llenartabla();
                MessageBox.Show("Datos modificados correctamente");

                CDB.Close();
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message + i.StackTrace);
            }
        }
    }
}
