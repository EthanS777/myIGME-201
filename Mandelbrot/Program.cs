using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>

    // Ethan Schechter
    // Practice Exercise 4: Mandelbrot 
    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            // Ask user for image coord start/end info:

            Console.Write("Choose new start value for imagCoord! It decrements, and default start value is 1.2 : ");
            string imagCoordStart = Console.ReadLine();
            Console.Write("Choose new end value (MUST be lower than start #) for imagCoord! Default end value is -1.2 : ");
            string imagCoordEnd = Console.ReadLine();

            // Ask user for real coord start/end info:

            Console.Write("Choose new start value for realCoord! It increments, and default start value is -0.6 : ");
            string realCoordStart = Console.ReadLine();
            Console.Write("Choose new end value (MUST be higher than start #) for realCood! Default end value is 1.77 : ");
            string realCoordEnd = Console.ReadLine();

            // convert to numbers (decimal):

            double numImagStart = Convert.ToDouble(imagCoordStart);
            double numImagEnd = Convert.ToDouble(imagCoordEnd);
            double numRealStart = Convert.ToDouble(realCoordStart);
            double numRealEnd = Convert.ToDouble(realCoordEnd);


            // first for-loop: adjust to start with user input, go until user input, and decrement by dividing by 48 to show 48 values

            for (imagCoord = numImagStart; imagCoord >= numImagEnd; imagCoord -= ((numImagStart - numImagEnd) / 48))
            {
                // if the starting image coord number is less than the end #, INVALID
                if (numImagStart < numImagEnd)
                {
                    Console.WriteLine("INVALID VALUES");
                }

                // second for-loop: adjust to start with user input, end with user input, increment divide by 80 for 80 values

                for (realCoord = numRealStart; realCoord <= numRealEnd; realCoord += ((numRealEnd - numRealStart) / 80))
                {
                    // if starting real coord number is greater than end #, INVALID
                    if (numRealStart > numRealEnd)
                    {
                        Console.WriteLine("INVALID VALUES");
                    }

                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}

