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
    public partial class MenuDevolucion : Form
    {
        public MenuDevolucion()
        {
            InitializeComponent();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_Devolucion arm = new Registro_Devolucion();
            arm.Show();
            
            
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
            if (tipousuariopublico.tipousuario == "Gerente")
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
