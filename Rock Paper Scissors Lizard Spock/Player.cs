using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    public class Player
    {

        public int chooseOption;
        public int playerScore;
        

        public virtual int Pick()
        {
            return chooseOption;
        }
    }
}


