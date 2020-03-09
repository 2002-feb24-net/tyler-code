using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict1 = new Dictionary<String, int>();

            dict1["Bob"] = 91;
            // Instead of using dictory
            // we could use a class
            // 2 values and store a list of class instances

            string[] names = {"A", "B", "C"}
            var dict2 = new Dictionary<string, int>()
            {
                ["Bill"] = 99
            };

            foreach(var item in dict1)
            {
                string key = item.Key;
                int value = item.Value;
            }
    }

    class Student
    {
        string name;
        int grade;
    }
}
