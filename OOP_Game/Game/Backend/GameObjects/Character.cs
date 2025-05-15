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
        protected int Speed = 15;
        protected const int Gravity = 3;

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

        protected int X
        {
            get { return character.Location.X; }   
        }
            
        protected int Y
        {
            get { return character.Location.Y; }   
        }

        public virtual void SetProperties()
        {
            character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            character.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
