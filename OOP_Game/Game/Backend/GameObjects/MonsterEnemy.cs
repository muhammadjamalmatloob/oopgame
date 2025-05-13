using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Backend.Interfaces;
using System.Drawing;
using System.Windows.Forms;

namespace Game.Backend.GameObjects
{
    public class MonsterEnemy : Enemy, IJump
    {
        public MonsterEnemy(PictureBox character) : base(character)
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
