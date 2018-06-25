using System;

namespace StaticMetthods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SayHi();
            SayHi();
            
        }

        static void SayHi()
        {
            Console.WriteLine("Hi, from the static method.");
        }
    }

    class Person
    {
        public void SayHi()
        {
            Console.WriteLine("Hi, from non the static method.");
        }
    }
}
