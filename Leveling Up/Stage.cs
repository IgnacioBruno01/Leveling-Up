using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leveling_Up
{
    class Stage
    {
        private List<Enemy> Enemies;
        private List<Enemy> Boss;
        private Texture texture;
        private Sprite sprite;
        private TileMap tileMapCollisionable;

        public Stage(int maxEnemeiesInFloor, string backgroundPath)
        {
            texture = new Texture(backgroundPath);
            sprite = new Sprite(texture);
            tileMapCollisionable = new TileMap();
            Enemies = new List<Enemy>();
            Random random = new Random();
            int enemiesInFloor = random.Next(1, maxEnemeiesInFloor);
            for (int i = 0; i < enemiesInFloor; i++)
            {
                //Enemies.Add(new Enemy());
            }
        }
        public void Update(Player player)
        {

        }
    }
}
