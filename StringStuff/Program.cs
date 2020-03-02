using System;

namespace StringStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Read is for one character
            System.Console.Write("enter some text: ");
            String input = Console.ReadLine();

            if (input.Contains("nick")) // case sentive by defuault
            {
                System.Console.WriteLine("Input contains 'nick'");
            } else
            {
                System.Console.WriteLine(input);
            }
            
            // input.IndexOf like contains instead of returning true it returns where in the strings
            // instead of false

            Console.Write("index of '.' ");
            int index = input.IndexOf(".");
            System.Console.WriteLine(input.IndexOf("."));

            //substring is with indexof
            System.Console.WriteLine("After the first dot");
            System.Console.WriteLine(input.Substring(index + 1));
            //if -1 console.write not found

            int length = input.Length; //how many chars
            //how to find how many words in a string break it up spaces
            int words = input.Split(' ').Length;
            System.Console.WriteLine(words);

            String[] words2 = input.Split(' ');

            String stringWithoutSpcaes = input.Replace(' ', '-');
            System.Console.WriteLine(stringWithoutSpcaes);

            //ToUpper and ToLower

            String uperCase, lowerCase;
            uperCase = input.ToUpper();
            lowerCase = input.ToLower();
        }
    }
}
