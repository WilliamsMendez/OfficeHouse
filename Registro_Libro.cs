using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OfficeHouse.clases;

namespace OfficeHouse
{
    public partial class Registro_Libro : Form
    {
        public Registro_Libro()
        {
            InitializeComponent();
        }
        //ingreso en base de datos
        MySqlConnection CDB = Cconexion.conex();
        public void llenartabla()
        {
            string consulta = "select * from libro";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, CDB);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgv_libro.DataSource = dt;
        }
        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Registro frm = new Menu_Registro();
            frm.Show();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw codigodebarra = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            imgbarra.Image = codigodebarra.Draw(txt_codigo.Text, 40);
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "JPEG|*.jpeg";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string varimg = saveFileDialog1.FileName;
                Bitmap varbmp = new Bitmap(imgbarra.Image);
                varbmp.Save(varimg, ImageFormat.Jpeg);
            }
            
            
            try
            {
                CDB.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = CDB;
                comando.CommandText = ("Insert into libro(id_libro, titulo_libro , autor_libro , Editorial , Categoria , precio, fecha_ingreso ) values('"+ txt_codigo.Text +" ', '" + Titulolibro.Text + "','" + Autorlibro.Text + "','" + Editoriallibro.Text + "', '" + Categorialibro.Text + "', '" + float.Parse(preciolibro.Text) + "', '" + fechaingresolibro.Value.ToString("yyyy/MM/dd") + "');");
                comando.ExecuteNonQuery();
                llenartabla();
                CDB.Close();
                MessageBox.Show("Datos ingresados correctamente");
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message + i.StackTrace);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                CDB.Open();
                

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = CDB;
                comando.CommandText = ("UPDATE libro SET id_libro='" + txt_codigo.Text + "',titulo_libro='" + Titulolibro.Text + "', autor_libro='" + Autorlibro.Text + "',Editorial='" + Editoriallibro.Text + "',Categoria='" + Categorialibro.Text + "',precio='" + float.Parse(preciolibro.Text) + "',fecha_ingreso='" + fechaingresolibro.Value.ToString("yyyy/MM/dd") + "' WHERE id_libro='" + txt_codigo.Text + "'");
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

           private void Registro_Libro_Load(object sender, EventArgs e)
        {
            string consulta = "select * from libro";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, CDB);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgv_libro.DataSource = dt;
            cbCategoria_libro();
        }

        private void dgv_libro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dgv_libro.SelectedCells[0].Value.ToString();
            Titulolibro.Text = dgv_libro.SelectedCells[1].Value.ToString();
            Autorlibro.Text = dgv_libro.SelectedCells[2].Value.ToString();
            Editoriallibro.Text = dgv_libro.SelectedCells[3].Value.ToString();
            Categorialibro.Text = dgv_libro.SelectedCells[4].Value.ToString();
            //regitradoxtal.SelectedIndex = dgv_libro.SelectedCells[6].Value.ToString();
            preciolibro.Text = dgv_libro.SelectedCells[5].Value.ToString();
            fechaingresolibro.Value = Convert.ToDateTime(dgv_libro.SelectedCells[6].Value.ToString());


        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            CDB.Open();

            string consulta = "delete from libro where id_libro="+txt_codigo.Text+"";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, CDB);
            MySqlCommand comando = new MySqlCommand(consulta, CDB);
            comando.ExecuteNonQuery();
            llenartabla();
            CDB.Close();
            MessageBox.Show("Datos eliminados correctamente");
        }

        private void cbCategoria_libro()
        {
            string consul_Categ = "SELECT Categoria FROM Categoria_libro";
            MySqlCommand comandCateg = new MySqlCommand(consul_Categ, CDB);
            MySqlDataAdapter da = new MySqlDataAdapter(comandCateg);
            DataTable dtCateg = new DataTable();
            da.Fill(dtCateg);
            Categorialibro.DisplayMember = "Categoria";
            Categorialibro.DataSource = dtCateg;

            string consulempleado = "SELECT nombre_empleado FROM empleado";
            MySqlCommand comandempleado = new MySqlCommand(consulempleado, CDB);
            MySqlDataAdapter da1 = new MySqlDataAdapter(comandempleado);
            DataTable dtemp = new DataTable();
            da1.Fill(dtemp);
            regitradoxtal.DisplayMember = "nombre_empleado";
            regitradoxtal.DataSource = dtemp;
        }
    }
}

