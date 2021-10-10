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
    public partial class frmCapturarDatos : Form
    {
        public frmCapturarDatos()
        {
            InitializeComponent();
        }

        private void frmCapturarDatos_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
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
                

                conn.Close();
            }
            catch (Exception Ex)
            {
                //MessageBox.Show(Ex.Message); //mensaje con el sistema normal
                MetroFramework.MetroMessageBox.Show(this,
                    Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );//mensaje usando el formato del frameWork

            }
        }
    }
}
