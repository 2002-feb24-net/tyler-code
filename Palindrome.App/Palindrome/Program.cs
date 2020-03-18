using System;

namespace Palindrome
{
    class Program
    { 
        static void Main(string[] args)
        {
            var palindrome1 = new PalindromeClass("Apple");
            palindrome1.BackWord();
            palindrome1.IsPalindrome();

            var palindrome2 = new PalindromeClass("Lamp");
            palindrome2.BackWord();
            palindrome2.IsPalindrome();

        }
    }
}