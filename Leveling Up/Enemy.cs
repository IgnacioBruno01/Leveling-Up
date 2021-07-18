using System;
using System.Collections.Generic;
using System.Text;

namespace Leveling_Up
{
    public abstract class Enemy : GameObjectBase
    {
        protected string name;
        protected int level;
        protected int maxHP;
        protected int HP;
        protected int maxMana;
        protected int mana;
        protected int speed;
        protected int ataque;
        protected int ataquemagico;
        protected int defensa;
        protected int defensaMagica;
        protected int xpDropeada;
        protected string botin;
        public bool muerteEnemy;
        public Enemy("Monstruos/Sprites", new Vector2f(0.0f, 0.0f))
        {

        }
    }

    public sealed class Goblin : Enemy
    {
        public Goblin(string name, int level, int maxHP, int HP, int maxMana, int mana, int speed, int ataque, int ataquemagico,
            int defensa, int defensaMagica, int xpDropeada, string botin) : base(name, level, maxHP, HP, maxMana, mana, speed, ataque, ataquemagico, defensa, defensaMagica, xpDropeada, botin)
        {

        }
    }
}
