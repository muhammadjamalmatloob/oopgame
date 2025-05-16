using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Game.Backend.GameObjects
{
    public class MissileEnemy : Enemy
    {
        public MissileEnemy() { }
        public MissileEnemy(PictureBox character) : base(character)
        {

        }

        public void MoveMissile(PictureBox missile,Random rnd)
        {
            missile.Top = -100;
            missile.Left = rnd.Next(180,527);
            MoveDown(missile);
        }
    }
}
