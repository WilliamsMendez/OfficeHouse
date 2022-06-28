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
            //ingreso en base de datos
            MySqlConnection CDB = Cconexion.conex();
            try
            {
                CDB.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = CDB;
                comando.CommandText = ("Insert into libro(id_libro, titulo_libro , autor_libro , Editorial , Categoria , precio, fecha_ingreso ) values('"+ txt_codigo.Text +" ', '" + Titulolibro.Text + "','" + Autorlibro.Text + "','" + Editoriallibro.Text + "', '" + Categorialibro.Text + "', '" + float.Parse(preciolibro.Text) + "', '" + fechaingresolibro.Value.ToString("yyy/MM/dd") + "');");
                comando.ExecuteNonQuery();
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
            
        }
    }
}
