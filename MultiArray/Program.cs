using System;

namespace MultiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // you can make an arry would contain any type
            // You can make an array of arrays

            // for example, for 2 dimeismeila image data
            string[][] image = new string[4][];
            image[0] = new string[] {"Black", "Grey", "White", "Brown"};
            image[1] = new string[] {"Black", "Grey", "White", "Brown"};
            image[2] = new string[] {"Black", "Grey", "White", "Brown"};
            image[3] = new string[] {"Black", "Grey", "White", "Brown"};
            // How to access
            String string1 = image[0][3]; //the fourth element in first array
            // Jagged array are uneven, not a rectagle or square [4][] or [][4]


            // what we have up there up tehre is "array of arrays
            // this is soemthing different does enfore rectagle 
            string[,] image2 = new string[4, 4]{
            {"Black", "Grey", "White", "Brown"},
            {"Black", "Grey", "White", "Brown"},
            {"Black", "Grey", "White", "Brown"},
            {"Black", "Grey", "White", "Brown"},
            };

            // How to access it
            String newString2 = image2[0,2];

            // 
        }
    }
}
