using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT2Q9
{
    public abstract class Skiing : Adventure
    {
        public string mountainName;

        public abstract void Slide();
        public virtual void HaveFun()
        {

        }
       
    }
}
