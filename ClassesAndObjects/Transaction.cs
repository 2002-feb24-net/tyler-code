using System;
using System.Collections.Generic;

namespace ClassesAndObjects
{
    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public  String Notes { get; }

        public Transaction(decimal amount, DateTime date, String notes)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes =  notes;


        }
    }
}