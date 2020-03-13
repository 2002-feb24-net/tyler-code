using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public class RockPaperScissors
    {
        // Use Lists

        int wins = 0;
        int losses = 0;
        int ties = 0;
        int totalRounds = 0;

        List<String> roundsResults = new List<String>();
        List<int> winsList = new List<int>();
        List<int> losesList = new List<int>();
        List<int> tiesList = new List<int>();

        public void PlayRound()
        {
            totalRounds = roundsResults.Count;
            
            System.Console.WriteLine("Rock is 0, Paper is 1, Scissors is 2");
            Console.Write("Enter a 0, 1, 2: ");
            int userInput = int.Parse(Console.ReadLine());
            String convertUser = ConvertNum(userInput);
            System.Console.WriteLine("You chose a {0}", convertUser);

            int comMove = ComDecides();
            String convertCom = ConvertNum(comMove);
            System.Console.WriteLine("The computer chose a " + convertCom);
            WhoWins(userInput, comMove);
            System.Console.WriteLine();
        }

        public void PrintSummary()
        {
            WhoWon();
        }

        public int ComDecides()
        {
            Random rnd = new Random();
            int com = rnd.Next(0, 3);

            return com;

        }

        public string ConvertNum(int num)
        {
            string newString = "";

            switch(num)
            {
                case 0:
                newString = "Rock";
                break;
                case 1:
                newString = "Paper";
                break;
                default:
                newString = "Scissors";
                break;
            }

            return newString;

        }

        // Rock is 0
        // Paper is 1
        // Scissors is 2
        public void WhoWins(int userInput, int comMove)
        {
            if((userInput < comMove) || ((userInput == 0) && (comMove == 2)))
            {
                System.Console.WriteLine("You win!");
                roundsResults.Add("Wins");
                wins++;
                winsList.Add(wins);
            }
            else if((userInput > comMove) || (userInput == 0 ) && (comMove == 1))
            {
                System.Console.WriteLine("You lose. :(");
                roundsResults.Add("Losses");
                losses++;
                losesList.Add(losses);
            }
            else 
            {
                System.Console.WriteLine("It's a tie");
                roundsResults.Add("Tie");
                ties++;
                tiesList.Add(ties++);
            }
        }

        public void WhoWon()
        {
            if(winsList.Count > losesList.Count)
            {
                System.Console.WriteLine("You beat the computer!");
            }
            else if(winsList.Count == losesList.Count)
            {
                System.Console.WriteLine("You and the computer rivaled each other");
            }
            else 
            {
                System.Console.WriteLine("The computer beat you");
            }
        }

        public void PrintListCount() 
        {
            System.Console.WriteLine("You won {0} times.", winsList.Count);
            System.Console.WriteLine("You lost {0} times", losesList.Count);
            System.Console.WriteLine("You two tied {0}", tiesList.Count);
        }
    }
}