using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalUTQ5
{
    enum Colors
    {
        Red,
        Orange,
        Yellow,
        Green,
        LightBlue,
        DarkBlue,
        Purple,
        Gray
    }
    public class Program
    {

        // adjacency matrix 
        static int[,] adjMatrix = new int[,]
        { 
                 // Value of -1: not adjacent or related or directed to that color
                 // Any other value is the weight of the edge

                        // red   // orange   // yellow   // green   // L. blue   // D. blue   // purple  // gray
            /*red*/    { -1,      -1,         -1,         -1,        -1,           1,          -1,         5 },
            /*orange*/ { -1,      -1,         -1,         -1,        -1,          -1,           1,        -1 },
            /*yellow*/ { -1,      -1,         -1,          6,        -1,          -1,          -1,        -1 },
            /*green*/  { -1,      -1,         -1,         -1,        -1,          -1,          -1,        -1 },
        /*light blue*/ { -1,      -1,         -1,         -1,        -1,           1,          -1,         0 },
        /* dark blue*/ { -1,      -1,          8,         -1,         1,          -1,          -1,        -1 },
           /*purple*/  { -1,      -1,          1,         -1,        -1,          -1,          -1,        -1 },
           /*gray*/    { -1,       1,         -1,         -1,         0,          -1,          -1,        -1 }
        };


        // adjacency list
        static int[][] adjlist = new int[][]
        {
                 // Green is Null since it doesn't have an edge pointing to any other color

             /*red*/     new int[] { (int)Colors.DarkBlue, (int)Colors.Gray },
             /*orange*/  new int[] { (int)Colors.Purple },
             /*yellow*/  new int[] { (int)Colors.Green },
             /*green*/   null,
         /*light blue*/  new int[] { (int)Colors.DarkBlue, (int)Colors.Gray },
         /*dark blue*/   new int[] { (int)Colors.Yellow, (int)Colors.LightBlue },
           /*purple*/    new int[] { (int)Colors.Yellow },
           /*gray*/      new int[] { (int)Colors.Orange, (int)Colors.LightBlue }
        };


        // Q5 part: outputting the DSP quickest path

        // Main: call DSP function, loop through colors in the quickest path between RED and GREEN, output colors
        static void Main(string[] args)
        {
            Colors[] quickestPath = DSP((int)Colors.Red, (int)Colors.Green);
            Console.WriteLine("Here is the shortest path from Red to Green: ");

            foreach (Colors colors in quickestPath)
            {
                Console.WriteLine(colors + ", then");
            }
        }

        // DSP function: accepts the colors (start red, end green), find shortest path
        static Colors[] DSP(int startColor, int endColor)
        {
            int colorsNum = Enum.GetValues(typeof(Colors)).Length; // length- num colors
            int[] distances = new int[colorsNum];  // distances between colors (weights)
            bool[] visited = new bool[colorsNum];  // was that color visited?
            int[] previous = new int[colorsNum];   // previous color nums

            // loop through num of colors
            for (int i = 0; i < colorsNum; i++)
            {
                distances[i] = int.MaxValue;  
                visited[i] = false;
                previous[i] = -1; // previous arrays
            }

            // the starting distance: 0
            distances[startColor] = 0;

            // D's algorithm
            for (int i = 0; i < colorsNum - 1; i++)
            {
                // find vertex with smallest distance
                int j = -1;
                int smallestDistance = int.MaxValue;

                // loop through num colors
                for (int k = 0; k < colorsNum; k++)
                {
                    if (!visited[k] && distances[k] < smallestDistance)
                    {
                        j = k;
                        smallestDistance = distances[k];
                    }
                }
                // then count the vertex as visited
                visited[j] = true;

                // update distances/previous
                for (int l = 0; l < colorsNum; l++)
                {
      
                    if (!visited[l] && adjMatrix[j, l] != -1 && distances[j] != int.MaxValue &&
                        distances[j] + adjMatrix[j, l] < distances[l])
                    {
                        distances[l] = distances[j] + adjMatrix[j, l];
                        previous[l] = j;
                    }
                }
            }

            // path start to end-
            List<Colors> pathTime = new List<Colors>();
            int current = endColor;

            while (current != -1)
            {
                pathTime.Add((Colors)current);
                current = previous[current];
            }

            // reverse it to display from red to green, not vice-versa
            pathTime.Reverse();

            // change to array
            return pathTime.ToArray();
        }
    }
}
