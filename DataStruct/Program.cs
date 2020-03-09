using System;

namespace DataStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            // now that we've defined a class
            // we can create objecs from that class

            //the class ssaves as template to create the object;

            // Objects
            Product candyBar = new Product();

            // Variables
            int candyBArAmount = GetStock("ceral");

            // candyBar.SetDefault();
            candyBar.SetValues("22", candyBArAmount, 4.5);
            System.Console.WriteLine(candyBar);
            
        }

        static int GetStock(string name)
        {
            int quantiy = 0;

            do
            {
            Console.Write("Enter quantiy of product " + name + " : ");

            quantiy = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Please enter a positive number");
            System.Console.WriteLine();
            } while(quantiy < 0);

            return quantiy;
        }
    }
}
