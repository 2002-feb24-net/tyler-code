using System;

namespace Marix
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write code to test out Matrix code
            // Matrix class
            Matrix m1 = new Matrix();
            Matrix m2  = new Matrix();

            m1.SetDemison(2, 2);
            m1.SetDemison(2, 2);

            m1.SetNum(0, 0, 5);
            m1.SetNum(0, 1, 2);
            m1.SetNum(1, 0, 9);
            m1.SetNum(1, 1, 3);

            m2.SetNum(0, 0, 7);
            m2.SetNum(0, 1, 6);
            m2.SetNum(1, 0, 8);
            m2.SetNum(1, 1, 2);
        }
    }
}
