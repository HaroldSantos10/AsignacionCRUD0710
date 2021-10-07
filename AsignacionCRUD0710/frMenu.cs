using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignacionCRUD0710
{
    public partial class frMenu : Form
    {
        public frMenu()
        {
            InitializeComponent();
        }

        private void frMenu_Load(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanciamos al formulario
            frmTest frm = new frmTest();
            frm.MdiParent = this;//definir el formulario padre
            frm.Show();//mostrar el formulario
        }
    }
}
