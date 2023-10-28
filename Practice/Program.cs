using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice 
{



    static class Program
    {
        public class MyClass
        {
            public int myInt;

            public MyClass(int nVal)
            {
                this.myInt += nVal;
            }
        }

        public class MyDerivedClass : MyClass
        {
            public MyDerivedClass(int nVal) : base(nVal)
            {
                this.myInt = (this.myInt + 2) * 4;
            }
        }
        
        static void Main(string[] args)
        {
            MyDerivedClass myObj = new MyDerivedClass(42);
            Console.WriteLine(myObj.myInt);
        }
    }



}
