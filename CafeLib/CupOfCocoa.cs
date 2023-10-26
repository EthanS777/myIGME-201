using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public class CupOfCocoa : HotDrink, ITakeOrder
    {
        public static int numCups;
        public bool marshmallows;
        private string source;

        public string Source
        {
            set
            {
                source = value;
            }
        }

        public override void Steam()
        {

        }

        public override byte AddSugar(byte amount)
        {
            return base.AddSugar(amount);
        }

        public void TakeOrder()
        {

        }

        public CupOfCocoa()
        {
         
        }

        public CupOfCocoa(bool marshmallows) : base("Expensive Organic Brand")
        {

        }
    }
}
