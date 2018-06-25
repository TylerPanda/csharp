using System;

namespace NestClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animal = new Animals();
            Animals.Dogs dog = new Animals.Dogs();
            Animals.Cats cat = new Animals.Cats();
            
            Console.WriteLine(animal.animalName + "\t" +  animal.animalCountry);
            Console.WriteLine(dog.dogBreed + "\t" + dog.dogNickName);
            Console.WriteLine(cat.catName);
        }
    }
    class Animals
    {
        public string animalName = "animalName";
        public string animalCountry = "animalCountry";

        public class Dogs
        {
            public string dogBreed = "dogBreed";
            public string dogNickName = "dogNickName";
        }

        public class Cats
        {
            public string catName = "catName";
        }
    }
}
