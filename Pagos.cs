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

namespace OfficeHouse
{
    public partial class Pagos : Form
    {
        

        public Pagos()
        {
            InitializeComponent();
           
        }


        private void btnpagar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnatras_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Registro_alquiler frm = new Registro_alquiler();
            frm.Show();
        }

        private void btntarjeta_Click_1(object sender, EventArgs e)
        {
            Datos_Tarjeta frm = new Datos_Tarjeta();
            frm.Show();
        }

        private void txt_Descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Num_Membresia_TextChanged(object sender, EventArgs e)
        {

        }
        public void datos()
        {
            
        }
        private void Pagos_Load(object sender, EventArgs e)
        {
            txt_Num_Membresia.Text = tipousuariopublico.numeromem;
            txt_Descripcion.Text = "Titulo="+ datospago.tituloalquiler+"   Autor=" +datospago.autoralquiler +"   Cantidad de libros= " +datospago.cantidadlibro + "";
            int cant;
            double precio, subt, Isv, total;
                       
            precio= datospago.precio;
            cant = datospago.cantidadlibro; 
            
            

            subt = cant * precio;
            Isv = subt * 0.15;
            total = subt + Isv;

            this.txt_subtotal.Text = subt.ToString();
            this.txt_isv.Text = Isv.ToString();
            this.txt_total.Text = total.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
