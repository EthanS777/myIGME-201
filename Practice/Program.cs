using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3 };

            myFunction("hi", myArray, false);

        }

        static void myFunction(string label, int[] args,
 bool showLabel) // params not needed
        {
            if (showLabel) // Equals true? False?
            {
                Console.WriteLine(label);
            }

            foreach (int i in args)
            {
                Console.WriteLine("{0}", i);
            }
        }


    }
}
