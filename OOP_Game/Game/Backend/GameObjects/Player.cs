using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game.Backend.Interfaces;
using Game.Backend.SoftwareClasses;
using Game.Properties;

namespace Game.Backend.GameObjects
{
    public class Player : Character, IJump
    {
        public State state;
        private int initY;
        private int JumpSpeed = 20;
        PictureBox fire;
        private int fireRange = 360;
        private int fireSpeed = 30;
        private int FireDistance = 0;

        public int XF
        {
            get { return fire.Location.X; }
        }

        public int YF
        {
            get { return fire.Location.Y; }
        }
        public Player(PictureBox character, PictureBox fire) : base(character)
        {
            
            this.character = character;
            state = State.Normal;
            this.fire = fire;
            fire.Visible = false;
        }
        public Player()
        {
            state = State.Normal;
        }
        public void StartJump()
        {
            ResetFire();
            state = State.Jumping;
            initY = Y;
            JumpSpeed = 20;
        }


        public void JumpController()
        {
            if (state == State.Jumping)
            {
                if (Y - Gravity > initY)
                {
                    state = State.Normal;
                    Position(X, initY);
                }
                else
                {
                    JumpSpeed -= Gravity;
                    Position(X, Y - JumpSpeed);
                }
            }
        }

        public void StartFire()
        {
            ResetFire();
            state = State.Firing;
            fire.Visible = true;
        }

        public void FireController()
        {
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
                    fire.Top += 1;
                    FirePosition(XF + fireSpeed,YF);
                }
            }
        }

        public new void SetProperties()
        {
            base.SetProperties();
            character.Size = new System.Drawing.Size(131, 79);
            Position(70, 323);
            character.Image = Assets.Player;
            character.Visible = true;
        }

        private void FirePosition(int X, int Y)
        {
            fire.Location = new Point(X, Y);
        }

        public void ResetPlayer()
        {
            character.Size = new System.Drawing.Size(131, 79);
            Position(70, 323);
            character.Image = Assets.Player;
            character.Visible = true;
        }

        public void ResetFire()
        {
            fire.Top = 307;
            fire.Visible = false;
            fire.Left = character.Left + 156;
            FireDistance = 0;
        }

        
    }
    public enum State
    {
        Normal,
        Jumping,
        Firing,
        Destroy,
        Left,
        Right
    }
}
