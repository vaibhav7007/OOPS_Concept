using OOPsConcept.Inheritance;
using System;
using System.Threading;

namespace OOPsConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Animal animal = new Animal();
            animal.name = "Stella";
            animal.breedName = "Rawtweiller";
            animal.price = 15000;
            animal.dogDetails();

            Dog dog = new Dog();
            dog.name = "Lucy";
            dog.breedName = "PitBull";
            dog.price = 30000;
            dog.dogDetails();
            dog.run();

            Console.ReadLine();


        }
    }
}