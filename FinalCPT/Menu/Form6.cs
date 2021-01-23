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
    public partial class frmPowerups : Form
    {
        public frmPowerups()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Hides the powerups form and shows the main menu
            this.Close();
            Form frmMenu = new frmMenu();
            frmMenu.Visible = true;
        }      
      
    }
}
