using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leveling_Up
{
    class Game
    {
        private RenderWindow window;
        private GamePlay gameplay;
        public Game()
        {
            VideoMode videomode = new VideoMode();
            videomode.Height = 1000;
            videomode.Width = 1800;

            window = new RenderWindow(videomode, "Leveling Up");
            window.Closed += CloseWindow;
            window.SetFramerateLimit(FrameRate.FRAMERATE_LIMIT);

            gameplay = new GamePlay();
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            window.Close();
        }
        public bool UpdateWindow()
        {
            window.DispatchEvents();
            window.Clear(Color.Black);
            return window.IsOpen;
        }
        public void UpdateGame()
        {
            gameplay.Update();
        }
        public void DrawGame()
        {
            gameplay.Draw(window);
            window.Display();
        }
    }
}