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
            int i;
            for (i = 1; i <= 10; i++)
            {
                if ((i % 2) == 0)
                {
                    continue;
                }
                
                Console.WriteLine(i);
            }

        }
    }
}
