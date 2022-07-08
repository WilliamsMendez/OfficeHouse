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
            puesto_empleado();
        }
        MySqlConnection CDB = Cconexion.conex();
       
        public void llenartabla()
        {
            string consulta = "select * from  empleado";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, CDB);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgv_libro.DataSource = dt;
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
            
            try
            {
                CDB.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = CDB;
                comando.CommandText = ("Insert into empleado(id_empleado, nombre_empleado, apellido_empleado, usuario_empleado, clave_empleado, fecha_contratacion, fecha_nacimiento_empleado, puesto_empleado  ) values('"+ codigo_usuario.Text+"', '"+nombre_usuario.Text+"', '"+apellido_usuario.Text+"', '"+usuario_usuario.Text+"', '"+clave_usuario.Text+"', '"+dtp_contratacion.Value.ToString("yyyy/MM/dd")+"','"+dtp_nacimiento.Value.ToString("yyyy/MM/dd")+"', '"+puesto_usuario.Text+"');");
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

        private void dtp_contratacion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            string consulta = "select * from empleado";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, CDB);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgv_libro.DataSource = dt;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CDB.Open();

            string consulta = "delete from empleado where id_empleado=" + codigo_usuario.Text + "";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, CDB);
            MySqlCommand comando = new MySqlCommand(consulta, CDB);
            comando.ExecuteNonQuery();
            llenartabla();
            CDB.Close();
            MessageBox.Show("Datos eliminados correctamente");
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                CDB.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = CDB;
                comando.CommandText = ("UPDATE empleado SET id_empleado='" + codigo_usuario.Text + "',nombre_empleado='" + nombre_usuario.Text + "',apellido_empleado='" + apellido_usuario.Text + "', usuario_empleado='" + usuario_usuario.Text + "',clave_empleado='" + clave_usuario.Text + "',fecha_contratacion='" + dtp_contratacion.Value.ToString("yyyy/MM/dd") + "',fecha_nacimiento_empleado='" + dtp_nacimiento.Value.ToString("yyyy/MM/dd") + "',puesto_empleado='" + puesto_usuario.Text + "'WHERE id_empleado='" + codigo_usuario.Text + "'");
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

        private void dgv_libro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo_usuario.Text = dgv_libro.SelectedCells[0].Value.ToString();
            nombre_usuario.Text = dgv_libro.SelectedCells[1].Value.ToString();
            apellido_usuario.Text = dgv_libro.SelectedCells[2].Value.ToString();
            usuario_usuario.Text = dgv_libro.SelectedCells[3].Value.ToString();
            clave_usuario.Text = dgv_libro.SelectedCells[4].Value.ToString();
            //regitradoxtal.SelectedIndex = dgv_libro.SelectedCells[6].Value.ToString();
            dtp_contratacion.Value = Convert.ToDateTime(dgv_libro.SelectedCells[5].Value.ToString());
            dtp_nacimiento.Value = Convert.ToDateTime(dgv_libro.SelectedCells[6].Value.ToString());
            puesto_usuario.Text = dgv_libro.SelectedCells[7].Value.ToString();
            
        }

        private void puesto_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void puesto_empleado()
        {
            string consul_Categ = "SELECT tipo_usuario FROM tipo_usuario";
            MySqlCommand puestoemp = new MySqlCommand(consul_Categ, CDB);
            MySqlDataAdapter da1 = new MySqlDataAdapter(puestoemp);
            DataTable dtCateg = new DataTable();
            da1.Fill(dtCateg);
            puesto_usuario.DisplayMember = "tipo_usuario";
            puesto_usuario.DataSource = dtCateg;
        }
    }
}
