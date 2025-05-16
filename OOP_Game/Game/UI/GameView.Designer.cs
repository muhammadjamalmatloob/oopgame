namespace Game
{
    partial class GameView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameView));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.player_pic = new System.Windows.Forms.PictureBox();
            this.pFirePic = new System.Windows.Forms.PictureBox();
            this.TEnemy_pic = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            this.life1 = new System.Windows.Forms.PictureBox();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.healthbar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.TEnemyFire_pic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enemyHealth = new System.Windows.Forms.ProgressBar();
            this.win = new System.Windows.Forms.Label();
            this.lose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFirePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEnemy_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEnemyFire_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 5;
            this.gameTimer.Tick += new System.EventHandler(this.Update);
            // 
            // player_pic
            // 
            this.player_pic.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.player_pic.BackColor = System.Drawing.Color.Transparent;
            this.player_pic.Image = ((System.Drawing.Image)(resources.GetObject("player_pic.Image")));
            this.player_pic.Location = new System.Drawing.Point(70, 323);
            this.player_pic.Name = "player_pic";
            this.player_pic.Size = new System.Drawing.Size(156, 88);
            this.player_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player_pic.TabIndex = 0;
            this.player_pic.TabStop = false;
            // 
            // pFirePic
            // 
            this.pFirePic.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pFirePic.BackColor = System.Drawing.Color.Transparent;
            this.pFirePic.Image = global::Game.Properties.Resources.PlayerFire;
            this.pFirePic.Location = new System.Drawing.Point(226, 307);
            this.pFirePic.Name = "pFirePic";
            this.pFirePic.Size = new System.Drawing.Size(33, 32);
            this.pFirePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pFirePic.TabIndex = 1;
            this.pFirePic.TabStop = false;
            // 
            // TEnemy_pic
            // 
            this.TEnemy_pic.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TEnemy_pic.BackColor = System.Drawing.Color.Transparent;
            this.TEnemy_pic.Image = global::Game.Properties.Resources.Enemy1;
            this.TEnemy_pic.Location = new System.Drawing.Point(712, 323);
            this.TEnemy_pic.Name = "TEnemy_pic";
            this.TEnemy_pic.Size = new System.Drawing.Size(248, 85);
            this.TEnemy_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TEnemy_pic.TabIndex = 2;
            this.TEnemy_pic.TabStop = false;
            // 
            // life2
            // 
            this.life2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.life2.BackColor = System.Drawing.Color.Transparent;
            this.life2.Image = global::Game.Properties.Resources.Life;
            this.life2.Location = new System.Drawing.Point(878, 12);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(44, 43);
            this.life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life2.TabIndex = 3;
            this.life2.TabStop = false;
            this.life2.Click += new System.EventHandler(this.life01_Click);
            // 
            // life1
            // 
            this.life1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.life1.BackColor = System.Drawing.Color.Transparent;
            this.life1.Image = global::Game.Properties.Resources.Life;
            this.life1.Location = new System.Drawing.Point(828, 12);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(44, 43);
            this.life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life1.TabIndex = 4;
            this.life1.TabStop = false;
            // 
            // life3
            // 
            this.life3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.life3.BackColor = System.Drawing.Color.Transparent;
            this.life3.Image = global::Game.Properties.Resources.Life;
            this.life3.Location = new System.Drawing.Point(928, 12);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(44, 43);
            this.life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life3.TabIndex = 5;
            this.life3.TabStop = false;
            // 
            // healthbar
            // 
            this.healthbar.Location = new System.Drawing.Point(33, 43);
            this.healthbar.Name = "healthbar";
            this.healthbar.Size = new System.Drawing.Size(141, 23);
            this.healthbar.TabIndex = 6;
            this.healthbar.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Health";
            // 
            // TEnemyFire_pic
            // 
            this.TEnemyFire_pic.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TEnemyFire_pic.BackColor = System.Drawing.Color.Transparent;
            this.TEnemyFire_pic.Image = global::Game.Properties.Resources.Enemy1Fire;
            this.TEnemyFire_pic.Location = new System.Drawing.Point(683, 340);
            this.TEnemyFire_pic.Name = "TEnemyFire_pic";
            this.TEnemyFire_pic.Size = new System.Drawing.Size(38, 20);
            this.TEnemyFire_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TEnemyFire_pic.TabIndex = 8;
            this.TEnemyFire_pic.TabStop = false;
            this.TEnemyFire_pic.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(628, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "ENEMY HEALTH";
            // 
            // enemyHealth
            // 
            this.enemyHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enemyHealth.Location = new System.Drawing.Point(633, 40);
            this.enemyHealth.Name = "enemyHealth";
            this.enemyHealth.Size = new System.Drawing.Size(177, 23);
            this.enemyHealth.TabIndex = 9;
            this.enemyHealth.Value = 100;
            // 
            // win
            // 
            this.win.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.win.AutoSize = true;
            this.win.BackColor = System.Drawing.Color.Transparent;
            this.win.Font = new System.Drawing.Font("Stencil", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.win.ForeColor = System.Drawing.Color.ForestGreen;
            this.win.Location = new System.Drawing.Point(270, 162);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(298, 76);
            this.win.TabIndex = 11;
            this.win.Text = "YOU WIN";
            this.win.Visible = false;
            // 
            // lose
            // 
            this.lose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lose.AutoSize = true;
            this.lose.BackColor = System.Drawing.Color.Transparent;
            this.lose.Font = new System.Drawing.Font("Stencil", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lose.ForeColor = System.Drawing.Color.Maroon;
            this.lose.Location = new System.Drawing.Point(270, 196);
            this.lose.Name = "lose";
            this.lose.Size = new System.Drawing.Size(327, 76);
            this.lose.TabIndex = 12;
            this.lose.Text = "YOU LOSE";
            this.lose.Visible = false;
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.Location1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lose);
            this.Controls.Add(this.win);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enemyHealth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.healthbar);
            this.Controls.Add(this.life3);
            this.Controls.Add(this.life1);
            this.Controls.Add(this.life2);
            this.Controls.Add(this.TEnemy_pic);
            this.Controls.Add(this.player_pic);
            this.Controls.Add(this.pFirePic);
            this.Controls.Add(this.TEnemyFire_pic);
            this.Name = "GameView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameView";
            this.Load += new System.EventHandler(this.Start);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IsKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFirePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEnemy_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEnemyFire_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox player_pic;
        private System.Windows.Forms.PictureBox pFirePic;
        private System.Windows.Forms.PictureBox TEnemy_pic;
        private System.Windows.Forms.PictureBox life2;
        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.ProgressBar healthbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox TEnemyFire_pic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar enemyHealth;
        private System.Windows.Forms.Label win;
        private System.Windows.Forms.Label lose;
    }
}