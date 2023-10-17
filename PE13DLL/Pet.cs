using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PE13DLL
{
    public abstract class Pet
    {
        private string name;
        public int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {

            }
        }

        public abstract void Eat();



        public abstract void Play();
      


        public abstract void GoToVet();
       

        public Pet()
        {

        }

        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


    }
}
            
      

