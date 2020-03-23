using System;
using Project0.Data;
using Project0.Data.Entities;
using Project0;

namespace Project0
{
    public class Program
    {
        public static readonly Project0Context ctx = new Project0Context();

        public static void Main()
        {
            var cust1 = new CustomerMethod();
            cust1.NewCustomer();
            ctx.Add(cust1);
            ctx.SaveChanges();

            //var cus1 = new Customer
            //{
            //    FirstName = Console.ReadLine()
            //};

            //ctx.Customer.Add(cus1);
            //ctx.SaveChanges();

            //string userin = "";
            //var cust1 = new CustomerMethod();
            //Prompt();
            //Console.Write("Are you a new customer : (y/n)");
            //Console.ReadLine();

            //if (userin == "y")
            //{
            //    cust1.NewCustomer();
            //}
            //else
            //{
            //    cust1.UserNameAndPass();
            //}
            //Prompt();
            //MainMenu();
        }

        static void Prompt()
        {
            System.Console.WriteLine("Welcome to the Pizza Planet Console Application!");
            System.Console.WriteLine("-------------------------------------------------");
            System.Console.WriteLine();
            System.Console.WriteLine("We have a number of different places here in Texas and Oaklahoma");
        }

        public static string[] ProductsWeSell()
        {
            System.Console.WriteLine("We sell: ");
            System.Console.WriteLine();
            string[] items = { "Pizza", "Wings", "Drinks", "Sides", "Deserts", "Exit" };
            int a;

            for (a = 1; a <= items.Length; a++)
            {
                Console.WriteLine(a + ". " + items[a - 1]);
            }
            System.Console.WriteLine();

            return items;
        }

        public static int UserDecides()
        {
            System.Console.WriteLine();
            Console.Write("Which one would you like: ");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    var pizza1 = new Pizza();
                    pizza1.GroupMethod();
                    break;
                case 2:
                    var wings1 = new Data.Wings();
                    wings1.GroupMethod();
                    break;
                case 3:
                    var drinks1 = new Drinks();
                    drinks1.GroupMethod();
                    break;
                case 4:
                    var sides1 = new Data.Sides();
                    sides1.GroupMethod();
                    break;
                case 5:
                    var deserts1 = new Desert();
                    deserts1.GroupMethod();
                    break;
                case 6:
                    Console.WriteLine("Good-bye");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Sorry didn't catch that. Try again.");
                    UserDecides();
                    break;
            }


            return userInput;
        }

        public static void MainMenu()
        {
            try
            {
                ProductsWeSell();
                UserDecides();
            }
            catch (FormatException)
            {
                Console.WriteLine("Sorry, you must enter a number. Try again");
                MainMenu();
            }

        }


    }
}
