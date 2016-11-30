using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    class Game
    {
        public Player player1;
        public Player player2;

        public void StartGame()
        {
            ShowName();
            ShowRules();
            PlayerChoice();
            RunGame();
            PlayAgain();
        }

        public void RestartGame()
        {
            RunGame();
            PlayAgain();
        }
        private void RunGame()
        {
            int player1points = 0;
            int player2points = 0;
            bool X = true;
            while (X == true)
            {
                    int checker = 0;
                    Console.WriteLine("player1 turn");
                    int p1 = player1.Pick();
                    Console.Clear();
                    Console.WriteLine("player2 turn");
                    int p2 = player2.Pick();                  
                    checker = (5 + p1 - p2) % 5;

                    if (checker == 1 || checker == 3)
                    {
                        Console.WriteLine("player1 wins");
                        player1points = player1points + 1;

                    }
                    else if (checker == 2 || checker == 4)
                    {
                    Console.WriteLine("player2 wins");
                    player2points = player2points + 1;
                    }
                    else if (checker == 0)
                    {
                        Console.WriteLine("It's a Tie!!");
                    }
                    if (player1points == 2)
                    {
                    Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>PLAYER ONE WINS!!!!<<<<<<<<<<<<<<<<<<<<<<<<<");
                    X = false;
                    }
                    else if (player2points == 2)
                   {
                    Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>PLAYER TWO WINS!!!!<<<<<<<<<<<<<<<<<<<<<<<<<");
                    X = false;
                }
            }
           
        }

        public void PlayAgain()
        {
            
            Console.WriteLine("would you like to play again?");
            Console.WriteLine("yes or no");
            string finishgame = Console.ReadLine();
            if (finishgame == "yes")
            {
                Console.WriteLine("Restarting Game");
                RestartGame();
            }
            else if (finishgame == "no") 
            {
                Console.WriteLine("Thanks for playing...Goodbye");
                Console.WriteLine("<press any key to exit>");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please choose yes or no");
                PlayAgain();
            }
        }
        private void ShowName()
        {
            Console.WriteLine("Rock Paper Scissors Lizard Spock");
        }
        private void ShowRules()
        {
            Console.WriteLine("Game is best out of three");
            Console.WriteLine("Rock crushes Scissors \nRock crushes Lizard \nPaper covers Rock \nPaper disproves Spock");
            Console.WriteLine("Scissors cuts Paper \nScissors decapitates Lizard \nLizard eats Paper");
            Console.WriteLine("Lizard poisons Spock \nSpock vaporizes Rock \nSpock smashes Scissors");
        }
        private void PlayerChoice()
        { 
            Console.WriteLine("Choose 1 or 2 Players");
            string PickPlayer = (Console.ReadLine());
            if(PickPlayer == "1") 
            {
                player1 = new Human();
                player2 = new AI();
                Console.WriteLine("You vs AI");
            }

            else if(PickPlayer == "2")
            {
                player1 = new Human();
                player2 = new Human();
                Console.WriteLine("Head to Head");
            }
            else
            {
                Console.WriteLine("Please choose 1 or 2 players");
                PlayerChoice();                
            }
        }
    }
}