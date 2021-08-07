using SFML.Graphics;
using SFML.System;
using System.IO;

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
        private TileMap collisiones;
        private Title title;
        private Stage stage;
   
        Vector2f inicialPlayerPosition = new Vector2f(0.0f, 0.0f);

        public GamePlay()
        {
            title = new Title("",new SFML.System.Vector2f(100.0f, 100.0f));
            home = new Home("Background" + Path.DirectorySeparatorChar + "casa piso 1.png");
            player = new Player("", inicialPlayerPosition);
            city = new City("Background" + Path.DirectorySeparatorChar + "city", player);
            collisiones = new TileMap("Tilemap" + Path.DirectorySeparatorChar + "tileset.png", "Tilemap" + Path.DirectorySeparatorChar + "tilemap.csv", 32, 32, 4, new SFML.System.Vector2f(2.0f, 2.0f));
        }
        public void Update()
        {
            switch (currentLocation)
            {
                case Location.City:
                    city.Update(player);
                    city.Stay(player);
                    break;
                case Location.Dungeon:
                    dungeon.Update(stage);
                    break;
                case Location.Home:
                    home.Update(player);
                    home.Stay(player);
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
                    city.Draw(window);
                    break;
                case Location.Dungeon:
                    break;
                case Location.Home:
                    home.Draw(window);
                    break;
                default:
                    break;
            }
            collisiones.Draw(window);
        }
    }
}