using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Ethan Schechter
// Unit Exam 1, Question 3
namespace UT1_Q3
{
    // define delegate method data type with a double and int as params
    delegate double RoundingNumbers(double userDouble, int userInt);

    // class purpose: to imitate the Math.Round(double, int) function with delegates
    static internal class Program
    {
        static void Main(string[] args)
        {
            // declare delegate method variable:
            RoundingNumbers userInput;

            // extra variables for the answer number and parameters for delegate method call
            double dAnswer = 0; // final answer
            double doubleMoment = 0;
            int intMoment = 0;

            // pointing variable to method it should call
            userInput = new RoundingNumbers(roundTime);

            // calling the delegate method
            dAnswer = userInput(doubleMoment, intMoment);

            // print out the new rounded number
            Console.WriteLine("Your new rounded number is: " + dAnswer);

        }

        // method roundTime which has 2 params, one double and one int to round by a specific # of decimals
        static double roundTime(double doubleTime, int intTime)
        {
            // prompt user to enter a double number, store in string
            Console.Write("Enter a number that's a double!: ");
            string doubleRead = Console.ReadLine();

            // prompt user to enter an integer number, store in string
            Console.Write("How many digits do you want it rounded to? (integer): ");
            string integerRead = Console.ReadLine();

            double trueDoubleRead; // this will be the actual double after string conversion
            int trueIntegerRead; // this will be the actual integer to round after string conversion
            double roundingTime; // this will be what we store the rounded double in

            // convert strings into their assigned double/int variables
            double.TryParse(doubleRead, out trueDoubleRead);
            int.TryParse(integerRead, out trueIntegerRead);

            // store the rounded in the variable that will be returned 
            roundingTime = Math.Round(trueDoubleRead, trueIntegerRead);

            // return the new double rounded number
            return roundingTime;
        }
    }
}
