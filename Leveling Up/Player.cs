using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Leveling_Up
{
    public class Player : GameObjectBase
    {
        public int xpActual;
        public int xpProximoNivel;
        private bool muertePJ;
        public Player() : base("Player/Sprites", new Vector2f(0.0f, 0.0f),name)
        {
            this.name = lines[0];


        }


        public override void Update()
        {


            base.Update();
        }
        public override void Draw(RenderWindow window)
        {
            base.Draw(window);
        }
    }
}
