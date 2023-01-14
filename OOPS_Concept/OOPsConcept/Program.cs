using OOPsConcept.Abstraction;
using OOPsConcept.Inheritance;
using OOPsConcept.Polymorphism;
using System;
using System.Threading;

namespace OOPsConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");





            Chettah chettah = new Chettah();
            chettah.run();

            Tiger tiger = new Tiger();
            tiger.run();

            Console.ReadLine();


        }
    }
}