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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player_pic = new System.Windows.Forms.PictureBox();
            this.pFirePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFirePic)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Update);
            // 
            // player_pic
            // 
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
            this.pFirePic.BackColor = System.Drawing.Color.Transparent;
            this.pFirePic.Image = global::Game.Properties.Resources.PlayerFire;
            this.pFirePic.Location = new System.Drawing.Point(226, 307);
            this.pFirePic.Name = "pFirePic";
            this.pFirePic.Size = new System.Drawing.Size(33, 32);
            this.pFirePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pFirePic.TabIndex = 1;
            this.pFirePic.TabStop = false;
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.Location1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.player_pic);
            this.Controls.Add(this.pFirePic);
            this.Name = "GameView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameView";
            this.Load += new System.EventHandler(this.Start);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IsKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFirePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox player_pic;
        private System.Windows.Forms.PictureBox pFirePic;
    }
}