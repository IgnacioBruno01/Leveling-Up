using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Leveling_Up
{
    public class Player : Character
    {
        public string type;
        public int xpActual;
        public int xpProximoNivel;
        public int gold;
        private Location location;
        public Player(string path, Vector2f position, string type, string name, int level, int maxHP, int HP, int maxMana, int mana,
            int speed, int ataque, int ataquemagico, int defensa, int defensaMagica, int xpActual, int xpProximoNivel, int gold) : base(path, position, type, name, level, maxHP, HP, maxMana, mana,
            speed, ataque, ataquemagico, defensa, defensaMagica)
        {
            texture = new Texture("Player/Sprites");
            sprite = new Sprite(texture);
            currentPosition = position;
            this.type = type;
            this.name = name;
            this.level = level;
            this.maxHP = maxHP;
            this.HP = HP;
            this.maxMana = maxMana;
            this.mana = mana;
            this.speed = speed;
            this.ataque = ataque;
            this.ataquemagico = ataquemagico;
            this.defensa = defensa;
            this.defensaMagica = defensaMagica;
            this.xpActual = xpActual;
            this.xpProximoNivel = xpProximoNivel;
            this.gold = gold;
        }


        public override void Update()
        {


            base.Update();
        }
        public override void Draw(RenderWindow window)
        {
            base.Draw(window);
        }
        public Location GetLocation()
        {
            return location;
        }

        public void GoToDungeon()
        {
            location = Location.Dungeon;
        }

        public void GoToCity()
        {
            location = Location.City;
        }
        public void GoToShop()
        {
            location = Location.Shop;
        }
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
        public bool muertePJ()
        {
            return HP <= 0;
        }
    }
}
