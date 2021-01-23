namespace Menu
{
    partial class frmMenu
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnControls = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picStar = new System.Windows.Forms.PictureBox();
            this.picHeart = new System.Windows.Forms.PictureBox();
            this.btnPowerups = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Ravie", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(260, 135);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(233, 84);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnControls
            // 
            this.btnControls.Font = new System.Drawing.Font("Ravie", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControls.Location = new System.Drawing.Point(260, 225);
            this.btnControls.Name = "btnControls";
            this.btnControls.Size = new System.Drawing.Size(233, 84);
            this.btnControls.TabIndex = 1;
            this.btnControls.Text = "Controls";
            this.btnControls.UseVisualStyleBackColor = true;
            this.btnControls.Click += new System.EventHandler(this.btnControls_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Ravie", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(260, 315);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(233, 84);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picStar
            // 
            this.picStar.BackColor = System.Drawing.SystemColors.Control;
            this.picStar.Image = global::Menu.Resource1.Mario_Star_PNG_Transparent_Image;
            this.picStar.Location = new System.Drawing.Point(718, -2);
            this.picStar.Name = "picStar";
            this.picStar.Size = new System.Drawing.Size(41, 40);
            this.picStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStar.TabIndex = 5;
            this.picStar.TabStop = false;
            // 
            // picHeart
            // 
            this.picHeart.Image = global::Menu.Resource1.Heart_Container__Ocarina_of_Time_and_Majora_s_Mask_;
            this.picHeart.Location = new System.Drawing.Point(765, -2);
            this.picHeart.Name = "picHeart";
            this.picHeart.Size = new System.Drawing.Size(41, 40);
            this.picHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeart.TabIndex = 6;
            this.picHeart.TabStop = false;
            // 
            // btnPowerups
            // 
            this.btnPowerups.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPowerups.Location = new System.Drawing.Point(685, -2);
            this.btnPowerups.Name = "btnPowerups";
            this.btnPowerups.Size = new System.Drawing.Size(153, 73);
            this.btnPowerups.TabIndex = 7;
            this.btnPowerups.Text = "\r\nPowerups";
            this.btnPowerups.UseVisualStyleBackColor = true;
            this.btnPowerups.Click += new System.EventHandler(this.btnPowerups_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Menu.Resource1.FotoJet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 442);
            this.Controls.Add(this.picHeart);
            this.Controls.Add(this.picStar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnControls);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPowerups);
            this.DoubleBuffered = true;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnControls;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picStar;
        private System.Windows.Forms.PictureBox picHeart;
        private System.Windows.Forms.Button btnPowerups;
    }
}

