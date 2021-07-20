using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leveling_Up
{
    public abstract class Character : GameObjectBase
    {
        public Character(string path, Vector2f position, string type, string name, int level, int maxHP, int HP, int maxMana, int mana,
            int speed, int ataque, int ataquemagico, int defensa, int defensaMagica) : base(path, position,type,name,level,maxHP,HP,maxMana,mana,speed,ataque,ataquemagico,defensa,defensaMagica)
        {
            texture = new Texture(path);
            sprite = new Sprite(texture);
            currentPosition = position;
            sprite.Position = currentPosition;
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
        }
    }
}
