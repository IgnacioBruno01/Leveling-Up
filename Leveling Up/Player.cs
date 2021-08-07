using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;

namespace Leveling_Up
{
    public class Player : Character, IColisionable
    {

        public int xpActual;
        public int xpProximoNivel = 100;
        public int gold;
        // private Location location;
        public Player(string path, Vector2f position) : base(path, position)
        {
            TextFileReader.ReadPlayerFromFile("Player/Player.txt", this);
        }

        public override void Update()
        {
            base.Update();
        }
        public override void Draw(RenderWindow window)
        {
            base.Draw(window);
        }

        private void Movement()
        {
            if (Keyboard.IsKeyPressed(Keyboard.Key.D))
            {
                currentPosition.X += speed * FrameRate.GetDeltaTime();
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.A))
            {
                currentPosition.X -= speed * FrameRate.GetDeltaTime();
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.S))
            {
                currentPosition.Y += speed * FrameRate.GetDeltaTime();
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.W))
            {
                currentPosition.Y -= speed * FrameRate.GetDeltaTime();
            }
        }
        //public Location GetLocation()
        //{
        //    return location;
        //}
        //
        //public void GoToDungeon()
        //{
        //    location = Location.Dungeon;
        //}
        //
        //public void GoToCity()
        //{
        //    location = Location.City;
        //}
        //public void GoToShop()
        //{
        //    location = Location.Shop;
        //}
        //public void GoToHome()
        //{
        //    location = Location.Home;
        //}
        public void Heal()
        {
            HP = maxHP;
        }

        public void Heal(int amount)
        {
            HP += amount;
            if (HP > maxHP)
            {
                HP = maxHP;
            }
        }

        public void RestoreMana()
        {
            mana = maxMana;
        }

        public void RestoreMana(int amount)
        {
            mana += amount;
            if (mana > maxMana)
            {
                mana = maxMana;
            }
        }
        public FloatRect GetBounds()
        {
            return sprite.GetGlobalBounds();
        }
        public bool muertePJ()
        {
            return HP <= 0;
        }
        public void OnCollision(IColisionable other)
        {
            
        }
       
        public void OnCollisionEnter(IColisionable other)
        {
            if (other is InvisibleWall)
            {
                Console.WriteLine("Player enter");
            }
        }
       
        public void OnCollisionExit(IColisionable other)
        {
            if (other is InvisibleWall)
            {
                Console.WriteLine("Player exit");
            }
        }
    }
}