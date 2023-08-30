using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: Professor: David Schuh, Student: Ethan Schechter
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter

            // int i = 0 - ERROR: SYNTAX - no semicolon, fixed below
            int i = 0;
            /* added above for-loop */ string allNumbers = null;

            // loop through the numbers 1 through 10
            //for (i = 1; i < 10; ++i) ERROR: LOGICAL -  we're looping 1-10, not 1-9. should be i <= 10
            for (i = 1; i <= 10; ++i) 
            {
                // declare string to hold all numbers
                // string allNumbers = null; ERROR: should be declared before for-loop so line 57 doesn't error 

                // output explanation of calculation
                // Console.Write(i + "/" + i - 1 + " = "); ERROR: SYNTAX - will not compile without parentheses
                Console.Write(i + "/" + (i - 1) + " = ");

                // output the calculation based on the numbers
                // adding some code to prevent the error with i = 1, dividing by i=1 here means 1/0 which = an error, won't run properly
                if (i == 1)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    Console.WriteLine(i / (i - 1));
                }
                

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                // i = i + 1; ERROR: LOGICAL - should not be here, already incrementing "i" in the for-loop. No need to increment again. 
            }

            // output all numbers which have been processed
             Console.WriteLine("These numbers have been processed: " + allNumbers); 
        }
    }
}
