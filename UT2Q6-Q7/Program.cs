using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UT2Q4;

// Unit Test 2, Questions 6 & 7, referencing DLL from Q4 
namespace UT2Q6_Q7
{
    // class Program: contains the entire project & 2 methods 
    internal class Program
    {
        // Main: creating Tardis & PhoneBooth objects, calling UsePhone() method with both
        static void Main(string[] args)
        {
            // create new classes
            Tardis TardisTime = new Tardis();
            PhoneBooth phoneBoothTime = new PhoneBooth();

            // call the UsePhone method with both objects
            UsePhone(TardisTime);
            UsePhone(phoneBoothTime);
        }

        // UsePhone method: use the interface to call MakeCall(), HangUp()
        static void UsePhone(object obj)
        {
            // if the object is of the Tardis class
            if (obj.GetType() == typeof(Tardis))
            {
                // cast obj. as Tardis class
                Tardis tardis = (Tardis)obj;
                // set interface = to that class
                PhoneInterface interfaceTime = tardis;
                // call the methods using interface
                interfaceTime.MakeCall();
                interfaceTime.HangUp();

                // #7: call TimeTravel();
                tardis.TimeTravel();
            }

            // else if the object is of the PhoneBooth class
            else if (obj.GetType() == typeof(PhoneBooth))
            {
                // cast obj. as PhoneBooth class
                PhoneBooth phoneBooth = (PhoneBooth)obj;
                // set interface = to that class
                PhoneInterface interfaceTime = phoneBooth;
                // call the methods using interface
                interfaceTime.MakeCall();
                interfaceTime.HangUp();

                // #7: call OpenDoor();
                phoneBooth.OpenDoor();
            }
        }
    }
}
