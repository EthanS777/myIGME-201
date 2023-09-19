using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Q5
{
   /*	Given the formula z = 3y2 + 2x - 1 write a console application to calculate z for the following ranges of x and y:
•	-1 <= x <= 1 in 0.1 increments
•	1 <= y <= 4 in 0.1 increments
Use a 3-dimensional array double[,,] to store the values of x, y and z for each computation*/

    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[3];
            

            for (arr[0] = -1; arr[0] <= 1; arr[0] += 0.1)
            {
                for (arr[1] = 1; arr[1] <= 4; arr[1] += 0.1)
                {
                    Console.WriteLine(3 * arr[1] * arr[1] + 2 * arr[0] - 1);
                }
            }

        }
    }
}
