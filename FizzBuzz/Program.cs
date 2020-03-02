using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fizz = 267;
            //Buzz = 134
            //FizzBuzz = 66

            int a = 1;
            int sumFizz = 0;
            int sumBuzz = 0;
            int sumBoth = 0;

            for (a = 1; a <= 1000; a++)
            {
                if(a % 3 == 0)
                {
                    if((a % 3 == 0) && (a % 5 == 0))
                    {
                        Console.Write("FizzBuzz, ");
                        sumBoth += 1;
                    } else
                    {
                        Console.Write("Fizz, ");
                        sumFizz += 1;
                    }
                }
                else if(a % 5 == 0) {
                    Console.Write("Buzz, ");
                    sumBuzz += 1;
                }
            }
        }
    }
}
