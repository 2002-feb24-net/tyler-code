using System;

namespace ConverterA
{
    class Program
    {
        static void Main(string[] args)
        {
            Prompt();
            String mainA = Getinfo();
            // System.Console.WriteLine(mainA);
            Convert(mainA);
        }

        static void Prompt()
        {
            System.Console.WriteLine("This is a program that will ask you you for a multi-word term.");
            System.Console.WriteLine("Ex. Central Proccessing Unit or Away from Keyboard");
            System.Console.WriteLine("Then it will convert it to it's  Acroymn");
            System.Console.WriteLine();
        }

        static String Getinfo() {
            Console.Write("Enter a multi-term word: ");
            String userInput = Console.ReadLine();

            return userInput;
        }

        static void Convert(String mainA) 
        {
            String sub = "";

            String[] words = mainA.Split(' ');
            foreach (String word in words)
            {
                int start = 0;
                sub = word.Substring(start, 1);
                Console.Write(sub.ToUpper());
            }
            
        }
    }
}
