using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public class Customer : IMood
    {
        public string name;
        public string creditCardNumber;

       public string Mood
        {
            get;
        }
    }
}
