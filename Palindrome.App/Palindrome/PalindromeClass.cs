using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome
{
    public class PalindromeClass : IIsPalindrome
    {

        public static string Word1 { get; set; }
        public string Word2 { get; set; }
        public bool isSame { get; set; }
        public char[] letter { get; set; } = new char[Word1.Length];

        public PalindromeClass(string Word1)
        {

        }

        public void BackWord()
        {
            Console.WriteLine("Word foward: ");
            letter = Word1.ToCharArray();
            Word2 = String.Empty;
            for(int i = letter.Length - 1; i > -1; --i)
            {
                Word2  += letter[i];
            }

            Console.WriteLine(Word2);
        }

        public bool IsPalindrome()
        {
            if(Word1 == Word2)
            {
                isSame = true;
            }
            else
            {
                isSame = false;
            }

            return isSame;
        }
    }
}
