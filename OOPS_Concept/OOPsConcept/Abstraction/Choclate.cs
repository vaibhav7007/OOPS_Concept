using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept.Abstraction
{
    abstract class Chocolate
    {
        public abstract void eat();
        public static void taste()
        {
            Console.WriteLine("Choclate is sweet to eat");
        }
    }
}