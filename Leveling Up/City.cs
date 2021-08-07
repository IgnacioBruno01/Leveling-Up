using SFML.Graphics;
using SFML.Window;
using System;
using System.IO;

namespace Leveling_Up
{
    class City
    {
        private Sprite sprite;
        private Texture texture;
        enum Options { GoToHome, GoToDungeon, Error }

        public City(string backgroundPath, Player player)
        {
            texture = new Texture(backgroundPath);
            sprite = new Sprite(texture);

        }
        Options option;
        public Player Stay(Player player)
        {
            Options option;

            if (Keyboard.IsKeyPressed(Keyboard.Key.Up))
            {
                option = Options.GoToHome;
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Down))
            {
                option = Options.GoToDungeon;
            }
            return player;
        }
        public void Update(Player player)
        {
        }
        public void Draw(RenderWindow window)
        {
            window.Draw(sprite);
        }
    }
}