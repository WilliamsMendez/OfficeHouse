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

        private void Registro_Devolucion_Load(object sender, EventArgs e)
        {

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
            //ingreso en base de datos
            MySqlConnection CDB = Cconexion.conex();
            try
            {
                CDB.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = CDB;
                comando.CommandText = ("Insert into devolucion(id_devolucion, fecha_devolucion, descripcion_devolucion, pago_libro_dañado, revision_gerencial) values('"+codigo_devolucion.Text+"', '"+fecha_devolucion.Value.ToString("G")+"', '"+""+"', '"+estado_libro.Text+"', '"+""+"');");
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
