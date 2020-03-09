using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Counter for win
            // Losses
            // Ties
            // Who won
            RockPaperScissors game1 = new RockPaperScissors();

            bool readyToQuit = false;

            while(!readyToQuit)
            {
                System.Console.Write("Do you want to play another round? ");
                String input = Console.ReadLine();
                System.Console.WriteLine();

                if(input == "n")
                {
                    readyToQuit = true;
                }
                else
                {
                    game1.PlayRound();
                    // That method should play a round and print the result
                }
            }

            game1.PrintSummary();
            game1.PrintListCount();
            // That method should print out a summary of the rounds
            // How many wins , how many losses
        }
    }
}
