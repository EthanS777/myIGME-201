using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalUTQ3
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

        public static void Main(string[] args)
        {

        }
    }
}
