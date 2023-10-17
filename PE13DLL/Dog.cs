using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE13DLL
{
    public class Dog : Pet, IDog
    {
        public string license;

        public override void Eat()
        {
            Console.WriteLine(Name + ": Yummy! Food makes my tail wag");
        }

        public override void Play()
        {
            Console.WriteLine(Name + ": Doggy play time!");
        }

        public void Bark()
        {
            Console.WriteLine(Name + ": WOOF WOOF");
        }

        public void NeedWalk()
        {
            Console.WriteLine(Name + ": Potty time");
        }

        public override void GoToVet()
        {
            Console.WriteLine(Name + ": Woof, whimper");
        }

        public Dog(string szLicense, string szName, int nAge) : base(szName, nAge)
        {
            this.license = szLicense;
        }
    }
}
