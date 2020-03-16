using System;
using System.Collections.Generic;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string palindrome = "apple";
            
            _ = new char[palindrome.Length];
            char[] letter = palindrome.ToCharArray();

            PrintWordForward(palindrome, letter);
            Console.WriteLine();
            string newString = BackwardWord(palindrome, letter);
            Console.WriteLine();
            bool theSame = IsSame(palindrome, newString);

            Console.WriteLine();
            Console.WriteLine(theSame);
            Console.WriteLine();
            string newWord = ChangeWord(newString, theSame);
            Console.WriteLine(newWord);
        }

        public static void PrintWordForward(string word, char[] charString)
        {
            Console.WriteLine("Word foward: ");
            for(int i = 0; i < word.Length; i++)
            {
                Console.Write(charString[i]);
            }
            Console.WriteLine();
        }

        public static string BackwardWord(string word, char[] charString)
        {
            Console.WriteLine("Word backward: ");
            for (int i = word.Length - 1; i >= 0; i--)

            {
                Console.Write(charString[i]);
            }

            string backwardString = new string(charString);

            return backwardString;
        }

        static bool IsSame(string string1, string string2)
        {
            bool same;
            if (string1 == string2)
            {
                same = true;
            }
            else
            {
                same = false;
            }

            return same;
        }

        static string ChangeWord(string string2, bool same2)
        {
            int i = 0;

            while(false)
            {

            }
        }
    }
}