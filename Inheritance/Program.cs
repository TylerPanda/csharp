using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dogs dog = new Dogs();
            Console.WriteLine(dog);
        }
    }
    class Animal
    {
        public string animalName;
        public DateTime animalBirthDate;

        public void FeedAnimal()
        {

        }
    }

    class Dogs
    {
        public string dogBreed;
        public string dogIntelligence;
        public bool isEasyToString;
    }
}
