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
        public bool isgameover = false;
        Player player = new Player();
        TankEnemy enemy = new TankEnemy();
        int life = 3;
       
        public GameView()
        {
            InitializeComponent();
        }

        private void Start(object sender, EventArgs e)
        {
            player = new Player(player_pic, pFirePic);
            enemy = new TankEnemy(TEnemy_pic,TEnemyFire_pic);
            gameTimer.Start();
        }

        private void Update(object sender, EventArgs e)
        {   
            player.JumpController();
            player.FireController();

            enemy.FireController(GameController.Enemy1Decider(enemy, player).fire);
            enemy.MoveLeft(GameController.Enemy1Decider(enemy, player).left);
            enemy.MoveRight(GameController.Enemy1Decider(enemy, player).right);
            player.Collision(player_pic, TEnemyFire_pic, healthbar);
            enemy.Collision(TEnemy_pic, pFirePic, enemyHealth);
            if(healthbar.Value == 0 && life >= 0)
            {
                life--;
                healthbar.Value = 100;
                
            }
            if(life == 2)
            {
                life3.Visible = false;
            }
            if(life == 1)
            {
                life2.Visible = false;
            }
            if(life == 0)
            {
                life1.Visible = false;
            }

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
