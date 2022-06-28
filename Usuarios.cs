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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Gerente frm = new Menu_Gerente();
            frm.Show();
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //ingreso en base de datos
            MySqlConnection CDB = Cconexion.conex();
            try
            {
                CDB.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = CDB;
                comando.CommandText = ("Insert into empleado(id_empleado, nombre_empleado, apellido_empleado, usuario_empleado, clave_empleado, fecha_contrato, fecha_nacimiento_empleado, puesto_empleado  ) values('1', '"+nombre_usuario.Text+"', '"+apellido_usuario.Text+"', '"+usuario_usuario.Text+"', '"+clave_usuario.Text+"', '"+dtp_contratacion.Value.ToString("G")+"','"+dtp_nacimiento.Value.ToString("G")+"', '"+puesto_usuario.Text+"');");
                comando.ExecuteNonQuery();
                CDB.Close();
                MessageBox.Show("Datos ingresados correctamente");
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message + i.StackTrace);
            }
        }

        private void dtp_contratacion_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
