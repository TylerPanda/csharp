using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Dogs dog = new Dogs();
            dog.Attack();
            dog.SayHi();
            dog.Run();
        }
    }

    public interface IAnimals
    {
        void Run();
    }

    public interface IDogCommands : IAnimals
    {
        void Stay();
        void Sit();
        void Attack();

        string DogName
        {
            set;
            get;
        }
    }

    interface Tranier
    {

    }

    class Animals
    {
        string AnimalName;

        public void SayHi()
        {
            Console.WriteLine("Hi from the animals class.");
        }
    }

    class Dogs : Animals, IDogCommands, Tranier
    {
        private string DogBreed;

        public void Stay()
        {
            Console.WriteLine("Dog is staying.");
        }

        public void Sit()
        {
            Console.WriteLine("Dig is sitting.");
        }

        public void Attack()
        {
            Console.WriteLine("Dog is attacking.");
        }

        public void Run()
        {
            Console.WriteLine("Animal is runnung.");
        }

        public string DogName
        {
            get;
            set;
        }
    }
}
