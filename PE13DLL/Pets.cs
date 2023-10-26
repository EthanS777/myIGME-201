using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE13DLL
{
   

    public class Pets
    {

        public List<Pet> petList = new List<Pet>();


        public Pet this[int nPetEl]
        {

            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                // if the index is less than the number of list elements
                if (nPetEl < petList.Count)
                {
                    // update the existing value at that index
                    petList[nPetEl] = value;
                }
                else
                {
                    // add the value to the list
                    petList.Add(value);
                }
            }
        }

        public int Count
        {
            get
            {
                return petList.Count;
            }
        }

        public void Add(Pet pet)
        {
            petList.Add(pet);
        }

        public void Remove(Pet pet)
        {
            petList.Remove(pet); 
        }

        public int RemoveAt(int petEl)
        {
             petList.RemoveAt(petEl);
            return petEl;
        }
    }
}
