namespace Game
{
    partial class MainMenu
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.play = new System.Windows.Forms.PictureBox();
            this.location = new System.Windows.Forms.PictureBox();
            this.difficulty = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.location)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficulty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.Image = global::Game.Properties.Resources.wood;
            this.play.Location = new System.Drawing.Point(302, -52);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(423, 212);
            this.play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.play.TabIndex = 0;
            this.play.TabStop = false;
            // 
            // location
            // 
            this.location.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.location.BackColor = System.Drawing.Color.Transparent;
            this.location.Image = global::Game.Properties.Resources.wood;
            this.location.Location = new System.Drawing.Point(302, 81);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(423, 212);
            this.location.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.location.TabIndex = 1;
            this.location.TabStop = false;
            // 
            // difficulty
            // 
            this.difficulty.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.difficulty.BackColor = System.Drawing.Color.Transparent;
            this.difficulty.Image = global::Game.Properties.Resources.wood;
            this.difficulty.Location = new System.Drawing.Point(302, 213);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(423, 212);
            this.difficulty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.difficulty.TabIndex = 2;
            this.difficulty.TabStop = false;
            // 
            // exit
            // 
            this.exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Image = global::Game.Properties.Resources.wood;
            this.exit.Location = new System.Drawing.Point(302, 345);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(423, 212);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 3;
            this.exit.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(473, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "PLAY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SaddleBrown;
            this.label2.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(452, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "LOCATION";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SaddleBrown;
            this.label3.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(444, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "DIFFICULTY";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SaddleBrown;
            this.label4.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(478, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "EXIT";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.Location1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.location);
            this.Controls.Add(this.play);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.location)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficulty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.PictureBox location;
        private System.Windows.Forms.PictureBox difficulty;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

