using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeHouse.clases
{
    /*internal class Cconexion
    {
        MySqlConnection conexion = new MySqlConnection();
        static string servidor = "b5ixdlvobetayca5mkmt-mysql.services.clever-cloud.com";
        static string db = "b5ixdlvobetayca5mkmt";
        static string usuario = "u4rfifleiqqauwst";
        static string password = "ZTTSrjjNnDg5BpwtsjeI";
        static string puerto = "3306";

        string cadeconexion = "server = " + servidor + ";" + "port = " + puerto + ";" + "user id = " + usuario + ";" + "password = " + password + ";" + "database =" + db + ";";

        public MySqlConnection establecerconexion()
        {
            try {
                conexion.ConnectionString = cadeconexion;
                conexion.Open();
                MessageBox.Show("Hubo conexion en la Base de Datos");
            
            }
            catch (MySqlException)
            {
                MessageBox.Show("No hubo conexion");
            
            }
            return conexion;
        }
    }*/

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


}
