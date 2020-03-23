using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Data
{
    public class Sides : Product, IAddChocies
    {
        public Sides()
        {
            Name = "Sides";
            ProductChoices();
        }

        public Dictionary<string, double> ProductChoices()
        {
            Choices.Add("Stuffed Garlic Knots", 5.99);
            Choices.Add("Breadsticks", 4.99);
            Choices.Add("Cheesesticks", 5.99);
            Choices.Add("Fries", 2.99);

            return Choices;
        }
    }
}
