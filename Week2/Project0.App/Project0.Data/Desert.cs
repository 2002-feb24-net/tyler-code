using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Data
{
    public class Desert : Product, IAddChocies
    {
        public Desert()
        {
            Name = "Drinks";
            ProductChoices();
        }

        public Dictionary<string, double> ProductChoices()
        {
            Choices.Add("Mini Sweet Rolls", 5.99);
            Choices.Add("Cinnamon Rolls", 4.99);
            Choices.Add("Brownie", 6.99);
            Choices.Add("Icing Dip", .79);

            return Choices;
        }
    }
}
