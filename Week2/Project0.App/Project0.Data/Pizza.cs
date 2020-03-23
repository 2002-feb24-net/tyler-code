using Project0.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project0
{
    public class Pizza : Product, IAddChocies
    {
        public Pizza()
        {
            Name = "Pizza";
            ProductChoices();
        }

        public Dictionary<string, double> ProductChoices()
        {
            Choices.Add("Pepperoni", 12);
            Choices.Add("Cheese", 11);
            Choices.Add("Supreme", 13);

            return Choices;
        }
    }
}
