using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndInterefaces
{
    class MyClass : Interface1
    {
        public int myInt1 = 11;
        public string myString1 { get; }

        private int _myInt2 = 2;
        private string _myString2 = "I am private string";

        public MyClass() { }

        public static string myString3 = "I am static string";

        public MyClass(int myInt1, string myString1)
        {
            this.myInt1 = myInt1;
            this.myString1 = myString1;
        }

        public String GetString()
        {
            return myString1;
        }

        public void Print()
        {
            Console.WriteLine("This my 2nd int {0} and this 2nd String {1}" ,_myInt2, _myString2);
        }

        public String InstanceMethod()
        {
            return _myString2;
        }

        public void  refMethod(ref int x)
        {
            x = x + 100;
            Console.WriteLine(x);
        }

        public void ValueMethod(int x)
        {
            x += 222;
            Console.WriteLine(x);
        }

        public int OutPut(out int outVar, int num)
        {
            Console.WriteLine(num);
            outVar = num + 333;
            num *= num;

            return num;
        }

        public void ParamArraMethod(string s, params int[] args)
        {
            foreach(var item in args)
            {
                if(item == 0)
                {
                    Console.WriteLine("It's 0");
                }
            }
        }

        public int returnDouble(int x)
        {
            return x += x;
        }
    }
}
