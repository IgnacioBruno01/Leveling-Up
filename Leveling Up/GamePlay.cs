using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leveling_Up
{
    class GamePlay
    {
        public enum Location { City, Dungeon, Home };
        private Location currentLocation;
        private Background background;
        private Player player;
        private Dungeon dungeon;
        private Home home;
        private City city;
        Vector2f inicialPlayerPosition = new Vector2f(0.0f, 0.0f);

        public GamePlay()
        {
            home = new Home();
            player = new Player("Player/Sprites/Sprite Player.png", inicialPlayerPosition);
        }
        public void Update()
        {
            switch (currentLocation)
            {
                case Location.City:
                    break;
                case Location.Dungeon:
                    break;
                case Location.Home:
                    home.Update(player);
                    break;
                default:
                    break;
            }
        }
        public void Draw(RenderWindow window)
        {
            switch (currentLocation)
            {
                case Location.City:
                    break;
                case Location.Dungeon:
                    break;
                case Location.Home:
                    home.Draw();
                    break;
                default:
                    break;
            }
        }
    }
}