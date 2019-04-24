namespace Login1
{
    partial class ViewModoJogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewModoJogo));
            this.ViewPanelModoJogo = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.buttonONLINE = new System.Windows.Forms.Button();
            this.buttonVSJogador = new System.Windows.Forms.Button();
            this.buttonVSComputador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.closelogin = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ViewPanelModoJogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closelogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewPanelModoJogo
            // 
            this.ViewPanelModoJogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ViewPanelModoJogo.BackgroundImage")));
            this.ViewPanelModoJogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewPanelModoJogo.Controls.Add(this.pictureBox2);
            this.ViewPanelModoJogo.Controls.Add(this.pictureBox3);
            this.ViewPanelModoJogo.Controls.Add(this.pictureBox1);
            this.ViewPanelModoJogo.Controls.Add(this.buttonONLINE);
            this.ViewPanelModoJogo.Controls.Add(this.buttonVSJogador);
            this.ViewPanelModoJogo.Controls.Add(this.buttonVSComputador);
            this.ViewPanelModoJogo.Controls.Add(this.label1);
            this.ViewPanelModoJogo.Controls.Add(this.closelogin);
            this.ViewPanelModoJogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPanelModoJogo.ForeColor = System.Drawing.Color.Black;
            this.ViewPanelModoJogo.GradientBottomLeft = System.Drawing.Color.Black;
            this.ViewPanelModoJogo.GradientBottomRight = System.Drawing.Color.White;
            this.ViewPanelModoJogo.GradientTopLeft = System.Drawing.Color.Silver;
            this.ViewPanelModoJogo.GradientTopRight = System.Drawing.Color.Silver;
            this.ViewPanelModoJogo.Location = new System.Drawing.Point(0, 0);
            this.ViewPanelModoJogo.Name = "ViewPanelModoJogo";
            this.ViewPanelModoJogo.Quality = 10;
            this.ViewPanelModoJogo.Size = new System.Drawing.Size(850, 580);
            this.ViewPanelModoJogo.TabIndex = 0;
            this.ViewPanelModoJogo.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPanelModoJogo_Paint);
            // 
            // buttonONLINE
            // 
            this.buttonONLINE.BackColor = System.Drawing.Color.Silver;
            this.buttonONLINE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonONLINE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonONLINE.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonONLINE.ForeColor = System.Drawing.Color.Black;
            this.buttonONLINE.Location = new System.Drawing.Point(615, 248);
            this.buttonONLINE.Name = "buttonONLINE";
            this.buttonONLINE.Size = new System.Drawing.Size(185, 259);
            this.buttonONLINE.TabIndex = 10;
            this.buttonONLINE.TabStop = false;
            this.buttonONLINE.Text = "ONLINE\r\n\r\nExperimenta jogar uma partida de damas contra outro jogador online.";
            this.buttonONLINE.UseVisualStyleBackColor = false;
            this.buttonONLINE.Click += new System.EventHandler(this.buttonONLINE_Click);
            // 
            // buttonVSJogador
            // 
            this.buttonVSJogador.BackColor = System.Drawing.Color.Silver;
            this.buttonVSJogador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVSJogador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVSJogador.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVSJogador.ForeColor = System.Drawing.Color.Black;
            this.buttonVSJogador.Location = new System.Drawing.Point(337, 248);
            this.buttonVSJogador.Name = "buttonVSJogador";
            this.buttonVSJogador.Size = new System.Drawing.Size(185, 259);
            this.buttonVSJogador.TabIndex = 10;
            this.buttonVSJogador.TabStop = false;
            this.buttonVSJogador.Text = "VS. JOGADOR\r\n\r\nExperimenta jogar uma partida de damas contra outro jogador.";
            this.buttonVSJogador.UseVisualStyleBackColor = false;
            this.buttonVSJogador.Click += new System.EventHandler(this.buttonVSJogador_Click);
            // 
            // buttonVSComputador
            // 
            this.buttonVSComputador.BackColor = System.Drawing.Color.Silver;
            this.buttonVSComputador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVSComputador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVSComputador.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVSComputador.ForeColor = System.Drawing.Color.Black;
            this.buttonVSComputador.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonVSComputador.Location = new System.Drawing.Point(60, 248);
            this.buttonVSComputador.Name = "buttonVSComputador";
            this.buttonVSComputador.Size = new System.Drawing.Size(185, 259);
            this.buttonVSComputador.TabIndex = 10;
            this.buttonVSComputador.TabStop = false;
            this.buttonVSComputador.Text = "VS. COMPUTADOR\r\n\r\nExperimenta jogar uma partida de damas contra o computador.";
            this.buttonVSComputador.UseVisualStyleBackColor = false;
            this.buttonVSComputador.Click += new System.EventHandler(this.buttonVSComputador_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selecione o Modo de Jogo";
            // 
            // closelogin
            // 
            this.closelogin.BackColor = System.Drawing.Color.Transparent;
            this.closelogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closelogin.BackgroundImage")));
            this.closelogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closelogin.Location = new System.Drawing.Point(812, 3);
            this.closelogin.Name = "closelogin";
            this.closelogin.Size = new System.Drawing.Size(35, 35);
            this.closelogin.TabIndex = 7;
            this.closelogin.TabStop = false;
            this.closelogin.Click += new System.EventHandler(this.closelogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(661, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(382, 140);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // ViewModoJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 580);
            this.Controls.Add(this.ViewPanelModoJogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewModoJogo";
            this.Text = "ViewModoJogo";
            this.ViewPanelModoJogo.ResumeLayout(false);
            this.ViewPanelModoJogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closelogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel ViewPanelModoJogo;
        private System.Windows.Forms.PictureBox closelogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonONLINE;
        private System.Windows.Forms.Button buttonVSJogador;
        private System.Windows.Forms.Button buttonVSComputador;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}