using System;

namespace Palindrome
{
    class Program : IIsPalindrome
    {
        static void Main(string[] args)
        {
            string palindrome = "apple";
            bool theSame = true;

            
            _ = new char[palindrome.Length];
            char[] letter = palindrome.ToCharArray();

            PrintWordForward(palindrome, letter);
            Console.WriteLine();
            string newString = BackwardWord(palindrome, letter);
            Console.WriteLine();
            //bool theSame = IsPalindrome(palindrome, newString);

            Console.WriteLine();
            Console.WriteLine(theSame);
            Console.WriteLine();
            string newWord = ChangeWord(newString, palindrome, theSame);
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

        static string ChangeWord(string string2, string string1, bool same2)
        {
            //int count = 0;

            string combineString = string1 + string2;

            return combineString;
        }

        public bool IsPalindrome(string string1, string string2)
        {
            bool same = true; ;
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

    }
}