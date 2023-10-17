using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE13DLL
{
    public class Cat : Pet, ICat
    {
        public override void Eat()
        {
            Console.WriteLine(Name + ": Yummy! I love eating");
        }
        
        public override void Play()
        {
            Console.WriteLine(Name + ": Fun kitty time!");
        }

        public void Purr()
        {
            Console.WriteLine(Name + ": Prrrrr!");
        }

        public void Scratch()
        {
            Console.WriteLine(Name + ": Meow!");
        }

        public override void GoToVet()
        {
            Console.WriteLine(Name + ": Meow... :(");
        }

        public Cat()
        {

        }
    }
}
