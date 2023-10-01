using System.IO;
using System;
using System.Dynamic;

// Ethan Schechter
// Exam 1, Question 1

// class purpose: to take the Math Quiz app, include division and have user round to 2 decimals
static class Program
{
    // Main: holds all the code for this solution
    static void Main()
    {
        // store user name
        string myName = "";

        // string and int of # of questions
        string sQuestions = "";
        int nQuestions = 0;
        double dQuestions = 0;

        // string and base value related to difficulty
        string sDifficulty = "";
        int nMaxRange = 0;
        double dMaxRange = 0;

        // constant for setting difficulty with 1 variable
        const int MAX_BASE = 10;

        // question and # correct counters
        int nCntr = 0;
        int nCorrect = 0;
        double dCorrect = 0;

        // operator picker
        int nOp = 0;

        // operands and solution
        int val1 = 0;
        int val2 = 0;
        int nAnswer = 0;

        double dVal1 = 0;
        double dVal2 = 0;


        // add a double to be the answer when problem is division
        double dAnswer = 0;

        // string and int for the response
        string sResponse = "";
        Int32 nResponse = 0;
        // add a double for a response
        double dResponse = 0;

        // boolean for checking valid input
        bool bValid = false;

        // play again?
        string sAgain = "";

        // seed the random number generator
        Random rand = new Random();

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("Math Quiz!");
        Console.WriteLine();

        // fetch the user's name into myName
        while (true)
        {
            Console.Write("What is your name-> ");
            myName = Console.ReadLine();

            if (myName.Length > 0)
            {
                break;
            }
        }

    // label to return to if they want to play again
    start:

        // initialize correct responses for each time around
        nCorrect = 0;

        Console.WriteLine();

        do
        {
            Console.Write("How many questions-> ");
            sQuestions = Console.ReadLine();

            try
            {
                nQuestions = int.Parse(sQuestions);
                bValid = true;
            }
            catch
            {
                Console.WriteLine("Please enter an integer.");
                bValid = false;
            }

        } while (!bValid);

        Console.WriteLine();

        do
        {
            Console.Write("Difficulty level (easy, medium, hard)-> ");
            sDifficulty = Console.ReadLine();
        } while (sDifficulty.ToLower() != "easy" &&
                 sDifficulty.ToLower() != "medium" &&
                 sDifficulty.ToLower() != "hard");

        Console.WriteLine();

        // if they choose easy, then set nMaxRange = MAX_BASE, unless myName == "David", then set difficulty to hard
        // if they choose medium, set nMaxRange = MAX_BASE * 2
        // if they choose hard, set nMaxRange = MAX_BASE * 3
        switch (sDifficulty.ToLower())
        {
            case "easy":
                nMaxRange = MAX_BASE;
                if (myName.ToLower() == "david")
                {
                    goto case "hard";
                }
                break;

            case "medium":
                nMaxRange = MAX_BASE * 2;
                break;

            case "hard":
                nMaxRange = MAX_BASE * 3;
                break;
        }

        // ask each question
        for (nCntr = 0; nCntr < nQuestions; ++nCntr)
        {
            // generate a random number between 0 inclusive and 3 exclusive to get the operation
            nOp = rand.Next(0, 3);

            val1 = rand.Next(0, nMaxRange) + nMaxRange;
            val2 = rand.Next(0, nMaxRange);

            dVal1 = rand.Next(0, nMaxRange) + dMaxRange;
            dVal2 = rand.Next(0, nMaxRange);

            // if either argument is 0, pick new numbers
            if (val1 == 0 || val2 == 0)
            {
                // decrement counter to try this one again (because it will be incremented at the top of the loop)
                --nCntr;
                continue;
            }

            // if nOp == 0, then addition
            // if nOp == 1, then subtraction
            // else multiplication or DIVISION
            if (nOp == 0) // addition
            {
                nAnswer = val1 + val2;
                sQuestions = $"Question #{nCntr + 1}: {val1} + {val2} => ";
            }
            else if (nOp == 1) // subtraction
            {
                nAnswer = val1 - val2; 
                sQuestions = $"Question #{nCntr + 1}: {val1} - {val2} => ";
            }
            else if (nOp == 2) // when nOp is 2, that's for division
            {
                dAnswer = dVal1 / dVal2;
                // ROUND dAnswer to 2 decimal places
                dAnswer = Math.Round(dAnswer, 2);
                // prompt user to round appropriately
                Console.WriteLine("For this question, round to 2 decimals!");
                sQuestions = $"Question #{nCntr + 1}: {dVal1} / {dVal2} => ";
            }
            else // else multiplication
            {
                dAnswer = dVal1 * dVal2;
                sQuestions = $"Question #{nCntr + 1}: {dVal1} * {dVal2} => ";
            }

            // display the question and prompt for the answer

            // if NOT division, make sure they only type in an integer and not a double
            if (nOp != 2)
            {
                do
                {
                    // print the question, put it into sResponse
                    Console.Write(sQuestions);
                    sResponse = Console.ReadLine();

                    try
                    {
                        // try to parse the string into an int, still valid
                        nResponse = int.Parse(sResponse);
                        bValid = true;
                    }
                    catch
                    {
                        // if impossible and invalid, prompt user to enter an integer. no longer valid
                        Console.WriteLine("Please enter an integer.");
                        bValid = false;
                    }

                } while (!bValid);
            }

           // if DIVISION, make sure they're allowed to enter a double
            if (nOp == 2)
            {
                do
                {
                    // print the question to the console
                    Console.Write(sQuestions);

                    try
                    {
                        // try to convert the ReadLine into a double, still valid
                        dResponse = Convert.ToDouble(Console.ReadLine());
                        bValid = true;
                    }
                    catch
                    {
                        // if impossible and invalid, prompt user to enter a double. no longer valid
                        Console.WriteLine("Please enter a double.");
                        bValid = false;
                    }
                } while (!bValid);
            }


            // if problem is NOT containing division...
            if (nOp != 2)
            {
                // if answer is correct, congratulate user
                if (nResponse == nAnswer)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Well done, {0}!!!", myName);

                    ++nCorrect;
                }
                // if answer is incorrect, display apologies and right answer
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I'm sorry {0}. The answer is {1}", myName, nAnswer);
                }
            }
            // if the type is DIVISION...
            if (nOp == 2)
            {
                // if answer is correct, congratulate user
                if (dResponse == dAnswer)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Well done, {0}!!!", myName);

                    ++dCorrect;
                }
                // if answer is incorrect, display apologies and right answer 
                else 
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I'm sorry {0}. The answer is {1}", myName, dAnswer);
                }
            }
            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
        }

        Console.WriteLine();

        // output how many they got correct and their score

        // ADJUST to show the accurate correct answer with the division doubles combined with the num types
        Console.WriteLine("You got {0} correct out of {1}, which is a score of {2:P2}", nCorrect + dCorrect, nQuestions + dQuestions, (Convert.ToDouble(nCorrect) + dCorrect) / Convert.ToDouble(nQuestions) + dQuestions);
        Console.WriteLine();

        do
        {
            // prompt if they want to play again
            Console.Write("Do you want to play again? ");

            sAgain = Console.ReadLine();

            if (sAgain.ToLower().StartsWith("y"))
            {
                goto start;
            }
            else if (sAgain.ToLower().StartsWith("n"))
            {
                break;
            }
        } while (true);
    }
}