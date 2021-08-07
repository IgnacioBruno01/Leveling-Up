using SFML.Graphics;
using SFML.Window;
using System;

namespace Leveling_Up
{
    class Home
    {
        private Texture texture;
        private Sprite sprite;
        enum Options { HealerPlayer, GoToCity }

        public Home(string backgroundPath)
        {
            texture = new Texture(backgroundPath);
            sprite = new Sprite(texture);
        }

        public Player HealerPlayer(Player player)
        {
            player.Heal();
            player.RestoreMana();
            return player;
        }
        public Player Stay(Player player)
        {
            Options option;

            if (Keyboard.IsKeyPressed(Keyboard.Key.Up))
            {
                if (Keyboard.IsKeyPressed(Keyboard.Key.Enter))
                {
                    option = Options.HealerPlayer;
                }
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Down))
            {
                if (Keyboard.IsKeyPressed(Keyboard.Key.Enter))
                {
                    option = Options.GoToCity;
                }

            }

            //switch (option)
            //{
            //    case Options.HealerPlayer:
            //        if (Keyboard.IsKeyPressed(Keyboard.Key.Up))
            //        {
            //            if (Keyboard.IsKeyPressed(Keyboard.Key.Enter))
            //            {
            //                player = HealerPlayer(player);
            //            }
            //        }
            //
            //        break;
            //    case Options.GoToCity:
            //        if (Keyboard.IsKeyPressed(Keyboard.Key.Down))
            //        {
            //            if (Keyboard.IsKeyPressed(Keyboard.Key.Enter))
            //            {
            //                player.GoToCity();
            //            }
            //        }
            //        break;
            //    default:
            //        break;
            //}
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