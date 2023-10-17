using PE13DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ethan Schechter
// Practice Exercise 13: Pet App
namespace PetApp
{
    // class Program: references the DLL of the schUML design for PE13
    internal class Program
    {
        // Main: create reference variables, list of pets, implement a for loop
        static void Main(string[] args)
        {
            // reference variables for the pets, interfaces
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            // create list of pets
            Pets pets = new Pets();
            
            // random number generator
            Random rand = new Random();

            // for-loop that iterates 50 times
            for (int i = 0; i < 50; i++)
            {
                // if randon number between 1 and 10 is 1 (10% chance), get an animal
                if (rand.Next(1, 11) == 1)
                {
                    // 50% chance for dog or cat: 
                    if (rand.Next(0, 2) == 0)
                    {
                        // add a dog
                        dog = new Dog("340", "Larry", 7);
                    }
                    else
                    {
                        // else add a cat
                        cat = new Cat();
                    }
                }
                else
                {
                    // choose a random pet from pets and choose a random activity for the pet to do

                    //  thisPet = rand.Next(petsList.Count); --> Error ??

                    //  cannot figure out 4b & 4c 
                }

               
            }
        }
    }
}
