using System;

namespace Classes3
{
    public class People
    {
        String name;
        int age;
        double heightInFeet;

        public void setDefault()
        {
            name = "John";
            age = 18;
            heightInFeet = 5.1;
        }

        public override String ToString()
        {
            return name + " is" + age +  "years old, and is" + heightInFeet + "feet tall.";
        }
    }
}