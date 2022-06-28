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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Registro_alquiler_Load(object sender, EventArgs e)
        {

        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAlquiler frm = new MenuAlquiler();
            frm.Show();
        }

        private void btnpagar_Click(object sender, EventArgs e)
        {
            //ingreso en base de datos
            MySqlConnection CDB = Cconexion.conex();
            try
            {
                CDB.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = CDB;
                comando.CommandText = ("Insert into alquiler(id_alquiler,cantidad, descripcion_alquiler, fecha_alquier, fecha_aprox_entrada ) values('"+codigo_alquiler.Text+"', '"+float.Parse(cantidad_alquiler.Text)+"', '"+""+"','"+fecha_alquier.Value.ToString("G")+"','"+dtp_fecha_aprox_entrega.Value.ToString("G")+"');");
                comando.ExecuteNonQuery();
                CDB.Close();
                MessageBox.Show("Datos ingresados correctamente");
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message + i.StackTrace);
            }
        }
    }
}
