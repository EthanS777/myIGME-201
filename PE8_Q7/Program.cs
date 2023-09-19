using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Q7
{
    // Ethan Schechter, PE8, Question 7
    internal class Program
    {
        /* Purpose: Write a console application that accepts a string from the user,
     outputs a string with the characters in reverse order.*/
        static void Main(string[] args)
        {
            // declare variables for user string and the reversed version
            string userString;
            string userStringReversed = "";

            // prompt user for input
            Console.Write("Please enter a string, any string: ");
            userString = Console.ReadLine();

            // looping through the input string, working backwards
            for (int i = userString.Length - 1; i >= 0; i--)
            {
                userStringReversed += userString[i];
            }
            Console.WriteLine("Here's that string in reverse: " + userStringReversed);
        }
    }
}
