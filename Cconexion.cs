﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeHouse.clases
{
    
    class Cconexion
    {
        public static MySqlConnection conex()
        {
            string servidor = "server = b5ixdlvobetayca5mkmt-mysql.services.clever-cloud.com ; database = b5ixdlvobetayca5mkmt ; Uid = u4rfifleiqqauwst ; pwd = ZTTSrjjNnDg5BpwtsjeI ";
            MySqlConnection conexionDB = new MySqlConnection(servidor);

            try
            {
                return conexionDB;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
                return null;
            }
        }
    }

    public class tipousuariopublico
    {
        static public string tipousuario;
        static public string numeromem;
    }

    public class pantallaav
    {
        static public int av;
    }

    public class datospago
    {
        static public double precio;
        static public string tituloalquiler;
        static public string autoralquiler;
        static public int cantidadlibro;
    }
}
