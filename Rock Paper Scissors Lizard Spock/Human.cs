using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    class Human : Player
    {
        public override int Pick()
        {
            
            Console.WriteLine("r-Rock, p-Paper, s-Scissors, l-Lizard, sp-Spock");
            string PickPlayer = (Console.ReadLine());
            if (PickPlayer == "r")
            {
                chooseOption = 0;
                Console.WriteLine("You Choose Rock");
                return chooseOption;
            }

            else if (PickPlayer == "p")
            {
                chooseOption = 1;
                Console.WriteLine("You Choose Paper");
                return chooseOption;
            }
            else if (PickPlayer == "s")
            {
                chooseOption = 2;
                Console.WriteLine("You Choose Scissors");
                return chooseOption;
            }
            else if (PickPlayer == "l")
            {
                chooseOption = 3;
                Console.WriteLine("You Choose Lizard");
                return chooseOption;
            }
            else if (PickPlayer == "sp")
            {
                chooseOption = 4;
                Console.WriteLine("You Choose Spock");
                return chooseOption;
            }
            else
            {
                Console.WriteLine("Make A Valid Selection");
                Pick();
                return chooseOption;
            }
        }
    }
}
