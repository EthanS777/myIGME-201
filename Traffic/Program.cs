using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesPE11;

// Ethan Schechter
// PE 11, Question 6

// Traffic console app, referencing the .dll file of the vehicles class library
namespace Traffic
{
    internal class Program
    {
        static void Main(string[] args) { 
       
           //FreightTrain myFreightTrain = new FreightTrain();
            SUV mySUV = new SUV();

            AddPassenger(mySUV);
            // AddPassenger(myFreightTrain); **Error when object passed does not inherit from interface
        }

        // AddPassenger function, accepting an object within the IPassengerCarrier interface
         static void AddPassenger(IPassengerCarrier carrier)
        {
            // call the LoadPassenger() method using the reference "carrier"
            carrier.LoadPassenger();
            
            // if the object is passed to the function, call the .ToString()
            if (carrier is object)
            {
                Console.WriteLine(carrier.ToString());
            }
        }
    }
}
