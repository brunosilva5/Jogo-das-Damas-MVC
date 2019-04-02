namespace Login1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.loginbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.signupbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.closelogin = new System.Windows.Forms.PictureBox();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textboxUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closelogin)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.loginbutton);
            this.bunifuGradientPanel1.Controls.Add(this.signupbutton);
            this.bunifuGradientPanel1.Controls.Add(this.closelogin);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuTileButton1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuMaterialTextbox2);
            this.bunifuGradientPanel1.Controls.Add(this.textboxUsername);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton1);
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
            // loginbutton
            // 
            this.loginbutton.ActiveBorderThickness = 1;
            this.loginbutton.ActiveCornerRadius = 20;
            this.loginbutton.ActiveFillColor = System.Drawing.Color.Silver;
            this.loginbutton.ActiveForecolor = System.Drawing.Color.White;
            this.loginbutton.ActiveLineColor = System.Drawing.Color.White;
            this.loginbutton.BackColor = System.Drawing.SystemColors.Control;
            this.loginbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginbutton.BackgroundImage")));
            this.loginbutton.ButtonText = "LOGIN";
            this.loginbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.Color.Silver;
            this.loginbutton.IdleBorderThickness = 1;
            this.loginbutton.IdleCornerRadius = 20;
            this.loginbutton.IdleFillColor = System.Drawing.Color.White;
            this.loginbutton.IdleForecolor = System.Drawing.Color.Silver;
            this.loginbutton.IdleLineColor = System.Drawing.Color.DimGray;
            this.loginbutton.Location = new System.Drawing.Point(325, 450);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(5);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(181, 41);
            this.loginbutton.TabIndex = 3;
            this.loginbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signupbutton
            // 
            this.signupbutton.ActiveBorderThickness = 1;
            this.signupbutton.ActiveCornerRadius = 20;
            this.signupbutton.ActiveFillColor = System.Drawing.Color.Transparent;
            this.signupbutton.ActiveForecolor = System.Drawing.Color.Transparent;
            this.signupbutton.ActiveLineColor = System.Drawing.Color.Transparent;
            this.signupbutton.BackColor = System.Drawing.SystemColors.Control;
            this.signupbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signupbutton.BackgroundImage")));
            this.signupbutton.ButtonText = "Sign up";
            this.signupbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbutton.ForeColor = System.Drawing.Color.SeaGreen;
            this.signupbutton.IdleBorderThickness = 1;
            this.signupbutton.IdleCornerRadius = 20;
            this.signupbutton.IdleFillColor = System.Drawing.Color.Transparent;
            this.signupbutton.IdleForecolor = System.Drawing.Color.White;
            this.signupbutton.IdleLineColor = System.Drawing.Color.Transparent;
            this.signupbutton.Location = new System.Drawing.Point(429, 408);
            this.signupbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(145, 33);
            this.signupbutton.TabIndex = 7;
            this.signupbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signupbutton.Click += new System.EventHandler(this.signupbutton_Click);
            // 
            // closelogin
            // 
            this.closelogin.BackColor = System.Drawing.Color.Transparent;
            this.closelogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closelogin.BackgroundImage")));
            this.closelogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closelogin.Location = new System.Drawing.Point(803, 12);
            this.closelogin.Name = "closelogin";
            this.closelogin.Size = new System.Drawing.Size(35, 35);
            this.closelogin.TabIndex = 6;
            this.closelogin.TabStop = false;
            this.closelogin.Click += new System.EventHandler(this.closelogin_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "Login";
            this.bunifuTileButton1.Location = new System.Drawing.Point(359, 88);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButton1.TabIndex = 2;
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(233, 356);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(370, 44);
            this.bunifuMaterialTextbox2.TabIndex = 2;
            this.bunifuMaterialTextbox2.Text = "Password";
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textboxUsername
            // 
            this.textboxUsername.BackColor = System.Drawing.SystemColors.Control;
            this.textboxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxUsername.HintForeColor = System.Drawing.Color.Empty;
            this.textboxUsername.HintText = "";
            this.textboxUsername.isPassword = false;
            this.textboxUsername.LineFocusedColor = System.Drawing.Color.Black;
            this.textboxUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.textboxUsername.LineMouseHoverColor = System.Drawing.Color.Black;
            this.textboxUsername.LineThickness = 3;
            this.textboxUsername.Location = new System.Drawing.Point(233, 284);
            this.textboxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(370, 44);
            this.textboxUsername.TabIndex = 1;
            this.textboxUsername.Text = "Username";
            this.textboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textboxUsername.MouseEnter += new System.EventHandler(this.UsernameEnter);
            this.textboxUsername.MouseLeave += new System.EventHandler(this.UsernameLeave);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Remember me";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(215, 397);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = true;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(243, 59);
            this.bunifuFlatButton1.TabIndex = 5;
            this.bunifuFlatButton1.Text = "Remember me";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 580);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closelogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxUsername;
        private System.Windows.Forms.PictureBox closelogin;
        private Bunifu.Framework.UI.BunifuThinButton2 signupbutton;
        private Bunifu.Framework.UI.BunifuThinButton2 loginbutton;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}

