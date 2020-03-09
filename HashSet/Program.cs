using System;
using System.Collections.Generic;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use a hashset when you don't want duplicates and better comparison
            HashSet<string> bagOfStrings = new HashSet<string>{ "Jacob", "Abraham"};
            bagOfStrings.Add("Paul");
            bagOfStrings.Add("paul");
            bagOfStrings.Add("tyler");

            System.Console.WriteLine(bagOfStrings.Count);

            bool isPaul = bagOfStrings.Contains("Paul");
            System.Console.WriteLine(isPaul);

            bagOfStrings.Remove("Paul");
            // Retruns false if doesn't do anything
            // Can't make a subString
            bagOfStrings.UnionWith(new String[]{ "Hello", "bye"}); // Adding a array to a HashSet


        }

        public void FirstDuplicate()
        {
            for(int i = 0; i < 10; i++)
            {

                // Put this element in the set
                // but if it was already in there
                // return teh current index
                // Use the contains method


            }
        }
    }
}
