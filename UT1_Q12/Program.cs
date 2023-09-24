using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ethan Schechter
// Unit Test 1: Question 12
namespace UT1_Q12
{
    /* class Program: purpose to prompt for a user's name, call a function and increase
       salary if name is equal to mine */
    static internal class Program
    {
        // Main: Declare variables, prompt for user's name, call GiveRaise function
        static void Main(string[] args)
        {
            // variable declarations
            string sName;
            double dSalary = 30000;

            // prompt user for their name, store in sName
            Console.Write("Hey there user, what's your name? : ");
            sName = Console.ReadLine();

            // call GiveRaise
            GiveRaise(sName, ref dSalary); 
        }

        // GiveRaise: Increase salary by $19,999.99 if name is Ethan, return true- else, return false
        static bool GiveRaise(string name, ref double salary)
        {
            // if name is Ethan, increase salary and tell them they got a raise/their new salary. Return true
            if (name == "Ethan")
            {
                salary += 19999.99;
                Console.WriteLine("Woohoo! You got a raise! Your new salary is: " + salary);

                return true;
            }
            // if name is not Ethan (lame), return false
            else
            {
                return false;
            }
        }

    }
}