using System;

namespace BubbleSort2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = {5, 7, 9, 2, 0, -2};
            int i = 0;
            int j = 0;

            for(j = 0; j < array1.Length - 1; j++)
            {
                for (i = 0; i < array1.Length - 1; i++)
                {
                    if(array1[i] > array1[i + 1])
                    {
                        Swap(array1, i);
                    }
                }
            }

            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }
        }

        static void Swap(int[] array1, int i)
        {
            int temp = 0;
            temp = array1[i];
            array1[i] = array1[i + 1];
            array1[i + 1] = temp;

        }
    }
}
