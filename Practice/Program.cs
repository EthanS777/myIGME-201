using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string");
            string readingNow = Console.ReadLine();
            string[] test = Regex.Split(readingNow, string.Empty); // string split to an array 
            Array.Sort(test); // sort created string array 
            string sample = string.Join("", test); //rejoin string array
            Console.WriteLine(sample);
            Console.ReadLine();

        }


    }
}
