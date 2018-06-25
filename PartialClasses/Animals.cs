using System;

namespace PartialClasses
{
    partial class Animals
    {
        public DateTime birthDate = DateTime.Now;
        public string animalBreed = "animalBreed";
        
        public void sayHi()
        {
            Console.WriteLine("My name is Max. I am a dog.");
        }
    }
}
