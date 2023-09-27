using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ethan Schechter
// Unit Test 1: Question 13
namespace UT1_Q13
{
    /* class Program: contains the struct Employee- goal: to prompt for user name, call func,
     increase salary if they got a raise */
    static internal class Program
    {

            struct Employee { 
        
            public string sName;
            public double dSalary;

            public static bool GiveRaise(string name, ref double salary)
            {
                
            }

            }

        static void Main(string[] args)
        {
            Employee employeeName = new Employee();

            employeeName.sName = "Ethan";
            employeeName.dSalary = 30000;

            employeeName.GiveRaise(employeeName.sName, ref employeeName.dSalary);

        }
    }
}
