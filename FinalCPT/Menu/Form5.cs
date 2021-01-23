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
    public partial class frmGameWinner : Form
    {
        public frmGameWinner()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the Win form and opens the menu
            this.Close();
            Form frmMenu = new frmMenu();
            frmMenu.Visible = true;
        }

        private void frmGameWinner_Load(object sender, EventArgs e)
        {
            //If the winner is DoomGuy, then DoomGuy's picture is visible and the label for player 1 wins is visible.
            if (frmGame1.Win == 1)
            {
                picDoomGuy.Visible = true;
                lblP1Win.Visible = true;                   
            }

            //If the winner is Mario, then Mario's picture is visible and the label for player 1 wins is visible.
            if (frmGame1.Win == 2)
            {
                picMario.Visible = true;
                lblP1Win.Visible = true;
            }

            //If the winner is Link, then Link's picture is visible and the label for player 2 wins is visible.
            if (frmGame1.Win == 3)
            {
                picLink.Visible = true;
                lblP2Wins.Visible = true;
            }

            //If the winner is Guy, then Guy's picture is visible and the label for player 2 wins is visible. 
            if (frmGame1.Win == 4)
            {
                picGuy.Visible = true;
                lblP2Wins.Visible = true;
            }



        }
    }
}
