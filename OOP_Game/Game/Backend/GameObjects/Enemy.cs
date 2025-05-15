using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.Backend.GameObjects
{
    
    public abstract class Enemy : Character 
    {
        public State state;
        public Enemy(PictureBox character) : base (character)
        {
            this.character = character;
        }
        public Enemy ()
        {

        }

    }
}
