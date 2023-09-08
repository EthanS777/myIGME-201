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
                   // or, another way to convert: nFavoriteNumber = int.Parse(sFavoriteNumber);
                   // or, another way to convert: nFavoriteNumber = int.TryParse(sFavoriteNumber);
                }
                catch
                {
                    Console.WriteLine("Please enter an integer!!");
                }
            }

            // set favorite color to lower case
            // this WON'T change string contents, it's not equal to sFavoriteColor itself
            sFavoriteColor.ToLower();

            // change console output color to match their fav color
            switch (sFavoriteColor.ToLower())
            {
                case "red":
                case "RED":
                case "Red":
                case "rEd":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                    // or.. if none of the above.. then:
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            // a loop that outputs their favorite color fav num of times 
            for (int i = 0; i < nFavoriteNumber; ++i)
            {
                Console.WriteLine("Your favorite color is: " + sFavoriteColor);
          // string interpolation: Console.WriteLine($"Your favorite color is {sFavoriteColor}");
          // Console.WriteLine("Your {0} favorite color is {1}{2}", "most", sFavoriteColor);
            }

        }
    }
}


