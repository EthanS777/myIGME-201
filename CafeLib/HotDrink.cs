using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string size;
        public Customer customer;

        public virtual byte AddSugar(byte amount)
        {
            return amount;
        }

        public abstract void Steam();
        
      

        public HotDrink()
        {

        }
        
        
        public HotDrink(string brand)
        {

        }
    }
}
