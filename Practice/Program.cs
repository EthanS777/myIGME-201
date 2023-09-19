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
            string[] blab = new string[5];
            blab[4] = "5th string";
            Console.WriteLine(blab[4]);

        }
    }
}
