using System;
using System.Collections.Generic;
using System.Linq;
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
            SortedList<string, DateTime> friendBirthdays = new SortedList<string, DateTime>();
            friendBirthdays.Add("Joseph", new DateTime(2002, 10, 31));
            friendBirthdays.Add("Andrew", new DateTime(2003, 02, 16));
            friendBirthdays.Add("Violet", new DateTime(2002, 12, 08));

            foreach (KeyValuePair<string, DateTime> valuePair in  friendBirthdays)
            {
                Console.WriteLine($"person[{valuePair.Key}] = {valuePair.Value}");
            }

        }
    }



}
