using System;

namespace YearsSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of second: ");
            long num = long.Parse(Console.ReadLine());
            long inputSec = 3156952;
            double earthAnsw = num / inputSec;

            System.Console.WriteLine("Earth: " + earthAnsw);
            ConvertYear(earthAnsw);

        }

        static void ConvertYear(double earthAnsw) {
            String[] planets = {"Mercury", "Saturn", "Venus", "Jupiter", "Earth", "Neptune", "Mars", "Uranus"};
            double[] multiplier = {4.1, 1.5, 0.5, .08, .03, .01, .006, .004};
            double newAnsw = 0.0;
            
            for (int a = 0; a < planets.Length; a++)
            {
                System.Console.WriteLine(planets[a] + ": {0.00} years.", newAnsw);
            }
        }
    }
}
