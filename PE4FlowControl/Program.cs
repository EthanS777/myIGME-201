using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4FlowControl
{
    // Ethan Schechter
    // PE 4 - Flow Control
    // Class "Program": all work done for PE4 in here
    static internal class Program
    {
        /* The purpose of Main: Get two numbers from the user, display them, but reject if both #'s--
         -- are greater than 10. If so, ask for 2 new numbers */
        static void Main(string[] args)
        {
            // Get two numbers from the user - letting numOne and numTwo be strings at first

            string numOne = "";
            string numTwo = "";

            Console.WriteLine("Pick two numbers! They must both not be greater than 10.");

            Console.Write("First number: ");
            numOne = Console.ReadLine();

            Console.Write("Second number: ");
            numTwo = Console.ReadLine();

            // convert to ints in new vars

            int varOne = Convert.ToInt32(numOne);
            int varTwo = Convert.ToInt32(numTwo);

            // if BOTH are less than/equal to 10, or one is greater than 10 but another is not, print #'s
            if (varOne <= 10 && varTwo <= 10 || varOne <= 10 || varTwo <= 10)
            {
                Console.WriteLine("Valid! Your numbers were: " + numOne + " and " + numTwo);
            }
            // else if they're BOTH greater than 10, display error message and pick new #'s
            else if (varOne > 10 && varTwo > 10) 
            {
                Console.WriteLine("Sorry, those are both greater than 10. Pick new numbers next time.");
            }
        }
    }
}
