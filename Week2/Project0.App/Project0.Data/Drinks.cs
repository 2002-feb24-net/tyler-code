using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Data
{
    public class Drinks : Product, IAddChocies
    {
        public Drinks()
        {
            Name = "Drinks";
            ProductChoices();
        }

        public Dictionary<string, double> ProductChoices()
        {
            Choices.Add("Pepsi", 1.99);
            Choices.Add("Sprite", 1.99);
            Choices.Add("Dr. Pepper", 1.99);
            Choices.Add("Root Beer", 2.99);

            return Choices;
        }
    }
}
