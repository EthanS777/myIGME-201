using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace UT1_Q4
{
    // Ethan Schechter
    // Unit Test 1: Question 4

    // Purpose: to re-create the 3questions.exe program
    static internal class Program
    {
        // declare timer and set timeOut to false
        static Timer timeOutTimer;
        static bool bTimeOut = false;

        // Main: recreating the 3questions program
        static void Main(string[] args)
        {
            // variables for number of questions, user's answer, and play again
            string stringQuestion;
            int numQuestion;
            string stringAnswer;
            string playAgain;

        start:

            // TIMER: set it to new timer (5000 for 5 seconds), make sure its set to be an event handler passing the function TimesUp
            timeOutTimer = new Timer(5000);
            timeOutTimer.Elapsed += new ElapsedEventHandler(TimesUp);
            bTimeOut = false;


            start2:

            // ask for question number, convert from string to int
            Console.Write("Choose your question (1-3): ");
            stringQuestion = Console.ReadLine();
            int.TryParse(stringQuestion, out numQuestion);

            // start timer
            timeOutTimer.Start();


            // if-else to check which question # user selected, and print question
            // 1: the "color" question
            if (numQuestion == 1)
            {

                // give user the 5 second warning
                Console.WriteLine("You have 5 seconds to answer the following question: ");

                // ask the question, store in stringAnswer
                Console.WriteLine("What is your favorite color?");
                stringAnswer = Console.ReadLine();

                // stop timer if they press enter
                timeOutTimer.Stop();

                // if answer is RIGHT.. stop timer, congratulate and prompt to play again
                if (stringAnswer == "black")
                {
                    timeOutTimer.Stop();

                    Console.WriteLine("Well done!");
                here1:
                    Console.Write("Play again? ");
                    playAgain = Console.ReadLine();

                    if (playAgain == "yes" || playAgain == "Yes")
                    {
                        Console.WriteLine(" ");
                        goto start;
                    }
                    else if (playAgain == "no" || playAgain == "No")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        goto here1;
                    }
                    // if answer is WRONG.. stop timer, tell them true answer, prompt to play again
                }
                else
                {
                    timeOutTimer.Stop();
                    Console.WriteLine("Wrong! The answer is: black");
                here4:
                    Console.Write("Play again? ");
                    playAgain = Console.ReadLine();

                    if (playAgain == "yes" || playAgain == "Yes")
                    {
                        Console.WriteLine(" ");
                        goto start;
                    }
                    else if (playAgain == "no" || playAgain == "No")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        goto here4;
                    }
                }

            }
            // 2: the "life" question
            else if (numQuestion == 2)
            {

                // give user the 5 second warning
                Console.WriteLine("You have 5 seconds to answer the following question: ");

                // start timer
                timeOutTimer.Start();
                // prompt the question
                Console.WriteLine("What is the answer to life, the universe and everything?");
                stringAnswer = Console.ReadLine();

                // if answer is RIGHT.. stop timer, congratulate, and prompt to play again
                if (stringAnswer == "42")
                {
                    timeOutTimer.Stop();

                    Console.WriteLine("Well done!");
                here2:
                    Console.Write("Play again? ");
                    playAgain = Console.ReadLine();

                    if (playAgain == "yes" || playAgain == "Yes")
                    {
                        Console.WriteLine(" ");
                        goto start;
                    }
                    else if (playAgain == "no" || playAgain == "No")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        goto here2;
                    }
                }
                // if answer is WRONG.. stop timer, share answer, prompt user to play again
                else
                {
                    // stop timer if they click enter
                    timeOutTimer.Stop();
                    Console.WriteLine("Wrong! The answer is: 42");
                here3:
                    Console.Write("Play again? ");
                    playAgain = Console.ReadLine();

                    if (playAgain == "yes" || playAgain == "Yes")
                    {
                        Console.WriteLine(" ");
                        goto start;
                    }
                    else if (playAgain == "no" || playAgain == "No")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        goto here3;
                    }
                }
            }
            // 3: the "swallow" question
            else if (numQuestion == 3)
            {
                stringAnswer = "What do you mean? African or European swallow?";

                // give user the 5 second warning
                Console.WriteLine("You have 5 seconds to answer the following question: ");

                // start timer
                timeOutTimer.Start();
                // prompt the question
                Console.WriteLine("What is the airspeed velocity of an unladen swallow?");
                stringAnswer = Console.ReadLine();
                // stop timer if they click enter
                timeOutTimer.Stop();

                   // if answer is RIGHT.. stop timer, congratulate, and prompt to play again
                if (stringAnswer == "What do you mean? African or European swallow?")
                {
                    timeOutTimer.Stop();

                    Console.WriteLine("Well done!");
                here5:
                    Console.Write("Play again? ");
                    playAgain = Console.ReadLine();

                    if (playAgain == "yes" || playAgain == "Yes")
                    {
                        Console.WriteLine(" ");
                        goto start;
                    }
                    else if (playAgain == "no" || playAgain == "No")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        goto here5;
                    }
                }
                // if answer is WRONG.. stop timer, prompt user to play again, share answer
                else
                {
                    timeOutTimer.Stop();
                    Console.WriteLine("Wrong! The answer is: What do you mean? African or European swallow?");
                here5:
                    Console.Write("Play again? ");
                    playAgain = Console.ReadLine();

                    if (playAgain == "yes" || playAgain == "Yes")
                    {
                        Console.WriteLine(" ");
                        goto start;
                    }
                    else if (playAgain == "no" || playAgain == "No")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        goto here5;
                    }
                }
            }
            // if an answer other than 1, 2, or 3 is typed in for question #, go to start
            else
            {
                goto start2;
            }
        }

        // TimesUp function: Event handler args - sets the end of timer to true, stops it
        static void TimesUp(object sender, ElapsedEventArgs e)
        {
             
                bTimeOut = true;
            // stop timer 
               timeOutTimer.Stop();
            // prompt user time is over
               Console.WriteLine("Times up!");
            // prompt user to click enter
            Console.WriteLine("Please press enter.");
        }
    }
}
