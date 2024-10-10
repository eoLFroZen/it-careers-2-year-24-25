using System;
using System.Collections.Generic;

namespace D02P02
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animalCat = new Cat("Cat", "Fish");
            Cat cat = new Cat("Cat", "Fish");

            Animal animalDog = new Dog("Dog", "Meet");
            Dog dog = new Dog("Dog", "Meet");


            PrintExplainMyself(animalCat);
            PrintExplainMyself(cat);
            PrintExplainMyself(animalDog);
            PrintExplainMyself(dog);
        }

        static void PrintExplainMyself(Animal animal)
        {
            Console.WriteLine(animal.ExplainMyself());
        }

    }
}
