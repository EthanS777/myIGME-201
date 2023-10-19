using PE14Q2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

// Ethan Schechter
// Practice Exercise 14, Question 3
namespace PE14Q3
{
    // references: PE14Q2.dll (question 2 classes and interface)
    internal class Program
    {
        // Main: creating objects of both classes, call MyMethod() with each object
        static void Main(string[] args)
        {
            // create objects from both classes
            object myObject1 = new Class1();
            object myObject2 = new Class2();

            // call MyMethod() twice with myObject1 and then myObject2 
            MyMethod(myObject1);
            MyMethod(myObject2);
        }

        // MyMethod: accepts object, check to see if it's a type of class1 or class2... 
        // ...and then call common method name with interface
        public static void MyMethod(object myObject)
        {
            // is myObject a type of class1? if so...
            if (myObject.GetType() == typeof(Class1))
            {
                // make new local instantiation of class1
                Class1 classTime1 = new Class1();
                // set that class to be interface
                Interface1 interfaceTime1 = classTime1;
                // call the common method name using interface with class1
                interfaceTime1.MethodTime();
            }
            // else is my object a type of class2? if so...
            else if (myObject.GetType() == typeof(Class2))
            {
                // make new local instantiation of class2
                Class2 classTime2 = new Class2();
                // set that class to be interface
                Interface1 interfaceTime2 = classTime2;
               // use interface to call common method name with class2
                interfaceTime2.MethodTime();
            }
        }
    }
}
