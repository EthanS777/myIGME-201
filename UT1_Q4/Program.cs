using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UT1_Q4
{
    // Ethan Schechter
    // Unit Test 1: Question 4

    // Purpose: to re-create the 3questions.exe program
    internal class Program
    {
        // Main: recreating the 3questions program
        static void Main(string[] args)
        {
            // variables for number of questions, time, user's answer,
            string stringQuestion;
            int numQuestion;
            string stringAnswer;
            int time = 5;

            // ask for question number, convert from string to int
            Console.Write("Choose your question (1-3): ");
            stringQuestion = Console.ReadLine();
            int.TryParse(stringQuestion, out numQuestion);

            // give user the 5 second warning
            Console.WriteLine("You have 5 seconds to answer the following question: ");
            
            // if-else to check which question # user selected, and print question
            if (numQuestion == 1)
            {
                Console.WriteLine("What is your favorite color?");
                stringAnswer = Console.ReadLine();
                
            }
            else if (numQuestion == 2)
            {
                
                Console.WriteLine("What is the answer to life, the universe and everything?");
                stringAnswer = Console.ReadLine();
                

            }
            else if (numQuestion == 3)
            {
                Console.WriteLine("What is the airspeed velocity of an unladen swallow?");
                stringAnswer = Console.ReadLine();
                
            }
          


        }
    }
}
