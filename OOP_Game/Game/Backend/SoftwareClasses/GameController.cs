using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Game.Backend.GameObjects;

namespace Game.Backend.SoftwareClasses
{
    public class GameController
    {
        

        public static (bool fire, bool left, bool right) Enemy1Decider(TankEnemy enemy, Player player)
        {
            Random random = new Random();
            int n = random.Next(0, 10);
            if (enemy.X - player.X > 100)
            {
                enemy.moveleft = 0;
            }
            if (enemy.X < 829)
            {
                enemy.moveright = 0;
            }
            if (n == 0 && enemy.moveright == 0)
            {
                return (false, true, false);
            }
            else if (n < 4 && (enemy.X - player.X > 100) && enemy.moveright == 0)
            {
                return (true, true, false);
            }
            else if (n < 6 && enemy.X < 829 && enemy.moveleft == 0)
            {
                return (false, false, true);
            }
            else if (n == 6 && enemy.X < 829 && enemy.moveleft == 0)
            {
                return (true, false, true);
            }
            else
            {
                return (true, false, false);
            }
        }

    }
}
