using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalUTQ4
{
    // list of Colors in the digraph
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

        // Main: call depth first search function, with adj. matrix as parameter
        public static void Main(string[] args)
        {
            Console.WriteLine("DFS Result:");
            depthFirstSearch(adjMatrix);
        }

        // depthFirstSearch: get length of the first dimension of adj. array, loop through to see if searched
        // if not searched yet, call DFS2 which prints colors and goes through matrix
        public static void depthFirstSearch(int[,] aMatrix)
        {
            int numColors = aMatrix.GetLength(0);
            bool[] searched = new bool[numColors];

            for (int i = 0; i < numColors; i++)
            {
                if (!searched[i])
                {
                    DFS2(aMatrix, i, searched);
                }
            }
        }

        // DFS2: prints colors, sets the current vertex (i in color) to be true, then loops through first dimension of matrix
        // if not searched and vertex not equal to -1, call same function again to go to NEXT color
        static void DFS2(int[,] aMatrix, int vertex, bool[] searched)
        {
            searched[vertex] = true;
            Console.WriteLine(Enum.GetName(typeof(Colors), vertex));

            // for length of first dimension of matrix
            for (int i = 0; i < aMatrix.GetLength(1); i++)
            {
                // if matrix vertice is not equal to -1 (AKA adjacent/connected), and not searched yet, then go to NEXT color
                if (aMatrix[vertex, i] != -1 && !searched[i])
                {
                   DFS2(aMatrix, i, searched);
                }
            }
        }
    }
}
