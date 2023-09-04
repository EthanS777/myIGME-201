using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// all work for this PE is done in this PE3Variables namespace
namespace PE3Variables
{
    // Ethan Schechter
    // IGME 201 - Professor Schuh
    // PE 3: Variables and Expressions
    // class Program: purpose is to prompt the user for 4 values, then print the product out
    internal class Program
    {
        static void Main(string[] args)
        {
            string value1 = "";
            string value2 = "";
            string value3 = "";
            string value4 = "";

            Console.WriteLine("Hi! The purpose of this is to take four of your values and then display the product, after multiplication!");

            // prompt the user to enter their first value, then read and store 
            Console.Write("Please enter your first number: ");
            value1 = Console.ReadLine();

            // prompt user for their second value, then read and store 
            Console.Write("Please enter your second number: ");
            value2 = Console.ReadLine();

            // prompt for third value, then read and store
            Console.Write("Please enter the third number: ");
            value3 = Console.ReadLine();

            // prompt for value #4, then read and store
            Console.Write("Please enter your final number!: ");
            value4 = Console.ReadLine();

            // convert the strings to ints, then assign to new variables
            int numValue1 = Convert.ToInt32(value1);
            int numValue2 = Convert.ToInt32(value2);
            int numValue3 = Convert.ToInt32(value3);
            int numValue4 = Convert.ToInt32(value4);

            // print out the product of those ints in their new variables 
            Console.WriteLine("The product of your four numbers is: " + (numValue1 * numValue2 * numValue3 * numValue4));
        }
    }
}
