using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Contraseñas.Clases
{
    internal class ClassConexion
    {
        MySqlConnection conex = new MySqlConnection();

        static string servidor = "localhost";
        static string db = "pcsolution";
        static string usuario = "root";
        static string pass = "162460132-2";
        static string puerto = "3306";

        string CadenaConexion = "server=" + servidor + ";" + "port=" + puerto +";" + "user id=" + usuario + ";" + "password=" + pass + ";" + "database=" + db + ";";
        
        public MySqlConnection EstablecerConn()
        {
            try
            {
                conex.ConnectionString = CadenaConexion;
                conex.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo hacer la conexion, error: "+ex.ToString());
            }
            return conex;
        }
        public void CerrarConn()
        {
            conex.Close();
        }
    }
}
