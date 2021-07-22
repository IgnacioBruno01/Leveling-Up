using System;
using System.Collections.Generic;
using System.Text;

namespace Leveling_Up
{
    class City
    {
        enum Options { GoToHome, GoToDungeon, GoToShop, Error}

        public Player Stay(Player player)
        {
            bool stayCity = true;
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
                    case Options.GoToHome:
                        player.GoToHome();
                        break;
                    case Options.GoToDungeon:
                        player.GoToDungeon();
                        break;
                    case Options.GoToShop:
                        player.GoToShop();
                        stayCity = false;
                        break;
                    default:
                        break;
                }
            } while (stayCity);
            return player;
        }
    }
}