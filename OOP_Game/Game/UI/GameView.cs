using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game.Backend.GameObjects;
using Game.Backend.SoftwareClasses;

namespace Game
{
    public partial class GameView : Form
    {
        Player player = new Player();
        TankEnemy enemy = new TankEnemy();
       
        public GameView()
        {
            InitializeComponent();
        }

        private void Start(object sender, EventArgs e)
        {
            player = new Player(player_pic, pFirePic);
            enemy = new TankEnemy(TEnemy_pic,TEnemyFire_pic);
            timer1.Start();
        }

        private void Update(object sender, EventArgs e)
        {   
            player.JumpController();
            player.FireController();
            
        }

        

        private void IsKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !(player.state == State.Jumping))
            {
                player.StartJump();

            }
            if (e.KeyCode == Keys.F && !(player.state == State.Firing) && !(player.state == State.Jumping))
            {
                player.StartFire();
            }

            if (e.KeyCode == Keys.Left)
            {
                player.MoveLeft();
            }
            if (e.KeyCode == Keys.Right)
            {
                player.MoveRight();
            }


        }

        private void life01_Click(object sender, EventArgs e)
        {

        }
    }
}
