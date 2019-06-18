namespace CheckersGame
{
    partial class ViewMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMenu));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.closelogin = new System.Windows.Forms.PictureBox();
            this.buttonMenuLoadGame = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonMenuLogOut = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonMenuProfile = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonMenuPlay = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonMenuRules = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closelogin)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.buttonMenuRules);
            this.bunifuGradientPanel1.Controls.Add(this.closelogin);
            this.bunifuGradientPanel1.Controls.Add(this.buttonMenuLoadGame);
            this.bunifuGradientPanel1.Controls.Add(this.buttonMenuLogOut);
            this.bunifuGradientPanel1.Controls.Add(this.buttonMenuProfile);
            this.bunifuGradientPanel1.Controls.Add(this.buttonMenuPlay);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Silver;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Silver;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(850, 580);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // closelogin
            // 
            this.closelogin.BackColor = System.Drawing.Color.Transparent;
            this.closelogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closelogin.BackgroundImage")));
            this.closelogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closelogin.Location = new System.Drawing.Point(803, 12);
            this.closelogin.Name = "closelogin";
            this.closelogin.Size = new System.Drawing.Size(35, 35);
            this.closelogin.TabIndex = 9;
            this.closelogin.TabStop = false;
            this.closelogin.Click += new System.EventHandler(this.closelogin_Click);
            // 
            // buttonMenuLoadGame
            // 
            this.buttonMenuLoadGame.ActiveBorderThickness = 1;
            this.buttonMenuLoadGame.ActiveCornerRadius = 20;
            this.buttonMenuLoadGame.ActiveFillColor = System.Drawing.Color.Silver;
            this.buttonMenuLoadGame.ActiveForecolor = System.Drawing.Color.White;
            this.buttonMenuLoadGame.ActiveLineColor = System.Drawing.Color.White;
            this.buttonMenuLoadGame.BackColor = System.Drawing.Color.Transparent;
            this.buttonMenuLoadGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMenuLoadGame.BackgroundImage")));
            this.buttonMenuLoadGame.ButtonText = "LOAD GAME";
            this.buttonMenuLoadGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenuLoadGame.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuLoadGame.ForeColor = System.Drawing.Color.Silver;
            this.buttonMenuLoadGame.IdleBorderThickness = 1;
            this.buttonMenuLoadGame.IdleCornerRadius = 20;
            this.buttonMenuLoadGame.IdleFillColor = System.Drawing.Color.White;
            this.buttonMenuLoadGame.IdleForecolor = System.Drawing.Color.Silver;
            this.buttonMenuLoadGame.IdleLineColor = System.Drawing.Color.DimGray;
            this.buttonMenuLoadGame.Location = new System.Drawing.Point(310, 254);
            this.buttonMenuLoadGame.Margin = new System.Windows.Forms.Padding(5);
            this.buttonMenuLoadGame.Name = "buttonMenuLoadGame";
            this.buttonMenuLoadGame.Size = new System.Drawing.Size(218, 53);
            this.buttonMenuLoadGame.TabIndex = 8;
            this.buttonMenuLoadGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMenuLogOut
            // 
            this.buttonMenuLogOut.ActiveBorderThickness = 1;
            this.buttonMenuLogOut.ActiveCornerRadius = 20;
            this.buttonMenuLogOut.ActiveFillColor = System.Drawing.Color.Silver;
            this.buttonMenuLogOut.ActiveForecolor = System.Drawing.Color.White;
            this.buttonMenuLogOut.ActiveLineColor = System.Drawing.Color.White;
            this.buttonMenuLogOut.BackColor = System.Drawing.Color.Transparent;
            this.buttonMenuLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMenuLogOut.BackgroundImage")));
            this.buttonMenuLogOut.ButtonText = "LOGOUT";
            this.buttonMenuLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenuLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuLogOut.ForeColor = System.Drawing.Color.Silver;
            this.buttonMenuLogOut.IdleBorderThickness = 1;
            this.buttonMenuLogOut.IdleCornerRadius = 20;
            this.buttonMenuLogOut.IdleFillColor = System.Drawing.Color.White;
            this.buttonMenuLogOut.IdleForecolor = System.Drawing.Color.Silver;
            this.buttonMenuLogOut.IdleLineColor = System.Drawing.Color.DimGray;
            this.buttonMenuLogOut.Location = new System.Drawing.Point(310, 426);
            this.buttonMenuLogOut.Margin = new System.Windows.Forms.Padding(5);
            this.buttonMenuLogOut.Name = "buttonMenuLogOut";
            this.buttonMenuLogOut.Size = new System.Drawing.Size(218, 53);
            this.buttonMenuLogOut.TabIndex = 6;
            this.buttonMenuLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonMenuLogOut.Click += new System.EventHandler(this.buttonMenuLogOut_Click);
            // 
            // buttonMenuProfile
            // 
            this.buttonMenuProfile.ActiveBorderThickness = 1;
            this.buttonMenuProfile.ActiveCornerRadius = 20;
            this.buttonMenuProfile.ActiveFillColor = System.Drawing.Color.Silver;
            this.buttonMenuProfile.ActiveForecolor = System.Drawing.Color.White;
            this.buttonMenuProfile.ActiveLineColor = System.Drawing.Color.White;
            this.buttonMenuProfile.BackColor = System.Drawing.Color.Transparent;
            this.buttonMenuProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMenuProfile.BackgroundImage")));
            this.buttonMenuProfile.ButtonText = "MY PROFILE";
            this.buttonMenuProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenuProfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuProfile.ForeColor = System.Drawing.Color.Silver;
            this.buttonMenuProfile.IdleBorderThickness = 1;
            this.buttonMenuProfile.IdleCornerRadius = 20;
            this.buttonMenuProfile.IdleFillColor = System.Drawing.Color.White;
            this.buttonMenuProfile.IdleForecolor = System.Drawing.Color.Silver;
            this.buttonMenuProfile.IdleLineColor = System.Drawing.Color.DimGray;
            this.buttonMenuProfile.Location = new System.Drawing.Point(310, 168);
            this.buttonMenuProfile.Margin = new System.Windows.Forms.Padding(5);
            this.buttonMenuProfile.Name = "buttonMenuProfile";
            this.buttonMenuProfile.Size = new System.Drawing.Size(218, 53);
            this.buttonMenuProfile.TabIndex = 5;
            this.buttonMenuProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonMenuProfile.Click += new System.EventHandler(this.buttonMenuProfile_Click);
            // 
            // buttonMenuPlay
            // 
            this.buttonMenuPlay.ActiveBorderThickness = 1;
            this.buttonMenuPlay.ActiveCornerRadius = 20;
            this.buttonMenuPlay.ActiveFillColor = System.Drawing.Color.Silver;
            this.buttonMenuPlay.ActiveForecolor = System.Drawing.Color.White;
            this.buttonMenuPlay.ActiveLineColor = System.Drawing.Color.White;
            this.buttonMenuPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonMenuPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMenuPlay.BackgroundImage")));
            this.buttonMenuPlay.ButtonText = "PLAY";
            this.buttonMenuPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenuPlay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuPlay.ForeColor = System.Drawing.Color.Silver;
            this.buttonMenuPlay.IdleBorderThickness = 1;
            this.buttonMenuPlay.IdleCornerRadius = 20;
            this.buttonMenuPlay.IdleFillColor = System.Drawing.Color.White;
            this.buttonMenuPlay.IdleForecolor = System.Drawing.Color.Silver;
            this.buttonMenuPlay.IdleLineColor = System.Drawing.Color.DimGray;
            this.buttonMenuPlay.Location = new System.Drawing.Point(310, 80);
            this.buttonMenuPlay.Margin = new System.Windows.Forms.Padding(5);
            this.buttonMenuPlay.Name = "buttonMenuPlay";
            this.buttonMenuPlay.Size = new System.Drawing.Size(218, 53);
            this.buttonMenuPlay.TabIndex = 4;
            this.buttonMenuPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonMenuPlay.Click += new System.EventHandler(this.buttonMenuPlay_Click);
            // 
            // buttonMenuRules
            // 
            this.buttonMenuRules.ActiveBorderThickness = 1;
            this.buttonMenuRules.ActiveCornerRadius = 20;
            this.buttonMenuRules.ActiveFillColor = System.Drawing.Color.Silver;
            this.buttonMenuRules.ActiveForecolor = System.Drawing.Color.White;
            this.buttonMenuRules.ActiveLineColor = System.Drawing.Color.White;
            this.buttonMenuRules.BackColor = System.Drawing.Color.Transparent;
            this.buttonMenuRules.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMenuRules.BackgroundImage")));
            this.buttonMenuRules.ButtonText = "RULES";
            this.buttonMenuRules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenuRules.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuRules.ForeColor = System.Drawing.Color.Silver;
            this.buttonMenuRules.IdleBorderThickness = 1;
            this.buttonMenuRules.IdleCornerRadius = 20;
            this.buttonMenuRules.IdleFillColor = System.Drawing.Color.White;
            this.buttonMenuRules.IdleForecolor = System.Drawing.Color.Silver;
            this.buttonMenuRules.IdleLineColor = System.Drawing.Color.DimGray;
            this.buttonMenuRules.Location = new System.Drawing.Point(310, 339);
            this.buttonMenuRules.Margin = new System.Windows.Forms.Padding(5);
            this.buttonMenuRules.Name = "buttonMenuRules";
            this.buttonMenuRules.Size = new System.Drawing.Size(218, 53);
            this.buttonMenuRules.TabIndex = 10;
            this.buttonMenuRules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonMenuRules.Click += new System.EventHandler(this.buttonMenuRules_Click);
            // 
            // ViewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 580);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closelogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonMenuLogOut;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonMenuProfile;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonMenuPlay;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonMenuLoadGame;
        private System.Windows.Forms.PictureBox closelogin;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonMenuRules;
    }
}