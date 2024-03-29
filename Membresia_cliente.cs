﻿using System;
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
            this.Hide();
            string comando = "SELECT id_cliente FROM cliente where id_cliente ='"+textBox1.Text+"' ";
            MySqlCommand codigo = new MySqlCommand(comando, CDB);
            MySqlDataAdapter adapter = new MySqlDataAdapter(codigo);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            
            if (dt.Rows.Count == 1)
            {
                if (pantallaav.av == 1)
                {
                    
                    MenuAlquiler frm = new MenuAlquiler();
                    frm.Show();
                }
                else
                {
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
            this.Hide();
            Menu_Gerente frm = new Menu_Gerente();
            frm.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >=32 && e.KeyChar <=47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                epError.SetError(textBox1, "Ingrese su menbresia....");
                textBox1.Focus  ();

            }
            else
            {
                epError.Clear();
            }
        }

        private void btnregistro_Validated(object sender, EventArgs e)
        {
            MessageBox.Show("Membresia:" + textBox1.Text);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
