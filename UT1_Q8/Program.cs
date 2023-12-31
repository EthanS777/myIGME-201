﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ethan Schechter
// Unit Test 1, Question 8
namespace UT1_Q8
{
    // Class Program: goal - implement a multidimensional array for an equation
    internal class Program
    {
       
        // Main: 3D formula 
        static void Main(string[] args)
        {

            //  z = 4y3 + 2x2 - 8x + 7
            // 0 <= x <= 4 in 0.1 increments
            // -1 <= y <= 1 in 0.1 increments

            double x = 0;
            double y = 0;
            double z = 0;

            int nX = 0;
            int nY = 0;

            // we declare our 3 dimensional array to hold:
            // 38 values of x
            // 21 values of y 
            // 3 values for each data point: x, y, z
            double zArray = roundTime(42, 21); 

            int dataPointCntr = 0;

            for (x = 0; x <= 4; x += 0.1, nX++)
            {
                x = Math.Round(x, 1);

                // start with the 0'th "y" bucket for this value of x
                nY = 0;

                for (y = -1; y <= 1; y += 0.1, ++nY)
                {
                    y = Math.Round(y, 1);

                     double thisDataPoint = roundTime(x, y);

                   // zArray[dataPointCntr++] = new ZFunction(x,y);
                }
            }
        }

        // method roundTime, 2 params to round
        static double roundTime(double dX, double dY)
        {
            Console.Write("Enter a number that's a double!: ");
            string doubleRead = Console.ReadLine();

            Console.Write("How many digits do you want it rounded to? (integer): ");
            string integerRead = Console.ReadLine();

            double trueDoubleRead;
            int trueIntegerRead;
            double roundingTime;
            

            double.TryParse(doubleRead, out trueDoubleRead);
            int.TryParse(integerRead, out trueIntegerRead);

            roundingTime = Math.Round(trueDoubleRead, trueIntegerRead);

            return roundingTime;
        }

        }
    }
