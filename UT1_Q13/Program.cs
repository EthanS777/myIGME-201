using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// Ethan Schechter
// Unit Test 1: Question 13

// namespace: contains the struct Employee- goal: to prompt for user name, call func, increase salary if they got a raise 
namespace UT1_Q13
{
    // struct Employee: has public string and double, declare GiveRaise function
    struct Employee
    {

        public string sName;
        public double dSalary;

        // GiveRaise Increase salary by $19,999.99 if name is Ethan, return true- else, return false
        public static bool GiveRaise(string name, ref double salary)
        {
            // if name is Ethan, increase salary and tell them they got a raise
            if (name == "Ethan")
            {
                salary += 19999.99;
                Console.WriteLine("Woohoo! You got a raise! Your new salary is: " + salary);

                return true;
            }
            // if name is not Ethan (lame), return false
            else
            {
                return false;
            }
        }

    }
    // class Program: contains the calling of the struct  
    static internal class Program
    {
        // Main: declare new instance of Employee struct, prompt user for info on sName, and call the GiveRaise func
        static void Main(string[] args)
        {
            // new instance of struct
            Employee employeeName = new Employee();

            // prompt user for name, store in sName of the struct - declare salary as 30,000 to start
            Console.Write("Hey there user, what's your name? : ");
            employeeName.sName = Console.ReadLine();
            employeeName.dSalary = 30000;

            // call the GiveRaise function in Employee struct, passing only the struct variables as params
            Employee.GiveRaise(employeeName.sName, ref employeeName.dSalary);

        }
    }
}
