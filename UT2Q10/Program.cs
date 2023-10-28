using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UT2Q9;

// UT2, Q10: References the Q9 DLL of my schUML in C# form
namespace UT2Q10
{
    // Program: Contains entire project with two methods 
    internal class Program
    {
        // Main: create objects of the two child classes, call MyMethod with both of them
        static void Main(string[] args)
        {
            // create objects of my two child classes:
            Skiis skiis = new Skiis();
            Poles poles = new Poles();

            // call MyMethod with each object:
            MyMethod(skiis);
            MyMethod(poles);
        }

        // MyMethod:
        static void MyMethod(object obj)
        {
            // based on object type-
            // if object is of class Skiis:
            if (obj.GetType() == typeof(Skiis))
            {
                // cast the obj. as Skiis and Skiing, set those to be interface and parent respectively
                Skiis skiTime = (Skiis)obj;
                Skiing skiingTime1 = (Skiing)obj;

                TakeAction interfaceTime = skiTime;
                Skiing skiingTime2 = skiingTime1;

                // call methods
                interfaceTime.PutOn();
                interfaceTime.TakeOff();
                skiingTime2.Slide();
            }
            // else if object is of class Poles:
            else if (obj.GetType() == typeof(Poles))
            {
                // cast the obj. as Poles and Skiing, set those to be interface and parent respectively
                Poles poleTime = (Poles)obj;
                Skiing skiingTime3 = (Skiing)obj;

                TakeAction interfaceTime = poleTime;
                Skiing skiingTime4 = skiingTime3;

                // call methods
                interfaceTime.PutOn();
                interfaceTime.TakeOff();
                skiingTime4.Slide();
            }
        }
    }
}
