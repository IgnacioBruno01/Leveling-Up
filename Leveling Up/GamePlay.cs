using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leveling_Up
{
    class GamePlay
    {
        private Background background;
        private Player player;

        public GamePlay()
        {
            background = new Background();
            player = new Player();
        }
        public void Update()
        {
            background.Update();
            player.Update();
        }
        public void Draw(RenderWindow window)
        {
            background.Draw(window);
            player.Draw(window);
        }
    }
}
