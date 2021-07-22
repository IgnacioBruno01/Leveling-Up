using System;
using System.Collections.Generic;
using System.Text;

namespace Leveling_Up
{
    class Home
    {
        enum Options { HealerPlayer, GoToCity, Error }
        public Player HealerPlayer(Player player)
        {
            player.Heal();
            player.RestoreMana();
            return player;
        }
        public Player Stay(Player player)
        {
            bool stayInsideHome = true;
            Console.WriteLine("Welcome!");
            Options option;
            do
            {
                Console.WriteLine("Rest = 0   -   Leave = 1");

                int input = Convert.ToInt32(Console.ReadLine());

                if (input >= 0 && input < (int)Options.Error)
                {
                    option = (Options)input;
                }
                else
                {
                    option = Options.Error;
                }

                switch (option)
                {
                    case Options.HealerPlayer:
                        player = HealerPlayer(player);
                        break;
                    case Options.GoToCity:
                        player.GoToCity();
                        stayInsideHome = false;
                        break;
                    default:
                        break;
                }
            } while (stayInsideHome);
            return player;
        }

    }
}