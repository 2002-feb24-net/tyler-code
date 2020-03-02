using System;

namespace SubstringEx
{
    class Program
    {

        // Given a string and a number
        // Print all the substring of that length
        // Must have at least 2 methods including the main method
        // ex "abcd" 2 "ab" "bc" "cd
        static void Main(string[] args)
        {
            Prompt();
            GetInfo();
        }

        static void Prompt() {
            System.Console.WriteLine("String Spliter");
            System.Console.WriteLine("---------------");
            System.Console.WriteLine();
            System.Console.WriteLine("This is an application that will ask you for a word and number");
            System.Console.WriteLine("Then it will take the word and split into letters using the number that you entered");
            System.Console.WriteLine();
        }

        static void GetInfo() {
            int userNum = 0;
            int start = 0;
            String sub = "";

            Console.Write("Please enter a word: ");
            String userIn = Console.ReadLine();
            System.Console.WriteLine();
            System.Console.Write("Please enter a number: ");
            String stringNum = Console.ReadLine();
            userNum = Int32.Parse(stringNum);
            System.Console.WriteLine();

            for (int a = 1; a < userIn.Length; a++)
            {
                sub = userIn.Substring(start, userNum);
                System.Console.WriteLine(sub);
                start++;
            }
        }
    }
}
