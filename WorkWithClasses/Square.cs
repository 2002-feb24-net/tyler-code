using System;

namespace WorkWithClasses
{
    public class Square
    {
        int userLength = 0;
        int width = 0;

        public int AskUser()
        {
            Console.Write("How long do want this squre to be: ");
            int userLength = int.Parse(Console.ReadLine());

            return userLength;
        }

        public void SetDemension(int userLength, int width)
        {
            width = userLength;

            for (int a = 0; a < userLength; a++)
            {
                for (int b = 0; b < a; b++)
                {
                    if(a > b)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}