using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace AsignacionCRUD0710
{
    class conexion
    {
        public static MySqlConnection conex()
        {
            string servidor = @"Server=localhost;Database=smis001621;
                                    Uid=root;Pwd=usbw; SSL Mode=None";

            MySqlConnection conexionDB = new MySqlConnection(servidor);
            try
            {
                return conexionDB;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
                return null;
            }

        }
    }
}
