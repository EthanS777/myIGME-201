using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PE8_Q8
{
    // Ethan Schechter, PE 8, Q8
    internal class Program
    {
       /* Purpose: Write a console application that accepts a string and does a case-insensitive
          replacement of all occurrences of the word "no" with "yes" */ 
        static void Main(string[] args)
        {
            // variable declaring:
            string theHolyString;
            string theYesWord1 = "yes"; // lowercase yes
            string theYesWord2 = "Yes"; // uppercase Yes
            string theNoWord1 = "no"; // lowercase no
            string theNoWord2 = "No"; // uppercase No
            string theNewHolyString;
            string theRealNewHolyString;

            start:

            // prompt user for input string, save to theHolyString variable
            Console.Write("Type in anything (with the word 'yes')! : ");
            theHolyString = Console.ReadLine();

            // set a bool for if it contains "yes" or "Yes" using .Contains()
            bool thatsAYes1 = theHolyString.Contains(theYesWord1);
            bool thatsAYes2 = theHolyString.Contains(theYesWord2);

            // using .Replace(), if it contains "yes" (or "Yes"), replace with "no" (or "No")
            if (thatsAYes1 == true || thatsAYes2 == true)
            {
                // replace all cases of lowercase "yes" in original input string with lowercase "no"
               theNewHolyString = theHolyString.Replace(theYesWord1, theNoWord1);
                // replace all cases of uppercase "Yes" in the new string with uppercase "No"
                theRealNewHolyString = theNewHolyString.Replace(theYesWord2, theNoWord2);
                // print after all changes are made
                Console.WriteLine(theRealNewHolyString);
            }

            // just some extra: go back to start if user didn't use the word yes
            else
            {
                Console.WriteLine("Sorry. You didn't use the word yes in that string. :(. Try again.");
                goto start;
            }
            
        }
    }
}
