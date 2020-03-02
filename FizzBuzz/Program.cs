using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            for (a = 1; a <= 1000; a++)
            {

                if(a % 3 == 0)
                {
                    Console.Write("Fizz, ");
                }
                else if(a % 5 == 0) {
                    Console.Write("Buzz, ");
                }
                else if((a % 3 == 0) && (a % 5 == 0))
                {
                    Console.Write("FizzBuzz");
                }
            }
        }
    }
}
