using System;

namespace Leveling_Up
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Console.WriteLine("GameUpdate");
            while (game.UpdateWindow())
            {
                game.UpdateGame();
                game.DrawGame();
            }
            Console.ReadKey();
        }
    }
}
