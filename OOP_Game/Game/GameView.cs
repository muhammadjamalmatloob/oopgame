using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class GameView : Form
    {
        int JumpSpeed = 25;
        int speed = 10;
        int gravity = 2;
        bool jump = false;
        int Yinit;
        bool move = false;
        public GameView()
        {
            InitializeComponent();
        }

        private void Start(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Update(object sender, EventArgs e)
        {
            JumpManager();
        }

        private void StartJump()
        {
            jump = true;
            Yinit = pictureBox1.Location.Y;
        }

        private void JumpManager()
        {
            if (jump)
            {
                if (pictureBox1.Location.Y - gravity >= Yinit)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, Yinit);
                    jump = false;
                    JumpSpeed = 25;
                }
                else
                {
                    pictureBox1.Top -= JumpSpeed;
                    JumpSpeed -= gravity;
                }
            }
            

        }

        private void IsKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !jump)
            {
                StartJump();
            }
        }

        private void MoveRight()
        {

        }
    }
}
