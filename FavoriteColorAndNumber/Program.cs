using ColorsAndNumbers.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorsAndNumbers
{
    namespace Colors
    {
        enum EColors
        {
            red,
            orange,
            yellow,
            green,
            blue,
            indigo,
            violet
        }
    }
    namespace Numbers
    {
        enum ENumbers
        {
            one,
            two,
            three,
            four,
            five,
            six,
            seven
        }
    }
}
namespace FavoriteColorAndNumber
{
    using ColorsAndNumbers.Colors;
    using System.Xml;

    internal class Program
    {
        // function in c#! outside Main
        static void WriteMyVar(ref int nParameter)
        {
            
            Console.WriteLine(nParameter);
            nParameter = 42;
        }
        static void Main(string[] args)
        {
            // accessing the enum EColors which is nested inside two namespaces: with "using" on line 39, it's easier
            EColors eColors;

            Console.WriteLine(""); 


            int myInt = 0;
            int anotherInt = 2;
            myInt = anotherInt;

            string sFavoriteColor = null; // "null" can be used with strings
            int? nFavoriteNumber = null;
            string sFavoriteNumber = "";
            bool bValid = false;

            // function call!
            // ref = reference, for call by reference 
            WriteMyVar(ref myInt);

            // -------------------------- NEW EXERCISE --------------------------

            // prompt the user for their favorite color 
            Console.Write("Hello! Please enter your favorite color: ");

            // read the color from user, store it in variable 
            sFavoriteColor = Console.ReadLine();

            // prompt user for their favorite number 
            Console.Write("Please enter your favorite number: ");

            // read favorite number, store in variable 
            sFavoriteNumber = Console.ReadLine();


            while (nFavoriteNumber == null) 
            {
                try
                {
                    nFavoriteNumber = Convert.ToInt32(sFavoriteNumber);
                }
                catch
                {
                    Console.WriteLine("Please enter an integer!!");
                }
            }

            // a loop that outputs their favorite color fav num of times 
        }
    }
}


