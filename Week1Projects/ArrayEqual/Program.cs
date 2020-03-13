using System;
using System.Collections.Generic;

namespace ArrayEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<int>();
            var list2 = new List<int>();
            var list3= new List<int>();
            var list4 = new List<int>();
            var listOfList = new List<dynamic>();
            var rand = new Random();

            listOfList.Add(list1);
            listOfList.Add(list2);
            listOfList.Add(list3);
            listOfList.Add(list4);

            FillList(rand, list1);
            FillList(rand, list2);
            FillList(rand, list3);
            FillList(rand, list4);
            
            int amountOfLists = 4;
            for (int i = 0; i < amountOfLists; i++)
            {
                listOfList.Add(new List<int>());
            }
            

            

            

            
            
        }

        static void FillList(Random rand, List<int> listB)
        {
            int a = 0;

            for(a = 1; a <= 10; a++)
            {
                int b = rand.Next(0, 15);
                listB.Add(b);
            }

            DisplayList(listB);
        }

        static void DisplayList(List<int> ListA)
        {
            foreach(var item in ListA)
            {
                Console.Write(item + " ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine();
        }

        static void MakeList()
        {
            
        }
    }
}
