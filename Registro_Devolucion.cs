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
    public partial class Registro_Devolucion : Form
    {
        public Registro_Devolucion()
        {
            InitializeComponent();
        }
        //ingreso en base de datos
        MySqlConnection CDB = Cconexion.conex();

        public void llenartabla()
        {
            string consulta = "select * from devolucion";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, CDB);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgv_devolucion.DataSource = dt;
            
        }
        private void Registro_Devolucion_Load(object sender, EventArgs e)
        {
            string consulta = "select * from devolucion";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, CDB);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgv_devolucion.DataSource = dt;
            cbestadolibro();
            consultalibro();
        }

        private void cb_puesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDevolucion frm = new MenuDevolucion();
            frm.Show();
        }

        private void btnpagar_Click(object sender, EventArgs e)
        {
           
            try
            {
                CDB.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = CDB;
                comando.CommandText = ("Insert into devolucion( fecha_devolucion, estado_libro) values('"+fecha_devolucion.Value.ToString("yyyy/MM/dd")+"', '"+estado_libro.Text+"');");
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

        private void button1_Click(object sender, EventArgs e)
        {
            CDB.Open();

            string consulta = "delete from devolucion where id_devolucion=" + codigo_devolucion.Text + "";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, CDB);
            MySqlCommand comando = new MySqlCommand(consulta, CDB);
            comando.ExecuteNonQuery();
            llenartabla();
            CDB.Close();
            MessageBox.Show("Datos eliminados correctamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CDB.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = CDB;
                comando.CommandText = ("UPDATE devolucion SET id_devolucion='" + codigo_devolucion.Text + "',fecha_devolucion='" + fecha_devolucion.Value.ToString("yyyy/MM/dd")+ "',estado_libro='"+estado_libro.Text +  "' WHERE id_devolucion='" + codigo_devolucion.Text + "'");
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

        private void dgv_devolucion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo_devolucion.Text = dgv_devolucion.SelectedCells[0].Value.ToString();
            fecha_devolucion.Text = dgv_devolucion.SelectedCells[1].Value.ToString();
            estado_libro.Text = dgv_devolucion.SelectedCells[2].Value.ToString();
           
        }

        private void cbestadolibro()
        {
            string consulestado = "SELECT estadolibro FROM estado_libro";
            MySqlCommand comanestado = new MySqlCommand(consulestado, CDB);
            MySqlDataAdapter da = new MySqlDataAdapter(comanestado);
            DataTable dtestado = new DataTable();
            da.Fill(dtestado);
            estado_libro.DisplayMember = "estadolibro";
            estado_libro.DataSource = dtestado;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(estado_libro.Text == "Mal estado")
            {
                this.Hide();
                Pagos frm = new Pagos();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Devolucion realizada correctamente");
            }
        }

        private void consultalibro()
        {
            string consullibro = "SELECT titulo_libro,autor_libro FROM libro";
            MySqlCommand comandlibro = new MySqlCommand(consullibro, CDB);
            MySqlDataAdapter da = new MySqlDataAdapter(comandlibro);
            DataTable dtlibro = new DataTable();
            da.Fill(dtlibro);
            titulo_devolucion.DisplayMember = "titulo_libro";
            titulo_devolucion.DataSource = dtlibro;
            autor_devolucion.Text = dtlibro.Rows[0][1].ToString();

        }

        private void titulo_devolucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consullibro = "SELECT autor_libro FROM libro WHERE titulo_libro= '" + titulo_devolucion.Text + "'";
            MySqlCommand comandlibro = new MySqlCommand(consullibro, CDB);
            MySqlDataAdapter da = new MySqlDataAdapter(comandlibro);
            DataTable dtlibro = new DataTable();
            da.Fill(dtlibro);
            autor_devolucion.Text = dtlibro.Rows[0][0].ToString();
        }

        private void codigo_devolucion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten numeros en el codigo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void codigo_devolucion_Validated(object sender, EventArgs e)
        {
            if (codigo_devolucion.Text.Trim() == "")
            {
                epError.SetError(codigo_devolucion, "Ingrese el codigo....");
                codigo_devolucion.Focus();

            }
            else
            {
                epError.Clear();
            }
        }

        private void titulo_devolucion_Validated(object sender, EventArgs e)
        {
           
        }
    }
}
