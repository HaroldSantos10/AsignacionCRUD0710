using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AsignacionCRUD0710
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string connectionString = "";
            MySqlConnection conn;

            //manejo de excepciones 
            try
            {
                connectionString = @"Server=localhost;Database=smis001621;
                                    Uid=root;Pwd=usbw; SSL Mode=None";
                conn = new MySqlConnection(connectionString);
                conn.Open();
                //MessageBox.Show("Se establecio conexión a la base de datos");
                MetroFramework.MetroMessageBox.Show(this,
                    "CONEXION EXITOSA","MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                conn.Close();
            }
            catch (Exception Ex)
            {
                //MessageBox.Show(Ex.Message); //mensaje con el sistema normal
                MetroFramework.MetroMessageBox.Show(this,
                    Ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Warning
                    );//mensaje usando el formato del frameWork

            }


        }
    }
}
