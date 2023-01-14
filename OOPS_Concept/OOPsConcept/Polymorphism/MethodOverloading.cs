using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept.Polymorphism
{
    class overloadingConcept
    {
        //Method overloading can be achived by using of three Ways
        //By changing the number of parameters
        public int mul(int a, int b)
        {
            int mul = a * b;
            return mul;
        }

        public int mul(int a, int b, int c)
        {
            int mul = a * b * c;
            return mul;
        }
    }

    //By changing Datatypes of parameters
    class overloadingConcept1
    {
        public int add(int a, int b)
        {
            int add = a + b;
            return add;
        }

        public float add(float a, float b, float c)
        {
            float add = a + b + c;
            return add;
        }
    }

    //By changing order of parameters
    class overloadingConcept2
    {
        public void Data(int id, String name)
        {
            Console.WriteLine("Id is: " + id + " and " + " Name is: " + name);
        }

        public void Data(String name, int id)
        {
            Console.WriteLine("Name is: " + name + " and " + " Id is: " + id);
        }

    }


}