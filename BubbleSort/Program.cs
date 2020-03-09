using System;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> userList = new List<int>();
            string userIn = "y";
            int a = 0;
            int b = 0;
            int temp = 0;

            Prompt();
            userList = UserDecides(userIn, userList);

            Console.Write("Your list looks like this: ");
            DisplayList(userList);
            System.Console.WriteLine();
            System.Console.WriteLine();
            userList = BubbleSortFunction(a, b, temp, userList);
            System.Console.WriteLine("Your new list looks like this: ");
            DisplayList(userList);

        }

        static void Prompt()
        {
            System.Console.WriteLine("Welcome to the Bubble Sorting Program!");
            System.Console.WriteLine("In this program you enter numbers and then");
            System.Console.WriteLine("The program will sort them from lowest to ");
            System.Console.WriteLine("Highest. Negative are welcome too.");
            System.Console.WriteLine();
        }

        static List<int> BubbleSortFunction(int a, int b, int temp, List<int> userList)
        {
            for  (a = 0; a < userList.Count - 1; a++)
            {
                for (b = 0; b < userList.Count - 1; b++)
                {
                    if(userList[b] > userList[b + 1])
                    {
                        Swap(userList, temp, b);
                    }
                }
            }

            return userList;
        }

        static void Swap(List<int> userList, int temp, int b)
        {
            temp = userList[b + 1];
            userList[b + 1] = userList[b];
            userList[b] = temp;
        }

        static List<int> UserDecides(string userIn, List<int> userList)
        {
        
            while(userIn == "y")
            {
                Console.Write("Enter a number: ");
                int userNum = int.Parse(Console.ReadLine());
                userList.Add(userNum);
                System.Console.WriteLine();
                System.Console.Write("Do you want to go again. y or n: ");
                userIn = Console.ReadLine();
            }

            return userList;
        }


        static void DisplayList(List<int> userList)
        {
            foreach (var item in userList)
            {
                Console.Write(item + " ");
            }
        }
    }
}
