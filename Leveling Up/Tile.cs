using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leveling_Up
{
    class Tile
    {
        private Sprite sprite;
        public Tile(Texture texture, Vector2f position, Vector2f scale)
        {
            sprite = new Sprite(texture);
            sprite.Position = new Vector2f (position.X * scale.X, position.Y * scale.Y);
            sprite.Scale = scale;
        }
        public void Draw(RenderWindow window)
        {
            window.Draw(sprite);
        }
    }
}
