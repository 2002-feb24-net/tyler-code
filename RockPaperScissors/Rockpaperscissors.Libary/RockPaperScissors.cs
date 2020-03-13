using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.App
{
    public class RockPaperScissorsClass : InputOutput
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

        public void Output()
        {
            Console.WriteLine();
        }

        public void Output(string s)
        {
            Console.Write(s);
        }

        public void Output(string a, string b)
        {
            Console.Write(a, b);
        }

        public void Output(string a, int b)
        {
            Console.Write(a, b);
        }

        public string Input()
        {
            return Console.ReadLine();
        }

        public void PlayRound()
        {
            totalRounds = roundsResults.Count;

            Output("Rock is 0, Paper is 1, Scissors is 2");
            Output("Enter a 0, 1, 2: ");
            int userInput = int.Parse(Input());
            String convertUser = ConvertNum(userInput);
            Output("You chose a {0}", convertUser);

            int comMove = ComDecides();
            String convertCom = ConvertNum(comMove);
            Output("The computer chose a " + convertCom);
            WhoWins(userInput, comMove);
            Output();
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

            switch (num)
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
            if ((userInput < comMove) || ((userInput == 0) && (comMove == 2)))
            {
                Output("You win!");
                roundsResults.Add("Wins");
                wins++;
                winsList.Add(wins);
            }
            else if ((userInput > comMove) || (userInput == 0) && (comMove == 1))
            {
                Output("You lose. :(");
                roundsResults.Add("Losses");
                losses++;
                losesList.Add(losses);
            }
            else
            {
                Output("It's a tie");
                roundsResults.Add("Tie");
                ties++;
                tiesList.Add(ties++);
            }
        }

        public void WhoWon()
        {
            if (winsList.Count > losesList.Count)
            {
                Output("You beat the computer!");
            }
            else if (winsList.Count == losesList.Count)
            {
                Output("You and the computer rivaled each other");
            }
            else
            {
                Output("The computer beat you");
            }
        }

        public void PrintListCount()
        {
            Output("You won {0} times.", winsList.Count);
            Output("You lost {0} times", losesList.Count);
            Output("You two tied {0}", tiesList.Count);
        }
    }
}
