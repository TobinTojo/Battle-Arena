namespace Menu
{
    partial class frmCharacterSelect
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
            this.label1 = new System.Windows.Forms.Label();
            this.picDoomGuy = new System.Windows.Forms.PictureBox();
            this.picLink = new System.Windows.Forms.PictureBox();
            this.picGuy = new System.Windows.Forms.PictureBox();
            this.picMario = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picP1DoomGuy = new System.Windows.Forms.PictureBox();
            this.picP1Mario = new System.Windows.Forms.PictureBox();
            this.picP2Guy = new System.Windows.Forms.PictureBox();
            this.picP2Link = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tmrCharChosen = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDoomGuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1DoomGuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1Mario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2Guy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2Link)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose your character";
            // 
            // picDoomGuy
            // 
            this.picDoomGuy.Image = global::Menu.Resource1.DoomGuySelect;
            this.picDoomGuy.Location = new System.Drawing.Point(21, 122);
            this.picDoomGuy.Name = "picDoomGuy";
            this.picDoomGuy.Size = new System.Drawing.Size(146, 132);
            this.picDoomGuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDoomGuy.TabIndex = 1;
            this.picDoomGuy.TabStop = false;
            this.picDoomGuy.Click += new System.EventHandler(this.picDoomGuy_Click);
            // 
            // picLink
            // 
            this.picLink.Image = global::Menu.Resource1.linkFace;
            this.picLink.Location = new System.Drawing.Point(517, 122);
            this.picLink.Name = "picLink";
            this.picLink.Size = new System.Drawing.Size(146, 132);
            this.picLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLink.TabIndex = 2;
            this.picLink.TabStop = false;
            this.picLink.Click += new System.EventHandler(this.picLink_Click);
            // 
            // picGuy
            // 
            this.picGuy.Image = global::Menu.Resource1.guyFace;
            this.picGuy.Location = new System.Drawing.Point(679, 122);
            this.picGuy.Name = "picGuy";
            this.picGuy.Size = new System.Drawing.Size(146, 132);
            this.picGuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGuy.TabIndex = 3;
            this.picGuy.TabStop = false;
            this.picGuy.Click += new System.EventHandler(this.picGuy_Click);
            // 
            // picMario
            // 
            this.picMario.Image = global::Menu.Resource1.MarioFace;
            this.picMario.Location = new System.Drawing.Point(184, 122);
            this.picMario.Name = "picMario";
            this.picMario.Size = new System.Drawing.Size(146, 132);
            this.picMario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMario.TabIndex = 4;
            this.picMario.TabStop = false;
            this.picMario.Click += new System.EventHandler(this.picMario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(16, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "P1 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(551, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "P2";
            // 
            // picP1DoomGuy
            // 
            this.picP1DoomGuy.Image = global::Menu.Resource1.k59kcj6m35xx;
            this.picP1DoomGuy.Location = new System.Drawing.Point(100, 272);
            this.picP1DoomGuy.Name = "picP1DoomGuy";
            this.picP1DoomGuy.Size = new System.Drawing.Size(146, 132);
            this.picP1DoomGuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picP1DoomGuy.TabIndex = 7;
            this.picP1DoomGuy.TabStop = false;
            this.picP1DoomGuy.Visible = false;
            // 
            // picP1Mario
            // 
            this.picP1Mario.Image = global::Menu.Resource1.stand_to;
            this.picP1Mario.Location = new System.Drawing.Point(100, 272);
            this.picP1Mario.Name = "picP1Mario";
            this.picP1Mario.Size = new System.Drawing.Size(146, 132);
            this.picP1Mario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picP1Mario.TabIndex = 8;
            this.picP1Mario.TabStop = false;
            this.picP1Mario.Visible = false;
            // 
            // picP2Guy
            // 
            this.picP2Guy.Image = global::Menu.Resource1.idle___Copy;
            this.picP2Guy.Location = new System.Drawing.Point(621, 272);
            this.picP2Guy.Name = "picP2Guy";
            this.picP2Guy.Size = new System.Drawing.Size(146, 132);
            this.picP2Guy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picP2Guy.TabIndex = 14;
            this.picP2Guy.TabStop = false;
            this.picP2Guy.Visible = false;
            // 
            // picP2Link
            // 
            this.picP2Link.Image = global::Menu.Resource1.link_walk_down_2;
            this.picP2Link.Location = new System.Drawing.Point(621, 272);
            this.picP2Link.Name = "picP2Link";
            this.picP2Link.Size = new System.Drawing.Size(146, 132);
            this.picP2Link.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picP2Link.TabIndex = 13;
            this.picP2Link.TabStop = false;
            this.picP2Link.Visible = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Black;
            this.btnPlay.Location = new System.Drawing.Point(267, 296);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(257, 95);
            this.btnPlay.TabIndex = 15;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(273, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 39);
            this.label4.TabIndex = 16;
            this.label4.Text = "Click to choose";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(17, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Player 1 Characters";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(601, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Player 2 Characters";
            // 
            // tmrCharChosen
            // 
            this.tmrCharChosen.Enabled = true;
            this.tmrCharChosen.Tick += new System.EventHandler(this.tmrCharChosen_Tick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(712, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 50);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmCharacterSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Menu.Resource1.tumblr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 442);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.picP2Guy);
            this.Controls.Add(this.picP2Link);
            this.Controls.Add(this.picP1Mario);
            this.Controls.Add(this.picP1DoomGuy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picMario);
            this.Controls.Add(this.picGuy);
            this.Controls.Add(this.picLink);
            this.Controls.Add(this.picDoomGuy);
            this.Controls.Add(this.label1);
            this.Name = "frmCharacterSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Select";
            this.Load += new System.EventHandler(this.frmCharacterSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDoomGuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1DoomGuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1Mario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2Guy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2Link)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picDoomGuy;
        private System.Windows.Forms.PictureBox picLink;
        private System.Windows.Forms.PictureBox picGuy;
        private System.Windows.Forms.PictureBox picMario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picP1DoomGuy;
        private System.Windows.Forms.PictureBox picP1Mario;
        private System.Windows.Forms.PictureBox picP2Guy;
        private System.Windows.Forms.PictureBox picP2Link;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer tmrCharChosen;
        private System.Windows.Forms.Button btnBack;
    }
}