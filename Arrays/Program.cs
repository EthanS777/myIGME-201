using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] myIntArray = { 5, 6, 7, 8, 9, 23, 123, -90 };
                // myIntArray[0]
            }

            {
                int[] myIntArray = new int[8] { 5, 6, 7, 8, 9, 23, 123, -90 };
            }

            {
                int[] myIntArray = new int[8];
                myIntArray[0] = 5;
                myIntArray[1] = 6;
                myIntArray[2] = 7;
                myIntArray[3] = 8;
                myIntArray[4] = 9;
                myIntArray[5] = 23;
                myIntArray[6] = 123;
                myIntArray[7] = -90;

                int[] myIntArray2;
                myIntArray2 = myIntArray;

                myIntArray2[0] = 55;

                myIntArray = null;
                myIntArray2 = null;
            }

            {
                int arraySize = 5;
                int[] myIntArray = new int[arraySize];
            }

            {
                int[ , ] funcVal = new int[21, 2];
                for (x = -10; x <= 10; ++x, ++xCntr)
                {
                    y = 2 * (int)Math.Pow(x, 2) + 3; 

                }
            }

            {
                int[][] jaggedIntArray = new int[2][]; // jagged array
                jaggedIntArray[0] = new int[3];
                jaggedIntArray[1] = new int[4];

                jaggedIntArray[0][0] = 1;
                jaggedIntArray[0][1] = 2;
                jaggedIntArray[0][2] = 3;

                jaggedIntArray[1][0] = 1;
                jaggedIntArray[1][1] = 2;
                jaggedIntArray[1][2] = 3;
                jaggedIntArray[1][3] = 4;
            }
        }
    }
}
