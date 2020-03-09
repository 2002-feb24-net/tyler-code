using System;
using System.Collections.Generic;

namespace WorkWithHashSet
{
    class Program
    {
        // HashSets methods I know
        // Clear
        // Add
        // SetEquals
        static void Main(string[] args)
        {
            var hash1 = new HashSet<int>();
            var hash2 = new HashSet<int>();
            var hashList = new HashSet<int>(hash1);
            

            FillHash(hash1, 1, 10);
            

            // DisplayHash(hash1);
            System.Console.WriteLine();
            DisplayHash(hash2);
            foreach(var item in hashList)
            {
                Console.Write(item + " ");
            }

            
            
        }

        static void DisplayHash(HashSet<int> HashA)
        {
            foreach(var item in HashA)
            {
                Console.Write(item + " ");
            }
        }

        static void FillHash(HashSet<int> HashB, int start, int length)
        {
            for (int a = start; a < length; a++)
            {
                HashB.Add(a);
            }
        }
    }
}

// var equal = hash2.SetEquals(hash1);

            // System.Console.WriteLine();
            // if(equal == true)
            // {
            //     System.Console.WriteLine("These two hashes are the same.");
            // }
            // else
            // {
            //     System.Console.WriteLine("These two hashes aren't the same");
            // }
