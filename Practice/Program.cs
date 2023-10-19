using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice
{
    public abstract class Classy
    {
        private string member;

        public string Member
        {

            get
            { // read
                return this.member;
            }
            set
            { // write
                this.member = value;
            }
        }

    }


    static class Program
    {
        static void Main()
        {
 
        }
    }



}
