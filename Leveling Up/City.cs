using System;
using System.Collections.Generic;
using System.Text;

namespace Leveling_Up
{
    class City
    {
        enum Options { GoToHome, GoToDungeon, Error}

        public Player Stay(Player player)
        {
        
            Console.WriteLine("Welcome!");
            Options option;

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
                    default:
                        break;
                }
            return player;
        }
    }
}