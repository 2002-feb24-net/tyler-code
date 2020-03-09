using System;
using System.Linq;

namespace MergeSort
{
    class Program
    {
        // 1. Split the array in half, left, and right
        // 2. keep doing that for each subarray, until you can't anymore cause it's size 1
        // combine your 2 arrays, one by one trough both of them
        //      keeping teh result sorted overall
        // Don't use result array use orignal

        static void Main(string[] args)
        {
            int[] array1 = { 0, 5, 11, -1, 3 };

        }

        static void Sort(int[] arrayA)
        {
            int mid = arrayA.Length / 2;
            int[] left = Split(arrayA, 0, mid);
            int[] right = Split(arrayA, mid, arrayA.Length);
            int l = 0;
            int r = 0;

            if(arrayA.Length < 2)
            {
                return;
            }

            Sort(left);
            Sort(right);

            for (int i = 0; i < arrayA.Length; i++)
            {
                if(l >= left.Length)
                {
                }
            }
        }

        static int[] Split(int[] array1, int start, int end)
        {
            int length = end - start;
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = array1[start + i]
            }

            return result;
        }
    }
}
