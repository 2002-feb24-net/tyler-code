using System;

namespace WorkWithClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s1 = new Square();
            int mainLength = 0;
            int width = 0;

            mainLength = s1.AskUser();
            s1.SetDemension(mainLength, width);
        }
    }
}
