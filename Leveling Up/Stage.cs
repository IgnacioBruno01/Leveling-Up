using System;
using System.Collections.Generic;
using System.Text;

namespace Leveling_Up
{
    class Stage
    {
        public List<Enemy> Enemies;
        public List<Enemy> Boss;

        public Stage(int maxEnemeiesInFloor)
        {
            Enemies = new List<Enemy>();
            Random random = new Random();
            int enemiesInFloor = random.Next(1, maxEnemeiesInFloor);
            for (int i = 0; i < enemiesInFloor; i++)
            {
                //Enemies.Add(new Enemy());
            }
        }
        public Stage()
        {

        }
    }
}
