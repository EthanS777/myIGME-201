using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

// Ethan Schechter 
// IGME 201: Practice Exercise 7- Mad Libs

// namespace: class Program, Main function
namespace PE7MadLibs
{
    static internal class Program
    {
        // Main: creating a Mad Libs game with practice in text files, I/O, and strings
        static void Main(string[] args)
        {
            int numStories = 0;
            int cntr = 0;
            int numChoice = 0;

            string resultString = "";
            bool playingGame = true;

            // declare input variable as StreamReader 
            StreamReader input;

            // open file, count # of lines
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            string line = null;
            while ((line = input.ReadLine()) != null)
            {
                ++numStories;
            }


            // close file
            input.Close();

            start:
            // do you want to play mad libs?
            
            Console.Write("Do you want to play Mad Libs? : ");
            string playString = Console.ReadLine();

            // for case-insensitive yes or no's, either run through program, terminate it, or prompt to try again
            switch (playString)
            {
                case "yes":
                    break;
                case "Yes":
                    break;
                case "no":
                    Console.WriteLine("Goodbye.");
                    playingGame = false;
                    break;
                case "No":
                    Console.WriteLine("Goodbye");
                    playingGame = false;
                    break;
                default:
                    Console.WriteLine("That's not a yes or no! Try again.");
                        goto start;
                    break;
            }

            while (playingGame == true)
            {
                // only allocate as many strings as there are Mad Libs
                string[] madLibs = new string[numStories];

                // read the Mad Libs into the array of strings
               
                input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

                line = null;
                while ((line = input.ReadLine()) != null)
                {
                    // set this array element to the current line of the template file
                    madLibs[cntr] = line;

                    // replace the "\\n" tag with the newline escape character
                    madLibs[cntr] = madLibs[cntr].Replace("\\n", "\n");

                    ++cntr;
                }

                input.Close();

                // prompt the user for which Mad Lib they want to play (numChoice)
                // ask user for name, to choose story between 1 and n, prompt user for inputs, then print story
                // declare resultString to hold final result


                Console.Write("Your name? : ");
                string name = Console.ReadLine();

                Console.Write("Okay " + name + ", choose a story between 1 and 5: ");
                string storyNum = Console.ReadLine();
                int.TryParse(storyNum, out numChoice);


                // split the Mad Lib into separate words
                string[] words = madLibs[numChoice].Split(' ');
                
                // loop through all the words in story
                foreach (string word in words)
                {
                    // if current word starts with {
                    if (word[0] == '{')
                    {
                        string replaceWord = word.Replace("{", "").Replace("}", " ").Replace("_", " ");
                        // prompt the user for the replacement
                        Console.Write("Input a {0}: ", replaceWord);
                        // and append the user response to the result string
                        resultString += " " + Console.ReadLine();
                    }
                    // else append word to the result string
                    else
                    {
                        resultString = resultString + " " + word;
                    }

                }
                // print story
                Console.WriteLine(resultString);

            }
        }
    }
}
