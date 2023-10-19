﻿
// Unit Exam 1
// Question 2
// Modify the numbersort app to also request sentences, sort words in ascending order

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace NumberSort
{
    class Program
    {
        // the definition of the delegate function data type
        delegate double sortingFunction(double[] a);

        static void Main(string[] args)
        {
            // declare the unsorted and sorted arrays
            double[] aUnsorted;
            double[] aSorted;

            // declare the delegate variable which will point to the function to be called
            sortingFunction findHiLow;

            Console.WriteLine("There are two parts to this program: Part 2 is designed for Question 2 on Unit Exam 1 \n");
        // a label to allow us to easily loop back to the start if there are input issues
        start:
            Console.WriteLine("Part 1: Enter a list of space-separated numbers");

            // read the space-separated string of numbers
            string sNumbers = Console.ReadLine();

            // split the string into the an array of strings which are the individual numbers
            string[] sNumber = sNumbers.Split(' ');

            // initialize the size of the unsorted array to 0
            int nUnsortedLength = 0;

            // a double used for parsing the current array element
            double nThisNumber;

            // iterate through the array of number strings
            foreach (string sThisNumber in sNumber)
            {
                // if the length of this string is 0 (ie. they typed 2 spaces in a row)
                if (sThisNumber.Length == 0)
                {
                    // skip it
                    continue;
                }

                try
                {
                    // try to parse the current string into a double
                    nThisNumber = double.Parse(sThisNumber);

                    // if it's successful, increment the number of unsorted numbers
                    ++nUnsortedLength;
                }
                catch
                {
                    // if an exception occurs
                    // indicate which number is invalid
                    Console.WriteLine($"Number #{nUnsortedLength + 1} is not a valid number.");

                    // loop back to the start
                    goto start;
                }
            }

            // now we know how many unsorted numbers there are
            // allocate the size of the unsorted array
            aUnsorted = new double[nUnsortedLength];

            // reset nUnsortedLength back to 0 to use as the index to store the numbers in the unsorted array
            nUnsortedLength = 0;
            foreach (string sThisNumber in sNumber)
            {
                // still skip the blank strings
                if (sThisNumber.Length == 0)
                {
                    continue;
                }

                // parse it into a double (we know they are all valid now)
                nThisNumber = double.Parse(sThisNumber);

                // store the value into the array
                aUnsorted[nUnsortedLength] = nThisNumber;

                // increment the array index
                nUnsortedLength++;
            }

            // allocate the size of the sorted array
            aSorted = new double[nUnsortedLength];

            // prompt for <a>scending or <d>escending
            Console.Write("Ascending or Descending? ");
            string sDirection = Console.ReadLine();

            if (sDirection.ToLower().StartsWith("a"))
            {
                findHiLow = new sortingFunction(FindLowestValue);
            }
            else
            {
                findHiLow = new sortingFunction(FindHighestValue);
            }

            // start the sorted length at 0 to use as sorted index element
            int nSortedLength = 0;

            // while there are unsorted values to sort
            while (aUnsorted.Length > 0)
            {
                // store the lowest or highest unsorted value as the next sorted value
                aSorted[nSortedLength] = findHiLow(aUnsorted);

                // remove the current sorted value
                RemoveUnsortedValue(aSorted[nSortedLength], ref aUnsorted);

                // increment the number of values in the sorted array
                ++nSortedLength;
            }

            // write the sorted array of numbers
            Console.WriteLine("The sorted list is: ");
            foreach (double thisNum in aSorted)
            {
                Console.Write($"{thisNum} ");
            }

            Console.WriteLine();

            // a good space to separate the parts
            start2:

            // space between Part 1 and Part 2
            Console.WriteLine("");

            // prompt user for a string, store it in readingNow 
            Console.Write("Part 2: First, type either ascending or descending: ");
            string orderType = Console.ReadLine();

            // string variable for the output of the re-arranged array
            string trueOutput;

            // if the order type is ASCENDING.. sort in ascending order
            if (orderType == "ascending" || orderType == "Ascending")
            {
                Console.Write(" Now, type in a string, and I'll send it back but in ascending alphabetical order!: ");
                string readingNow = Console.ReadLine();

                string[] arrAy = Regex.Split(readingNow, ""); // split the string into an array 
                Array.Sort(arrAy); // sort the array to appear in alphabetical order 
                trueOutput = string.Join("", arrAy); // use string.Join with the array, separate with no spaces to just show letters

                // write the output with just the letters in alphabetical order
                Console.WriteLine(trueOutput);
            }
            // if the order type is DESCENDING.. sort in descending order
            else if (orderType == "descending" || orderType == "Descending")
            {
                Console.Write(" Now, type in a string, and I'll send it back but in descending alphabetical order!: ");
                string readingNow = Console.ReadLine();

                string[] arrAy = Regex.Split(readingNow, ""); // split the string into an array 
                Array.Reverse(arrAy); // REVERSE the array
                trueOutput = string.Join("", arrAy); // use string.Join with the array, separate with no spaces to just show letters

                // write the output with just the letters in alphabetical order
                Console.WriteLine(trueOutput);
            }
            // if neither ascending or descending, give error and prompt to try again 
            else
            {
                Console.WriteLine("Invalid, please select either ascending or descending");
                goto start2;
            }

            start3:

            // User prompted to re-try
            Console.Write("\n Re-try part 2? ");
            string reTry = Console.ReadLine();

            // if yes, go back up
            if (reTry == "yes" || reTry == "Yes")
            {
                goto start2;
            }
            // if no, say goodbye and exit
            else if (reTry == "no" || reTry == "No")
            {
                Console.WriteLine("Bye bye for now");
                return;
            }
            // if neither yes or no, invalid - prompt again
            else
            {
                Console.WriteLine("Choose yes or no");
                goto start3;
            }
        }

        // find the lowest value in the array of doubles
        static double FindLowestValue(double[] array)
        {
            // define return value
            double returnVal;

            // initialize to the first element in the array
            // (we must initialize to an array element)
            returnVal = array[0];

            // loop through the array
            foreach (double thisNum in array)
            {
                // if the current value is less than the saved lowest value
                if (thisNum < returnVal)
                {
                    // save this as the lowest value
                    returnVal = thisNum;
                }
            }

            // return the lowest value
            return (returnVal);
        }

        static double FindHighestValue(double[] array)
        {
            // define return value
            double returnVal;

            // initialize to the first element in the array
            // (we must initialize to an array element)
            returnVal = array[0];

            // loop through the array
            foreach (double thisNum in array)
            {
                // if the current value is greater than the saved highest value
                if (thisNum > returnVal)
                {
                    // save this as the highest value
                    returnVal = thisNum;
                }
            }

            // return the highest value
            return (returnVal);
        }


        // remove the first instance of a value from an array
        static void RemoveUnsortedValue(double removeValue, ref double[] array)
        {
            // allocate a new array to hold 1 less value than the source array
            double[] newArray = new double[array.Length - 1];

            // we need a separate counter to index into the new array, 
            // since we are skipping a value in the source array
            int dest = 0;

            // the same value may occur multiple times in the array, so skip subsequent occurrences
            bool bAlreadyRemoved = false;

            // iterate through the source array
            foreach (double srcNumber in array)
            {
                // if this is the number to be removed and we didn't remove it yet
                if (srcNumber == removeValue && !bAlreadyRemoved)
                {
                    // set the flag that it was removed
                    bAlreadyRemoved = true;

                    // and skip it (ie. do not add it to the new array)
                    continue;
                }

                // insert the source number into the new array
                newArray[dest] = srcNumber;

                // increment the new array index to insert the next number
                ++dest;
            }

            // set the ref array equal to the new array, which has the target number removed
            // this changes the variable in the calling function (aUnsorted in this case)
            array = newArray;
        }
    }
}

