using System;
using System.Collections.Generic;
using System.Text;
namespace Project0.Data
{
    public class Wings : Product, IAddChocies
    {
        public Wings()
        {
            Name = "Wing";
            ProductChoices();
        }

        public Dictionary<string, double> ProductChoices()
        {
            Choices.Add("Tradional", 7.39);
            Choices.Add("Breaded Bone-Out", 7.5);
            Choices.Add("Dip", .79);

            return Choices;
        }
    }
}
