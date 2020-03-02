using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Tyler", 1000);
            System.Console.WriteLine("Account {0} was created for {1} with ${2} itinial balance.", account.ID, account.Owner, account.Balance);
        }
    }
}
