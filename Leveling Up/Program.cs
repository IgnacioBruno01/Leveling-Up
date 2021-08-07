using System;

namespace Leveling_Up
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            MusicManager.GetInstance().Play();
            FrameRate.InitFrameRateSystem();
            while (game.UpdateWindow())
            {
                game.UpdateGame();
                CollisionManager.GetInstance().CheckCollisions();
                game.DrawGame();
                FrameRate.OnFrameEnd();
            }
            Console.ReadKey();
        }
    }
}
