using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Like arrays, each Lists instance can contain
            //  Just one pirticualr types of data, which you can chose when you create the list

            // Unlike arrays , Lists can grow and shrink in size

            List<int> numbers = new List<int>();
            numbers.Add(123);
            // Empty by default
            int length = numbers.Count;
            // now numbers.Count = 1
            int firstItem = numbers[0];
            // int thirdItem = numbers[2]; // will get an error
            numbers.Insert(0, 1000);
            // Now 5 is at 5
            // List has . contains to check membership in the list
            // List ahs index o

        }
    }
}
