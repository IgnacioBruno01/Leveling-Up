using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leveling_Up
{
    class Background
    {
        public Texture texture;
        public Sprite sprite;
        public Background(string backgroundPath)
        {
            texture = new Texture(backgroundPath);
            sprite = new Sprite(texture);
        }

        public void Draw(RenderWindow window)
        {
            window.Draw(sprite);
        }
    }
}