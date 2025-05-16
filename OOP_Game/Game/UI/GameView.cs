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
        Random rand;
        Player player = new Player();
        TankEnemy enemy = new TankEnemy();
        int life = 4;
        int n;

        public GameView()
        {
            InitializeComponent();
        }

        private void Start(object sender, EventArgs e)
        {
            win.Visible = false;
            lose.Visible = false;
            player = new Player(player_pic, pFirePic);
            enemy = new TankEnemy(TEnemy_pic, TEnemyFire_pic);
            rand = new Random();
            gameTimer.Start();
        }

        private void Update(object sender, EventArgs e)
        {
            int n = rand.Next(0, 9);
            player.JumpController();
            player.FireController();
            enemy.FireController();
            if (enemy.X - 500 >= player.X)
            {
                enemy.MoveLeft();
            }
            else if (n < 4 && enemy.X - 350 >= player.X)
            {
                enemy.MoveLeft();
                if (enemy.state != State.Firing)
                {
                    enemy.StartFire();
                }
            }
            else if (n >= 4 && player.X < 829)
            {
                enemy.MoveRight();
            }
            else if (enemy.state != State.Firing)
            {
                enemy.StartFire();
            }
            player.Collision(player_pic, TEnemyFire_pic, healthbar);
            enemy.Collision(TEnemy_pic, pFirePic, enemyHealth);
            if (healthbar.Value == 0 && life >= 0)
            {
                life--;
                healthbar.Value = 100;

            }
            if (life == 2)
            {
                life3.Visible = false;
            }
            if (life == 1)
            {
                life2.Visible = false;
            }
            if (life == 0)
            {

                life1.Visible = false;
                isgameover = true;
                gameTimer.Stop();
                lose.Visible = true;
            }
            if (enemyHealth.Value == 0)
            {
                isgameover = true;
                gameTimer.Stop();
                win.Visible = true;
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
            if(e.KeyCode == Keys.Enter && isgameover== true)
            {
                MainMenu mm = new MainMenu();
                mm.Show();
                this.Visible = false;
            }


        }

        private void life01_Click(object sender, EventArgs e)
        {

        }

        
    }
}
