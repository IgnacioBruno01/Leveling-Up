using System;
using System.Collections.Generic;
using System.Text;

namespace Leveling_Up
{
    class Shop
    {
        enum Options { GoToCity,Buy,Sell, Error}
        public Shop()
        {

        }
        public Player Buy(Player player)
        {
            return player;
        }
        public Player Sell(Player player)
        {
            return player;
        }
        public Player Stay(Player player)
        {
            bool stayInsideShop = true;
            Console.WriteLine("Welcome to the shop 'Hephaestus'! How can I help you?");
            Options option;
            do
            {
                Console.WriteLine("Buy = 0   -   Sell = 1");

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
                    case Options.GoToCity:
                        player.GoToCity();
                        stayInsideShop = false;
                        break;
                    case Options.Buy:
                        player = Buy(player);
                        
                        break;
                    case Options.Sell:
                        player = Sell(player);
                        break;
                    default:
                        break;
                }
            } while (stayInsideShop);
            return player;
        }
    }
}