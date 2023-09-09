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
            int number = 3;
            switch (number)
            {
                case 1:
                    Console.WriteLine("Just");
                    break;

                case 2:
                case 4:
                    Console.WriteLine("an");
                    break;

                default:
                    Console.WriteLine("example");
                    break;
            }

        }
    }
}
