using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeHouse
{
    public partial class MenuDevolucion : Form
    {
        public MenuDevolucion()
        {
            InitializeComponent();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Membresia_cliente frm = new Membresia_cliente();
            frm.Show();
            
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consulta_Devolucion frm = new Consulta_Devolucion();
            frm.Show();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            this.Hide();
            Historial_Devolucion frm = new Historial_Devolucion();
            frm.Show();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDevolucion frm = new MenuDevolucion();
            frm.Show();
        }
    }
}
