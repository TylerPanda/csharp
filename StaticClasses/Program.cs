using System;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal.GetAge();
        }
    }
    static class Animal
    {
        static public string name;

        static public void GetAge()
        {
            Console.WriteLine(DateTime.Now.Year - DateTime.Now.AddYears(-4).Year);
        }
    }
}
