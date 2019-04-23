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
            this.label1 = new System.Windows.Forms.Label();
            this.closelogin = new System.Windows.Forms.PictureBox();
            this.buttonVSComputador = new System.Windows.Forms.Button();
            this.buttonVSJogador = new System.Windows.Forms.Button();
            this.buttonONLINE = new System.Windows.Forms.Button();
            this.ViewPanelModoJogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closelogin)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewPanelModoJogo
            // 
            this.ViewPanelModoJogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ViewPanelModoJogo.BackgroundImage")));
            this.ViewPanelModoJogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewPanelModoJogo.Controls.Add(this.buttonONLINE);
            this.ViewPanelModoJogo.Controls.Add(this.buttonVSJogador);
            this.ViewPanelModoJogo.Controls.Add(this.buttonVSComputador);
            this.ViewPanelModoJogo.Controls.Add(this.label1);
            this.ViewPanelModoJogo.Controls.Add(this.closelogin);
            this.ViewPanelModoJogo.Dock = System.Windows.Forms.DockStyle.Fill;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bem-vindo ao Modo de Jogo";
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
            // 
            // buttonVSComputador
            // 
            this.buttonVSComputador.BackColor = System.Drawing.Color.Transparent;
            this.buttonVSComputador.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVSComputador.ForeColor = System.Drawing.Color.Black;
            this.buttonVSComputador.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonVSComputador.Location = new System.Drawing.Point(60, 175);
            this.buttonVSComputador.Name = "buttonVSComputador";
            this.buttonVSComputador.Size = new System.Drawing.Size(185, 332);
            this.buttonVSComputador.TabIndex = 9;
            this.buttonVSComputador.Text = "\r\nVS. COMPUTADOR\r\n\r\nExperimenta jogar uma partida de damas contra o computador.";
            this.buttonVSComputador.UseVisualStyleBackColor = false;
            // 
            // buttonVSJogador
            // 
            this.buttonVSJogador.BackColor = System.Drawing.Color.Transparent;
            this.buttonVSJogador.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVSJogador.ForeColor = System.Drawing.Color.Black;
            this.buttonVSJogador.Location = new System.Drawing.Point(337, 175);
            this.buttonVSJogador.Name = "buttonVSJogador";
            this.buttonVSJogador.Size = new System.Drawing.Size(185, 332);
            this.buttonVSJogador.TabIndex = 10;
            this.buttonVSJogador.Text = "\r\nVS. JOGADOR\r\n\r\nExperimenta jogar uma partida de damas contra outro jogador.";
            this.buttonVSJogador.UseVisualStyleBackColor = false;
            // 
            // buttonONLINE
            // 
            this.buttonONLINE.BackColor = System.Drawing.Color.Transparent;
            this.buttonONLINE.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonONLINE.ForeColor = System.Drawing.Color.Black;
            this.buttonONLINE.Location = new System.Drawing.Point(615, 175);
            this.buttonONLINE.Name = "buttonONLINE";
            this.buttonONLINE.Size = new System.Drawing.Size(185, 332);
            this.buttonONLINE.TabIndex = 11;
            this.buttonONLINE.Text = "\r\nONLINE\r\n\r\nExperimenta jogar uma partida de damas contra outro jogador online.";
            this.buttonONLINE.UseVisualStyleBackColor = false;
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
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel ViewPanelModoJogo;
        private System.Windows.Forms.PictureBox closelogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonONLINE;
        private System.Windows.Forms.Button buttonVSJogador;
        private System.Windows.Forms.Button buttonVSComputador;
    }
}