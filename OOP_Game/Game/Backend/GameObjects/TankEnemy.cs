using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Backend.Interfaces;
using System.Drawing;
using System.Windows.Forms;
using Game.Backend.SoftwareClasses;

namespace Game.Backend.GameObjects
{
    public class TankEnemy : Enemy
    {
        PictureBox fire;
        private int fireRange = 360;
        private int fireSpeed = 30;
        private int FireDistance = 0;
        public int moveright = 0;
        public int moveleft = 0;

        public int XF
        {
            get { return fire.Location.X; }
        }

        public int YF
        {
            get { return fire.Location.Y; }
        }
        public TankEnemy(PictureBox character, PictureBox fire) : base(character)
        {
            this.character = character;
            this.fire = fire;
        }
        public TankEnemy()
        {

        }

        public new void SetProperties()
        {
            base.SetProperties();
            character.Size = new System.Drawing.Size(248, 85);
            Position(712, 323);
            character.Image = Assets.Player;
            character.Visible = true;
        }

        private void FirePosition(int X, int Y)
        {
            fire.Location = new Point(X, Y);
        }

        public void StartFire()
        {
            
        }

        public void FireController(bool condition)
        {
            if (condition)
            {
                if (state != State.Firing)
                {
                    ResetFire();
                    state = State.Firing;
                    fire.Visible = true;
                }
                if (state == State.Firing)
                {
                    if (FireDistance + fireSpeed > fireRange)
                    {
                        state = State.Normal;
                        ResetFire();
                    }
                    else
                    {
                        FireDistance += fireSpeed;
                        FirePosition(XF - fireSpeed, YF);
                    }
                }
            }
        }

        public void ResetFire()
        {
            fire.Visible = false;
            fire.Left = character.Left - 29;
            FireDistance = 0;
        }

        public void MoveLeft(bool condition)
        {
            if (moveleft == 30)
            {
                moveleft = 0;
            }
            if (condition && moveright == 0)
            {
                moveleft++;
                base.MoveLeft();
            }
            
        }
        public void MoveRight(bool condition)
        {
            if (moveright == 20)
            {
                moveright = 0;
            }
            if (condition && moveleft == 0)
            {
                moveright++;
                base.MoveRight();
            }

        }

        public void Collision(PictureBox enemy, PictureBox bullet, ProgressBar health)
        {
            if (bullet.Bounds.IntersectsWith(enemy.Bounds) && health.Value != 0)
            {
                health.Value -= 5;
            }
        }
    }
}
