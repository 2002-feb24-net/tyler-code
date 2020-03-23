using Project0;
using Project0.Data;
using Project0.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Data
{
    public class Product
    {
        public string Name { get; set; }
        public Dictionary<string, double> Choices { get; set; } = new Dictionary<string, double>();

        

        public void Border(string message)
        {
            int a;
            for (a = 0; a < message.Length + 2; a++)
            {
                Console.Write("-");
            }
        }

        public void Intro()
        {
            string message = "Welcome to the {0} page.";

            System.Console.WriteLine(message, Name);
            Border(message);
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Below is a list of every kind of {0}s we sell and their corresponding prices:", Name);
        }

        public void DisiplayChoices()
        {
            Console.Write("Type ");
            foreach (var item in Choices)
            {
                Console.Write("'" + item.Key + "' ");
            }
            System.Console.WriteLine();
        }

        public void DisplayChoicesAndPrices(Dictionary<string, double> dict1)
        {
            System.Console.WriteLine();
            foreach (var item in dict1)
            {
                System.Console.WriteLine($"{item.Key} {Name} {item.Value.ToString("C2")}");
            }
        }

        public void AddToOrdr()
        {

            System.Console.WriteLine();
            Console.Write("Choose: ");

            string userIn = Console.ReadLine();
            if (Choices.TryGetValue(userIn, out _))
            {
                //.Add(userIn, price);
                Console.WriteLine("Added to your order");
                userIn = "";
                MenuOrEnd(userIn);
            }
            else
            {
                Console.WriteLine("Try again");
                AddToOrdr();
            }

        }

        public void MenuOrEnd(string s)
        {
            System.Console.WriteLine();
            Console.WriteLine("Type 'y' to display your order ");
            System.Console.WriteLine("Type 'n' to go back to the menu");
            System.Console.WriteLine(); ;
            System.Console.Write("Are you done ?");
            s = Console.ReadLine();
            System.Console.WriteLine();
            if (s == "y")
            {
                DisplayChoicesAndPrices(CustomerMethod.CustomerOrder);
                System.Console.WriteLine();
                System.Console.WriteLine($"{CustomerMethod.CustomerOrder} ");
            }
        }

        public void GroupMethod()
        {
            Intro();
            DisiplayChoices();
            DisplayChoicesAndPrices(Choices);
            AddToOrdr();
        }
    }
}
