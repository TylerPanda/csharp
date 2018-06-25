using System;
using MyOwnNameSpace.GameOfThrone;

namespace NameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            MyOwnNameSpace.animals animal = new MyOwnNameSpace.animals();
            animal.sayHi();
            // MyOwnNameSpace.GameOfThrone.HouseStark.sayQuote();
            HouseStark.sayQuote();
        }
    }
}

namespace MyOwnNameSpace
{
    class animals
    {
        public string animalColor = "animalColor";

        public void sayHi()
        {
            Console.WriteLine("Hi, from the custome namespace.");
        }
    }
    namespace GameOfThrone
    {
        class HouseStark
        {
            public static void sayQuote()
            {
                Console.WriteLine("The north remembers.");
            }
        }
    }
} 