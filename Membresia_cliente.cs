using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeHouse.clases;
using MySql.Data.MySqlClient;

namespace OfficeHouse
{
    public partial class Membresia_cliente : Form
    {
        private MySqlConnection conex;
        MySqlConnection CDB = Cconexion.conex();
        public Membresia_cliente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            
            string comando = "SELECT id_cliente FROM cliente where id_cliente ='"+textBox1.Text+"' ";
            MySqlCommand codigo = new MySqlCommand(comando, CDB);
            MySqlDataAdapter adapter = new MySqlDataAdapter(codigo);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            tipousuariopublico.numeromem = dt.Rows[0][0].ToString();
            if (dt.Rows.Count == 1)
            {
                if (pantallaav.av == 1)
                {
                    this.Hide();
                    MenuAlquiler frm = new MenuAlquiler();
                    frm.Show();
                }
                else
                {
                    this.Hide();
                    MenuDevolucion frm = new MenuDevolucion();
                    frm.Show();
                }
            }
            else
            {
                MessageBox.Show("Cliente no existente");

            }

        }

        private void btnusuario_Click(object sender, EventArgs e)
        {

        }
    }
}
