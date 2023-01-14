using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept.Inheritance
{
    class Animal
    {
        public String name;
        public String breedName;
        public float price;
        public void dogDetails()
        {
            Console.WriteLine("Description of dog Name:{0} BreedName:{1} and price:{2}", name, breedName, price);
        }
    }
}