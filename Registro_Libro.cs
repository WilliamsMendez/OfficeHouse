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
                comando.CommandText = ("Insert into libro(titulo_libro , autor_libro , Editorial , Categoria , precio, fecha_ingreso ) values('" + Titulolibro.Text + "','" + Autorlibro.Text + "','" + Editoriallibro.Text + "', '" + Categorialibro.Text + "', '" + float.Parse(preciolibro.Text) + "', '" + fechaingresolibro.Value.ToString("yyyy/MM/dd") + "');");
                comando.ExecuteNonQuery();
                llenartabla();
                CDB.Close();
                MessageBox.Show("Datos ingresados correctamente");
                Titulolibro.Text = "";
                preciolibro.Text = "";
                txt_codigo.Text = "";

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
                Titulolibro.Text = "";
                preciolibro.Text = "";
                txt_codigo.Text = "";
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
            Titulolibro.Text = "";
            preciolibro.Text = "";
            txt_codigo.Text = "";
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

            string consuledit = "SELECT editorial FROM Editorial";
            MySqlCommand comandoedit = new MySqlCommand(consuledit, CDB);
            MySqlDataAdapter da2 = new MySqlDataAdapter(comandoedit);
            DataTable dtedit = new DataTable();
            da2.Fill(dtedit);
            Editoriallibro.DisplayMember = "editorial";
            Editoriallibro.DataSource = dtedit;

            string consulautor = "SELECT autorcol FROM autor";
            MySqlCommand comandoautor = new MySqlCommand(consulautor, CDB);
            MySqlDataAdapter da3 = new MySqlDataAdapter(comandoautor);
            DataTable dtautor = new DataTable();
            da3.Fill(dtautor);
            Autorlibro.DisplayMember = "autorcol";
            Autorlibro.DataSource = dtautor;
        }

        private void dgv_libro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten numeros en el codigo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void preciolibro_TextChanged(object sender, EventArgs e)
        {

        }

        public void validaciones()
        {
            if (txt_codigo.Text.Trim() == "")
            {
                epError.SetError(txt_codigo, "Ingrese el codigo....");
                txt_codigo.Focus();
                MessageBox.Show("Ingrese el codigo....");
            }
            else
                if (Titulolibro.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el titulo....");
                epError.SetError(Titulolibro, "Ingrese el Titulo....");
                Titulolibro.Focus();

            }
            else
                if (Autorlibro.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el autor");
                epError.SetError(Autorlibro, "Ingrese el autor....");
                Autorlibro.Focus();

            }
            else
                if (preciolibro.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el precio");
                epError.SetError(preciolibro, "Ingrese el precio");
                preciolibro.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void preciolibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten numeros en el codigo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Autorlibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras en el nombre", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_codigo_Validated(object sender, EventArgs e)
        {
            if (txt_codigo.Text.Trim() == "")
            {
                epError.SetError(txt_codigo, "Ingrese el Codigo....");
                txt_codigo.Focus();

            }
            else
            {
                epError.Clear();
            }
        }

        private void Titulolibro_Validated(object sender, EventArgs e)
        {
            if (Titulolibro.Text.Trim() == "")
            {
                epError.SetError(Titulolibro, "Ingrese el Titulo....");
                Titulolibro.Focus();

            }
            else
            {
                epError.Clear();
            }
        }

        private void Autorlibro_Validated(object sender, EventArgs e)
        {
            if (Autorlibro.Text.Trim() == "")
            {
                epError.SetError(Autorlibro, "Ingrese el Autor....");
                Autorlibro.Focus();

            }
            else
            {
                epError.Clear();
            }
        }

        private void preciolibro_Validated(object sender, EventArgs e)
        {
            if (preciolibro.Text.Trim() == "")
            {
                epError.SetError(preciolibro, "Ingrese el Precio....");
                preciolibro.Focus();

            }
            else
            {
                epError.Clear();
            }
        }

        private void Autorlibro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

