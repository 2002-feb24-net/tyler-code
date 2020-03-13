using System;
using RockPaperScissors.App;

namespace RockPaperScissors
{
    class Program : InputOut
    {
        static void Main(string[] args)
        {
            // Counter for win
            // Losses
            // Ties
            // Who won
            var game1 = new RockPaperScissorsClass();
            var InOut = new InputOut();

            bool readyToQuit = false;

            while (!readyToQuit)
            {
                Output("Do you want to play another round? ");
                String input = Console.ReadLine();
                System.Console.WriteLine();

                if (input == "n")
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
