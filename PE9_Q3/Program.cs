using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

// Ethan Schechter
// PE9, Q3
namespace PE9_Q3
{
    // define delegate method data type with user string as param
    delegate string ReadingLine(string userString);

    // class purpose: to imitate the Console.ReadLine() function with delegates
    internal class Program
    {   
        static void Main(string[] args)
        {
            // declare delegate method variable:
            ReadingLine userInput;

            // extra variables for the answer string and parameter for delegate method call
             string sAnswer = "";
             string stringyTime = "";

            // pointing variable to method it should call
             userInput = new ReadingLine(readString);

            // calling the delegate method
             sAnswer = userInput(stringyTime);

           
        }

        // method readString which has a param
        static string readString(string stringTime)
        {
            // enter the string
            Console.Write("Enter a string, any string!: ");
            string readTime = Console.ReadLine();
            return readTime;
        }
    }
}
