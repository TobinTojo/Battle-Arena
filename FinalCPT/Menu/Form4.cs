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
    //Makes movement enum for the characters and the bullets
    enum MoveState
    {
        Up,
        Down,
        Left,
        Right,
        None
    }
    public partial class frmGame1 : Form
    {
        //global variables
        MoveState Player1 = MoveState.None;
        MoveState Player2 = MoveState.None;
        MoveState BulletP1 = MoveState.None;
        MoveState BulletP2 = MoveState.None;
        bool RightP2 = false;
        bool LeftP2 = false;
        bool UpP2 = false;
        bool DownP2 = false;
        bool RightP1 = false;
        bool LeftP1 = false;
        bool UpP1 = false;
        bool DownP1 = false;
        int Player1Lives = 5;
        int Player2Lives = 5;
        int Count = 1;
        int Pause = 0;
        public static int Win = 0;
        int CountDown = 10;
        bool InvincibilityP1 = false;
        bool InvincibilityP2 = false;   

        public frmGame1()
        {
            InitializeComponent();
        }

        private void frmGame1_Load(object sender, EventArgs e)
        {
            //Enables timers for the powerups
            tmrHeart.Enabled = true;
            tmrStar.Enabled = true;

            //Player2
            
            //If the player2 chose Link, Link is visible, if they chose Guy, Guy is visible
            if (frmCharacterSelect.Player2 == 1)
            {
                picLinkLeft.BringToFront();
            }

            else
            {
                picGuyLeft.BringToFront();
            }

            //Player1

            //If the player1 chose Doomguy, Doomguy is visible, if they chose Mario, Mario is visible
            if (frmCharacterSelect.Player1 == 1)
            {
                picDoomGuyRight.BringToFront();
            }

            else
            {
                picMarioRight.BringToFront();
            }
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {     
            //checks if the players intersecs with the star powerup
            if (picLinkDown.Bounds.IntersectsWith(picStar.Bounds))
            {
            InvincibilityP2 = true;
	        picStar.Visible = false;
	        tmrCountDown.Enabled = true;
            }

            if (picMarioDown.Bounds.IntersectsWith(picStar.Bounds))
            {
	            InvincibilityP1 = true;
	            picStar.Visible = false;
	            tmrCountDown.Enabled = true;
            }


            //checks if the players intersects with the heart powerup
            if ((picLinkDown.Bounds.IntersectsWith(picHeart.Bounds)))
            {
                picHeart.Top = 4;
                picHeart.Visible = false;
                Player2Lives += 1;
                lblP2Lives.Text = Player2Lives.ToString();
            }

            if ((picMarioDown.Bounds.IntersectsWith(picHeart.Bounds)))
            {
                picHeart.Top = 4;
                picHeart.Visible = false;
                Player1Lives += 1;
                lblP1Lives.Text = Player1Lives.ToString();
            }


            //If player 2 lives is 0, then Player1 wins. tmrGame is stopped and new form opens.
            if (Player2Lives == 0)
            {
                if (frmCharacterSelect.Player1 == 1)
                {
                    Win = 1;
                }
                
                if (frmCharacterSelect.Player1 == 2)
                {
                    Win = 2;
                }
                
                tmrGame.Enabled = false;
                this.Close();
                Form frmGameWinner = new frmGameWinner();
                frmGameWinner.Visible = true;
            }
            //If player 1 lives is 0, then Player2 wins. tmrGame is stopped and new form opens.
            if (Player1Lives == 0)
            {
                if (frmCharacterSelect.Player2 == 1)
                {
                    Win = 3;
                }

                if (frmCharacterSelect.Player2 == 2)
                {
                    Win = 4;
                }

                tmrGame.Enabled = false;
                this.Close();
                Form frmGameWinner = new frmGameWinner();
                frmGameWinner.Visible = true;
            }
            
            //CollisionP2
            //Collision top border
            if (picLinkDown.Top < 76)
            {
                picLinkUp.Top = 77;
                picLinkDown.Top = 77;
                picLinkLeft.Top = 77;
                picLinkRight.Top = 77;
                picGuyUp.Top = 77;
                picGuyDown.Top = 77;
                picGuyLeft.Top = 77;
                picGuyRight.Top = 77;
            }
            //Collision bottom border
            if (picLinkDown.Top > 456)
            {
                picLinkUp.Top = 455;
                picLinkDown.Top = 455;
                picLinkLeft.Top = 455;
                picLinkRight.Top = 455;
                picGuyUp.Top = 455;
                picGuyDown.Top = 455;
                picGuyLeft.Top = 455;
                picGuyRight.Top = 455;
            }
            //Collision left border
            if (picLinkDown.Left <= 0)
            {
                picLinkUp.Left = 1;
                picLinkDown.Left = 1;
                picLinkLeft.Left = 1;
                picLinkRight.Left = 1;
                picGuyUp.Left = 1;
                picGuyDown.Left = 1;
                picGuyLeft.Left = 1;
                picGuyRight.Left = 1;
            }
            //Collision right border
            else if (picLinkDown.Right > ClientSize.Width)
            {
                picLinkUp.Left = ClientSize.Width - 30;
                picLinkDown.Left = ClientSize.Width - 30;
                picLinkLeft.Left = ClientSize.Width - 30;
                picLinkRight.Left = ClientSize.Width - 30;
                picGuyUp.Left = ClientSize.Width - 30;
                picGuyDown.Left = ClientSize.Width - 30;
                picGuyLeft.Left = ClientSize.Width - 30;
                picGuyRight.Left = ClientSize.Width - 30;
            }
            //CollisionP1
            if (picMarioDown.Top < 76)
            {
                picMarioUp.Top = 77;
                picMarioDown.Top = 77;
                picMarioLeft.Top = 77;
                picMarioRight.Top = 77;
                picDoomGuyUp.Top = 77;
                picDoomGuyDown.Top = 77;
                picDoomGuyLeft.Top = 77;
                picDoomGuyRight.Top = 77;
            }
            //Collision bottom border
            if (picMarioDown.Top > 456)
            {
                picMarioUp.Top = 455;
                picMarioDown.Top = 455;
                picMarioLeft.Top = 455;
                picMarioRight.Top = 455;
                picDoomGuyUp.Top = 455;
                picDoomGuyDown.Top = 455;
                picDoomGuyLeft.Top = 455;
                picDoomGuyRight.Top = 455;
            }
            //Collision left border
            if (picMarioDown.Left <= 0)
            {
                picMarioUp.Left = 1;
                picMarioDown.Left = 1;
                picMarioLeft.Left = 1;
                picMarioRight.Left = 1;
                picDoomGuyUp.Left = 1;
                picDoomGuyDown.Left = 1;
                picDoomGuyLeft.Left = 1;
                picDoomGuyRight.Left = 1;
            }
            //Collision right border
            else if (picMarioDown.Right > ClientSize.Width)
            {
                picMarioUp.Left = ClientSize.Width - 30;
                picMarioDown.Left = ClientSize.Width - 30;
                picMarioLeft.Left = ClientSize.Width - 30;
                picMarioRight.Left = ClientSize.Width - 30;
                picDoomGuyUp.Left = ClientSize.Width - 30;
                picDoomGuyDown.Left = ClientSize.Width - 30;
                picDoomGuyLeft.Left = ClientSize.Width - 30;
                picDoomGuyRight.Left = ClientSize.Width - 30;
            }
            //Player2

            //Depending on the character player 2 selects, when a button is pressed for the corresponding 
            //character, the sprite for that character shows and the character moves
            if (Player2 == MoveState.Up)
            {
                if (frmCharacterSelect.Player2 == 1)
                {
                    picLinkUp.BringToFront();
                }

                else
                {
                    picGuyUp.BringToFront();
                }


                picGuyDown.Top -= 5;
                picGuyLeft.Top -= 5;
                picGuyUp.Top -= 5;
                picGuyRight.Top -= 5;

                picLinkDown.Top -= 5;
                picLinkLeft.Top -= 5;
                picLinkUp.Top -= 5;
                picLinkRight.Top -= 5;
            }

            if (Player2 == MoveState.Down)
            {
                if (frmCharacterSelect.Player2 == 1)
                {
                    picLinkDown.BringToFront();
                }

                else
                {
                    picGuyDown.BringToFront();
                }
                picGuyDown.Top += 5;
                picGuyLeft.Top += 5;
                picGuyUp.Top += 5;
                picGuyRight.Top += 5;

                picLinkDown.Top += 5;
                picLinkLeft.Top += 5;
                picLinkUp.Top += 5;
                picLinkRight.Top += 5;
            }

            if (Player2 == MoveState.Right)
            {
                if (frmCharacterSelect.Player2 == 1)
                {
                    picLinkRight.BringToFront();
                }

                else
                {
                    picGuyRight.BringToFront();
                }
                picGuyDown.Left += 5;
                picGuyLeft.Left += 5;
                picGuyUp.Left += 5;
                picGuyRight.Left += 5;

                picLinkDown.Left += 5;
                picLinkLeft.Left += 5;
                picLinkUp.Left += 5;
                picLinkRight.Left += 5;
            }

            if (Player2 == MoveState.Left)
            {
                if (frmCharacterSelect.Player2 == 1)
                {
                    picLinkLeft.BringToFront();
                }

                else
                {
                    picGuyLeft.BringToFront();
                }
                picGuyDown.Left -= 5;
                picGuyLeft.Left -= 5;
                picGuyUp.Left -= 5;
                picGuyRight.Left -= 5;

                picLinkDown.Left -= 5;
                picLinkLeft.Left -= 5;
                picLinkUp.Left -= 5;
                picLinkRight.Left -= 5;
            }
            //BulletP2
            
            //Depending on the movestate of player 2, the bullet will fire in the direction they are facing
            //If the bullet collides with anything it dissapears and is moved
            if (BulletP2 == MoveState.Left)
            {
                picBulletP2.Left -= 10;
                if (picBulletP2.Bounds.IntersectsWith(picBulletP1.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder5.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder6.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder7.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder8.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder9.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder10.Bounds))))))))
                {
                    picBulletP1.Top = 0;
                    picBulletP1.Left = 0;
                    picBulletP2.Top = 963;
                    picBulletP2.Left = 497;
                    picBulletP2.Visible = false;
                    BulletP2 = MoveState.None;
                    BulletP1 = MoveState.None;

                }
            }
            if (picBulletP2.Bounds.IntersectsWith(picMarioDown.Bounds))
            {
                //If player1 is invincible, the bullet does no damage
                if (InvincibilityP1 != true)
                {
                    Player1Lives -= 1;
                    lblP1Lives.Text = Player1Lives.ToString();
                    picBulletP2.Top = 963;
                    picBulletP2.Left = 497;
                    picBulletP1.Top = 0;
                    picBulletP1.Left = 0;
                    Count = 0;
                    BulletP2 = MoveState.None;
                    BulletP1 = MoveState.None;
                    picBulletP2.Visible = false;
                    picMarioDown.Visible = false;
                    picMarioUp.Visible = false;
                    picMarioLeft.Visible = false;
                    picMarioRight.Visible = false;
                    picDoomGuyDown.Visible = false;
                    picDoomGuyUp.Visible = false;
                    picDoomGuyRight.Visible = false;
                    picDoomGuyLeft.Visible = false;

                    //Reset
                    picLinkUp.Top = 446;
                    picLinkDown.Top = 446;
                    picLinkLeft.Top = 446;
                    picLinkRight.Top = 446;
                    picGuyUp.Top = 446;
                    picGuyDown.Top = 446;
                    picGuyLeft.Top = 446;
                    picGuyRight.Top = 446;
                    picLinkUp.Left = 921;
                    picLinkDown.Left = 921;
                    picLinkLeft.Left = 921;
                    picLinkRight.Left = 921;
                    picGuyUp.Left = 921;
                    picGuyDown.Left = 921;
                    picGuyLeft.Left = 921;
                    picGuyRight.Left = 921;
                    picMarioUp.Top = 81;
                    picMarioDown.Top = 81;
                    picMarioLeft.Top = 81;
                    picMarioRight.Top = 81;
                    picDoomGuyUp.Top = 81;
                    picDoomGuyDown.Top = 81;
                    picDoomGuyLeft.Top = 81;
                    picDoomGuyRight.Top = 81;
                    picMarioUp.Left = 35;
                    picMarioDown.Left = 35;
                    picMarioLeft.Left = 35;
                    picMarioRight.Left = 35;
                    picDoomGuyUp.Left = 35;
                    picDoomGuyDown.Left = 35;
                    picDoomGuyLeft.Left = 35;
                    picDoomGuyRight.Left = 35;
                    tmrRespawn.Enabled = true;
                }
            }

            if (BulletP2 == MoveState.Right)
            {
                picBulletP2.Left += 10;
                if (picBulletP2.Bounds.IntersectsWith(picBulletP1.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder5.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder6.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder7.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder8.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder9.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder10.Bounds))))))))
                {
                    picBulletP1.Top = 0;
                    picBulletP1.Left = 0;
                    picBulletP2.Top = 963;
                    picBulletP2.Left = 497;
                    BulletP2 = MoveState.None;
                    BulletP1 = MoveState.None;
                    picBulletP2.Visible = false;
                }
                if (picBulletP2.Bounds.IntersectsWith(picMarioDown.Bounds))
                {
                    //If player1 is invincible, the bullet does no damage
                    if (InvincibilityP1 != true)
                    {
                        Player1Lives -= 1;
                        lblP1Lives.Text = Player1Lives.ToString();
                        picBulletP2.Top = 963;
                        picBulletP2.Left = 497;
                        picBulletP1.Top = 0;
                        picBulletP1.Left = 0;
                        Count = 0;
                        BulletP2 = MoveState.None;
                        BulletP1 = MoveState.None;
                        picBulletP2.Visible = false;
                        picMarioDown.Visible = false;
                        picMarioUp.Visible = false;
                        picMarioLeft.Visible = false;
                        picMarioRight.Visible = false;
                        picDoomGuyDown.Visible = false;
                        picDoomGuyUp.Visible = false;
                        picDoomGuyRight.Visible = false;
                        picDoomGuyLeft.Visible = false;
                        //Reset
                        picLinkUp.Top = 446;
                        picLinkDown.Top = 446;
                        picLinkLeft.Top = 446;
                        picLinkRight.Top = 446;
                        picGuyUp.Top = 446;
                        picGuyDown.Top = 446;
                        picGuyLeft.Top = 446;
                        picGuyRight.Top = 446;
                        picLinkUp.Left = 921;
                        picLinkDown.Left = 921;
                        picLinkLeft.Left = 921;
                        picLinkRight.Left = 921;
                        picGuyUp.Left = 921;
                        picGuyDown.Left = 921;
                        picGuyLeft.Left = 921;
                        picGuyRight.Left = 921;
                        picMarioUp.Top = 81;
                        picMarioDown.Top = 81;
                        picMarioLeft.Top = 81;
                        picMarioRight.Top = 81;
                        picDoomGuyUp.Top = 81;
                        picDoomGuyDown.Top = 81;
                        picDoomGuyLeft.Top = 81;
                        picDoomGuyRight.Top = 81;
                        picMarioUp.Left = 35;
                        picMarioDown.Left = 35;
                        picMarioLeft.Left = 35;
                        picMarioRight.Left = 35;
                        picDoomGuyUp.Left = 35;
                        picDoomGuyDown.Left = 35;
                        picDoomGuyLeft.Left = 35;
                        picDoomGuyRight.Left = 35;
                        tmrRespawn.Enabled = true;
                    }
                }
            }

            if (BulletP2 == MoveState.Down)
            {
                picBulletP2.Top += 10;
                if (picBulletP2.Bounds.IntersectsWith(picBorder3.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(pictureBox3.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBulletP1.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder5.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder6.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder7.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder8.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder9.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder10.Bounds))))))))))
                {
                    picBulletP1.Top = 0;
                    picBulletP1.Left = 0;
                    picBulletP2.Top = 963;
                    picBulletP2.Left = 496;
                    BulletP2 = MoveState.None;
                    BulletP1 = MoveState.None;

                }
                if (picBulletP2.Bounds.IntersectsWith(picMarioDown.Bounds))
                {
                    //If player1 is invincible, the bullet does no damage
                    if (InvincibilityP1 != true)
                    {
                        Player1Lives -= 1;
                        lblP1Lives.Text = Player1Lives.ToString();
                        picBulletP2.Top = 963;
                        picBulletP2.Left = 497;
                        picBulletP1.Top = 0;
                        picBulletP1.Left = 0;
                        Count = 0;
                        BulletP2 = MoveState.None;
                        BulletP1 = MoveState.None;
                        picBulletP2.Visible = false;
                        picMarioDown.Visible = false;
                        picMarioUp.Visible = false;
                        picMarioLeft.Visible = false;
                        picMarioRight.Visible = false;
                        picDoomGuyDown.Visible = false;
                        picDoomGuyUp.Visible = false;
                        picDoomGuyRight.Visible = false;
                        picDoomGuyLeft.Visible = false;
                        //Reset
                        picLinkUp.Top = 446;
                        picLinkDown.Top = 446;
                        picLinkLeft.Top = 446;
                        picLinkRight.Top = 446;
                        picGuyUp.Top = 446;
                        picGuyDown.Top = 446;
                        picGuyLeft.Top = 446;
                        picGuyRight.Top = 446;
                        picLinkUp.Left = 921;
                        picLinkDown.Left = 921;
                        picLinkLeft.Left = 921;
                        picLinkRight.Left = 921;
                        picGuyUp.Left = 921;
                        picGuyDown.Left = 921;
                        picGuyLeft.Left = 921;
                        picGuyRight.Left = 921;
                        picMarioUp.Top = 81;
                        picMarioDown.Top = 81;
                        picMarioLeft.Top = 81;
                        picMarioRight.Top = 81;
                        picDoomGuyUp.Top = 81;
                        picDoomGuyDown.Top = 81;
                        picDoomGuyLeft.Top = 81;
                        picDoomGuyRight.Top = 81;
                        picMarioUp.Left = 35;
                        picMarioDown.Left = 35;
                        picMarioLeft.Left = 35;
                        picMarioRight.Left = 35;
                        picDoomGuyUp.Left = 35;
                        picDoomGuyDown.Left = 35;
                        picDoomGuyLeft.Left = 35;
                        picDoomGuyRight.Left = 35;
                        tmrRespawn.Enabled = true;
                    }
                }
            }

            if (BulletP2 == MoveState.Up)
            {
                picBulletP2.Top -= 10;
                if (picBulletP2.Bounds.IntersectsWith(picBorder.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder2.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBulletP1.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder5.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder6.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder7.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder8.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder9.Bounds) ||
                    (picBulletP2.Bounds.IntersectsWith(picBorder10.Bounds))))))))))
                {
                    picBulletP1.Top = 0;
                    picBulletP1.Left = 0;
                    picBulletP2.Top = 963;
                    picBulletP2.Left = 497;
                    BulletP2 = MoveState.None;
                    BulletP1 = MoveState.None;
                    picBulletP2.Visible = false;
                }
                if (picBulletP2.Bounds.IntersectsWith(picMarioDown.Bounds))
                {
                    //If player1 is invincible, the bullet does no damage
                    if (InvincibilityP1 != true)
                    {
                        Player1Lives -= 1;
                        lblP1Lives.Text = Player1Lives.ToString();
                        picBulletP2.Top = 963;
                        picBulletP2.Left = 497;
                        picBulletP1.Top = 0;
                        picBulletP1.Left = 0;
                        Count = 0;
                        BulletP2 = MoveState.None;
                        BulletP1 = MoveState.None;
                        picBulletP2.Visible = false;
                        picMarioDown.Visible = false;
                        picMarioUp.Visible = false;
                        picMarioLeft.Visible = false;
                        picMarioRight.Visible = false;
                        picDoomGuyDown.Visible = false;
                        picDoomGuyUp.Visible = false;
                        picDoomGuyRight.Visible = false;
                        picDoomGuyLeft.Visible = false;
                        //Reset
                        picLinkUp.Top = 446;
                        picLinkDown.Top = 446;
                        picLinkLeft.Top = 446;
                        picLinkRight.Top = 446;
                        picGuyUp.Top = 446;
                        picGuyDown.Top = 446;
                        picGuyLeft.Top = 446;
                        picGuyRight.Top = 446;
                        picLinkUp.Left = 921;
                        picLinkDown.Left = 921;
                        picLinkLeft.Left = 921;
                        picLinkRight.Left = 921;
                        picGuyUp.Left = 921;
                        picGuyDown.Left = 921;
                        picGuyLeft.Left = 921;
                        picGuyRight.Left = 921;
                        picMarioUp.Top = 81;
                        picMarioDown.Top = 81;
                        picMarioLeft.Top = 81;
                        picMarioRight.Top = 81;
                        picDoomGuyUp.Top = 81;
                        picDoomGuyDown.Top = 81;
                        picDoomGuyLeft.Top = 81;
                        picDoomGuyRight.Top = 81;
                        picMarioUp.Left = 35;
                        picMarioDown.Left = 35;
                        picMarioLeft.Left = 35;
                        picMarioRight.Left = 35;
                        picDoomGuyUp.Left = 35;
                        picDoomGuyDown.Left = 35;
                        picDoomGuyLeft.Left = 35;
                        picDoomGuyRight.Left = 35;
                        tmrRespawn.Enabled = true;
                    }
                }
            }
            //MazeBoundsP1Up
            if (picMarioDown.Bounds.IntersectsWith(picBorder5.Bounds) && UpP1 == true)
            {
                picMarioUp.Top = 370;
                picMarioDown.Top = 370;
                picMarioLeft.Top = 370;
                picMarioRight.Top = 370;
                picDoomGuyUp.Top = 370;
                picDoomGuyDown.Top = 370;
                picDoomGuyLeft.Top = 370;
                picDoomGuyRight.Top = 370;
            }
            if (picMarioDown.Bounds.IntersectsWith(picBorder6.Bounds) && UpP1 == true)
            {
                picMarioUp.Top = 370;
                picMarioDown.Top = 370;
                picMarioLeft.Top = 370;
                picMarioRight.Top = 370;
                picDoomGuyUp.Top = 370;
                picDoomGuyDown.Top = 370;
                picDoomGuyLeft.Top = 370;
                picDoomGuyRight.Top = 370;
            }
            if (picMarioDown.Bounds.IntersectsWith(picBorder7.Bounds) && UpP1 == true)
            {
                picMarioUp.Top = 249;
                picMarioDown.Top = 249;
                picMarioLeft.Top = 249;
                picMarioRight.Top = 249;
                picDoomGuyUp.Top = 249;
                picDoomGuyDown.Top = 249;
                picDoomGuyLeft.Top = 249;
                picDoomGuyRight.Top = 249;
            }
            if (picMarioDown.Bounds.IntersectsWith(picBorder8.Bounds) && UpP1 == true)
            {
                picMarioUp.Top = 424;
                picMarioDown.Top = 424;
                picMarioLeft.Top = 424;
                picMarioRight.Top = 424;
                picDoomGuyUp.Top = 424;
                picDoomGuyDown.Top = 424;
                picDoomGuyLeft.Top = 424;
                picDoomGuyRight.Top = 424;
            }
            if (picMarioDown.Bounds.IntersectsWith(picBorder9.Bounds) && UpP1 == true)
            {
                picMarioUp.Top = 227;
                picMarioDown.Top = 227;
                picMarioLeft.Top = 227;
                picMarioRight.Top = 227;
                picDoomGuyUp.Top = 227;
                picDoomGuyDown.Top = 227;
                picDoomGuyLeft.Top = 227;
                picDoomGuyRight.Top = 227;
            }
            //MazeBoundsP1Down
            if (picMarioDown.Bounds.IntersectsWith(picBorder6.Bounds) && DownP1 == true)
            {
                picMarioUp.Top = 264;
                picMarioDown.Top = 264;
                picMarioLeft.Top = 264;
                picMarioRight.Top = 264;
                picDoomGuyUp.Top = 264;
                picDoomGuyDown.Top = 264;
                picDoomGuyLeft.Top = 264;
                picDoomGuyRight.Top = 264;
            }
            if (picMarioDown.Bounds.IntersectsWith(picBorder7.Bounds) && DownP1 == true)
            {
                picMarioUp.Top = 86;
                picMarioDown.Top = 86;
                picMarioLeft.Top = 86;
                picMarioRight.Top = 86;
                picDoomGuyUp.Top = 86;
                picDoomGuyDown.Top = 86;
                picDoomGuyLeft.Top = 86;
                picDoomGuyRight.Top = 86;
            }
            if (picMarioDown.Bounds.IntersectsWith(picBorder8.Bounds) && DownP1 == true)
            {
                picMarioUp.Top = 256;
                picMarioDown.Top = 256;
                picMarioLeft.Top = 256;
                picMarioRight.Top = 256;
                picDoomGuyUp.Top = 256;
                picDoomGuyDown.Top = 256;
                picDoomGuyLeft.Top = 256;
                picDoomGuyRight.Top = 256;
            }
            if (picMarioDown.Bounds.IntersectsWith(picBorder9.Bounds) && DownP1 == true)
            {
                picMarioUp.Top = 120;
                picMarioDown.Top = 120;
                picMarioLeft.Top = 120;
                picMarioRight.Top = 120;
                picDoomGuyUp.Top = 120;
                picDoomGuyDown.Top = 120;
                picDoomGuyLeft.Top = 120;
                picDoomGuyRight.Top = 120;
            }
            //MazeBoundsLeftP1
            if (picMarioDown.Bounds.IntersectsWith(picBorder5.Bounds) && RightP1 == true)
            {
                picMarioUp.Left = 68;
                picMarioDown.Left = 68;
                picMarioLeft.Left = 68;
                picMarioRight.Left = 68;
                picDoomGuyUp.Left = 68;
                picDoomGuyDown.Left = 68;
                picDoomGuyLeft.Left = 68;
                picDoomGuyRight.Left = 68;
            }
            if (picMarioDown.Bounds.IntersectsWith(picBorder7.Bounds) && RightP1 == true)
            {
                picMarioUp.Left = 377;
                picMarioDown.Left = 377;
                picMarioLeft.Left = 377;
                picMarioRight.Left = 377;
                picDoomGuyUp.Left = 377;
                picDoomGuyDown.Left = 377;
                picDoomGuyLeft.Left = 377;
                picDoomGuyRight.Left = 377;
            }
            if (picMarioDown.Bounds.IntersectsWith(picBorder8.Bounds) && RightP1 == true)
            {
                picMarioUp.Left = 561;
                picMarioDown.Left = 561;
                picMarioLeft.Left = 561;
                picMarioRight.Left = 561;
                picDoomGuyUp.Left = 561;
                picDoomGuyDown.Left = 561;
                picDoomGuyLeft.Left = 561;
                picDoomGuyRight.Left = 561;
            }
            if (picMarioDown.Bounds.IntersectsWith(picBorder9.Bounds) && RightP1 == true)
            {
                picMarioUp.Left = 561;
                picMarioDown.Left = 561;
                picMarioLeft.Left = 561;
                picMarioRight.Left = 561;
                picDoomGuyUp.Left = 561;
                picDoomGuyDown.Left = 561;
                picDoomGuyLeft.Left = 561;
                picDoomGuyRight.Left = 561;
            }
            if (picMarioDown.Bounds.IntersectsWith(picBorder10.Bounds) && RightP1 == true)
            {
                picMarioUp.Left = 789;
                picMarioDown.Left = 789;
                picMarioLeft.Left = 789;
                picMarioRight.Left = 789;
                picDoomGuyUp.Left = 789;
                picDoomGuyDown.Left = 789;
                picDoomGuyLeft.Left = 789;
                picDoomGuyRight.Left = 789;
            }
            //MazeBoundsP1Right
            if (picMarioDown.Bounds.IntersectsWith(picBorder5.Bounds) && LeftP1 == true)
            {
                picMarioUp.Left = 175;
                picMarioDown.Left = 175;
                picMarioLeft.Left = 175;
                picMarioRight.Left = 175;
                picDoomGuyUp.Left = 175;
                picDoomGuyDown.Left = 175;
                picDoomGuyLeft.Left = 175;
                picDoomGuyRight.Left = 175;
            }
            if (picMarioDown.Bounds.IntersectsWith(picBorder6.Bounds) && LeftP1 == true)
            {
                picMarioUp.Left = 456;
                picMarioDown.Left = 456;
                picMarioLeft.Left = 456;
                picMarioRight.Left = 456;
                picDoomGuyUp.Left = 456;
                picDoomGuyDown.Left = 456;
                picDoomGuyLeft.Left = 456;
                picDoomGuyRight.Left = 456;
            }
            if (picMarioDown.Bounds.IntersectsWith(picBorder7.Bounds) && LeftP1 == true)
            {
                picMarioUp.Left = 456;
                picMarioDown.Left = 456;
                picMarioLeft.Left = 456;
                picMarioRight.Left = 456;
                picDoomGuyUp.Left = 456;
                picDoomGuyDown.Left = 456;
                picDoomGuyLeft.Left = 456;
                picDoomGuyRight.Left = 456;
            }
            if (picMarioDown.Bounds.IntersectsWith(picBorder8.Bounds) && LeftP1 == true)
            {
                picMarioUp.Left = 645;
                picMarioDown.Left = 645;
                picMarioLeft.Left = 645;
                picMarioRight.Left = 645;
                picDoomGuyUp.Left = 645;
                picDoomGuyDown.Left = 645;
                picDoomGuyLeft.Left = 645;
                picDoomGuyRight.Left = 645;
            }
            if (picMarioDown.Bounds.IntersectsWith(picBorder9.Bounds) && LeftP1 == true)
            {
                picMarioUp.Left = 896;
                picMarioDown.Left = 896;
                picMarioLeft.Left = 896;
                picMarioRight.Left = 896;
                picDoomGuyUp.Left = 896;
                picDoomGuyDown.Left = 896;
                picDoomGuyLeft.Left = 896;
                picDoomGuyRight.Left = 896;
            }
            if (picMarioDown.Bounds.IntersectsWith(picBorder10.Bounds) && LeftP1 == true)
            {
                picMarioUp.Left = 896;
                picMarioDown.Left = 896;
                picMarioLeft.Left = 896;
                picMarioRight.Left = 896;
                picDoomGuyUp.Left = 896;
                picDoomGuyDown.Left = 896;
                picDoomGuyLeft.Left = 896;
                picDoomGuyRight.Left = 896;
            }
            //MazeBoundsP2Up
            if (picLinkDown.Bounds.IntersectsWith(picBorder5.Bounds) && UpP2 == true)
            {
                picLinkUp.Top = 370;
                picLinkDown.Top = 370;
                picLinkLeft.Top = 370;
                picLinkRight.Top = 370;
                picGuyUp.Top = 370;
                picGuyDown.Top = 370;
                picGuyLeft.Top = 370;
                picGuyRight.Top = 370;
            }
            if (picLinkDown.Bounds.IntersectsWith(picBorder6.Bounds) && UpP2 == true)
            {
                picLinkUp.Top = 370;
                picLinkDown.Top = 370;
                picLinkLeft.Top = 370;
                picLinkRight.Top = 370;
                picGuyUp.Top = 370;
                picGuyDown.Top = 370;
                picGuyLeft.Top = 370;
                picGuyRight.Top = 370;
            }
            if (picLinkDown.Bounds.IntersectsWith(picBorder7.Bounds) && UpP2 == true)
            {
                picLinkUp.Top = 249;
                picLinkDown.Top = 249;
                picLinkLeft.Top = 249;
                picLinkRight.Top = 249;
                picGuyUp.Top = 249;
                picGuyDown.Top = 249;
                picGuyLeft.Top = 249;
                picGuyRight.Top = 249;
            }
            if (picLinkDown.Bounds.IntersectsWith(picBorder8.Bounds) && UpP2 == true)
            {
                picLinkUp.Top = 424;
                picLinkDown.Top = 424;
                picLinkLeft.Top = 424;
                picLinkRight.Top = 424;
                picGuyUp.Top = 424;
                picGuyDown.Top = 424;
                picGuyLeft.Top = 424;
                picGuyRight.Top = 424;
            }
            if (picLinkDown.Bounds.IntersectsWith(picBorder9.Bounds) && UpP2 == true)
            {
                picLinkUp.Top = 227;
                picLinkDown.Top = 227;
                picLinkLeft.Top = 227;
                picLinkRight.Top = 227;
                picGuyUp.Top = 227;
                picGuyDown.Top = 227;
                picGuyLeft.Top = 227;
                picGuyRight.Top = 227;
            }
            //MazeBoundsP2Down
            if (picLinkDown.Bounds.IntersectsWith(picBorder6.Bounds) && DownP2 == true)
            {
                picLinkUp.Top = 264;
                picLinkDown.Top = 264;
                picLinkLeft.Top = 264;
                picLinkRight.Top = 264;
                picGuyUp.Top = 264;
                picGuyDown.Top = 264;
                picGuyLeft.Top = 264;
                picGuyRight.Top = 264;
            }
            if (picLinkDown.Bounds.IntersectsWith(picBorder7.Bounds) && DownP2 == true)
            {
                picLinkUp.Top = 86;
                picLinkDown.Top = 86;
                picLinkLeft.Top = 86;
                picLinkRight.Top = 86;
                picGuyUp.Top = 86;
                picGuyDown.Top = 86;
                picGuyLeft.Top = 86;
                picGuyRight.Top = 86;
            }
            if (picLinkDown.Bounds.IntersectsWith(picBorder8.Bounds) && DownP2 == true)
            {
                picLinkUp.Top = 256;
                picLinkDown.Top = 256;
                picLinkLeft.Top = 256;
                picLinkRight.Top = 256;
                picGuyUp.Top = 256;
                picGuyDown.Top = 256;
                picGuyLeft.Top = 256;
                picGuyRight.Top = 256;
            }
            if (picLinkDown.Bounds.IntersectsWith(picBorder9.Bounds) && DownP2 == true)
            {
                picLinkUp.Top = 120;
                picLinkDown.Top = 120;
                picLinkLeft.Top = 120;
                picLinkRight.Top = 120;
                picGuyUp.Top = 120;
                picGuyDown.Top = 120;
                picGuyLeft.Top = 120;
                picGuyRight.Top = 120;
            }
            //MazeBoundsP2Left
            if (picLinkDown.Bounds.IntersectsWith(picBorder5.Bounds) && RightP2 == true)
            {
                picLinkUp.Left = 68;
                picLinkDown.Left = 68;
                picLinkLeft.Left = 68;
                picLinkRight.Left = 68;
                picGuyUp.Left = 68;
                picGuyDown.Left = 68;
                picGuyLeft.Left = 68;
                picGuyRight.Left = 68;
            }
            if (picLinkDown.Bounds.IntersectsWith(picBorder7.Bounds) && RightP2 == true)
            {
                picLinkUp.Left = 377;
                picLinkDown.Left = 377;
                picLinkLeft.Left = 377;
                picLinkRight.Left = 377;
                picGuyUp.Left = 377;
                picGuyDown.Left = 377;
                picGuyLeft.Left = 377;
                picGuyRight.Left = 377;
            }
            if (picLinkDown.Bounds.IntersectsWith(picBorder8.Bounds) && RightP2 == true)
            {
                picLinkUp.Left = 561;
                picLinkDown.Left = 561;
                picLinkLeft.Left = 561;
                picLinkRight.Left = 561;
                picGuyUp.Left = 561;
                picGuyDown.Left = 561;
                picGuyLeft.Left = 561;
                picGuyRight.Left = 561;
            }
            if (picLinkDown.Bounds.IntersectsWith(picBorder9.Bounds) && RightP2 == true)
            {
                picLinkUp.Left = 561;
                picLinkDown.Left = 561;
                picLinkLeft.Left = 561;
                picLinkRight.Left = 561;
                picGuyUp.Left = 561;
                picGuyDown.Left = 561;
                picGuyLeft.Left = 561;
                picGuyRight.Left = 561;
            }
            if (picLinkDown.Bounds.IntersectsWith(picBorder10.Bounds) && RightP2 == true)
            {
                picLinkUp.Left = 789;
                picLinkDown.Left = 789;
                picLinkLeft.Left = 789;
                picLinkRight.Left = 789;
                picGuyUp.Left = 789;
                picGuyDown.Left = 789;
                picGuyLeft.Left = 789;
                picGuyRight.Left = 789;
            }
            //MazeBoundsP2Right
            if (picLinkDown.Bounds.IntersectsWith(picBorder5.Bounds) && LeftP2 == true)
            {
                picLinkUp.Left = 175;
                picLinkDown.Left = 175;
                picLinkLeft.Left = 175;
                picLinkRight.Left = 175;
                picGuyUp.Left = 175;
                picGuyDown.Left = 175;
                picGuyLeft.Left = 175;
                picGuyRight.Left = 175;
            }
            if (picLinkDown.Bounds.IntersectsWith(picBorder6.Bounds) && LeftP2 == true)
            {
                picLinkUp.Left = 456;
                picLinkDown.Left = 456;
                picLinkLeft.Left = 456;
                picLinkRight.Left = 456;
                picGuyUp.Left = 456;
                picGuyDown.Left = 456;
                picGuyLeft.Left = 456;
                picGuyRight.Left = 456;
            }
            if (picLinkDown.Bounds.IntersectsWith(picBorder7.Bounds) && LeftP2 == true)
            {
                picLinkUp.Left = 456;
                picLinkDown.Left = 456;
                picLinkLeft.Left = 456;
                picLinkRight.Left = 456;
                picGuyUp.Left = 456;
                picGuyDown.Left = 456;
                picGuyLeft.Left = 456;
                picGuyRight.Left = 456;
            }
            if (picLinkDown.Bounds.IntersectsWith(picBorder8.Bounds) && LeftP2 == true)
            {
                picLinkUp.Left = 645;
                picLinkDown.Left = 645;
                picLinkLeft.Left = 645;
                picLinkRight.Left = 645;
                picGuyUp.Left = 645;
                picGuyDown.Left = 645;
                picGuyLeft.Left = 645;
                picGuyRight.Left = 645;
            }
            if (picLinkDown.Bounds.IntersectsWith(picBorder9.Bounds) && LeftP2 == true)
            {
                picLinkUp.Left = 896;
                picLinkDown.Left = 896;
                picLinkLeft.Left = 896;
                picLinkRight.Left = 896;
                picGuyUp.Left = 896;
                picGuyDown.Left = 896;
                picGuyLeft.Left = 896;
                picGuyRight.Left = 896;
            }
            if (picLinkDown.Bounds.IntersectsWith(picBorder10.Bounds) && LeftP2 == true)
            {
                picLinkUp.Left = 896;
                picLinkDown.Left = 896;
                picLinkLeft.Left = 896;
                picLinkRight.Left = 896;
                picGuyUp.Left = 896;
                picGuyDown.Left = 896;
                picGuyLeft.Left = 896;
                picGuyRight.Left = 896;
            }

            //Player1

            //Depending on the character player 1 selects, when a button is pressed for the corresponding 
            //character, the sprite for that character shows and the character moves
            if (Player1 == MoveState.Up)
            {
                if (frmCharacterSelect.Player1 == 1)
                {
                    picDoomGuyUp.BringToFront();
                }

                else
                {
                    picMarioUp.BringToFront();
                }
                picDoomGuyDown.Top -= 5;
                picDoomGuyLeft.Top -= 5;
                picDoomGuyUp.Top -= 5;
                picDoomGuyRight.Top -= 5;

                picMarioDown.Top -= 5;
                picMarioLeft.Top -= 5;
                picMarioUp.Top -= 5;
                picMarioRight.Top -= 5;
            }

            if (Player1 == MoveState.Down)
            {
                if (frmCharacterSelect.Player1 == 1)
                {
                    picDoomGuyDown.BringToFront();
                }

                else
                {
                    picMarioDown.BringToFront();
                }
                picDoomGuyDown.Top += 5;
                picDoomGuyLeft.Top += 5;
                picDoomGuyUp.Top += 5;
                picDoomGuyRight.Top += 5;

                picMarioDown.Top += 5;
                picMarioLeft.Top += 5;
                picMarioUp.Top += 5;
                picMarioRight.Top += 5;
            }

            if (Player1 == MoveState.Right)
            {
                if (frmCharacterSelect.Player1 == 1)
                {
                    picDoomGuyRight.BringToFront();
                }

                else
                {
                    picMarioRight.BringToFront();
                }
                picDoomGuyDown.Left += 5;
                picDoomGuyLeft.Left += 5;
                picDoomGuyUp.Left += 5;
                picDoomGuyRight.Left += 5;

                picMarioDown.Left += 5;
                picMarioLeft.Left += 5;
                picMarioUp.Left += 5;
                picMarioRight.Left += 5;
            }

            if (Player1 == MoveState.Left)
            {
                if (frmCharacterSelect.Player1 == 1)
                {
                    picDoomGuyLeft.BringToFront();
                }

                else
                {
                    picMarioLeft.BringToFront();
                }
                picDoomGuyDown.Left -= 5;
                picDoomGuyLeft.Left -= 5;
                picDoomGuyUp.Left -= 5;
                picDoomGuyRight.Left -= 5;

                picMarioDown.Left -= 5;
                picMarioLeft.Left -= 5;
                picMarioUp.Left -= 5;
                picMarioRight.Left -= 5;
            }
            //BulletP1

            //Depending on the movestate of player 1, the bullet will fire in the direction they are facing
            //If the bullet collides with anything it dissapears and is moved
            if (BulletP1 == MoveState.Left)
            {
                picBulletP1.Left -= 10;
                if (picBulletP1.Bounds.IntersectsWith(picBulletP2.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder5.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder6.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder7.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder8.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder9.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder10.Bounds))))))))
                {
                    picBulletP1.Top = 0;
                    picBulletP1.Left = 0;
                    picBulletP2.Top = 963;
                    picBulletP2.Left = 497;
                    BulletP2 = MoveState.None;
                    BulletP1 = MoveState.None;
                    picBulletP1.Visible = false;

                }
                if (picBulletP1.Bounds.IntersectsWith(picLinkDown.Bounds))
                {
                    //If player1 is invincible, the bullet does no damage
                    if (InvincibilityP2 != true)
                    {
                        Player2Lives -= 1;
                        lblP2Lives.Text = Player2Lives.ToString();
                        picBulletP1.Top = 0;
                        picBulletP1.Left = 0;
                        picBulletP2.Top = 963;
                        picBulletP2.Left = 497;
                        Count = 0;
                        BulletP2 = MoveState.None;
                        BulletP1 = MoveState.None;
                        picBulletP1.Visible = false;
                        picLinkDown.Visible = false;
                        picLinkUp.Visible = false;
                        picLinkLeft.Visible = false;
                        picLinkRight.Visible = false;
                        picGuyDown.Visible = false;
                        picGuyUp.Visible = false;
                        picGuyLeft.Visible = false;
                        picGuyRight.Visible = false;
                        //Reset
                        picMarioUp.Top = 81;
                        picMarioDown.Top = 81;
                        picMarioLeft.Top = 81;
                        picMarioRight.Top = 81;
                        picDoomGuyUp.Top = 81;
                        picDoomGuyDown.Top = 81;
                        picDoomGuyLeft.Top = 81;
                        picDoomGuyRight.Top = 81;
                        picMarioUp.Left = 35;
                        picMarioDown.Left = 35;
                        picMarioLeft.Left = 35;
                        picMarioRight.Left = 35;
                        picDoomGuyUp.Left = 35;
                        picDoomGuyDown.Left = 35;
                        picDoomGuyLeft.Left = 35;
                        picDoomGuyRight.Left = 35;
                        picLinkUp.Top = 446;
                        picLinkDown.Top = 446;
                        picLinkLeft.Top = 446;
                        picLinkRight.Top = 446;
                        picGuyUp.Top = 446;
                        picGuyDown.Top = 446;
                        picGuyLeft.Top = 446;
                        picGuyRight.Top = 446;
                        picLinkUp.Left = 921;
                        picLinkDown.Left = 921;
                        picLinkLeft.Left = 921;
                        picLinkRight.Left = 921;
                        picGuyUp.Left = 921;
                        picGuyDown.Left = 921;
                        picGuyLeft.Left = 921;
                        picGuyRight.Left = 921;
                        tmrRespawn.Enabled = true;
                    }
                }
            }

            if (BulletP1 == MoveState.Right)
            {
                picBulletP1.Left += 10;
                if (picBulletP1.Bounds.IntersectsWith(picBulletP2.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder5.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder6.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder7.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder8.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder9.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder10.Bounds))))))))
                {
                    picBulletP1.Top = 0;
                    picBulletP1.Left = 0;
                    picBulletP2.Top = 963;
                    picBulletP2.Left = 497;
                    BulletP2 = MoveState.None;
                    BulletP1 = MoveState.None;
                    picBulletP1.Visible = false;
                }
                if (picBulletP1.Bounds.IntersectsWith(picLinkDown.Bounds))
                {
                    //If player1 is invincible, the bullet does no damage
                    if (InvincibilityP2 != true)
                    {
                        Player2Lives -= 1;
                        lblP2Lives.Text = Player2Lives.ToString();
                        picBulletP1.Top = 0;
                        picBulletP1.Left = 0;
                        picBulletP2.Top = 963;
                        picBulletP2.Left = 497;
                        Count = 0;
                        BulletP2 = MoveState.None;
                        BulletP1 = MoveState.None;
                        picBulletP1.Visible = false;
                        picLinkDown.Visible = false;
                        picLinkUp.Visible = false;
                        picLinkLeft.Visible = false;
                        picLinkRight.Visible = false;
                        picGuyDown.Visible = false;
                        picGuyUp.Visible = false;
                        picGuyLeft.Visible = false;
                        picGuyRight.Visible = false;
                        //Reset
                        picMarioUp.Top = 81;
                        picMarioDown.Top = 81;
                        picMarioLeft.Top = 81;
                        picMarioRight.Top = 81;
                        picDoomGuyUp.Top = 81;
                        picDoomGuyDown.Top = 81;
                        picDoomGuyLeft.Top = 81;
                        picDoomGuyRight.Top = 81;
                        picMarioUp.Left = 35;
                        picMarioDown.Left = 35;
                        picMarioLeft.Left = 35;
                        picMarioRight.Left = 35;
                        picDoomGuyUp.Left = 35;
                        picDoomGuyDown.Left = 35;
                        picDoomGuyLeft.Left = 35;
                        picDoomGuyRight.Left = 35;
                        picLinkUp.Top = 446;
                        picLinkDown.Top = 446;
                        picLinkLeft.Top = 446;
                        picLinkRight.Top = 446;
                        picGuyUp.Top = 446;
                        picGuyDown.Top = 446;
                        picGuyLeft.Top = 446;
                        picGuyRight.Top = 446;
                        picLinkUp.Left = 921;
                        picLinkDown.Left = 921;
                        picLinkLeft.Left = 921;
                        picLinkRight.Left = 921;
                        picGuyUp.Left = 921;
                        picGuyDown.Left = 921;
                        picGuyLeft.Left = 921;
                        picGuyRight.Left = 921;
                        tmrRespawn.Enabled = true;
                    }
                }
            }

            if (BulletP1 == MoveState.Down)
            {
                picBulletP1.Top += 10;
                if (picBulletP1.Bounds.IntersectsWith(picBorder3.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(pictureBox3.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBulletP2.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder5.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder6.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder7.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder8.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder9.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder10.Bounds))))))))))
                {
                    picBulletP1.Top = 0;
                    picBulletP1.Left = 0;
                    picBulletP2.Top = 963;
                    picBulletP2.Left = 497;
                    BulletP2 = MoveState.None;
                    BulletP1 = MoveState.None;
                    picBulletP1.Visible = false;
                }
                if (picBulletP1.Bounds.IntersectsWith(picLinkDown.Bounds))
                {
                    //If player1 is invincible, the bullet does no damage
                    if (InvincibilityP2 != true)
                    {
                        Player2Lives -= 1;
                        lblP2Lives.Text = Player2Lives.ToString();
                        picBulletP1.Top = 0;
                        picBulletP1.Left = 0;
                        picBulletP2.Top = 963;
                        picBulletP2.Left = 497;
                        Count = 0;
                        BulletP2 = MoveState.None;
                        BulletP1 = MoveState.None;
                        picBulletP1.Visible = false;
                        picLinkDown.Visible = false;
                        picLinkUp.Visible = false;
                        picLinkLeft.Visible = false;
                        picLinkRight.Visible = false;
                        picGuyDown.Visible = false;
                        picGuyUp.Visible = false;
                        picGuyLeft.Visible = false;
                        picGuyRight.Visible = false;
                        //Reset
                        picMarioUp.Top = 81;
                        picMarioDown.Top = 81;
                        picMarioLeft.Top = 81;
                        picMarioRight.Top = 81;
                        picDoomGuyUp.Top = 81;
                        picDoomGuyDown.Top = 81;
                        picDoomGuyLeft.Top = 81;
                        picDoomGuyRight.Top = 81;
                        picMarioUp.Left = 35;
                        picMarioDown.Left = 35;
                        picMarioLeft.Left = 35;
                        picMarioRight.Left = 35;
                        picDoomGuyUp.Left = 35;
                        picDoomGuyDown.Left = 35;
                        picDoomGuyLeft.Left = 35;
                        picDoomGuyRight.Left = 35;
                        picLinkUp.Top = 446;
                        picLinkDown.Top = 446;
                        picLinkLeft.Top = 446;
                        picLinkRight.Top = 446;
                        picGuyUp.Top = 446;
                        picGuyDown.Top = 446;
                        picGuyLeft.Top = 446;
                        picGuyRight.Top = 446;
                        picLinkUp.Left = 921;
                        picLinkDown.Left = 921;
                        picLinkLeft.Left = 921;
                        picLinkRight.Left = 921;
                        picGuyUp.Left = 921;
                        picGuyDown.Left = 921;
                        picGuyLeft.Left = 921;
                        picGuyRight.Left = 921;
                        tmrRespawn.Enabled = true;
                    }
                }
            }

            if (BulletP1 == MoveState.Up)
            {
                picBulletP1.Top -= 10;
                if (picBulletP1.Bounds.IntersectsWith(picBorder.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder2.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBulletP2.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder5.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder6.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder7.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder8.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder9.Bounds) ||
                    (picBulletP1.Bounds.IntersectsWith(picBorder10.Bounds))))))))))
                {
                    picBulletP1.Top = 0;
                    picBulletP1.Left = 0;
                    picBulletP2.Top = 963;
                    picBulletP2.Left = 497;                    
                    BulletP2 = MoveState.None;
                    BulletP1 = MoveState.None;
                    picBulletP1.Visible = false;
                }
                if (picBulletP1.Bounds.IntersectsWith(picLinkDown.Bounds))
                {
                    //If player1 is invincible, the bullet does no damage
                    if (InvincibilityP2 != true)
                    {
                        Player2Lives -= 1;
                        lblP2Lives.Text = Player2Lives.ToString();
                        picBulletP1.Top = 0;
                        picBulletP1.Left = 0;
                        picBulletP2.Top = 963;
                        picBulletP2.Left = 497;
                        Count = 0;
                        BulletP2 = MoveState.None;
                        BulletP1 = MoveState.None;
                        picBulletP1.Visible = false;
                        picLinkDown.Visible = false;
                        picLinkUp.Visible = false;
                        picLinkLeft.Visible = false;
                        picLinkRight.Visible = false;
                        picGuyDown.Visible = false;
                        picGuyUp.Visible = false;
                        picGuyLeft.Visible = false;
                        picGuyRight.Visible = false;
                        //Reset
                        picMarioUp.Top = 81;
                        picMarioDown.Top = 81;
                        picMarioLeft.Top = 81;
                        picMarioRight.Top = 81;
                        picDoomGuyUp.Top = 81;
                        picDoomGuyDown.Top = 81;
                        picDoomGuyLeft.Top = 81;
                        picDoomGuyRight.Top = 81;
                        picMarioUp.Left = 35;
                        picMarioDown.Left = 35;
                        picMarioLeft.Left = 35;
                        picMarioRight.Left = 35;
                        picDoomGuyUp.Left = 35;
                        picDoomGuyDown.Left = 35;
                        picDoomGuyLeft.Left = 35;
                        picDoomGuyRight.Left = 35;
                        picLinkUp.Top = 446;
                        picLinkDown.Top = 446;
                        picLinkLeft.Top = 446;
                        picLinkRight.Top = 446;
                        picGuyUp.Top = 446;
                        picGuyDown.Top = 446;
                        picGuyLeft.Top = 446;
                        picGuyRight.Top = 446;
                        picLinkUp.Left = 921;
                        picLinkDown.Left = 921;
                        picLinkLeft.Left = 921;
                        picLinkRight.Left = 921;
                        picGuyUp.Left = 921;
                        picGuyDown.Left = 921;
                        picGuyLeft.Left = 921;
                        picGuyRight.Left = 921;
                        tmrRespawn.Enabled = true;
                    }
                }
            }
        }

        private void frmGame1_KeyDown(object sender, KeyEventArgs e)
        {
            //If the escape key is pressed, tmrGame is stopped, which stops the whole game and a label 
            //shows the controls
            if (e.KeyCode == Keys.Escape)
            {
                lblEscape.Visible = false;
                Pause++;
                if (Pause == 1)
                {
                    lblPause.Visible = true;
                    tmrGame.Enabled = false;
                }
                //When the escape key is pressed the second time it stars tmrGame which unpauses the game and removes the label
                if (Pause == 2)
                {
                    lblPause.Visible = false;
                    Pause = 0;
                    tmrGame.Enabled = true;
                }
            }
            //If the game is paused and the enter key is pressed, the game form exits and the main menu shows
            if (e.KeyCode == Keys.Enter)
            {
                if (Pause == 1)
                {
                    this.Close();
                    Form frmMenu = new frmMenu();
                    frmMenu.Visible = true;
                }
            }
            //Player2

            //Sets the movestate of the character based on the key thats pressed
            if (e.KeyCode == Keys.Down)
            {
                Player2 = MoveState.Down;
                LeftP2 = false;
                RightP2 = false;
                UpP2 = false;
                DownP2 = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                Player2 = MoveState.Up;
                LeftP2 = false;
                RightP2 = false;
                UpP2 = true;
                DownP2 = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                Player2 = MoveState.Right;
                LeftP2 = false;
                RightP2 = true;
                UpP2 = false;
                DownP2 = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                Player2 = MoveState.Left;
                LeftP2 = true;
                RightP2 = false;
                UpP2 = false;
                DownP2 = false;
            }
            //BulletP2

            //Shoots the bullet in the direction the player is facing as long as the bullet is not already in motion
            if (e.KeyCode == Keys.NumPad0 && LeftP2 == true && BulletP2 == MoveState.None)
            {
                picBulletP2.BringToFront();
                picBulletP2.Visible = true;
                BulletP2 = MoveState.Left;
                picBulletP2.Top = picLinkDown.Top;
                picBulletP2.Left = picLinkDown.Left;
            }

            if (e.KeyCode == Keys.NumPad0 && RightP2 == true && BulletP2 == MoveState.None)
            {
                picBulletP2.BringToFront();
                picBulletP2.Visible = true;
                BulletP2 = MoveState.Right;
                picBulletP2.Top = picLinkDown.Top;
                picBulletP2.Left = picLinkDown.Left + 22;
            }

            if (e.KeyCode == Keys.NumPad0 && UpP2 == true && BulletP2 == MoveState.None)
            {
                picBulletP2.BringToFront();
                picBulletP2.Visible = true;
                BulletP2 = MoveState.Up;
                picBulletP2.Top = picLinkDown.Top;
                picBulletP2.Left = picLinkDown.Left + 22;
            }

            if (e.KeyCode == Keys.NumPad0 && DownP2 == true && BulletP2 == MoveState.None)
            {
                picBulletP2.BringToFront();
                picBulletP2.Visible = true;
                BulletP2 = MoveState.Down;
                picBulletP2.Top = picLinkDown.Top;
                picBulletP2.Left = picLinkDown.Left + 22;
            }
            //Player1

            //Sets the movestate of the character based on the key thats pressed
            if (e.KeyCode == Keys.S)
            {
                Player1 = MoveState.Down;
                LeftP1 = false;
                RightP1 = false;
                UpP1 = false;
                DownP1 = true;
            }

            if (e.KeyCode == Keys.W)
            {
                Player1 = MoveState.Up;
                LeftP1 = false;
                RightP1 = false;
                UpP1 = true;
                DownP1 = false;
            }

            if (e.KeyCode == Keys.D)
            {
                Player1 = MoveState.Right;
                LeftP1 = false;
                RightP1 = true;
                UpP1 = false;
                DownP1 = false;
            }

            if (e.KeyCode == Keys.A)
            {
                Player1 = MoveState.Left;
                LeftP1 = true;
                RightP1 = false;
                UpP1 = false;
                DownP1 = false;
            }

            //BulletP1

            //Shoots the bullet in the direction the player is facing as long as the bullet is not already in motion
            if (e.KeyCode == Keys.Space && LeftP1 == true && BulletP1 == MoveState.None)
            {
                picBulletP1.BringToFront();
                picBulletP1.Visible = true;
                BulletP1 = MoveState.Left;
                picBulletP1.Top = picDoomGuyDown.Top;
                picBulletP1.Left = picDoomGuyDown.Left;
            }

            if (e.KeyCode == Keys.Space && RightP1 == true && BulletP1 == MoveState.None)
            {
                picBulletP1.BringToFront();
                picBulletP1.Visible = true;
                BulletP1 = MoveState.Right;
                picBulletP1.Top = picDoomGuyDown.Top;
                picBulletP1.Left = picDoomGuyDown.Left + 22;
            }

            if (e.KeyCode == Keys.Space && UpP1 == true && BulletP1 == MoveState.None)
            {
                picBulletP1.BringToFront();
                picBulletP1.Visible = true;
                BulletP1 = MoveState.Up;
                picBulletP1.Top = picDoomGuyDown.Top;
                picBulletP1.Left = picDoomGuyDown.Left + 22;
            }

            if (e.KeyCode == Keys.Space && DownP1 == true && BulletP1 == MoveState.None)
            {
                picBulletP1.BringToFront();
                picBulletP1.Visible = true;
                BulletP1 = MoveState.Down;
                picBulletP1.Top = picDoomGuyDown.Top;
                picBulletP1.Left = picDoomGuyDown.Left + 22;
            }
        }

        private void frmGame1_KeyUp(object sender, KeyEventArgs e)
        {
            
            //Player2

            //When the player releases the key, the character stops moving
            if (e.KeyCode == Keys.Down)
            {
                Player2 = MoveState.None;
            }

            if (e.KeyCode == Keys.Up)
            {
                Player2 = MoveState.None;
            }

            if (e.KeyCode == Keys.Right)
            {
                Player2 = MoveState.None;
            }

            if (e.KeyCode == Keys.Left)
            {
                Player2 = MoveState.None;
            }

            //Player1

            //When the player releases the key, the character stops moving
            if (e.KeyCode == Keys.W)
            {
                Player1 = MoveState.None;
            }

            if (e.KeyCode == Keys.S)
            {
                Player1 = MoveState.None;
            }

            if (e.KeyCode == Keys.D)
            {
                Player1 = MoveState.None;
            }

            if (e.KeyCode == Keys.A)
            {
                Player1 = MoveState.None;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picDoomGuyRight_Click(object sender, EventArgs e)
        {

        }

        private void tmrRespawn_Tick(object sender, EventArgs e)
        {
            //This timer handles showing the character during the repawn flicker

            //Stops the flicker after count > 3 
           if (Count > 3)
            {
                tmrRespawn.Enabled = false;
                tmrRespawnHide.Enabled = false;

            }

            //While count < 3 the player flickers
            if (Count < 3)
            {
                Count++;
                //Player2 Respawn
                picLinkDown.Visible = true;
                picLinkUp.Visible = true;
                picLinkLeft.Visible = true;
                picLinkRight.Visible = true;
                picGuyDown.Visible = true;
                picGuyUp.Visible = true;
                picGuyLeft.Visible = true;
                picGuyRight.Visible = true;
                if (frmCharacterSelect.Player2 == 1)
                {
                    picLinkUp.BringToFront();
                }
                if (frmCharacterSelect.Player2 == 2)
                {
                    picGuyUp.BringToFront();
                }
                //Player1 Respawn
                picMarioDown.Visible = true;
                picMarioUp.Visible = true;
                picMarioLeft.Visible = true;
                picMarioRight.Visible = true;
                picDoomGuyDown.Visible = true;
                picDoomGuyUp.Visible = true;
                picDoomGuyRight.Visible = true;
                picDoomGuyLeft.Visible = true;
                if (frmCharacterSelect.Player1 == 1)
                {
                    picDoomGuyDown.BringToFront();
                }
                if (frmCharacterSelect.Player1 == 2)
                {
                    picMarioDown.BringToFront();
                }


                if (frmCharacterSelect.Player2 == 1)
                {
                    picLinkUp.BringToFront();
                }
                if (frmCharacterSelect.Player2 == 2)
                {
                    picGuyUp.BringToFront();
                }
                tmrRespawnHide.Enabled = true;
                tmrRespawn.Enabled = false;

            }


        }
        private void tmrRespawnHide_Tick(object sender, EventArgs e)
        {
            //This timer handles hiding the character during the repawn flicker

            //While count < 3 the player flickers
            if (Count < 3)
            {
                //Player 1
                picMarioDown.Visible = false;
                picMarioUp.Visible = false;
                picMarioLeft.Visible = false;
                picMarioRight.Visible = false;
                picDoomGuyDown.Visible = false;
                picDoomGuyUp.Visible = false;
                picDoomGuyRight.Visible = false;
                picDoomGuyLeft.Visible = false;
                //Player 2
                picLinkDown.Visible = false;
                picLinkUp.Visible = false;
                picLinkLeft.Visible = false;
                picLinkRight.Visible = false;
                picGuyDown.Visible = false;
                picGuyUp.Visible = false;
                picGuyLeft.Visible = false;
                picGuyRight.Visible = false;

                tmrRespawn.Enabled = true;
                tmrRespawnHide.Enabled = false;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tmrHeart_Tick(object sender, EventArgs e)
        {           
            //After 45 seconds the heart spawns 
            picHeart.Visible = true;
            picHeart.Top = 273;
            picHeart.Left = 496;
        }

        private void tmrStar_Tick(object sender, EventArgs e)
        {
            //After 60 seconds the star spawns
            picStar.Visible = true;
            picStar.Top = 257;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tmrCountDown_Tick(object sender, EventArgs e)
        {
            //When either player is invincible, the countdown for the invincibility is enabled and the 
            //timer counts down every 1 second for 10 seconds
            if (InvincibilityP2 == true)
            {
                 lblTimerP2.Visible = true;
            }

            if (InvincibilityP1 == true)
            {
                lblTimerP1.Visible = true;
            }
            lblCountDown.Visible = true;
	        CountDown--;
	        lblCountDown.Text = CountDown.ToString();

            //If countdown = 0, then invincibilty is false and tmrCountDown is disabled.
	        if (CountDown == 0)
	        {
		        lblCountDown.Visible = false;
		        tmrCountDown.Enabled = false;
		        lblCountDown.Visible = false;
		        InvincibilityP1 = false;
		        InvincibilityP2 = false;
		        CountDown = 10;
		        lblCountDown.Text = CountDown.ToString();
                lblTimerP1.Visible = false;
                lblTimerP2.Visible = false;
                picStar.Top = -1;
	        }

            

        }

        private void picStar_Click(object sender, EventArgs e)
        {
            
        }
        
    }

   }        
    

