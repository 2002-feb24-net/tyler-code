using System;
using System.Collections.Generic;

namespace PersonList
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListofPeople = new List<dynamic>();
            bool mainDuplicate = false;

            var person1 = new Person("Tyler", 23);
            var person2 = new Person("Tristan", 23);
            var person3 = new Person("Mary", 33);
            var person4 = new Person("John", 42);
            var person5 = new Person("Lucas", 11);

            ListofPeople.Add(person1);
            ListofPeople.Add(person2);
            ListofPeople.Add(person3);
            ListofPeople.Add(person4);
            ListofPeople.Add(person5);

            System.Console.WriteLine("Here is a list of people");
            

            mainDuplicate = CheckDuplicate(ListofPeople);

            // if(mainDuplicate == true)
            // {
            //     Console.WriteLine("This list has a duplicate");
            // }
            // else
            // {
            //     System.Console.WriteLine("This list does not has duplicate");
            // }
        }

        static bool CheckDuplicate(List<dynamic> ListofPeople)
        {
            bool hasDuplicate = false;
            int a = 0;

            for (a = 0; a < ListofPeople.Count; a++)
            {
                if(ListofPeople[a].Contains(ListofPeople[a]))
                {
                    hasDuplicate = true;
                }
            }

            return hasDuplicate;
        }

        // BubbleSort algorthim because the bubble sorting algorthim looks at the first 2
        // of the array, list, whatever have you. if the firs one is greater than the 2nd it swaps the two. Then moves on the elment
        // And begins the cycle until. If it get through an an etire array without swapping then it stops.

        // The inssertion sorting algorthim considers the frist elments and looks at the second element, if the first one is greater
        // It will insert the 2nd element into the 1st index, and put them into a sub array for the sorted elements

        // The difference the Bubblesorting algorthim it will look at the entire array once even if it's already sorted, the Iinsertion
        // The insertion algorthim doesn't loop through array if it's already sorted.

        // The insertion sorting algorthim is faser

        static List<dynamic> insertSort(List<dynamic> ListofPeople)
        {
            int a = 0;
            int b = 0;

            for (a = 0; a < ListofPeople.Count; a++)
            {
                for (b = a + 1; b < 0; b--)
                {
                    Swap(ListofPeople, b);
                }
            }

            return ListofPeople;
        }

        static List<dynamic> InsertByShift(List<dynamic> ListofPeople)
        {
            inti
        }

        static void Swap(List<dynamic> ListofPeople, int b)
        {
            int temp = ListofPeople[b - 1];
            ListofPeople[b -1] = ListofPeople[b];
            ListofPeople[b] = temp;
        }

        static void DisplayList(List<dynamic> ListA)
        {
            foreach (var item in ListA)
            {
                Console.Write(item + " ");
            }
        }
    }
}
