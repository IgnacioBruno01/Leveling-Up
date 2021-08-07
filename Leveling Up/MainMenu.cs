using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leveling_Up
{
    class MainMenu
    {
        private Title GameName;
        private Title text;

        public bool exitMenu;

        public MainMenu()
        {
            GameName = new Title("Welcome to the Levelin Up!", new SFML.System.Vector2f(100.0f, 100.0f));
            text = new Title("PRESS 'ENTER' TO CONTINUE", new SFML.System.Vector2f(100.0F, 500.0F));
            exitMenu = false;
        }

        public void Update()
        {
            if (Keyboard.IsKeyPressed(Keyboard.Key.Enter))
            {
                exitMenu = true;
            }
        }

        public void Draw(RenderWindow window)
        {
            GameName.Draw(window);
            text.Draw(window);
        }
    }
}