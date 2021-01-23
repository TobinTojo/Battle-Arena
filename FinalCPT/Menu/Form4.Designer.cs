namespace Menu
{
    partial class frmGame1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblP1Lives = new System.Windows.Forms.Label();
            this.lblP2Lives = new System.Windows.Forms.Label();
            this.tmrRespawn = new System.Windows.Forms.Timer(this.components);
            this.tmrRespawnHide = new System.Windows.Forms.Timer(this.components);
            this.lblPause = new System.Windows.Forms.Label();
            this.tmrHeart = new System.Windows.Forms.Timer(this.components);
            this.lblEscape = new System.Windows.Forms.Label();
            this.tmrStar = new System.Windows.Forms.Timer(this.components);
            this.tmrCountDown = new System.Windows.Forms.Timer(this.components);
            this.lblTimerP1 = new System.Windows.Forms.Label();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.lblTimerP2 = new System.Windows.Forms.Label();
            this.picStar = new System.Windows.Forms.PictureBox();
            this.picBorder2 = new System.Windows.Forms.PictureBox();
            this.picBorder = new System.Windows.Forms.PictureBox();
            this.picHeart = new System.Windows.Forms.PictureBox();
            this.picBorder7 = new System.Windows.Forms.PictureBox();
            this.picBorder8 = new System.Windows.Forms.PictureBox();
            this.picBorder9 = new System.Windows.Forms.PictureBox();
            this.picBorder6 = new System.Windows.Forms.PictureBox();
            this.picBorder10 = new System.Windows.Forms.PictureBox();
            this.picBorder5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picBorder3 = new System.Windows.Forms.PictureBox();
            this.picBulletP2 = new System.Windows.Forms.PictureBox();
            this.picBulletP1 = new System.Windows.Forms.PictureBox();
            this.picDoomGuyDown = new System.Windows.Forms.PictureBox();
            this.picDoomGuyUp = new System.Windows.Forms.PictureBox();
            this.picDoomGuyLeft = new System.Windows.Forms.PictureBox();
            this.picDoomGuyRight = new System.Windows.Forms.PictureBox();
            this.picMarioLeft = new System.Windows.Forms.PictureBox();
            this.picMarioRight = new System.Windows.Forms.PictureBox();
            this.picMarioUp = new System.Windows.Forms.PictureBox();
            this.picMarioDown = new System.Windows.Forms.PictureBox();
            this.picGuyLeft = new System.Windows.Forms.PictureBox();
            this.picGuyRight = new System.Windows.Forms.PictureBox();
            this.picGuyUp = new System.Windows.Forms.PictureBox();
            this.picGuyDown = new System.Windows.Forms.PictureBox();
            this.picLinkLeft = new System.Windows.Forms.PictureBox();
            this.picLinkRight = new System.Windows.Forms.PictureBox();
            this.picLinkUp = new System.Windows.Forms.PictureBox();
            this.picLinkDown = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBulletP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBulletP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoomGuyDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoomGuyUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoomGuyLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoomGuyRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMarioLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMarioRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMarioUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMarioDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuyLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuyRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuyUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuyDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrGame
            // 
            this.tmrGame.Enabled = true;
            this.tmrGame.Interval = 10;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-7, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 42);
            this.label1.TabIndex = 28;
            this.label1.Text = "P1 Lives:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(742, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 42);
            this.label2.TabIndex = 29;
            this.label2.Text = "P2 Lives:";
            // 
            // lblP1Lives
            // 
            this.lblP1Lives.AutoSize = true;
            this.lblP1Lives.BackColor = System.Drawing.Color.Black;
            this.lblP1Lives.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1Lives.ForeColor = System.Drawing.Color.White;
            this.lblP1Lives.Location = new System.Drawing.Point(170, -1);
            this.lblP1Lives.Name = "lblP1Lives";
            this.lblP1Lives.Size = new System.Drawing.Size(40, 42);
            this.lblP1Lives.TabIndex = 30;
            this.lblP1Lives.Text = "5";
            // 
            // lblP2Lives
            // 
            this.lblP2Lives.AutoSize = true;
            this.lblP2Lives.BackColor = System.Drawing.Color.Black;
            this.lblP2Lives.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2Lives.ForeColor = System.Drawing.Color.White;
            this.lblP2Lives.Location = new System.Drawing.Point(914, -1);
            this.lblP2Lives.Name = "lblP2Lives";
            this.lblP2Lives.Size = new System.Drawing.Size(40, 42);
            this.lblP2Lives.TabIndex = 31;
            this.lblP2Lives.Text = "5";
            // 
            // tmrRespawn
            // 
            this.tmrRespawn.Interval = 500;
            this.tmrRespawn.Tick += new System.EventHandler(this.tmrRespawn_Tick);
            // 
            // tmrRespawnHide
            // 
            this.tmrRespawnHide.Interval = 500;
            this.tmrRespawnHide.Tick += new System.EventHandler(this.tmrRespawnHide_Tick);
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.Location = new System.Drawing.Point(396, 235);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(228, 74);
            this.lblPause.TabIndex = 32;
            this.lblPause.Text = "Play (Escape)\r\nQuit (Enter)";
            this.lblPause.Visible = false;
            this.lblPause.Click += new System.EventHandler(this.label3_Click);
            // 
            // tmrHeart
            // 
            this.tmrHeart.Interval = 45000;
            this.tmrHeart.Tick += new System.EventHandler(this.tmrHeart_Tick);
            // 
            // lblEscape
            // 
            this.lblEscape.AutoSize = true;
            this.lblEscape.BackColor = System.Drawing.Color.Black;
            this.lblEscape.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscape.ForeColor = System.Drawing.Color.White;
            this.lblEscape.Location = new System.Drawing.Point(242, 517);
            this.lblEscape.Name = "lblEscape";
            this.lblEscape.Size = new System.Drawing.Size(429, 42);
            this.lblEscape.TabIndex = 34;
            this.lblEscape.Text = "Press Escape to Pause";
            // 
            // tmrStar
            // 
            this.tmrStar.Interval = 60000;
            this.tmrStar.Tick += new System.EventHandler(this.tmrStar_Tick);
            // 
            // tmrCountDown
            // 
            this.tmrCountDown.Interval = 1000;
            this.tmrCountDown.Tick += new System.EventHandler(this.tmrCountDown_Tick);
            // 
            // lblTimerP1
            // 
            this.lblTimerP1.AutoSize = true;
            this.lblTimerP1.BackColor = System.Drawing.Color.Black;
            this.lblTimerP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerP1.ForeColor = System.Drawing.Color.White;
            this.lblTimerP1.Location = new System.Drawing.Point(276, -1);
            this.lblTimerP1.Name = "lblTimerP1";
            this.lblTimerP1.Size = new System.Drawing.Size(212, 31);
            this.lblTimerP1.TabIndex = 36;
            this.lblTimerP1.Text = "P1 Invincibility:";
            this.lblTimerP1.Visible = false;
            // 
            // lblCountDown
            // 
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.BackColor = System.Drawing.Color.Black;
            this.lblCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.ForeColor = System.Drawing.Color.White;
            this.lblCountDown.Location = new System.Drawing.Point(490, -1);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(46, 31);
            this.lblCountDown.TabIndex = 37;
            this.lblCountDown.Text = "10";
            this.lblCountDown.Visible = false;
            // 
            // lblTimerP2
            // 
            this.lblTimerP2.AutoSize = true;
            this.lblTimerP2.BackColor = System.Drawing.Color.Black;
            this.lblTimerP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerP2.ForeColor = System.Drawing.Color.White;
            this.lblTimerP2.Location = new System.Drawing.Point(276, -1);
            this.lblTimerP2.Name = "lblTimerP2";
            this.lblTimerP2.Size = new System.Drawing.Size(212, 31);
            this.lblTimerP2.TabIndex = 38;
            this.lblTimerP2.Text = "P2 Invincibility:";
            this.lblTimerP2.Visible = false;
            this.lblTimerP2.Click += new System.EventHandler(this.label4_Click);
            // 
            // picStar
            // 
            this.picStar.Image = global::Menu.Resource1.Mario_Star_PNG_Transparent_Image;
            this.picStar.Location = new System.Drawing.Point(487, -1);
            this.picStar.Name = "picStar";
            this.picStar.Size = new System.Drawing.Size(49, 47);
            this.picStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStar.TabIndex = 35;
            this.picStar.TabStop = false;
            this.picStar.Visible = false;
            this.picStar.Click += new System.EventHandler(this.picStar_Click);
            // 
            // picBorder2
            // 
            this.picBorder2.Image = global::Menu.Resource1._6G_0;
            this.picBorder2.Location = new System.Drawing.Point(487, -1);
            this.picBorder2.Name = "picBorder2";
            this.picBorder2.Size = new System.Drawing.Size(488, 76);
            this.picBorder2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBorder2.TabIndex = 19;
            this.picBorder2.TabStop = false;
            // 
            // picBorder
            // 
            this.picBorder.Image = global::Menu.Resource1._6G_0;
            this.picBorder.Location = new System.Drawing.Point(1, -1);
            this.picBorder.Name = "picBorder";
            this.picBorder.Size = new System.Drawing.Size(488, 76);
            this.picBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBorder.TabIndex = 18;
            this.picBorder.TabStop = false;
            // 
            // picHeart
            // 
            this.picHeart.Image = global::Menu.Resource1.Heart_Container__Ocarina_of_Time_and_Majora_s_Mask_;
            this.picHeart.Location = new System.Drawing.Point(472, -1);
            this.picHeart.Name = "picHeart";
            this.picHeart.Size = new System.Drawing.Size(35, 39);
            this.picHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeart.TabIndex = 33;
            this.picHeart.TabStop = false;
            this.picHeart.Visible = false;
            // 
            // picBorder7
            // 
            this.picBorder7.Image = global::Menu.Resource1.downloadleft;
            this.picBorder7.Location = new System.Drawing.Point(416, 137);
            this.picBorder7.Name = "picBorder7";
            this.picBorder7.Size = new System.Drawing.Size(39, 106);
            this.picBorder7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBorder7.TabIndex = 27;
            this.picBorder7.TabStop = false;
            // 
            // picBorder8
            // 
            this.picBorder8.Image = global::Menu.Resource1.downloadRight;
            this.picBorder8.Location = new System.Drawing.Point(600, 300);
            this.picBorder8.Name = "picBorder8";
            this.picBorder8.Size = new System.Drawing.Size(39, 118);
            this.picBorder8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBorder8.TabIndex = 26;
            this.picBorder8.TabStop = false;
            // 
            // picBorder9
            // 
            this.picBorder9.Image = global::Menu.Resource1.download;
            this.picBorder9.Location = new System.Drawing.Point(600, 171);
            this.picBorder9.Name = "picBorder9";
            this.picBorder9.Size = new System.Drawing.Size(290, 50);
            this.picBorder9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBorder9.TabIndex = 25;
            this.picBorder9.TabStop = false;
            // 
            // picBorder6
            // 
            this.picBorder6.Image = global::Menu.Resource1.download;
            this.picBorder6.Location = new System.Drawing.Point(167, 315);
            this.picBorder6.Name = "picBorder6";
            this.picBorder6.Size = new System.Drawing.Size(288, 50);
            this.picBorder6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBorder6.TabIndex = 24;
            this.picBorder6.TabStop = false;
            // 
            // picBorder10
            // 
            this.picBorder10.Image = global::Menu.Resource1.downloadleft;
            this.picBorder10.Location = new System.Drawing.Point(828, 217);
            this.picBorder10.Name = "picBorder10";
            this.picBorder10.Size = new System.Drawing.Size(62, 293);
            this.picBorder10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBorder10.TabIndex = 23;
            this.picBorder10.TabStop = false;
            // 
            // picBorder5
            // 
            this.picBorder5.Image = global::Menu.Resource1.downloadRight;
            this.picBorder5.Location = new System.Drawing.Point(107, 72);
            this.picBorder5.Name = "picBorder5";
            this.picBorder5.Size = new System.Drawing.Size(62, 293);
            this.picBorder5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBorder5.TabIndex = 22;
            this.picBorder5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Menu.Resource1._6G_0;
            this.pictureBox3.Location = new System.Drawing.Point(487, 497);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(488, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // picBorder3
            // 
            this.picBorder3.Image = global::Menu.Resource1._6G_0;
            this.picBorder3.Location = new System.Drawing.Point(1, 497);
            this.picBorder3.Name = "picBorder3";
            this.picBorder3.Size = new System.Drawing.Size(488, 76);
            this.picBorder3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBorder3.TabIndex = 20;
            this.picBorder3.TabStop = false;
            // 
            // picBulletP2
            // 
            this.picBulletP2.BackColor = System.Drawing.Color.Black;
            this.picBulletP2.Location = new System.Drawing.Point(963, 497);
            this.picBulletP2.Name = "picBulletP2";
            this.picBulletP2.Size = new System.Drawing.Size(12, 13);
            this.picBulletP2.TabIndex = 17;
            this.picBulletP2.TabStop = false;
            this.picBulletP2.Visible = false;
            // 
            // picBulletP1
            // 
            this.picBulletP1.BackColor = System.Drawing.Color.Black;
            this.picBulletP1.Location = new System.Drawing.Point(1, 497);
            this.picBulletP1.Name = "picBulletP1";
            this.picBulletP1.Size = new System.Drawing.Size(12, 13);
            this.picBulletP1.TabIndex = 16;
            this.picBulletP1.TabStop = false;
            this.picBulletP1.Visible = false;
            // 
            // picDoomGuyDown
            // 
            this.picDoomGuyDown.Image = global::Menu.Resource1.k59kcj6m35xx;
            this.picDoomGuyDown.Location = new System.Drawing.Point(35, 81);
            this.picDoomGuyDown.Name = "picDoomGuyDown";
            this.picDoomGuyDown.Size = new System.Drawing.Size(33, 45);
            this.picDoomGuyDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDoomGuyDown.TabIndex = 15;
            this.picDoomGuyDown.TabStop = false;
            // 
            // picDoomGuyUp
            // 
            this.picDoomGuyUp.Image = global::Menu.Resource1.c15;
            this.picDoomGuyUp.Location = new System.Drawing.Point(35, 81);
            this.picDoomGuyUp.Name = "picDoomGuyUp";
            this.picDoomGuyUp.Size = new System.Drawing.Size(33, 45);
            this.picDoomGuyUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDoomGuyUp.TabIndex = 14;
            this.picDoomGuyUp.TabStop = false;
            // 
            // picDoomGuyLeft
            // 
            this.picDoomGuyLeft.BackgroundImage = global::Menu.Resource1.doomguy1;
            this.picDoomGuyLeft.Image = global::Menu.Resource1.doomguy1;
            this.picDoomGuyLeft.Location = new System.Drawing.Point(35, 81);
            this.picDoomGuyLeft.Name = "picDoomGuyLeft";
            this.picDoomGuyLeft.Size = new System.Drawing.Size(33, 45);
            this.picDoomGuyLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDoomGuyLeft.TabIndex = 13;
            this.picDoomGuyLeft.TabStop = false;
            // 
            // picDoomGuyRight
            // 
            this.picDoomGuyRight.Image = global::Menu.Resource1.doomguy;
            this.picDoomGuyRight.Location = new System.Drawing.Point(35, 81);
            this.picDoomGuyRight.Name = "picDoomGuyRight";
            this.picDoomGuyRight.Size = new System.Drawing.Size(33, 45);
            this.picDoomGuyRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDoomGuyRight.TabIndex = 12;
            this.picDoomGuyRight.TabStop = false;
            this.picDoomGuyRight.Click += new System.EventHandler(this.picDoomGuyRight_Click);
            // 
            // picMarioLeft
            // 
            this.picMarioLeft.Image = global::Menu.Resource1.stand_toright__1_;
            this.picMarioLeft.Location = new System.Drawing.Point(35, 81);
            this.picMarioLeft.Name = "picMarioLeft";
            this.picMarioLeft.Size = new System.Drawing.Size(33, 45);
            this.picMarioLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMarioLeft.TabIndex = 11;
            this.picMarioLeft.TabStop = false;
            // 
            // picMarioRight
            // 
            this.picMarioRight.Image = global::Menu.Resource1.stand_toright;
            this.picMarioRight.Location = new System.Drawing.Point(35, 81);
            this.picMarioRight.Name = "picMarioRight";
            this.picMarioRight.Size = new System.Drawing.Size(33, 45);
            this.picMarioRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMarioRight.TabIndex = 10;
            this.picMarioRight.TabStop = false;
            // 
            // picMarioUp
            // 
            this.picMarioUp.Image = global::Menu.Resource1.stand_from;
            this.picMarioUp.Location = new System.Drawing.Point(35, 81);
            this.picMarioUp.Name = "picMarioUp";
            this.picMarioUp.Size = new System.Drawing.Size(33, 45);
            this.picMarioUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMarioUp.TabIndex = 9;
            this.picMarioUp.TabStop = false;
            // 
            // picMarioDown
            // 
            this.picMarioDown.Image = global::Menu.Resource1.stand_to;
            this.picMarioDown.Location = new System.Drawing.Point(35, 81);
            this.picMarioDown.Name = "picMarioDown";
            this.picMarioDown.Size = new System.Drawing.Size(33, 45);
            this.picMarioDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMarioDown.TabIndex = 8;
            this.picMarioDown.TabStop = false;
            this.picMarioDown.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picGuyLeft
            // 
            this.picGuyLeft.Image = global::Menu.Resource1.idle___Copy__3_;
            this.picGuyLeft.Location = new System.Drawing.Point(921, 446);
            this.picGuyLeft.Name = "picGuyLeft";
            this.picGuyLeft.Size = new System.Drawing.Size(33, 45);
            this.picGuyLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGuyLeft.TabIndex = 7;
            this.picGuyLeft.TabStop = false;
            // 
            // picGuyRight
            // 
            this.picGuyRight.Image = global::Menu.Resource1.idle;
            this.picGuyRight.Location = new System.Drawing.Point(921, 446);
            this.picGuyRight.Name = "picGuyRight";
            this.picGuyRight.Size = new System.Drawing.Size(33, 45);
            this.picGuyRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGuyRight.TabIndex = 6;
            this.picGuyRight.TabStop = false;
            // 
            // picGuyUp
            // 
            this.picGuyUp.Image = global::Menu.Resource1.idle___Copy__2_;
            this.picGuyUp.Location = new System.Drawing.Point(921, 446);
            this.picGuyUp.Name = "picGuyUp";
            this.picGuyUp.Size = new System.Drawing.Size(33, 45);
            this.picGuyUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGuyUp.TabIndex = 5;
            this.picGuyUp.TabStop = false;
            // 
            // picGuyDown
            // 
            this.picGuyDown.Image = global::Menu.Resource1.idle___Copy;
            this.picGuyDown.Location = new System.Drawing.Point(921, 446);
            this.picGuyDown.Name = "picGuyDown";
            this.picGuyDown.Size = new System.Drawing.Size(33, 45);
            this.picGuyDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGuyDown.TabIndex = 4;
            this.picGuyDown.TabStop = false;
            // 
            // picLinkLeft
            // 
            this.picLinkLeft.Image = global::Menu.Resource1.link_walk_side_3__1_;
            this.picLinkLeft.Location = new System.Drawing.Point(921, 446);
            this.picLinkLeft.Name = "picLinkLeft";
            this.picLinkLeft.Size = new System.Drawing.Size(33, 45);
            this.picLinkLeft.TabIndex = 3;
            this.picLinkLeft.TabStop = false;
            // 
            // picLinkRight
            // 
            this.picLinkRight.Image = global::Menu.Resource1.link_walk_side_3;
            this.picLinkRight.Location = new System.Drawing.Point(921, 446);
            this.picLinkRight.Name = "picLinkRight";
            this.picLinkRight.Size = new System.Drawing.Size(33, 45);
            this.picLinkRight.TabIndex = 2;
            this.picLinkRight.TabStop = false;
            // 
            // picLinkUp
            // 
            this.picLinkUp.Image = global::Menu.Resource1.link_walk_up_4;
            this.picLinkUp.Location = new System.Drawing.Point(921, 446);
            this.picLinkUp.Name = "picLinkUp";
            this.picLinkUp.Size = new System.Drawing.Size(33, 45);
            this.picLinkUp.TabIndex = 1;
            this.picLinkUp.TabStop = false;
            // 
            // picLinkDown
            // 
            this.picLinkDown.Image = global::Menu.Resource1.link_walk_down_2;
            this.picLinkDown.Location = new System.Drawing.Point(921, 446);
            this.picLinkDown.Name = "picLinkDown";
            this.picLinkDown.Size = new System.Drawing.Size(33, 45);
            this.picLinkDown.TabIndex = 0;
            this.picLinkDown.TabStop = false;
            // 
            // frmGame1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(976, 570);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.lblTimerP2);
            this.Controls.Add(this.lblTimerP1);
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.picStar);
            this.Controls.Add(this.lblEscape);
            this.Controls.Add(this.lblP2Lives);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblP1Lives);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBorder2);
            this.Controls.Add(this.picBorder);
            this.Controls.Add(this.picHeart);
            this.Controls.Add(this.picBorder7);
            this.Controls.Add(this.picBorder8);
            this.Controls.Add(this.picBorder9);
            this.Controls.Add(this.picBorder6);
            this.Controls.Add(this.picBorder10);
            this.Controls.Add(this.picBorder5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.picBorder3);
            this.Controls.Add(this.picBulletP2);
            this.Controls.Add(this.picBulletP1);
            this.Controls.Add(this.picDoomGuyDown);
            this.Controls.Add(this.picDoomGuyUp);
            this.Controls.Add(this.picDoomGuyLeft);
            this.Controls.Add(this.picDoomGuyRight);
            this.Controls.Add(this.picMarioLeft);
            this.Controls.Add(this.picMarioRight);
            this.Controls.Add(this.picMarioUp);
            this.Controls.Add(this.picMarioDown);
            this.Controls.Add(this.picGuyLeft);
            this.Controls.Add(this.picGuyRight);
            this.Controls.Add(this.picGuyUp);
            this.Controls.Add(this.picGuyDown);
            this.Controls.Add(this.picLinkLeft);
            this.Controls.Add(this.picLinkRight);
            this.Controls.Add(this.picLinkUp);
            this.Controls.Add(this.picLinkDown);
            this.Name = "frmGame1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle Arena";
            this.Load += new System.EventHandler(this.frmGame1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGame1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmGame1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBulletP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBulletP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoomGuyDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoomGuyUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoomGuyLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoomGuyRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMarioLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMarioRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMarioUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMarioDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuyLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuyRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuyUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuyDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLinkDown;
        private System.Windows.Forms.PictureBox picLinkUp;
        private System.Windows.Forms.PictureBox picLinkRight;
        private System.Windows.Forms.PictureBox picLinkLeft;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.PictureBox picGuyDown;
        private System.Windows.Forms.PictureBox picGuyUp;
        private System.Windows.Forms.PictureBox picGuyRight;
        private System.Windows.Forms.PictureBox picGuyLeft;
        private System.Windows.Forms.PictureBox picMarioDown;
        private System.Windows.Forms.PictureBox picMarioUp;
        private System.Windows.Forms.PictureBox picMarioRight;
        private System.Windows.Forms.PictureBox picMarioLeft;
        private System.Windows.Forms.PictureBox picDoomGuyRight;
        private System.Windows.Forms.PictureBox picDoomGuyLeft;
        private System.Windows.Forms.PictureBox picDoomGuyUp;
        private System.Windows.Forms.PictureBox picDoomGuyDown;
        private System.Windows.Forms.PictureBox picBulletP1;
        private System.Windows.Forms.PictureBox picBulletP2;
        private System.Windows.Forms.PictureBox picBorder;
        private System.Windows.Forms.PictureBox picBorder2;
        private System.Windows.Forms.PictureBox picBorder3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picBorder5;
        private System.Windows.Forms.PictureBox picBorder10;
        private System.Windows.Forms.PictureBox picBorder6;
        private System.Windows.Forms.PictureBox picBorder9;
        private System.Windows.Forms.PictureBox picBorder8;
        private System.Windows.Forms.PictureBox picBorder7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblP1Lives;
        private System.Windows.Forms.Label lblP2Lives;
        private System.Windows.Forms.Timer tmrRespawn;
        private System.Windows.Forms.Timer tmrRespawnHide;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.PictureBox picHeart;
        private System.Windows.Forms.Timer tmrHeart;
        private System.Windows.Forms.Label lblEscape;
        private System.Windows.Forms.Timer tmrStar;
        private System.Windows.Forms.PictureBox picStar;
        private System.Windows.Forms.Timer tmrCountDown;
        private System.Windows.Forms.Label lblTimerP1;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Label lblTimerP2;
    }
}