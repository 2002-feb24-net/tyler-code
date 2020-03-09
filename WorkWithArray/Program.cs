using System;

namespace WorkWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of values you want to store in to the array: ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] userArray = new int[arrayLength];
            int a = 0;
            int b = 0;
            int sum = 0;

            for(a = 0; a < userArray.Length; a++)
            {
                Console.Write("Enter a number for the array: ");
                int userVar = int.Parse(Console.ReadLine());
                userArray[a] = userVar;
                System.Console.WriteLine();
                sum += userVar;
            }

            System.Console.WriteLine();

            for(b = 0; a < userArray.Length; b++)
            {
                Console.Write(a + " ");
            }

            System.Console.WriteLine();
            Console.WriteLine("The sum of the values in the array are {0}", sum);

            System.Console.WriteLine();
            System.Console.WriteLine("Here is your array in reverse order: ");
        }
    }
}
