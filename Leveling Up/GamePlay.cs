using SFML.Graphics;
using SFML.System;
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
        Vector2f inicialPlayerPosition = new Vector2f(0.0f, 0.0f);

        public GamePlay()
        {
            background = new Background();
            player = new Player("Player/Sprites/Sprite Player.png", inicialPlayerPosition);
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