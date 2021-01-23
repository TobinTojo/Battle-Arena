namespace Menu
{
    partial class frmGameWinner
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
            this.picLink = new System.Windows.Forms.PictureBox();
            this.picMario = new System.Windows.Forms.PictureBox();
            this.picGuy = new System.Windows.Forms.PictureBox();
            this.picDoomGuy = new System.Windows.Forms.PictureBox();
            this.lblP1Win = new System.Windows.Forms.Label();
            this.lblP2Wins = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoomGuy)).BeginInit();
            this.SuspendLayout();
            // 
            // picLink
            // 
            this.picLink.BackColor = System.Drawing.Color.Transparent;
            this.picLink.Image = global::Menu.Resource1._21249_6_zelda_link_hd;
            this.picLink.Location = new System.Drawing.Point(210, 137);
            this.picLink.Name = "picLink";
            this.picLink.Size = new System.Drawing.Size(255, 396);
            this.picLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLink.TabIndex = 0;
            this.picLink.TabStop = false;
            this.picLink.Visible = false;
            // 
            // picMario
            // 
            this.picMario.BackColor = System.Drawing.Color.Transparent;
            this.picMario.Image = global::Menu.Resource1._480px_Mario__victory____Super_Mario_64;
            this.picMario.Location = new System.Drawing.Point(193, 137);
            this.picMario.Name = "picMario";
            this.picMario.Size = new System.Drawing.Size(318, 396);
            this.picMario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMario.TabIndex = 1;
            this.picMario.TabStop = false;
            this.picMario.Visible = false;
            // 
            // picGuy
            // 
            this.picGuy.BackColor = System.Drawing.Color.Transparent;
            this.picGuy.Image = global::Menu.Resource1._5a68f75c01d15068bdfe880e;
            this.picGuy.Location = new System.Drawing.Point(193, 137);
            this.picGuy.Name = "picGuy";
            this.picGuy.Size = new System.Drawing.Size(318, 396);
            this.picGuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGuy.TabIndex = 2;
            this.picGuy.TabStop = false;
            this.picGuy.Visible = false;
            // 
            // picDoomGuy
            // 
            this.picDoomGuy.BackColor = System.Drawing.Color.Transparent;
            this.picDoomGuy.Image = global::Menu.Resource1.The_Doomguy;
            this.picDoomGuy.Location = new System.Drawing.Point(232, 137);
            this.picDoomGuy.Name = "picDoomGuy";
            this.picDoomGuy.Size = new System.Drawing.Size(252, 396);
            this.picDoomGuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDoomGuy.TabIndex = 3;
            this.picDoomGuy.TabStop = false;
            this.picDoomGuy.Visible = false;
            // 
            // lblP1Win
            // 
            this.lblP1Win.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.lblP1Win.AutoSize = true;
            this.lblP1Win.BackColor = System.Drawing.Color.Transparent;
            this.lblP1Win.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1Win.ForeColor = System.Drawing.Color.Transparent;
            this.lblP1Win.Location = new System.Drawing.Point(203, 73);
            this.lblP1Win.Name = "lblP1Win";
            this.lblP1Win.Size = new System.Drawing.Size(281, 42);
            this.lblP1Win.TabIndex = 4;
            this.lblP1Win.Text = "Player 1 Wins!";
            this.lblP1Win.Visible = false;
            // 
            // lblP2Wins
            // 
            this.lblP2Wins.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.lblP2Wins.AutoSize = true;
            this.lblP2Wins.BackColor = System.Drawing.Color.Transparent;
            this.lblP2Wins.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2Wins.ForeColor = System.Drawing.Color.Transparent;
            this.lblP2Wins.Location = new System.Drawing.Point(332, 73);
            this.lblP2Wins.Name = "lblP2Wins";
            this.lblP2Wins.Size = new System.Drawing.Size(281, 42);
            this.lblP2Wins.TabIndex = 5;
            this.lblP2Wins.Text = "Player 2 Wins!";
            this.lblP2Wins.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(670, 469);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(294, 89);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Main Menu";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmGameWinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Menu.Resource1.pngtree_black_gold_awards_gala_background_design_meeting_backgroundribbontrophyawards_partyparty_image_73998;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 570);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblP2Wins);
            this.Controls.Add(this.lblP1Win);
            this.Controls.Add(this.picDoomGuy);
            this.Controls.Add(this.picGuy);
            this.Controls.Add(this.picMario);
            this.Controls.Add(this.picLink);
            this.Name = "frmGameWinner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.frmGameWinner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoomGuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLink;
        private System.Windows.Forms.PictureBox picMario;
        private System.Windows.Forms.PictureBox picGuy;
        private System.Windows.Forms.PictureBox picDoomGuy;
        private System.Windows.Forms.Label lblP1Win;
        private System.Windows.Forms.Label lblP2Wins;
        private System.Windows.Forms.Button btnExit;
    }
}