using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leveling_Up
{
    public abstract class Character : GameObjectBase
    {
        public string name;
        public int level;
        public int maxHP;
        public int HP;
        public int maxMana;
        public int mana;
        public int speed;
        public int ataque;
        public int ataquemagico;
        public int defensa;
        public int defensaMagica;
        public Character(string path, Vector2f position) : base(path, position)
        {
         
        }
    }
}