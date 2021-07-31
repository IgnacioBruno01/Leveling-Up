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
          
            Console.WriteLine("Home sweet home!");
            Options option;
            
                Console.WriteLine("Rest = 0   -   Leave = 1");

                

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
                    
                        break;
                    default:
                        break;
                }
            return player;
        }

        public void Update(Player player)
        {

        }
        public void Draw()
        {

        }

    }
}