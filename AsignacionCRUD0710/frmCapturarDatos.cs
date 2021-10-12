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
            MySqlConnection conexionBD = conexion.conex();
            try
            {
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = ("INSERT INTO televisor(marca,modelo,color,size,year)" +
                    "values('" + tbxMarca.Text + "','" + tbxModelo.Text + "','" + tbxColor.Text + "'" +
                    ",'" + Convert.ToInt32(tbxSize.Text) + "','" + tbxYear.Text + "');");
                comando.ExecuteNonQuery();
                conexionBD.Close();
                MessageBox.Show("Datos registrados correctamente en la BD");
            }
            catch (Exception r)
            {

                MessageBox.Show(r.Message + r.StackTrace);
            }

            tbxMarca.Clear();
            tbxModelo.Clear();
            tbxColor.Clear();
            tbxSize.Clear();
            tbxYear.Clear();

        }
    }
}
