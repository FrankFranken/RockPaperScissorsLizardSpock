using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    class AI : Player
    {
        public override int Pick()
        {
            Random rnd = new Random();
            int PickPlayer = rnd.Next(1, 6);
            if(PickPlayer == 1)
            {
                chooseOption = 0;
                Console.WriteLine("AI Choose Rock");
                return chooseOption;
            }

            else if (PickPlayer == 2)
            {
                chooseOption = 1;
                Console.WriteLine("AI Choose Paper");
                return chooseOption;
            }
            else if (PickPlayer == 3)
            {
                chooseOption = 2;
                Console.WriteLine("AI Choose Scissors");
                return chooseOption;
            }
            else if (PickPlayer == 4)
            {
                chooseOption = 3;
                Console.WriteLine("AI Choose Lizard");
                return chooseOption;
            }
            else if (PickPlayer == 5)
            {
                chooseOption = 4;
                Console.WriteLine("AI Choose Spock");
                return chooseOption;
            }
            return chooseOption;
        }
    }
}
