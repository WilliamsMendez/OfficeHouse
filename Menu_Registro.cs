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

namespace OfficeHouse
{
    public partial class Menu_Registro : Form
    {
        public Menu_Registro()
        {
            InitializeComponent();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_Libro frm = new Registro_Libro();
            frm.Show();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consulta_Libro frm = new Consulta_Libro();
            frm.Show();
        }

        private void btnGregistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Historial_registro frm = new Historial_registro();
            frm.Show();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            if(tipousuariopublico.tipousuario == "Gerente")
                {
                this.Hide();
                Menu_Gerente frm = new Menu_Gerente();
                frm.Show();

            }
                else
            {
                this.Hide();
                Menu_Empleado frm = new Menu_Empleado();
                frm.Show();
            }
        }
    }
}
