using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConversion
{
    static internal partial class Program // PARTIAL: means class expands several files
    {
        static double myDivider(double n1, double n2) // this can be (and is) called in the other file!
        {
            return 1;
        }
    }
}
