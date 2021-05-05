using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRogue
{
    public class Combat
    {
        bool isAlive = true;
        int playeyHP = 50;
        int dmgGiven = 25;
        int newHP;

        public int DMGPlayer()
        {
            return newHP = playeyHP - dmgGiven;
        }

        public bool PlayerDied()
        {
            if (newHP == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
