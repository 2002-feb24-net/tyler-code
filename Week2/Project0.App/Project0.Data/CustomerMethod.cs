using Project0.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Data
{
    public class CustomerMethod : Customer
    {
        public static Dictionary<string, double> CustomerOrder { get; set; } = new Dictionary<string, double>();
        public string Password2 { get; set; }

        public void NewCustomer()
        {
            Console.Write("Please enter your first name: ");
            FirstName = Console.ReadLine();
            System.Console.WriteLine();
            Console.Write($"OK, {FirstName}, now enter your last name: ");
            LastName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What is your street address? ");
            Stret = Console.ReadLine();
            System.Console.WriteLine();
            System.Console.Write("What is your state? ");
            State = Console.ReadLine();
            System.Console.WriteLine();
            Console.Write("What is your zip code? ");
            Zip = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            Console.Write("What is your Phone number");
            PhoneNumber = Console.ReadLine();
            System.Console.WriteLine();
            Console.Write("What is your email address");
            Email = Console.ReadLine();
            UserId++;

            PrintInfo();
            System.Console.WriteLine("Great now setup a Username and Password");
            UserNameAndPass();
        }

        public void PrintInfo()
        {
            System.Console.WriteLine();
            Console.WriteLine("Just to verify");
            Console.WriteLine($"Your name is {FirstName} {LastName}");
            Console.WriteLine($"Your address is {Stret} {City}, {State} {Zip}");
            System.Console.WriteLine($"Your phone number is {PhoneNumber} and your email is {Email}");
            System.Console.WriteLine();
            System.Console.WriteLine("Is this information corret? (y/n) ");
            string yOrN = Console.ReadLine();
            if (yOrN == "n")
            {
                System.Console.WriteLine("Sorry to hear that. Let's do it again");
                NewCustomer();
            }
            else
            {
                System.Console.WriteLine("Well, great! Welcome to Pizza Planet!");
                
            }
        }

        public void UserNameAndPass()
        {
            Console.Write("Enter your username: ");
            UserName = Console.ReadLine();
            System.Console.WriteLine();
            CheckPassword();

        }

        public void CheckPassword()
        {
            Console.Write("Enter your password: ");
            Password = Console.ReadLine();
            System.Console.WriteLine();
            Console.Write("Verify your password again: ");
            Password2 = Console.ReadLine();

            if (Password != Password2)
            {
                System.Console.WriteLine("Sorry, your password didn't match. Try again");
                CheckPassword();
            }
        }
    }
}
