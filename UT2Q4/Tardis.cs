﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT2Q4
{
    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        // overload boolean operators 
        /*public static bool operator ==(Tardis a, Tardis b)
        {
            return
        }
        public static bool operator !=(Tardis a, Tardis b)
        {
            return
        }
        public static bool operator >(Tardis a, Tardis b)
        {
            return
        }
        public static bool operator <(Tardis a, Tardis b)
        {
            return
        }
        public static bool operator <=(Tardis a, Tardis b)
        {
            return
        }
        public static bool operator >=(Tardis a, Tardis b)
        {
            return
        }*/

        public byte WhichDrWho
        {
            get
            {
                return whichDrWho;
            }
       
        }
        public string FemaleSideKick
        {
            get
            {
                return femaleSideKick;
            }

        }
        public void TimeTravel()
        {

        }
    }
}
