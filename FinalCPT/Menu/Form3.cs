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
    public partial class frmCharacterSelect : Form
    {
       //global variabes  
        int Player = 0;
        public static int Player1;
        public static int Player2;
        public frmCharacterSelect()
        {
            InitializeComponent();
        }
        
        private void picDoomGuy_Click(object sender, EventArgs e)
        {
            //Sets player 1 to Doomguy
            picMario.Visible = false;
            picDoomGuy.Visible = false;
            picP1DoomGuy.Visible = true;
            Player1 = 1;
            Player++;

        }

        private void picMario_Click(object sender, EventArgs e)
        {
            //Sets player 1 to Mario
            picDoomGuy.Visible = false;
            picMario.Visible = false;
            picP1Mario.Visible = true;
            Player1 = 2;
            Player++;
        }

        private void picLink_Click(object sender, EventArgs e)
        {
            //Sets player 2 to Link
            picGuy.Visible = false;
            picLink.Visible = false;
            picP2Link.Visible = true;
            Player2 = 1;
            Player++;
        }

        private void picGuy_Click(object sender, EventArgs e)
        {
            //Sets player 2 to Guy
            picLink.Visible = false;
            picGuy.Visible = false;
            picP2Guy.Visible = true;
            Player2 = 2;
            Player++;
        }

      
        private void frmCharacterSelect_Load(object sender, EventArgs e)
        {          

        }

        private void tmrCharChosen_Tick(object sender, EventArgs e)
        {
            //If both players choose a character the button to play is visible
            if (Player == 2)
            {
                btnPlay.Visible = true;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Opens the game form and hides the character select
            this.Hide();
            Form frmGame1 = new frmGame1();
            frmGame1.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Hides the character select, and opens the menu
            this.Hide();
            Form frmMenu = new frmMenu();
            frmMenu.Visible = true;
        }
    }
}
