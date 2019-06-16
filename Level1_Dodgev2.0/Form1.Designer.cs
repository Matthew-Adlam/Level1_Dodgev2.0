namespace Level1_Dodgev2._0
{
    partial class FrmDodge
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
            this.PnlGame = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TmrPlanet = new System.Windows.Forms.Timer(this.components);
            this.TmrShip = new System.Windows.Forms.Timer(this.components);
            this.LblScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lives = new System.Windows.Forms.Label();
            this.LblLives = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HighScore = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lmfaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iHakUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hacksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youLoseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.start = new System.Windows.Forms.Button();
            this.instructions = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.redeemCode = new System.Windows.Forms.TextBox();
            this.redeemButton = new System.Windows.Forms.Button();
            this.TmrMystery = new System.Windows.Forms.Timer(this.components);
            this.PnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.Silver;
            this.PnlGame.Controls.Add(this.pictureBox1);
            this.PnlGame.Location = new System.Drawing.Point(13, 166);
            this.PnlGame.Margin = new System.Windows.Forms.Padding(4);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(500, 450);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.BackgroundImage = global::Level1_Dodgev2._0.Properties.Resources.download;
            this.pictureBox1.Image = global::Level1_Dodgev2._0.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(210, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TmrPlanet
            // 
            this.TmrPlanet.Enabled = true;
            this.TmrPlanet.Tick += new System.EventHandler(this.TmrPlanet_Tick);
            // 
            // TmrShip
            // 
            this.TmrShip.Enabled = true;
            this.TmrShip.Interval = 50;
            this.TmrShip.Tick += new System.EventHandler(this.TmrShip_Tick);
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScore.Location = new System.Drawing.Point(114, 90);
            this.LblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(15, 16);
            this.LblScore.TabIndex = 5;
            this.LblScore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Score";
            // 
            // Lives
            // 
            this.Lives.AutoSize = true;
            this.Lives.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lives.Location = new System.Drawing.Point(441, 43);
            this.Lives.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lives.Name = "Lives";
            this.Lives.Size = new System.Drawing.Size(40, 16);
            this.Lives.TabIndex = 7;
            this.Lives.Text = "Lives";
            // 
            // LblLives
            // 
            this.LblLives.AutoSize = true;
            this.LblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLives.Location = new System.Drawing.Point(454, 90);
            this.LblLives.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLives.Name = "LblLives";
            this.LblLives.Size = new System.Drawing.Size(15, 16);
            this.LblLives.TabIndex = 8;
            this.LblLives.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "High Score";
            // 
            // HighScore
            // 
            this.HighScore.AutoSize = true;
            this.HighScore.Location = new System.Drawing.Point(305, 90);
            this.HighScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HighScore.Name = "HighScore";
            this.HighScore.Size = new System.Drawing.Size(15, 16);
            this.HighScore.TabIndex = 10;
            this.HighScore.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lmfaoToolStripMenuItem,
            this.iHakUToolStripMenuItem,
            this.hacksToolStripMenuItem,
            this.youLoseToolStripMenuItem,
            this.idkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // lmfaoToolStripMenuItem
            // 
            this.lmfaoToolStripMenuItem.Name = "lmfaoToolStripMenuItem";
            this.lmfaoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.lmfaoToolStripMenuItem.Text = "lmfao";
            this.lmfaoToolStripMenuItem.Click += new System.EventHandler(this.lmfaoToolStripMenuItem_Click);
            // 
            // iHakUToolStripMenuItem
            // 
            this.iHakUToolStripMenuItem.Name = "iHakUToolStripMenuItem";
            this.iHakUToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.iHakUToolStripMenuItem.Text = "i hak u";
            this.iHakUToolStripMenuItem.Click += new System.EventHandler(this.iHakUToolStripMenuItem_Click);
            // 
            // hacksToolStripMenuItem
            // 
            this.hacksToolStripMenuItem.Name = "hacksToolStripMenuItem";
            this.hacksToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.hacksToolStripMenuItem.Text = "hacks!";
            this.hacksToolStripMenuItem.Visible = false;
            this.hacksToolStripMenuItem.Click += new System.EventHandler(this.hacksToolStripMenuItem_Click);
            // 
            // youLoseToolStripMenuItem
            // 
            this.youLoseToolStripMenuItem.Name = "youLoseToolStripMenuItem";
            this.youLoseToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.youLoseToolStripMenuItem.Text = "You Lose";
            this.youLoseToolStripMenuItem.Click += new System.EventHandler(this.youLoseToolStripMenuItem_Click);
            // 
            // idkToolStripMenuItem
            // 
            this.idkToolStripMenuItem.Name = "idkToolStripMenuItem";
            this.idkToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.idkToolStripMenuItem.Text = "idk";
            this.idkToolStripMenuItem.Click += new System.EventHandler(this.idkToolStripMenuItem_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(523, 0);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(100, 50);
            this.start.TabIndex = 12;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // instructions
            // 
            this.instructions.Location = new System.Drawing.Point(523, 73);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(100, 50);
            this.instructions.TabIndex = 13;
            this.instructions.Text = "Instructions";
            this.instructions.UseVisualStyleBackColor = true;
            this.instructions.Click += new System.EventHandler(this.instructions_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Redeem Code";
            // 
            // redeemCode
            // 
            this.redeemCode.Location = new System.Drawing.Point(520, 254);
            this.redeemCode.Name = "redeemCode";
            this.redeemCode.Size = new System.Drawing.Size(100, 22);
            this.redeemCode.TabIndex = 15;
            // 
            // redeemButton
            // 
            this.redeemButton.Location = new System.Drawing.Point(534, 292);
            this.redeemButton.Name = "redeemButton";
            this.redeemButton.Size = new System.Drawing.Size(75, 23);
            this.redeemButton.TabIndex = 16;
            this.redeemButton.Text = "Confirm";
            this.redeemButton.UseVisualStyleBackColor = true;
            this.redeemButton.Click += new System.EventHandler(this.redeemButton_Click);
            // 
            // TmrMystery
            // 
            this.TmrMystery.Enabled = true;
            this.TmrMystery.Interval = 1000;
            this.TmrMystery.Tick += new System.EventHandler(this.TmrMystery_Tick);
            // 
            // FrmDodge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 629);
            this.Controls.Add(this.redeemButton);
            this.Controls.Add(this.redeemCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.start);
            this.Controls.Add(this.HighScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblLives);
            this.Controls.Add(this.Lives);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.PnlGame);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDodge";
            this.Load += new System.EventHandler(this.FrmDodge_Load);
            this.Click += new System.EventHandler(this.FrmDodge_Click);
            this.DoubleClick += new System.EventHandler(this.FrmDodge_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDodge_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmDodge_KeyUp);
            this.PnlGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer TmrPlanet;
        private System.Windows.Forms.Timer TmrShip;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lives;
        private System.Windows.Forms.Label LblLives;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HighScore;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hacksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lmfaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iHakUToolStripMenuItem;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ToolStripMenuItem youLoseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idkToolStripMenuItem;
        private System.Windows.Forms.Button instructions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox redeemCode;
        private System.Windows.Forms.Button redeemButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer TmrMystery;
    }
}

