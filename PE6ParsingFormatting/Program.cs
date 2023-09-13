using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

// Ethan Schechter
// Practice Exercise 6: Parsing & Formatting
namespace PE6ParsingFormatting
{
    // class Program: all work will be done in this class, and in Main
    static internal class Program
    {
        // Main: Objective- Create a simple number guessing game (random 1-100) and have user guess it
        static void Main(string[] args)
        {

            // numGuess for string for input, trueNumGuess for conversion into #
            string numGuess;
            int trueNumGuess;

            // Generate random int 0-100 (101 exclusive)
            Random rand = new Random();
            int randomNumber = rand.Next(0, 101);

            // Testing: printing the number out, you're welcome! :)
            Console.WriteLine("Random number: " + randomNumber);

            // instructions for user
            Console.WriteLine("Welcome! You have 8 valid guesses to guess a number between 0 and 100. Good luck!");

            // loop: user gets 8 tries to guess the number (i = num guesses)
            for (int i = 1; i < 9; i++)
            {
                // guess num, store it, then parse to an int
                Console.Write("Turn #" + i + ": Guess a number: ");
                numGuess = Console.ReadLine();
                int.TryParse(numGuess, out trueNumGuess);

                // if between 0 and 100, valid #
                if (trueNumGuess >= 0 && trueNumGuess <= 100)
                {
                    // if guess greater than #, print guess too high
                    if (trueNumGuess > randomNumber)
                    {
                        Console.WriteLine("That guess is HIGHER than the number!\n");
                    }
                    // else if guess less than #, print guess too low
                    else if (trueNumGuess < randomNumber)
                    {
                        Console.WriteLine("That guess is LOWER than the number!\n");
                    }
                    // else if guess is same as #, print num times it took, exit loop
                    else if (trueNumGuess == randomNumber)
                    {
                        Console.WriteLine("Congrats! You guessed the right # in " + i + " turn(s)!");
                        break;
                    }

                    // if they fail to guess the correct # in 8 valid tries, print #
                    if (i == 8)
                    {
                        Console.WriteLine("Sorry! You failed to guess it correctly. The right # was: " + randomNumber);
                    }
                }
                // else, invalid: prompt for another #, don't count the guess
                else
                {
                    Console.WriteLine("Invalid input, try another number. This won't affect your # of guesses. \n");
                    i--;
                }
            }

        }
    }
}