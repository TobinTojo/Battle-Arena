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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the game when pressed
            Application.Exit();
        }

        private void btnControls_Click(object sender, EventArgs e)
        {
            //Hides the menu and opens the controls form
            this.Hide();
            Form frmControls = new frmControls();
            frmControls.Visible = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Hides the menu and opens the character select form 
            this.Hide();
            Form frmCharacterSelect = new frmCharacterSelect();
            frmCharacterSelect.Visible = true;
        }

        private void btnPowerups_Click(object sender, EventArgs e)
        {
            //Hides the menu and opens the powerup form
            this.Hide();
            Form frmPowerups = new frmPowerups();
            frmPowerups.Visible = true;
        }

    }
}
