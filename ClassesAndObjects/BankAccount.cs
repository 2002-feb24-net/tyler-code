using System;

namespace ClassesAndObjects
{
    public class BankAccount
    {
        public string ID{ get;}
        public string Owner{ get; set;}
        

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach(var item in AllTransaction)
            }
        }

        private static int accountNumberSeed = 0000000001;

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

            accountNumberSeed++;
        }
        
    }
}