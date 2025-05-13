using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game.Backend.Interfaces;

namespace Game.Backend.GameObjects
{
    public class Player : Character, IJump
    {
        public Player(PictureBox character) : base (character)
        {
            
        }

        public void StartJump()
        {

        }

        public void JumpController()
        {

        }

    }
}
