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
    public partial class Datos_Tarjeta : Form
    {
        public Datos_Tarjeta()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pagos frm = new Pagos();
            frm.Show();

            //ingreso en base de datos
            MySqlConnection CDB = Cconexion.conex();
            try
            {
                CDB.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = CDB;
                comando.CommandText = ("Insert into tarjetas(numero_tarjeta, nombre_propietario, fecha_vencimiento, cvv ) values('"+float.Parse(numero_tarjeta.Text) +"', '"+nombre_propietario_tarjeta.Text+"' , '"+fecha_vencimiento_tarjeta.Value.ToString("G")+"' , '"+float.Parse(numero_atras_tarjeta.Text) +"');");
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
