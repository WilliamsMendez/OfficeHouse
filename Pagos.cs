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
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
        }

        private void btntarjeta_Click(object sender, EventArgs e)
        {
            Datos_Tarjeta frm = new Datos_Tarjeta();
            frm.Show();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Close();
            Registro_Devolucion frm = new Registro_Devolucion();
            frm.Show();
        }
    }
}
