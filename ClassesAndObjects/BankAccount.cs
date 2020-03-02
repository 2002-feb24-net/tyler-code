using System;

namespace ClassesAndObjects
{
    public class BankAccount
    {
        public string ID{ get;}
        public string Owner{ get; set;}

        public decimal Balance{ get; }

        private static int accountNumberSeed = 1234567890;

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithdrawl(decimal amount, DateTime date, string note)
        {

        }

        public BankAccount(String name, decimal startBalance)
        {
            this.ID = accountNumberSeed.ToString();
            this.Owner = name;
            this.Balance = startBalance;
        }
        
    }
}