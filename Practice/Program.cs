using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice 
{
    static class Program
    {
        
        static void Main(string[] args)
        {
            
            // for (w, x, y), there are 11 w's, 41 x's, 21 y's 
            Tuple<double, double, double> mathTime = new Tuple<double, double, double>(11, 41, 21);
            SortedList<(double, double), double> mathTimer = new SortedList<(double, double), double>();

            int nW = 0;
            int nX = 0;
            int nY = 0;
            // for-loops for the ranges of w, x, y
            for (double w = -2; w <= 0; w += 0.2, nW++)
            {
                w = Math.Round(w, 1);

                for (double x = 0; x <= 4; x += 0.1, nX++)
                {
                    x = Math.Round(x, 1);

                    for (double y = -1; y <= 1; y += 0.1, nY++)
                    {
                        y = Math.Round(y, 1);

                        double z = (4 * Math.Pow(y, 3)) + (2 * Math.Pow(x, 2)) - (8 * w) + 7;

                        Console.WriteLine(Math.Round(z, 3));
                        
                    }
                }
            }
        }
    }
}
