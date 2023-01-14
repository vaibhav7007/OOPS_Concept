using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept.Polymorphism
{
    class Chettah
    {
        public virtual void run()
        {
            Console.WriteLine("Cheetah run faster than tiger");
        }
    }

    class Tiger : Chettah
    {
        public override void run()
        {
            Console.WriteLine("Tiger Started running towards prey");
        }
    }



}
