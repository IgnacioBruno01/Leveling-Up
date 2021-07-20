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
        private Dungeon dungeon;
        private Shop shop;

        public GamePlay()
        {
            background = new Background();
            player = new Player(TextFileReader.ReadPlayerFromFile("Player/Player"));
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
