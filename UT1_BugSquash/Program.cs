using Microsoft.Win32;
using System;

namespace UT1_BugSquash
{
    // Ethan Schechter
    // Unit Test 1, Question 14
    // Calculating Errors
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            //int nY - COMPILE TIME ERROR: missing semicolon
            int nY; // fixed
            int nAnswer;

            // Console.WriteLine(This program calculates x ^ y.); - COMPILE TIME ERROR: missing quotes
            Console.WriteLine("This program calculates x ^ y."); // fixed

            do
            {
                Console.Write("Enter a whole number for x: ");
                sNumber = Console.ReadLine(); // fixed: to be assigned as user input before called below
            } while (!int.TryParse(sNumber, out nX)); // - RUN TIME ERROR: sNumber not defined yet


            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            } // while (int.TryParse(sNumber, out nX)); - LOGICAL ERROR: nY should be after "out", not nX
            while (!int.TryParse(sNumber, out nY)); // fixed

            // compute the exponent of the number using a recursive function
             nAnswer = Power(nX, nY);

            Console.WriteLine("{nX}^{nY} = {nAnswer}");
        }


       // int Power(int nBase, int nExponent) COMPILE-TIME ERROR: did not include "static"
       static int Power(int nBase, int nExponent) 
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                returnVal = 0;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                nextVal = Power(nBase, nExponent + 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            // returnVal; COMPILE-TIME ERROR - should be "return returnVal", with the statement "return"
            return returnVal;
        }
    }
}