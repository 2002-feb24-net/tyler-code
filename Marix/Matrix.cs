using System;
using System.Collections.Generic;

namespace Marix
{
    public class Matrix
    {
        // Fields maybe just 1
        // How will we store teh data of thisM matrix
        // Assume the size is 2
        // Harder ex multiple sizes

        // Methods
        // 1 some way to fill in the dat

        // 2 Some commmon matrix operations
        // (matrix add, multiply, subtract, tranpose)

        public List<int> dataList = new List<int>();

        int[,] _data;

        int _rows;
        int _cols;

        public void SetDemison(int rows, int cols)
        {
            _data = new int[rows,cols];
            _rows = rows;
            _cols = cols;

        }

        public void SetNum(int rows, int cols, int value)
        {
            _data[rows, cols] = value;
        }

    }
}