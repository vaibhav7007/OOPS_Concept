using OOPsConcept.Abstraction;
using OOPsConcept.Encapsulation;
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
            Console.WriteLine("Welcome to the Oops Concept");


            ConceptEncapsulation CEncapsule = new ConceptEncapsulation();
            CEncapsule.Data = "Rohan";
            Console.WriteLine("The student name is: " + CEncapsule.Data);
            CEncapsule.info = "R007";
            Console.WriteLine("The student Id is: " + CEncapsule.info);


            Console.ReadLine();


        }
    }
}