using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leveling_Up
{
    public abstract class GameObjectBase
    {
        protected Texture texture;
        protected Sprite sprite;
        protected Vector2f currentPosition;
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

        public GameObjectBase(string texturePath, Vector2f startPosition, string type, string name, int level, int maxHP, int HP, int maxMana, int mana, int speed, int ataque, int ataquemagico, int defensa, int defensaMagica)
        {
            texture = new Texture(texturePath);
            sprite = new Sprite(texture);
            currentPosition = startPosition;
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
        public virtual void Update()
        {
            sprite.Position = currentPosition;
        }
        public virtual void Draw(RenderWindow window)
        {
            window.Draw(sprite);
        }
        public void Dispose()
        {
            sprite.Dispose();
            texture.Dispose();
        }
    }
}