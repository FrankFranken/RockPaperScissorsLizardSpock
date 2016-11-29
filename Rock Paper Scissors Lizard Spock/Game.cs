using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    class Game
    {
        public void StartGame()
        { 
            Console.WriteLine("Rock Paper Scissors Lizard Spock");
            Console.WriteLine("Press enter to continue");
            string enter = Console.ReadLine();

            Console.WriteLine("Choose 1player or 2player");
            string playerchoice = Console.ReadLine();
          
            switch (playerchoice)
            {
                case "1player":
                Console.WriteLine("1player vs Computer, best out of three Get Ready");
                    break;

                case "2player":
                Console.WriteLine("1player vs 2player, best out of three Get Ready");
                    break;

            default:
                    Console.WriteLine("Make a valid selection 1player or 2player");
                    break;
            }
        }
    }
}
