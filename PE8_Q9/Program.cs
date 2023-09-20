using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Q9
{
    static internal class Program
    {
        // Goal: to place double quotes around each word in a string (user inputted)
        // Ethan Schechter, PE8, Q9
        static void Main(string[] args)
        {
            // declare variables for strings
            string userString; // orig. inputted user string 
            string newUserString; // string after adding the "" quotes

            // prompt user to type in a string, store 
            Console.Write("Type in a string: "); 
            userString = Console.ReadLine();

            // set the new string equal to the orig, but replacing spaces with two quotes 
            newUserString = userString.Replace(" ", "\" \"");

            // print a quote at the beginning of the entire string, and one after
            Console.WriteLine("\"" + newUserString + "\"");        
        }
    }
}
