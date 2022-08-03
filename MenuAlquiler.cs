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
    public partial class MenuAlquiler : Form
    {
        public MenuAlquiler()
        {
            InitializeComponent();
        }

        private void MenuAlquiler_Load(object sender, EventArgs e)
        {
            
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            this.Hide();
           Registro_alquiler frm = new Registro_alquiler();
            frm.Show();
            
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consulta_Aquiler frm = new Consulta_Aquiler();
            frm.Show();
        }

        private void btnGregistro_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Historial_Alquiler frm = new Historial_Alquiler();
            //frm.Show();
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
