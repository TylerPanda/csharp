using System;

namespace PartialClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animal = new Animals();
            Console.WriteLine(animal.birthDate + "\t" + animal.animalBreed);
            animal.sayHi();
        }
    }
}
