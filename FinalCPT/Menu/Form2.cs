using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class frmControls : Form
    {
        public frmControls()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Hides the control form and opens the menu
            this.Hide();
            Form frmMenu = new frmMenu();
            frmMenu.Visible = true;
        }
    }
}
