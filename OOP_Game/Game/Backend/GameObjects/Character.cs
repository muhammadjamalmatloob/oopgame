using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.Backend.GameObjects
{
    public abstract class Character
    {
        protected PictureBox character;
        protected int Speed = 20;
        protected const int Gravity = 2;

        protected Character(PictureBox character)
        { 
            this.character = character;
        }
        protected Character()
        {
            
        }

        protected void Position(int X, int Y)
        {
            character.Location = new Point(X, Y);
        }

        public int X
        {
            get { return character.Location.X; }   
        }
            
        public int Y
        {
            get { return character.Location.Y; }   
        }

        public virtual void SetProperties()
        {
            character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            character.BackColor = System.Drawing.Color.Transparent;
        }

        public void MoveLeft()
        {
            if (X - Speed <= 0)
            {
                Position(0, Y);
            }
            else
            {
                Position(X - Speed, Y);
            }
        }

        public void MoveRight()
        {
            if (X + Speed >= 829)
            {
                Position(829, Y);
            }
            else
            {
                Position(X + Speed, Y);
            }
        }

        public void MoveDown(PictureBox picture)
        {
            picture.Left -= Speed;
        }
    }
}
