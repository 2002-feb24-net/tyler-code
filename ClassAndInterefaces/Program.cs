using System;

namespace ClassAndInterefaces
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 11;

             var class1 = new MyClass();
            Console.WriteLine(class1.myInt1);

            var class2 = new MyClass(12, "This is a new String");

            Console.WriteLine("This is an int {0} and this is a string {1}.", class2.myInt1, class2.myString1);
            class2.Print();
            Console.WriteLine(MyClass.myString3);
            string privateString = class2.InstanceMethod();
            Console.WriteLine(privateString);
            Console.WriteLine(MyClass.myString3);

            Console.WriteLine("ref variable == {0}", y);
            class1.refMethod(ref y);
            Console.WriteLine("ref variable == {0}", y);

            int z = 22;
            Console.WriteLine("value variable == {0}", z);
            class1.ValueMethod(z);
            Console.WriteLine("value variable == {0}", z);
            int returnNum =  class1.OutPut(out int varOut, 33);
            //Print the out value
            //Print the return

            Console.WriteLine("Param array below");
            class1.ParamArraMethod("Test", 1, 2, 3, 4, 5, 0, 6, 1);

            int returnDouble = class1.returnDouble(500);
            Console.WriteLine(returnDouble);


        }
    }
}
